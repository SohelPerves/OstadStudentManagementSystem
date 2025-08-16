# 🎓 Ostad Student Management System

A simple **Student Management System** built with **ASP.NET Core 8 MVC**, **Entity Framework Core**, and **SQL Server**.  
This project demonstrates CRUD operations, LINQ queries, and basic student filtering.

---

## 🚀 Features
- Add, Edit, View, and Delete Students (CRUD)
- Display only students **older than 18**
- Search students by **first/last name** using LINQ
- Display **student count** using `Count()`
- Bootstrap 5 styling with modern UI

---

## 🗄️ Database Structure

**Table: Students**
| Column     | Type      | Constraints                |
|------------|-----------|----------------------------|
| Id         | int       | Primary Key, Auto Increment|
| FirstName  | string    | Required, Max 50 chars     |
| LastName   | string    | Required, Max 50 chars     |
| Email      | string    | Required, Valid Email      |
| Age        | int       | Range(10-100)              |

---

## ⚙️ Technologies Used
- **ASP.NET Core 8 MVC**
- **Entity Framework Core 8**
- **SQL Server**
- **Bootstrap 5 + Bootstrap Icons**
- **C# LINQ**

---

## 📦 Installation & Setup

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/OstadStudentManagementSystem.git
   cd OstadStudentManagementSystem
