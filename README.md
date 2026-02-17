# 🎓 Student Management System – Web Version  

A professional **web-based Student Management System** built using **ASP.NET Core MVC (.NET 8)** with **Entity Framework Core** and **SQL Server**.

---

## 🚀 Project Overview  

This project is the **web conversion** of a console-based student management system.  

It demonstrates modern **.NET web development practices** using:

- 🧱 MVC Architecture  
- 🗄 Database Integration  
- 💻 Responsive UI Design  

> 🎯 The system supports full CRUD operations with a clean and professional interface.

---

# 🧱 Technologies Used  

- 🔹 ASP.NET Core MVC (.NET 8)  
- 🔹 Entity Framework Core (Code First)  
- 🔹 SQL Server  
- 🔹 Bootstrap 5  
- 🔹 Razor Views  
- 🔹 LINQ Queries  

---

# ✨ Features Implemented  

## ✅ MVC Architecture  

- **Model →** Student entity  
- **View →** Razor UI  
- **Controller →** Business logic handling  

---

## ✅ Database Integration  

- Code First Approach  
- Entity Framework Migrations  
- SQL Server Connection  
- DbContext configuration  

---

## ✅ CRUD Operations  

- ➕ Add Student  
- ✏ Edit Student  
- ❌ Delete Student  
- 👁 View Details  

---

## ✅ Search Functionality  

- 🔍 Search students by name  
- LINQ-based filtering  

---

## ✅ Dashboard  

- 📊 Total Students Count  
- 🕒 Recently Added Students  

---

## ✅ Professional UI  

- Clean Bootstrap 5 layout  
- Responsive design  
- Styled forms and tables  
- Navigation bar  
- User-friendly structure  

---

# 📂 Project Structure  

```text
SMS_Web-App-Version
│
├── Controllers
│     ├── StudentsController.cs
│     └── DashboardController.cs
│
├── Models
│     └── Student.cs
│
├── Data
│     └── AppDBContext.cs
│
├── Views
│     ├── Students
│     ├── Dashboard
│     └── Shared
│
├── wwwroot
├── appsettings.json
└── Program.cs
```

---

# 🗄 Database Setup  

## 1️⃣ Update Connection String  

Modify the connection string inside:

```json
appsettings.json
```

---

## 2️⃣ Run Migrations  

Using Package Manager Console:

```powershell
Add-Migration InitialCreate
Update-Database
```

Or using .NET CLI:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

# ▶ How to Run  

```bash
dotnet build
dotnet run
```

Then open:

```
https://localhost:xxxx
```

---

# 🎯 Learning Outcomes  

This project strengthened understanding of:

- ✔ MVC Pattern in ASP.NET Core  
- ✔ Entity Framework Core fundamentals  
- ✔ Database Migrations  
- ✔ LINQ Queries  
- ✔ Razor Syntax  
- ✔ Bootstrap UI Design  
- ✔ Basic Dashboard Implementation  

---

# 🌟 Future Enhancements (Planned)  

- 🔐 Role-Based Authentication  
- 📄 Pagination  
- 🌐 Web API Version  
- 🏫 University Portal Extension  
- 🚀 Deployment to Hosting  

---

# 👨‍💻 Author  

**Muhammad Abdullah**  
ASP.NET Core Developer *(Learning Phase 🚀)*  

---

## ⭐ If you found this project helpful, consider giving it a star!
