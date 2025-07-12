# Employee Management System

A desktop-based Employee Management System built with C#.NET (Windows Forms) and Microsoft SQL Server. This application enables users to manage employee records efficiently, compute salaries based on roles and attendance, and generate printable salary slips.

## Features

### Employee Module
- Add new employee details
- Update and delete existing employee records
- Search and display employee information

### Salary Module
- Calculate salary based on number of days worked and employee designation
- Generate formatted salary slips

### Print Functionality
- Print salary slips using Windows Forms' `PrintDocument` and `PrintPreviewDialog`

### Navigation
- Simple UI with buttons to switch between modules (Employee, Salary, Home)

## Technologies Used

| Category            | Tools / Technologies                  |
|---------------------|----------------------------------------|
| Frontend UI         | C#.NET (Windows Forms, Visual Studio) |
| Backend Database    | Microsoft SQL Server (LocalDB)        |
| Programming Language| C#                                    |
| Framework           | .NET Framework 4.7 or later           |
| UI Enhancements     | Guna UI / Bunifu UI (optional)        |
| Printing Utility    | PrintDocument, PrintPreviewDialog     |

## Database Design

**Database Name**: `Myemployee`

**Table**: `EmployeeTbl`

| Column Name | Data Type      | Description             |
|-------------|----------------|-------------------------|
| EmpId       | int (Primary Key) | Employee ID         |
| EmpName     | nvarchar(50)   | Employee Full Name      |
| EmpAdd      | nvarchar(100)  | Address                 |
| EmpPos      | nvarchar(50)   | Position / Designation  |
| EmpDOB      | date           | Date of Birth           |

## Folder Structure

EmployeeManagementSystem/
│
├── Employee.cs # Employee record form
├── Salary.cs # Salary calculation and slip
├── Home.cs # Main navigation form
├── Program.cs # Entry point
├── Myemployee.db.mdf # SQL Server LocalDB file
├── bin/ # Build output
├── obj/ # Intermediate build files
└── .gitignore # Git ignore rules
