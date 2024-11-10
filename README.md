
# Talabat

## Description
**Talabat** is an e-commerce platform for buying and selling products, where users can browse items, create accounts using Identity for secure login, and complete purchases. It allows users to place orders and make payments securely through Stripe.

## Prerequisites
- **.NET SDK 8.0.**
* **Database:** set up a database server (SSMS) to store product data, user information, and orders.
- **Code Editor:** Use an IDE like Visual Studio to edit and run the code.
* **Stripe Account:** Set up a Stripe account to process online payments.
- **JWT.**
* **Redis.**
  
## Features
 **1- Account Creation & Secure Login:** users can create accounts using ASP.NET Identity for secure login and authentication.
 
 **2- Token-Based Authentication by using JWT.** 
 
 **3- Product Browsing:** users can browse available products on the platform.
 
 **4- Create Purchasing Basket:** allows users to create a shopping basket containing the products they want to purchase before proceeding to checkout.
 
 **5- Order Placement:** users can place orders for products they wish to buy. 
 
 **6- Secure Payment Integration:** Stripe integration allows users to make secure payments for their orders.
 
 **7- Database Integration:** utilizes Entity Framework Core to store and manage product data, user information, and orders.
 
 **8- Redis Caching:** implements Redis for caching data to enhance performance and reduce database load.
 
 **9- Exception Handling:** provides centralized error handling to manage application errors.

## Used technologies:
**1- Authentication and Authorization.**

**2- JWT for Token-Based Authentication.**

**3- External Service Payment Integration (Stripe).**

**4- Dependency Injection:** the project uses Dependency Injection 
to manage object lifetimes and dependencies.

**5- Entity Framework Core (EF Core).**

**6- Automatic Database Updates:** ensures that the database schema is automatically updated when the project starts.

**7- Redis for Caching.**

**8- RESTful API:** the system follows a RESTful API for handling requests and responses.

## Used Patterns
- **Repository Pattern** 
* **Unit of Work Pattern**
- **N-Tears Pattern**
* **Specification Design Pattern**
  
## Packages
* **Microsoft.EntityFrameworkCore.**
- **Microsoft.AspNetCore.Identity.**
* **Authentication.JwtBearer.**
- **Stripe.Net for Stripe integration.**
* **Redis**

## Installation
**1- Install Git (if not already installed):** 
Before you begin, make sure you have Git installed on your machine.

**2- Clone the Repository from GitHub:**
- Find the "Clone or download" button and click it.
- Copy the HTTPS URL link provided (link).
- Now, open your terminal (Command Prompt, PowerShell, or Git Bash on Windows, or Terminal on macOS/Linux) and run the following command to clone the repository:

```bash
git clone (link)
```
This will download the entire repository to your local machine.


**3- Navigate to the Project Directory:**
Once the project is cloned, move into the project directory by running:

```bash
cd repository
```
Replace repository with the actual name of the project folder that was created after cloning.

**4- Open the Project in Visual Studio (or your preferred IDE)**

If you're using Visual Studio, you can open the project by navigating to the .sln file and double-clicking it, or you can run:

```bash
start MyProject.sln
```

**5- Install Dependencies (if applicable):**
If the project has external dependencies specified in a .csproj file or a NuGet.config file, you can restore them by running the following command in the terminal within the project directory:

```bash
dotnet restore
```

This will download all the necessary packages and dependencies for the project.

**6- Build the Project:**
To ensure the project builds correctly, use the following command:

```bash
dotnet build
```

This command will compile the project and show you if there are any errors or warnings.

**7- Run the Project:**
Finally, to run the project, use the following command:

```bash
dotnet run
```
