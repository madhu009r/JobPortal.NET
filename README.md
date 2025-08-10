# 💼 Job Portal Backend – .NET API

This is the **backend service** for a Job Portal application, developed using **.NET**.  
It provides secure and scalable RESTful APIs for job seekers, employers, and admins to manage job postings, applications, and user profiles.  
The backend is designed to integrate seamlessly with a React/Angular frontend or mobile applications.

---

## 🚀 Features

- **User Authentication & Authorization**  
  - Role-based access control for Admin, Employer, and Job Seeker
  - Secure authentication using JWT (JSON Web Tokens)

- **Job Management**  
  - Employers can create, update, and delete job postings
  - Job seekers can browse and search jobs

- **Application Tracking**  
  - Job seekers can apply for jobs
  - Employers can view and manage received applications

- **Profile Management**  
  - Job seekers: Resume upload, skill updates
  - Employers: Company profile management

- **Admin Dashboard APIs**  
  - Manage users, job listings, and site-wide statistics

- **Data Persistence**  
  - Uses Entity Framework Core with SQL Server for data storage

---

## 🛠️ Tech Stack

- **Backend Framework:** .NET 6 / .NET 7 (ASP.NET Core Web API)
- **Database:** MySQL
- **ORM:** Microsoft Entity Framework Core + Pomelo.EntityFrameworkCore.MySql
- **Authentication:** JWT-based Authentication
- **API Documentation:** Swagger / OpenAPI
- **Tools:** AutoMapper, LINQ, Dependency Injection

---

## 📂 Project Structure

JobPortalAPI/<br>
│<br>
├── Controllers/ # API endpoints<br>
├── Models/ # Database entity models<br>
├── DTOs/ # Data Transfer Objects<br>
├── Services/ # Business logic layer<br>
├── Repositories/ # Database access via EF Core<br>
├── Migrations/ # EF Core migrations for MySQL<br>
├── Program.cs # Application entry point<br>
└── appsettings.json # Configuration (MySQL, JWT, etc.)

## 🙌 Contributing
Pull requests are welcome!

- Steps to contribute:<br>
-1.Fork the repository<br>
-2.Create a new branch (git checkout -b feature-name)<br>
-3.Commit changes (git commit -m 'Add new feature')<br>
-4.Push to the branch (git push origin feature-name)<br>
-5.pen a Pull Request


## 📧 Contact
Madhubalan – madhubalan009r@gmail.com<br>
GitHub: @madhu009r



