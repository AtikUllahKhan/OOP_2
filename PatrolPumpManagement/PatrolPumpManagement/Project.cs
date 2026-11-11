using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PatrolPumpManagement
{
    public class Project
    {
        // The ONLY place where the database connection is written.
        public static string ConnectionString = @"Data Source=Atik-Khan;Initial Catalog=""Petrol Pump Management"";User ID=sa;Password=atik";

        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public Project()
        {
            // Connection is only created here. It is opened when a query runs and closed right after.
            this.Sqlcon = new SqlConnection(ConnectionString);
        }

        // Short way to make a parameter:  Project.P("@name", textBox.Text)
        public static SqlParameter P(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        // SELECT -> DataSet.  Use @parameters in the sql instead of joining text (this stops SQL injection).
        public DataSet ExecuteQuery(string sql, params SqlParameter[] ps)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(ps);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);      // Fill opens and closes the connection by itself
            return Ds;
        }

        // SELECT -> first table
        public DataTable ExecuteQueryTable(string sql, params SqlParameter[] ps)
        {
            return this.ExecuteQuery(sql, ps).Tables[0];
        }

        // INSERT / UPDATE / DELETE -> number of rows changed
        public int ExecuteDMLQuery(string sql, params SqlParameter[] ps)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(ps);
            try
            {
                this.Sqlcon.Open();
                return this.Sqlcom.ExecuteNonQuery();
            }
            finally
            {
                this.Sqlcon.Close();
            }
        }

        // SELECT one value (for example COUNT)
        public object ExecuteScalar(string sql, params SqlParameter[] ps)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(ps);
            try
            {
                this.Sqlcon.Open();
                return this.Sqlcom.ExecuteScalar();
            }
            finally
            {
                this.Sqlcon.Close();
            }
        }

        // For saving in 2 tables together (all or nothing): see FormSmAdd and FormSalesman.
        public SqlConnection NewConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static int ExecInTx(SqlConnection con, SqlTransaction tx, string sql, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand(sql, con, tx);
            cmd.Parameters.AddRange(ps);
            return cmd.ExecuteNonQuery();
        }
    }
}

namespace PatrolPumpManagement
{
    // Small helpers used by the forms
    public static class Util
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        // Grey hint text inside an empty TextBox (for example "Search by name...")
        public static void SetCue(TextBox tb, string text)
        {
            try
            {
                if (tb.IsHandleCreated)
                    SendMessage(tb.Handle, 0x1501, IntPtr.Zero, text);
                else
                    tb.HandleCreated += (s, e) => { try { SendMessage(tb.Handle, 0x1501, IntPtr.Zero, text); } catch { } };
            }
            catch { /* the hint is only cosmetic */ }
        }

        // Random password, easy to read out loud (no 0/O, 1/l/I)
        public static string GeneratePassword(int length = 6)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz23456789";
            var result = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] b = new byte[1];
                int limit = 256 - (256 % chars.Length);      // avoids a biased pick
                while (result.Length < length)
                {
                    rng.GetBytes(b);
                    if (b[0] < limit) result.Append(chars[b[0] % chars.Length]);
                }
            }
            return result.ToString();
        }
    }
}
