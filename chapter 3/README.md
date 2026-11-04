# Chapter 3 – Making Decisions (C#)

All the code from the chapter (Gaddis, *Starting Out with Visual C#*, 6e): the code that appeared in screenshots and the code written on the slides, combined in one place. Each section starts with a short summary of what it covers.

## Contents

1. [The if Statement](#1-the-if-statement)
2. [Relational Operators](#2-relational-operators)
3. [The if-else Statement](#3-the-if-else-statement)
4. [Test Score Average](#4-test-score-average)
5. [Payroll with Overtime](#5-payroll-with-overtime)
6. [Nested Decisions – Loan Qualify](#6-nested-decisions--loan-qualify)
7. [The if-else-if Statement](#7-the-if-else-if-statement)
8. [Logical Operators](#8-logical-operators)
9. [Range Checker](#9-range-checker)
10. [bool Variables and Flags](#10-bool-variables-and-flags)
11. [Comparing Strings](#11-comparing-strings)
12. [TryParse and Input Validation](#12-tryparse-and-input-validation)
13. [RadioButton, CheckBox and CheckedChanged](#13-radiobutton-checkbox-and-checkedchanged)
14. [The switch Statement](#14-the-switch-statement)
15. [ListBox](#15-listbox)

---

## 1. The if Statement

**Summary:** A decision structure runs a block of code only when a condition is true. The `if` statement tests a Boolean expression, and if it evaluates to `true`, the statements inside the braces execute. Otherwise they are skipped.

General format:

```csharp
if (expression)
{
    statement
    statement
    etc.
}
```

Example:

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

## 2. Relational Operators

**Summary:** Relational operators compare two values and produce `true` or `false`. They are what you normally put inside an `if` condition.

| Operator | Meaning | Example | Question it asks |
|---|---|---|---|
| `>` | Greater than | `x > y` | Is x greater than y? |
| `<` | Less than | `x < y` | Is x less than y? |
| `>=` | Greater than or equal to | `x >= y` | Is x greater than or equal to y? |
| `<=` | Less than or equal to | `x <= y` | Is x less than or equal to y? |
| `==` | Equal to | `x == y` | Is x equal to y? |
| `!=` | Not equal to | `x != y` | Is x not equal to y? |

## 3. The if-else Statement

**Summary:** `if-else` gives two paths. One block runs when the condition is true, and a different block runs when it is false. Exactly one of the two always executes.

General format:

```csharp
if (expression)
{
    statements
}
else
{
    statements
}
```

Example (temperature check):

```csharp
double Temp = 90;
if (Temp > 40)
{
    MessageBox.Show("hot");
}
else
{
    MessageBox.Show("cold");
}
```

> Note: in the original screenshot both branches displayed "hot". The `else` branch should display "cold".

## 4. Test Score Average

**Summary:** A Windows Forms program that reads three test scores from text boxes, calculates their average, displays it in a label, and shows a congratulation message if the average is above 95. A `try/catch` block handles invalid input.

**Form: Test Score Average**

| Control | Name |
|---|---|
| TextBox (Test Score #1) | `test1TextBox` |
| TextBox (Test Score #2) | `test2TextBox` |
| TextBox (Test Score #3) | `test3TextBox` |
| Label (Average) | `averageLabel` |
| Buttons | Calculate Average, Clear, Exit |

**Code:**

```csharp
try
{
    const double HIGH_SCORE = 95.0;      // High Score value
    double test1, test2, test3, average; // Variables

    // Get the test scores from the TextBoxes.
    test1 = double.Parse(test1TextBox.Text);
    test2 = double.Parse(test2TextBox.Text);
    test3 = double.Parse(test3TextBox.Text);

    // Calculate the average test score.
    average = (test1 + test2 + test3) / 3.0;

    // Display the average, rounded to 2 decimal places.
    averageLabel.Text = average.ToString("n1");

    // If the average is a high score, congratulate
    // the user with a message box.
    if (average > HIGH_SCORE)
    {
        MessageBox.Show("Congratulations! Great job!");
    }
}
catch (Exception ex)
{
    // Display the default error message.
    MessageBox.Show(ex.Message);
}
```

## 5. Payroll with Overtime

**Summary:** The form layout for a payroll program (the home assignment). The user enters hours worked and the hourly pay rate, and the program calculates gross pay, including overtime. Only the form design is shown; you write the code.

**Form: Payroll with Overtime**

| Control | Name |
|---|---|
| TextBox (Hours worked) | `hoursWorkedTextBox` |
| TextBox (Hourly pay rate) | `hourlyPayRateTextBox` |
| Label (Gross pay) | `grossPayLabel` |
| Button (Calculate Gross Pay) | `calculateButton` |
| Button (Clear) | `clearButton` |
| Button (Exit) | `exitButton` |

## 6. Nested Decisions – Loan Qualify

**Summary:** A nested decision places one `if` inside another so that more than one condition can be tested. In this example, a person qualifies for a loan only if their salary is at least 40,000 **and** they have been at their job for at least 2 years. The program also tells the user which requirement failed.

**Form: Loan Qualify**

| Control | Name / Text |
|---|---|
| GroupBox | Loan Salary |
| TextBox | Annual Salary |
| TextBox | Years at current job |
| Label | `decisionLabel` (Loan Decision) |
| Buttons | Check Qualification, Clear, Exit |

General format:

```csharp
if (expression)
{
    if (expression)
    {
        statements
    }
    else
    {
        statements
    }
}
else
{
    statements
}
```

**Code:**

```csharp
double salary = 400;
double yearsOnJob = 2;

if (salary >= 40000)
{
    if (yearsOnJob >= 2)
    {
        decisionLabel.Text = "You qualify for the loan";
    }
    else
    {
        decisionLabel.Text = "Minimum years at current job not met.";
    }
}
else
{
    decisionLabel.Text = "Minimum salary requirement not met.";
}
```

## 7. The if-else-if Statement

**Summary:** Used when you need to choose among several outcomes. Conditions are checked from top to bottom, and the first one that is true runs. If none are true, the final `else` runs. The example converts a numeric score into a letter grade.

General format:

```csharp
if (expression)
{
    statements
}
else if (expression)
{
    statements
}
else if (expression)
{
    statements
}
else
{
    statements
}
```

Example (letter grade):

```csharp
int score = int.Parse(testScoreTextBox.Text);
string grade = "A";
if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else if (score >= 70)
{
    grade = "C";
}
else if (score >= 60)
{
    grade = "D";
}
else
{
    grade = "F";
}
```

## 8. Logical Operators

**Summary:** Logical operators combine or reverse Boolean expressions. `&&` (AND) needs both sides true, `||` (OR) needs at least one side true, and `!` (NOT) flips true to false and false to true. The truth tables show every possible outcome.

| Operator | Meaning | Description |
|---|---|---|
| `&&` | AND | Both subexpressions must be true |
| `\|\|` | OR | One or both subexpressions must be true |
| `!` | NOT | Reverses the value to its opposite |

Examples:

```csharp
x > y && a < b       // Is x > y AND is a < b?
x == y || x == z     // Is x == y OR is x == z?
!(x > y)             // Is x > y NOT true?
```

**Truth tables**

| AND expression | Result | | OR expression | Result | | NOT expression | Result |
|---|---|---|---|---|---|---|---|
| `true && false` | false | | `true \|\| false` | true | | `!true` | false |
| `false && true` | false | | `false \|\| true` | true | | `!false` | true |
| `false && false` | false | | `false \|\| false` | false | | | |
| `true && true` | true | | `true \|\| true` | true | | | |

**Sample decision structures:**

```csharp
// The && operator
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// The || operator
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// The ! operator
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```

## 9. Range Checker

**Summary:** A practice form that asks the user for an integer from 1 through 10 and reports whether it is in range. It is a natural use of `&&` (for example, `number >= 1 && number <= 10`). Only the form design is shown.

**Form: Range_Checker**

| Control | Purpose |
|---|---|
| TextBox | Where the user enters the integer |
| Label | Range Decision (shows the result) |
| Buttons | Check Qualification, Clear, Exit |

## 10. bool Variables and Flags

**Summary:** A `bool` variable stores `true` or `false`. When used as a flag, it signals whether some condition exists in the program. Here the flag records whether a player's points exceed 5000, then displays the result.

```csharp
double points;
bool isGrandMaster;

points = double.Parse(txtPoints.Text);

if (points > 5000)
{
    isGrandMaster = true;
}
else
{
    isGrandMaster = false;
}

lblResult.Text = isGrandMaster.ToString();
```

## 11. Comparing Strings

**Summary:** Strings can be compared with `==` and `!=`, against another string or a literal, or with the `String.Compare` and `CompareTo` methods. Both methods return `0` when the strings are equal.

```csharp
// == operator
if (name1 == name2)
{
}

// Compare with a string literal
if (name1 != "bob")
{
}

// String.Compare method
if (String.Compare(name1, name2) == 0)
{
}

// CompareTo method
if (Name1.CompareTo(Name2) == 0)
{
}
```

## 12. TryParse and Input Validation

**Summary:** `TryParse` converts text to a number without throwing an exception when the input is invalid, and returns `true` or `false` to say whether it worked. It only checks the *format*, so you should also validate that the value makes sense (for example, hours between 1 and 168, or a score from 0 to 100).

General syntax (the `out` keyword is required):

```csharp
dataType.TryParse(string input, out targetVariable)
```

Example (payroll hours):

```csharp
int hours;
if (int.TryParse(textBox1.Text, out hours))
{
    // Here TryParse() succeeded — it's a number!
}
if (hours > 0 && hours <= 168)
{
}
```

Example (test score range):

```csharp
if (testScore >= 0 && testScore <= 100)
{
}
```

## 13. RadioButton, CheckBox and CheckedChanged

**Summary:** Radio buttons let the user pick exactly one option from a group, while check boxes allow any number of selections. Both expose a Boolean `Checked` property, and both raise a `CheckedChanged` event whenever that property changes.

Forms shown in the chapter: **RadioButton Example** (Football, Basketball, Baseball, OK) and **CheckBox Example** (Pepperoni, Cheese, Anchovies, OK).

```csharp
// RadioButton
if (choiceRadioButton.Checked) { } else { }
if (choiceRadioButton.Checked == true) { } else { }  // equivalent

// CheckBox
if (option1CheckBox.Checked) { } else { }
```

CheckedChanged event handler (created by double-clicking the control in the Designer):

```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
}
```

## 14. The switch Statement

**Summary:** `switch` chooses one path based on the value of a variable or expression. It is a cleaner alternative to a long `if-else-if` chain that tests the same variable. Each `case` ends with `break`, and the optional `default` handles any value that matches no case.

```csharp
switch (testExpression)
{
    case value_1:
        statement;
        break;
    case value_2:
        statement;
        break;
    default:
        statement;
        break;
}
```

## 15. ListBox

**Summary:** A `ListBox` shows a list of items the user can select from. You can add items, count them, read the selected item, and remove items. Always check that `SelectedIndex` is not `-1` before using the selected item, otherwise an exception occurs.

```csharp
// Get selected text
string selectedtext = listBox1.Text;
MessageBox.Show("your selected " + " " + selectedtext);

// Count items
int count_listbox;
count_listbox = listBox1.Items.Count;
MessageBox.Show("Total items is :" + " " + count_listbox);

// SelectedItem
selectedFruit = fruitListBox.SelectedItem.ToString();

// Add items
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");

// Check that an item is selected
if (fruitListBox.SelectedIndex != -1)
{
}

// Remove a specific item
daysListBox.Items.Remove("Tuesday");

// Remove by index
daysListBox.Items.RemoveAt(2);

// Remove the selected item safely
if (listBox1.SelectedIndex != -1) // Check if an item is selected
{
    listBox1.Items.RemoveAt(listBox1.SelectedIndex); // Remove selected item
}
else
{
    MessageBox.Show("Please select an item to remove.");
}

// Clear all items
daysListBox.Items.Clear();
```