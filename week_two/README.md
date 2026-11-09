# Explanation: Processing Data (Chapter 2)

This README explains the slides from *Starting Out with Visual C#* (Gaddis, 6th Edition), Chapter 2: Processing Data. Each concept is broken down one at a time. (The slide deck labels its sections 3.1 to 3.12.)

---

## Table of Contents

1. Reading Input with TextBox Controls
2. Variables
3. Data Types
4. Variable Names
5. Strings and Concatenation
6. Local Variables and Scope
7. Initializing and Declaring Variables
8. Numeric Data Types
9. Numeric Literals
10. Assignment Compatibility
11. Type Casting
12. The `var` Keyword
13. Performing Calculations
14. Integer Division
15. Inputting Numeric Values (Parse)
16. Outputting Numeric Values (ToString)
17. Formatting Numbers
18. Exception Handling (try-catch)
19. Named Constants
20. Fields
21. The Math Class
22. Tab Order and Focus
23. Access Keys
24. Colors and Background Images
25. GroupBox vs Panel
26. Debugging Logic Errors

---

## 1. Reading Input with TextBox Controls

A **TextBox** is a rectangular area that accepts keyboard input from the user.

- Found in the **Common Controls** group of the Toolbox. Double-click to add it to the form.
- Default name is `textBoxN` (`textBox1`, `textBox2`, ...).
- The **Text property** stores what the user typed, and it accepts **only strings**.

```csharp
textBox1.Text = "Hello";

// Three ways to clear a TextBox:
textBox1.Text = "";
textBox1.Text = string.Empty;
textBox1.Clear();
```

## 2. Variables

A **variable** is a storage location in memory, and the variable name represents that location.

You must **declare** a variable before using it:

```csharp
DataType VariableName;
```

## 3. Data Types

The **data type** specifies what kind of data a variable can hold. **Primitive data types** are basic, built-in types already defined by C# (not created by you), such as strings and integers.

Common C# types (the slide shows these in a picture):

| Type | Holds | Example |
|---|---|---|
| `int` | Whole numbers | `40` |
| `double` | Real numbers (with decimals) | `87.6` |
| `decimal` | High-precision real numbers (money) | `28.75m` |
| `string` | Text | `"Hello"` |
| `char` | A single character | `'A'` |
| `bool` | `true` or `false` | `true` |

## 4. Variable Names

- Choose **meaningful** names.
- The first character must be a letter or an underscore (`_`).
- No spaces.
- Do not use **keywords** (reserved words).

## 5. Strings and Concatenation

A **string** is a combination of characters (names, phone numbers, and so on). The value goes in **double quotes** on the right of `=`.

```csharp
productDescription = "Jamhuuriya University";
productLabel.Text = productDescription;     // show in a Label
MessageBox.Show(productDescription);        // show in a message box
```

**Concatenation** means appending one string to the end of another, using the `+` operator. It also works between a string and another type:

```csharp
fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
12 + " apples";
"Total is " + 25.75;
```

## 6. Local Variables and Scope

A **local variable** belongs to the method where it was declared.

- **Scope:** the part of the program where the variable can be accessed.
- **Lifetime:** how long the variable exists in memory. It is created when the method starts and destroyed when the method ends.

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string myName;
    myName = nameTextBox.Text;
}

private void secondButton_Click(object sender, EventArgs e)
{
    outputLabel.Text = myName;   // ERROR: myName is out of scope here
}
```

## 7. Initializing and Declaring Variables

- **Duplicate names:** you cannot declare two variables with the same name in the same scope. The same name in different methods is fine.
- **Assignment compatibility:** a value can only be assigned if it matches the variable's type.
- **Initialization:** a variable must have a value before you use it, otherwise you get the error *Use of unassigned local variable*.
- **Multiple variables in one statement:**

```csharp
string lastName, firstName, middleName;

