# Student Information System

## Description
This is a C# Windows Forms project that collects and displays student information.

## Features
- Enter student name
- Enter student ID
- Enter department
- Enter semester
- Display student information

## Technologies
- C#
- Windows Forms
- Visual Studio

## How It Works
When the **Show Info** button is clicked, the program reads the information entered by the user and displays it on the output label.

## Author
Student Information System Project


# Clear Button

This C# code clears all student information fields when the **Clear** button is clicked.

```csharp
private void btnclear_Click(object sender, EventArgs e)
{
    textname.Clear();
    textstudentid.Clear();
    textdepartment.Clear();
    textsemester.Clear();
}
```

It clears:

* Name
* Student ID
* Department
* Semester
