# _Pierre's Sweet and Savory Treats_

#### _C# ASP .NET Core MVC project for Epicodus, 2020.08.14_

#### By _**Sara Kane**_


## Description

MVC web application for a bakery to market sweet and savory treats. Uses user authentication and a many-to-many relationship.


## Specifications

* The application should have user authentication and a user should be able to log in and log out. 
  * Only logged in users should have create, update and delete functionality. 
  * All users should be able to have read functionality.
* There should be a many-to-many relationship between Treats and Flavors. 
  * A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats.
* A user should be able to navigate to a splash page that lists all treats and flavors. 
  * Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements
### Required Software
* [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* [MySQL Community Server and MySQL Workbench](https://dev.mysql.com/downloads/)

* Clone the GitHub repository by running `git clone https://github.com/sarakane/SweetAndSavoryTreats.Solution.git` in the terminal.
  * Or download the ZIP file by clicking on `Code` then `Download ZIP` from this repository.

### View locally 
* Navigate to the newly created `SweetAndSavoryTreats.Solution` folder.
* Navigate to the `SweetSavory` project folder.
* In the `appsettings.json` file, change the username `uid` and password `pwd` to match the username and password that you have set for your database connecton at localhost(127.0.0.1) on port 3306.
* In the terminal, run `dotnet restore` and `dotnet build` to build the application.
* Enter `dotnet tool install --global dotnet-ef` to install `dotnet ef` as a global tool.
* Enter `dotnet ef database update` to build the MySQL database from the Migrations folder.
* Enter `dotnet run` to run the program.
* Click on the _now lisetning on_ link to open in your browser.

## Known Bugs

* No known bugs.

## Technologies Used

* C# 
* .NET Core 2.2
* ASP .NET Core
* ASP .NET Core Identity
* Entity Famework Core
* MySQL Server 8.0.21
* Visual Studio Code
* Git

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Sara Kane_**