string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";
```

## 8. Numeric Data Types

To do math, a variable must have a numeric type.

| Type | Description |
|---|---|
| `int` | Whole numbers, from -2,147,483,648 to 2,147,483,647 |
| `double` | Real numbers, including fractions |
| `decimal` | Real numbers with greater precision, typically used for financial applications |

## 9. Numeric Literals

A **numeric literal** is a number written directly in code. It is never put in quotes.

```csharp
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;     // add M or m to make a decimal literal
```

- Whole numbers like `40` are `int`.
- Numbers with a decimal point like `87.6` are `double`.

## 10. Assignment Compatibility

| Variable type | Accepts | Does NOT accept |
|---|---|---|
| `int` | `int` | `double`, `decimal` |
| `double` | `double`, `int` | `decimal` |
| `decimal` | `decimal`, `int` | `double` |

```csharp
int hoursWorked = 40;        // works
int unitsSold = 650m;        // ERROR
double speed = 75;           // works
double sales = 6500.0m;      // ERROR
decimal price = 50;          // works
decimal sales = 6500.0;      // ERROR
```

## 11. Type Casting

**Explicit conversion** (type casting) uses a **cast operator**: the type name in parentheses.

```csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;

decimal money = 625.70m;
double realNumber = (double)money;
```

Casting to `int` drops the fractional part.

## 12. The `var` Keyword

`var` lets the compiler figure out the type from the value (**type inference**).

```csharp
var interestRate = 12.0;          // double
var stockCode = "D465U";          // string
var accountBalance = 1000.0m;     // decimal
```

Rules: you must give an initial value, and `var` works only for **local variables** (inside a method).

## 13. Performing Calculations

| Operator | Name | Description |
|---|---|---|
| `+` | Addition | Adds two numbers |
| `-` | Subtraction | Subtracts one number from another |
| `*` | Multiplication | Multiplies two numbers |
| `/` | Division | Gives the quotient |
| `%` | Modulus | Gives the remainder |

- Follow the **order of operations** and use parentheses to group: `result = (a + b) / 4;`
- **Mixed types:**
  - `int` with `double` gives `double`.
  - `int` with `decimal` gives `decimal`.
  - `double` with `decimal` is **not allowed**.

## 14. Integer Division

Dividing an `int` by an `int` always gives an `int`, dropping the fraction.

```csharp
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());           // 2

// To avoid integer division:
MessageBox.Show(((double)x / y).ToString());   // 2.333...
```

You can also declare `x` and `y` as `double`.

## 15. Inputting Numeric Values (Parse)

A TextBox always gives you a **string**, even if the user types `25.65`. You cannot use a cast to turn a string into a number. Use the **Parse** methods:

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal payRate = decimal.Parse(payRateTextBox.Text);
```

## 16. Outputting Numeric Values (ToString)

The `Text` property accepts only strings, so convert numbers with **ToString()**:

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());

// Alternative: implicit conversion with +
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

## 17. Formatting Numbers

`ToString` can take a **format string**:

| Format | Description | Number | Call | Result |
|---|---|---|---|---|
| `N` / `n` | Number format | 12.3 | `ToString("n3")` | 12.300 |
| `F` / `f` | Fixed-point | 123456.0 | `ToString("f2")` | 123456.00 |
| `E` / `e` | Exponential | 123456.0 | `ToString("e3")` | 1.235e+005 |
| `C` / `c` | Currency | -1234567.8 | `ToString("C")` | ($1,234,567.80) |
| `P` / `p` | Percentage | .234 | `ToString("P")` | 23.40% |

## 18. Exception Handling (try-catch)

An **exception** is an unexpected error that happens while the program is running (a runtime error), such as dividing by zero, opening a missing file, or invalid user input. If it is not handled, the program **crashes**.

**Exception handling** is writing code that catches the error and decides what to do instead. That code is an **exception handler**.

```csharp
try
{
    // statements that might cause an exception
}
catch
{
    // statements that respond to the exception
}
```

- **Throwing** = the problem is raised (the error occurs).
- **Catching** = the problem is handled.

**Analogy:** An ATM throws an "Invalid PIN" error after a wrong entry, and catches it by showing "Please try again" instead of shutting down.

**Example:**

```csharp
try
{
    miles = double.Parse(milesTextBox.Text);      // throws if input is not a number
    gallons = double.Parse(gallonsTextBox.Text);
    mpg = miles / gallons;
    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

When a statement in `try` throws an exception, the program jumps straight to the `catch` block.

**Showing the default error message:** every exception is an object with a `Message` property.

```csharp
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

