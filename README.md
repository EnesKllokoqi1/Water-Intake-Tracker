# C# UWP Water Intake Tracker

A C# UWP application that lets users add, remove, and track their daily water intake.

## Features

- Add, remove, and track daily water intake records.
- View the whole week’s daily water intake records.
  
## Architecture & Tech Stack

- **Data Storage:** SQLite database for storing all records.
- **Design Pattern:** MVVM (Model-View-ViewModel) for clean separation of concerns.
- **User Interface (UI):**
  
<img width="1920" height="1033" alt="{DFC76E10-6735-4ADB-996E-506697CA8BC1}" src="https://github.com/user-attachments/assets/e8d87e1d-6fa8-4fc4-89c6-205f12ec851a" />


## Database Structure

Each day can have multiple water intake records, and each water intake record is linked to a single day (one-to-many relationship).


