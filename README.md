
<h1 align="center">ARA Petrol Pump Management System</h1>

<p align="center">
  A desktop app that lets a petrol pump manager run stock and staff, and lets salesmen sell fuel at a simple sales counter.<br>
  My project for the <b>Object Oriented Programming 2</b> course.
</p>

##  About this project

This is a project from my **Object Oriented Programming 2** course. We were asked to build a real application using OOP ideas, and I chose a **petrol pump station** 

---

## What it can do

### manager
- See a **dashboard** with the number of products, salesmen and orders.
- **Manage products:** add, update, delete and search fuel and oil items (price and stock).
- **Manage salesmen:** add, update, delete and search staff (name, phone, salary, joining date).
- **Create logins automatically:** a new salesman gets a username (their ID, like `sm-010`) and a random password. The app shows them and can copy them to the clipboard.
- **Reset a password** in three clicks: pick the salesman, press *Generate*, press *Add / Update*.

### salesman
- Type a few letters and pick the product from suggestions.
- The price comes from the database, so it can't be changed at the counter.
- The app checks stock before adding an item, even for items already in the order.
- Grand total and change update live while typing.
- Pay with Cash, Card or Mobile Banking.
- Orders get their own numbers (`Od-001`, `Od-002`, …).
- Confirming an order saves it **and** reduces the stock together. If something goes wrong, nothing is saved.
---

## OOP ideas

| **Classes and objects** | Every screen is its own class (`Login`, `FormManager`, `FormProductAdd`, `FormSmAdd`, `FormSalesman`). The manager window creates screen objects and shows them inside itself. |
| **Encapsulation** | All database work lives in one class, `Project`. The forms never write connection code; they just ask `Project` to run a query. Each form keeps it in a private property. |
| **Inheritance** | Every screen inherits from `System.Windows.Forms.Form`, so it gets windows, controls and events for free. |
| **Reusability (DRY)** | The same `Project` class and the small `Util` helper (password generator, search hints) are used by every form. |
| **Separation of concerns** | Layout code lives in the `*.Designer.cs` files, behaviour in the matching `.cs` file (partial classes). |
| **Event-driven programming** | Buttons, typing, row clicks and form loading all trigger event handlers. |

---

## Built with

- **C#** and **Windows Forms**
- **Microsoft SQL Server**
- **Visual Studio** 2022


## Project structure

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

