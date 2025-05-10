# Library Management System

These instructions guide you through the necessary steps to configure and run the application. Ensure that all steps are followed to fully evaluate the complete functionality of the developed application. Make sure you have downloaded all the files.

## 1. System Requirements

Before starting the application, please make sure the following prerequisites are met:

### a. .NET SDK
  -  The application is developed using .NET 9.0-windows

### b. Database (SQLite)
  -  The application uses SQLite for database management.
  -  SQLite is bundled with the application through NuGet packages (SQLite and System.Data.SQLite), so it does not need to be installed manually.
  -  The application should determine the location of the database automatically, but in case it does not work, change the connection string with the correct location in *app.config*.

### c. IDE
  -  You can use JetBrains Rider *(recommended)* or Visual Studio to run and debug the application.


## 2. Running the Application

The application starts from the *Program.cs* class.

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


## 3. New Functionality Development (🎁 Mystery Box Feature)

The Mystery Box is a unique feature designed to suggest books for a specific person in a fun, randomized way, based on their reading history.

*How it works:*
-  The admin selects a person from the system (based on the person's CNP).
-  The application suggests books based on the genres and authors of the books previously borrowed by that person.
-  The generated books appear in a checklist. The admin can view details for each and select which ones to add to the borrowing list.
-  An animated "chest" opens visually when books are successfully generated, enhancing the experience.

**📚 How Are Mystery Box Books Selected?**
The books suggested in the Mystery Box are chosen using a smart recommendation system based on the selected person's borrowing history. Here's how it works:

### 1. Filter Available Books:

 -  The system first filters out books that are already borrowed by the person or are currently unavailable (i.e., no remaining copies).

### 2. Score Each Book:

-  Each remaining book is given a score based on how well it matches the person's past preferences:

    -  +1 point if the book shares at least one genre with previously borrowed books.

    -  +1 point if it shares at least one author.

### 3. Sort and Randomize:

-  Only books with a score > 0 are kept.

-  Books are then sorted by score (highest first) to prioritize better matches.

-  Among books with the same score, the order is randomized to keep the experience fresh and fun.

### 4. Take the Top N:

-  Finally, the system selects the requested number of top-scoring books to suggest.

If there aren't enough matched books, the rest are filled randomly from the pool of available books not yet borrowed by the person.


This feature provides a personalized and engaging way to discover books, especially for frequent readers.
