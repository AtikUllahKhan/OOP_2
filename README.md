
<h1 align="center">ARA Petrol Pump Management System</h1>

<p align="center">
  A desktop app that lets a petrol pump manager run stock and staff, and lets salesmen sell fuel at a simple sales counter.<br>
  My project for the <b>Object Oriented Programming 2</b> course.
</p>
---

## 👋 About this project

This is a project from my **Object Oriented Programming 2** course. We were asked to build a real application using OOP ideas, and I chose a **petrol pump station** because it has a clear, everyday workflow with different kinds of users: someone in charge who manages stock and staff, and people at the counter who sell.

The first version did its job, but I kept coming back to it. I found bugs, fixed them one by one, made the design much nicer, and added a feature I really wanted: when a manager adds a new salesman, the **username and password are created automatically**, so the salesman can sign in straight away.

I wanted it to feel like something a small station could actually use, not just a form full of text boxes.

---

## ✨ What it can do

### 👔 As a manager
- See a **dashboard** with the number of products, salesmen and orders.
- **Manage products:** add, update, delete and search fuel and oil items (price and stock).
- **Manage salesmen:** add, update, delete and search staff (name, phone, salary, joining date).
- **Create logins automatically:** a new salesman gets a username (their ID, like `sm-010`) and a random password. The app shows them and can copy them to the clipboard.
- **Reset a password** in three clicks: pick the salesman, press *Generate*, press *Add / Update*.

### 🧾 As a salesman
- Type a few letters and pick the product from suggestions.
- The price comes from the database, so it can't be changed at the counter.
- The app checks stock before adding an item, even for items already in the order.
- Grand total and change update live while typing.
- Pay with Cash, Card or Mobile Banking.
- Orders get their own numbers (`Od-001`, `Od-002`, …).
- Confirming an order saves it **and** reduces the stock together. If something goes wrong, nothing is saved.

---

## 📸 Screenshots

| Manager dashboard | Products |
|---|---|
| ![Dashboard](screenshots/02-manager-dashboard.png) | ![Products](screenshots/03-products.png) |

| Salesmen (automatic login) | Sales counter |
|---|---|
| ![Salesmen](screenshots/04-salesmen.png) | ![Sales counter](screenshots/05-sales-counter.png) |

---

## 🧱 OOP ideas I used

| Idea | Where you can see it |
|---|---|
| **Classes and objects** | Every screen is its own class (`Login`, `FormManager`, `FormProductAdd`, `FormSmAdd`, `FormSalesman`). The manager window creates screen objects and shows them inside itself. |
| **Encapsulation** | All database work lives in one class, `Project`. The forms never write connection code; they just ask `Project` to run a query. Each form keeps it in a private property. |
| **Inheritance** | Every screen inherits from `System.Windows.Forms.Form`, so it gets windows, controls and events for free. |
| **Reusability (DRY)** | The same `Project` class and the small `Util` helper (password generator, search hints) are used by every form. |
| **Separation of concerns** | Layout code lives in the `*.Designer.cs` files, behaviour in the matching `.cs` file (partial classes). |
| **Event-driven programming** | Buttons, typing, row clicks and form loading all trigger event handlers. |

---

## 🛠️ Built with

- **C#** and **Windows Forms** (.NET Framework 4.7.2)
- **Microsoft SQL Server** (Express edition is enough) through ADO.NET
- **Visual Studio** 2019 / 2022

---

## 🚀 Run it on your computer

### 1. You will need
- Windows 10 or 11
- Visual Studio with the **.NET desktop development** workload
- SQL Server (or SQL Server Express) and SQL Server Management Studio

### 2. Create the database
Open `Database/setup.sql` in SSMS and press **Execute**. It creates the database, the tables, a manager account and a few sample products.

> First login: user **`mgr-001`**, password **`admin123`**. Please change it afterwards.

### 3. Point the app to your SQL Server
Open `PatrolPumpManagement/Project.cs` and edit the connection string at the top. For SQL Server Express with Windows login:

```csharp
public static string ConnectionString =
    @"Data Source=.\SQLEXPRESS;Initial Catalog=""Petrol Pump Management"";Integrated Security=True";
```

### 4. Start it
Open `PatrolPumpManagement.sln`, press **F5**, and sign in.

---

## 🧭 How to use it

**Manager**
1. Sign in with a manager account.
2. **Products →** add the fuel and oil you sell, with price and quantity.
3. **Salesmen →** fill in the details. The username and password are already created. Press *Add / Update* and give the shown login to your salesman.

**Salesman**
1. Sign in with the username and password from the manager.
2. Search the product, enter the quantity, press *Add to order*.
3. Choose the payment type, enter the cash received, press *Confirm order*.
4. The message shows the order number, total and the change to give back.

---

## 📁 Project structure

```
PatrolPumpManagement/
├── Database/setup.sql          Creates the database, tables and sample data
├── screenshots/                Images used in this README
└── PatrolPumpManagement/
    ├── Project.cs              Database helper + small Util helpers
    ├── Program.cs              Starts the app (opens Login)
    ├── Login.cs                Sign in, opens manager or salesman window
    ├── FormManager.cs          Manager window: menu, dashboard, loads screens
    ├── FormProductAdd.cs       Products screen
    ├── FormSmAdd.cs            Salesmen screen + automatic login
    ├── FormSalesman.cs         Sales counter
    └── *.Designer.cs           Layouts (open them in the Visual Studio designer)
```

---

## 🐞 Bugs I found and fixed along the way

Fixing these taught me more than writing the first version did:

- Deleting a salesman could also delete **other users** who had the same password.
- The stock check compared against the **wrong product**.
- The order total **carried over** to the next customer.
- An order could be saved even when the cash was not enough.
- Typing special characters in the login box could break the SQL command. Everything now uses parameters.
- Back buttons opened extra windows and left the program running in the background.

---

## 🔭 What I would like to add next

- Store every item of an order and add daily / monthly **sales reports**
- **Print receipts**
- **Hash passwords** (they are plain text right now, as in my original database)
- Low-stock warnings on the dashboard
- Keep the connection string out of the code (for example in `App.config`)

---

## 🙋 About me

Made by **Atik Khan** as a student project. Feedback and suggestions are very welcome. Feel free to open an issue.
