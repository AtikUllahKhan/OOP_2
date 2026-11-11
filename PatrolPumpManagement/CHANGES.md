# What changed in this version

## 1. Designer tab
Open any form in Visual Studio with **double-click on the form file** in Solution Explorer
(or right-click -> View Designer, or Shift+F7). Forms no longer touch the database while the designer is open,
so the designer always loads. All five layouts were rebuilt and every control keeps its old name.

## 2. Automatic username + password for salesmen  (Manager -> Salesmen)
* **Username** = the Salesman ID (sm-010 ...), created automatically.
* **Password** = random 6 characters, created automatically. Press **Generate** for another one. Tick **Show password** to read it.
* After **Add / Update** a box shows the login details and offers to copy them to the clipboard.
* The salesman signs in on the normal Login screen with that username and password -> Sales Counter opens.
* To reset a password: click the salesman's row, press Generate, press Add / Update.
* Delete removes the salesman and the login together.

## 3. New design
Navy / amber theme. Login card, manager side menu with dashboard counters (Products, Salesmen, Orders),
card layout for Products and Salesmen, and a Sales Counter with an order summary panel.
Search is now one live box (name, ID, phone or price). Back buttons inside the manager screens are gone: use the left menu.

Files changed: Project.cs, Login.cs, FormManager.cs, FormProductAdd.cs, FormSmAdd.cs, FormSalesman.cs and the 5 *.Designer.cs files.
Database, App.config and project file: unchanged.