## 19. Named Constants

A **named constant** represents a value that cannot change while the program runs. Use the `const` keyword:

```csharp
const double INTEREST_RATE = 0.129;
```

Uppercase names are traditional but not required.

## 20. Fields

A **field** is a variable declared at the **class level**: inside the class but outside any method. Its scope is the **entire class**, and it is created when the form is created.

```csharp
public partial class Form1 : Form
{
    private string name = "Charles";    // field

    private void showNameButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(name);
    }

    private void dariusButton_Click(object sender, EventArgs e)
    {
        name = "Darius";                // any method can change it
    }
}
```

## 21. The Math Class

| Member | Description |
|---|---|
| `Math.Sqrt(x)` | Square root of x |
| `Math.Pow(x, y)` | x raised to the power y |
| `Math.Max(x, y)` | The larger value |
| `Math.Min(x, y)` | The smaller value |
| `Math.Round(x)` | x rounded to the nearest integer |
| `Math.PI` | The constant pi |
| `Math.E` | Base of the natural logarithm |

## 22. Tab Order and Focus

- The control with **focus** receives the user's keyboard input. If a Button has focus, pressing **Enter** runs its Click handler.
- **Tab order** is the order controls receive focus when the user presses Tab.
- The **TabIndex** property holds the position, starting at **0**.
- To set it visually: **View menu → Tab Order**, then click controls in the order you want. Labels can't receive focus, so their TabIndex doesn't matter.
- Change focus in code with the **Focus** method:

```csharp
private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}
```

## 23. Access Keys

An **access key** (mnemonic) is pressed with **Alt** to reach a control quickly. Put an ampersand (`&`) before a letter in the button's `Text` property:

```
E&xit   ->   Alt + X
```

It is not case sensitive.

## 24. Colors and Background Images

**Colors:** forms and most controls have **BackColor**. Controls that show text also have **ForeColor**. The color list has three tabs: **Custom**, **Web**, and **System**.

```csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

**Background images:** a Form has **BackgroundImage** (like PictureBox's `Image`) and **BackgroundImageLayout** (like `SizeMode`):

| Layout | Effect |
|---|---|
| None | Image in the top-left corner |
| Tile | Image repeated to fill the form |
| Center | Image centered |
| Stretch | Image enlarged and stretched to fill |
| Zoom | Image enlarged without stretching |

## 25. GroupBox vs Panel

Both are **containers** that hold other controls.

| | GroupBox | Panel |
|---|---|---|
| Title / `Text` property | Yes | No |
| `BorderStyle` property | No | Yes |

## 26. Debugging Logic Errors

A **logic error** doesn't stop the program from running but produces **incorrect results** (math mistakes, wrong variable, wrong value). Visual Studio's debugger helps find them.

- **Breakpoint:** a line you select in the code. When the running program reaches it, execution pauses in **break mode**. Click the left margin next to a line to set one (a red dot appears).
- **Break mode:** hover over a variable or property to see its current value.
- **Locals window:** shows all variables in the current procedure with their values and types.
- **Watch window:** shows only the variables you add. Open them from **Debug → Windows**.
- **Single-stepping:** run statements one at a time and check values after each one. Press **F11** (Step Into), use the toolbar button, or choose **Debug → Step Into**.

---

## Quick Summary

| Term | Meaning |
|---|---|
| Variable | Named storage location in memory |
| Data type | The kind of data a variable holds |
| Literal | A value written directly in code |
| Concatenation | Joining strings with `+` |
| Scope | Where a variable can be accessed |
| Cast | Explicit type conversion, e.g. `(int)x` |
| Parse | Converts a string to a number |
| ToString | Converts a value to a string |
| Exception | Runtime error |
| try-catch | Code that handles exceptions |
| Constant | Value that never changes (`const`) |
| Field | Class-level variable |
| Focus | Control receiving keyboard input |
| Breakpoint | Line where execution pauses for debugging |
| Logic error | Program runs but gives wrong results |