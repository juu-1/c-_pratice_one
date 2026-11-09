# Explanation: Introduction to Visual C# (Chapter 1)

This README explains the slides from *Starting Out with Visual C#* (Gaddis, 6th Edition), Chapter 1. Each concept is broken down one at a time.

---

## Table of Contents

1. Objects
2. Controls
3. .NET Framework
4. Visual Studio (IDE)
5. Projects and Solutions
6. Forms and Properties
7. Adding Controls and Naming Rules
8. How C# Code Is Organized
9. Event-Driven Programming
10. Message Boxes
11. Label, PictureBox, and TextAlign
12. IntelliSense
13. Sequential Execution
14. Comments and Indentation
15. Closing a Form
16. Syntax Errors

---

## 1. Objects

An **object** is a program component that contains **data** and performs **operations**. Programs use objects to carry out specific tasks.

- **Properties (fields):** data stored in the object, such as color, size, or text.
- **Methods:** operations the object can perform.

**Analogy:** A person is an object. Properties are name and age; methods are walking and talking.

**Example from the slides:** A "Wage Calculator" program has a **Form object** containing:
- 2 Label objects ("Number of hours worked" and "Hourly pay rate")
- 2 TextBox objects
- 2 Button objects ("Calculate gross pay" and "Exit")

## 2. Controls

**Controls** are objects that are visible in a program's GUI (graphical user interface).

- Most common: **Label**, **Button**, **TextBox**.
- Some GUI objects are invisible, such as **Timer** and **OpenFileDialog**.
- A **class** is code that describes a particular type of object (a blueprint).

## 3. .NET Framework

**.NET** is a collection of classes and other code used to create programs for Windows.

- Controls are defined by specialized classes provided by .NET.
- C# is a language supported by .NET.
- You can also write your own class to perform a special task.

## 4. Visual Studio (IDE)

**Visual Studio** is a professional **IDE** (Integrated Development Environment): one place to write, test, and build programs.

| Part | Purpose |
|---|---|
| **Designer Window** | Where you design the form visually |
| **Solution Explorer** | Lists the project's files |
| **Properties Window** | Shows the selected object's properties |
| **Toolbox** | Lists the controls you can use |
| **Menu Bar** | Menus like File, Edit, View, Project |
| **Standard Toolbar** | Buttons for frequently used commands |

**Related ideas:**

- **Auto Hide:** a window shows only as a tab on the edge of the environment.
- **Tooltip:** a small box that pops up when you hover over a toolbar or toolbox item.
- **Docked window:** attached to an edge of Visual Studio.
- **Floating window:** can be dragged around the screen. A window cannot float while in Auto Hide mode.
- Right-click a window's title bar and choose **Float** or **Dock** to switch.

## 5. Projects and Solutions

- **Project:** each Visual Studio application you create. It contains several files, typically `Form1.cs` and `Program.cs`.
- **Solution:** a container that can hold one or more projects.
- You set the project name the first time you save.
- If the form doesn't appear when opening a project: right-click `Form1.cs` in Solution Explorer and click **View Designer**.

## 6. Forms and Properties

- When you start a new **Windows Forms App**, an empty form named `Form1` is created automatically, 300 × 300 pixels.
- The **bounding box** is the thin dotted outline around a form in the Designer. Its **sizing handles** let you resize the form.
- **Properties** are settings that control how an object looks and behaves. Each property has two columns: **name** (left) and **value** (right).

**Changing a property's value:**

1. Click the object once to select it.
2. Open the Properties window (View menu → Properties Window) if it isn't visible.
3. Find the property and change its value. Example: change `Text` from "Form1" to "My First Program".

## 7. Adding Controls and Naming Rules

**Adding a control:** Select it in the Toolbox, then either double-click it or drag it onto the form. You can then resize it, move it, and change its properties. To delete a control, select it and press **Delete**.

**Naming rules (identifiers):**

- The first character must be a letter or an underscore (`_`).
- Other characters can be letters, digits, or underscores.
- No spaces.

**Valid examples:** `showDayButton`, `DisplayTotal`, `_ScoreLabel`

**camelCase:** start with lowercase, then capitalize the first letter of each following word (`showDayButton`).

## 8. How C# Code Is Organized

