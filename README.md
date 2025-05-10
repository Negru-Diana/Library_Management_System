# Library Management System

These instructions guide you through the necessary steps to configure and run the application. Ensure that all steps are followed to fully evaluate the complete functionality of the developed application. Make sure you have downloaded all the files.

##1. System Requirements

Before starting the application, please make sure the following prerequisites are met:

a. .NET SDK
  -  The application is developed using .NET 9.0-windows

b. SQLite
  -  The application uses SQLite for database management.
  -  SQLite is bundled with the application through NuGet packages (SQLite and System.Data.SQLite), so it does not need to be installed manually.
  -  The application should determine the location of the database automatically, but in case it does not work, change the connection string with the correct location in *app.config*.

c. IDE
  -  You can use JetBrains Rider *(recommended)* or Visual Studio to run and debug the application.


##2. Running the Application

The program should be started from Program.cs class.

To run the project in Rider, configure it as follows:
-  *Name:* Library_Management_System
-  *Project:* Library_Management_System
-  *Target framework:* net9.0-windows
-  *Exe path:* .../bin/Debug/net9.0-windows/Library_Management_System.exe
-  *Program arguments:* (leave empty)
-  *Working directory:* .../bin/Debug/net9.0-windows
-  *Environment variables:* (leave empty)
-  *.NET runtime arguments:* (leave empty)
-  *Runtime:* <Automatic>
-  *Use external console:* unchecked
-  *Open browser / URL:* (leave empty)
-  *Before launch*: check **Activate tool window**



