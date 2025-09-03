# C# UWP Water Intake Tracker

A C# UWP application that lets users add, remove, and track their daily water intake.

## Features

- Add, remove, and track daily water intake records.
- View the whole week’s daily water intake records.
  
## Architecture & Tech Stack

- **Data Storage:** SQLite database for storing all records.
- **Design Pattern:** MVVM (Model-View-ViewModel) for clean separation of concerns.
- **User Interface (UI):**
  
<img width="1920" height="1032" alt="App UI Screenshot" src="https://github.com/user-attachments/assets/8674fd88-bb21-44bc-984d-9312d8c3c0f8" />

## Database Structure

Each day can have multiple water intake records, and each water intake record is linked to a single day (one-to-many relationship).