C# code is organized in three ways:

1. **Namespace:** a container that holds classes.
2. **Class:** a container that holds methods.
3. **Method:** a group of statements that perform an operation.

A file containing program code is a **source code file**. Two are created automatically with every new project:

- `Program.cs`: start-up code that runs when the application starts.
- `Form1.cs`: code associated with the Form1 form.

Open them from Solution Explorer (right-click `Form1.cs` → **View Code**).

```csharp
namespace hello_world                  // Namespace
{
    public partial class Form1 : Form  // Class
    {
        public Form1()                 // Method
        {
            InitializeComponent();
        }
    }
}
```

## 9. Event-Driven Programming

GUI applications are **event-driven**: they respond to events while running. The program waits for the user to do something, then reacts.

- **Event:** a user action such as clicking, pressing a key, or moving the mouse.
- **Event handler:** a method that executes when a specific event occurs.
- Double-clicking a control (like a Button) in the Designer creates its default event handler automatically.

## 10. Message Boxes

A **message box** (also called a dialog box) displays a message. In .NET you use `MessageBox.Show`.

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
```

Placing this in the button's click event handler shows the message when the button is clicked. The **Hello World** app uses `MessageBox.Show("Hello World");` the same way.

## 11. Label, PictureBox, and TextAlign

### Label

Displays text on a form, either unchanging text or program output.

| Property | Purpose |
|---|---|
| `Text` | Gets or sets the displayed text |
| `Name` | Gets or sets the control's name |
| `Font` | Font, style, and size |
| `BorderStyle` | Border around the text |
| `AutoSize` | How the control resizes |
| `TextAlign` | Text alignment |

**TextAlign values:** TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, BottomRight.

**Displaying output in a Label with code:**

```csharp
answerLabel.Text = "Hello";   // = is the assignment operator
answerLabel.Text = "";        // clears the text
```

Notes: the item receiving the value must be on the **left** of `=`, and the `Text` property accepts only a **string**.

### PictureBox

Displays a graphic image on a form.

- `Image`: the image to display.
- `SizeMode`: how the image is displayed.
- `Visible`: whether the control is visible at run time.

Double-clicking a PictureBox in the Designer creates a Click event handler, so you can make clickable images.

## 12. IntelliSense

**IntelliSense** provides automatic code completion as you write statements.

- It suggests keywords, variables, methods, classes, and properties as you type.
- It makes language references easy to access and lets you insert elements directly into your code.

**Example:** typing `tra` shows options such as `translationLabel`.

## 13. Sequential Execution

Statements in a method execute **in the order they appear**, so arrangement matters.

**Correct:** flip the card so the back shows and the face is hidden.

```csharp
cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;
```

**Wrong:** setting both to `false` hides both pictures.

An incorrect sequence causes **logic errors**.

## 14. Comments, Blank Lines, and Indentation

**Comments** are brief notes in source code that explain how parts of the program work. The computer ignores them.

```csharp
// This is a line comment (one line)

/*
   This is a block comment
   (multiple lines)
*/
```

**Blank lines and indentation** make code easier for humans to read. Two identical programs behave the same, but the well-formatted one is much easier to understand.

## 15. Closing a Form

```csharp
this.Close();         // closes the current form
Application.Exit();   // closes the whole application
```

A common practice is to create an **Exit button** and add this code to its click handler.

## 16. Syntax Errors

A **syntax error** is a mistake in how code is written.

- Visual Studio checks each statement as you type.
- A syntax error is underlined with a **jagged red line**.
- If you try to compile and run with a syntax error, you'll see a **"There were build errors"** window.

**Example:** `MessageBox.Sho(...)` is an error because the correct method is `Show`.

---

## Quick Summary

| Term | Meaning |
|---|---|
| Object | Program component with data and operations |
| Property | Data stored in an object |
| Method | An operation an object can perform |
| Control | A visible object in the GUI |
| Class | Code describing a type of object |
| IDE | Environment for writing programs (Visual Studio) |
| Project | One application |
| Solution | Container for one or more projects |
| Event | A user action (click, key press) |
| Event handler | Method that runs when an event occurs |
| Syntax error | Mistake in code form |
| Logic error | Mistake in statement order or logic |