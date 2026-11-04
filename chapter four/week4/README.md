# Chapter 4 – Loops, Files, and Random Numbers (C#)

All the code from the chapter (Gaddis, *Starting Out with Visual C#*, 6e, Global Edition): the code that appeared in screenshots and the code written on the slides, combined in one place. Each section starts with a short summary of what it covers.

> Note: the slides number the sections 5.1–5.9 (the book's numbering), while the file is named Chapter 4. The section numbers below follow the slides.

## Contents

1. [The while Loop](#1-the-while-loop)
2. [Ending Balance Program (while loop example)](#2-ending-balance-program)
3. [The ++ and -- Operators](#3-the---and----operators)
4. [Postfix vs Prefix Mode](#4-postfix-vs-prefix-mode)
5. [Checkpoint Questions: Operators and while](#5-checkpoint-questions-operators-and-while)
6. [The for Loop](#6-the-for-loop)
7. [The Squares Application (for loop form)](#7-the-squares-application)
8. [The do-while Loop](#8-the-do-while-loop)
9. [Using Files for Data Storage](#9-using-files-for-data-storage)
10. [Writing Data to a File](#10-writing-data-to-a-file)
11. [Reading Data from a File](#11-reading-data-from-a-file)
12. [Reading a File with a Loop](#12-reading-a-file-with-a-loop)
13. [OpenFileDialog and SaveFileDialog](#13-openfiledialog-and-savefiledialog)
14. [Random Numbers](#14-random-numbers)
15. [The Load Event](#15-the-load-event)

---

## 1. The while Loop

**Summary:** A `while` loop repeats a block of statements as long as a Boolean expression is true. It is a *pretest* loop: the condition is checked before every iteration, so if it is false at the start, the body never runs. If nothing inside the loop ever makes the condition false, you get an infinite loop.

General format:

```csharp
while (BooleanExpression)
{
    statements
}
```

Loop that iterates 5 times (the counter starts below 5):

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
```

Loop that never runs (the condition is false from the start):

```csharp
int count = 5;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
```

Infinite loop (`count` is never increased, so the condition never becomes false):

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
}
```

## 2. Ending Balance Program

**Summary:** A practice program that calculates the ending balance of a savings account after a number of months, adding monthly interest each time through a loop. The first version shows only the final balance. The modified version also lists each month's balance in a ListBox.

**Form: Ending Balance**

| Control | Name |
|---|---|
| TextBox (Starting Balance) | `startingBalTextBox` |
| TextBox (Number of Months) | `monthsTextBox` |
| Label (Ending Balance) | `endingBalanceLabel` |
| Button (Calculate) | `calculateButton` |
| Button (Clear) | `clearButton` |
| Button (Exit) | `exitButton` |

**Modified form:** adds a ListBox named `detailListBox` between the inputs and the Ending Balance label. Example run: Starting Balance 1000, 8 months, ending balance `$1,040.71`, with one line per month in the list (month 1 is `$1,005.00`, month 2 is `$1,010.03`, and so on).

Code inside the loop:

```csharp
// Constant for the monthly interest rate.
const decimal INTEREST_RATE = 0.005m;

// Add this month's interest to the balance.
balance = balance + (INTEREST_RATE * balance);
```

Added in the modified version:

```csharp
// Display this month's ending balance.
detailListBox.Items.Add("The ending balance " +
    "for month " + count + " is " +
    balance.ToString("c"));
```

## 3. The ++ and -- Operators

**Summary:** To *increment* a variable means to add to it, and to *decrement* means to subtract. C# provides `++` and `--` as shortcuts for adding or subtracting 1. There are three equivalent ways to write each.

Adding 1:

```csharp
count++;
count += 1;
count = count + 1;
```

Subtracting 1:

```csharp
count--;
count -= 1;
count = count - 1;
```

## 4. Postfix vs Prefix Mode

**Summary:** The operators can go after the variable (postfix, `count++`) or before it (prefix, `++count`). In postfix mode the old value is used first and then changed. In prefix mode the value is changed first and then used. This only matters when the operator is part of a larger statement, such as an assignment.

```csharp
count++;   // postfix
--count;   // prefix
```

Postfix example (afterwards `x` is 5 and `count` is 6):

```csharp
int count = 5;
int x = 0;
MessageBox.Show("The X before ", x.ToString());
MessageBox.Show("The count before is ", count.ToString());
x = count++;
MessageBox.Show("The x after postfix ", x.ToString());
MessageBox.Show("The count after postfix is ", count.ToString());
```

Prefix example (afterwards both `x` and `count` are 6):

```csharp
int count = 5;
int x = 0;
MessageBox.Show("The X before ", x.ToString());
MessageBox.Show("The count before is ", count.ToString());
x = ++count;
MessageBox.Show("The x after prefix ", x.ToString());
MessageBox.Show("The count after prefix is ", count.ToString());
```

## 5. Checkpoint Questions: Operators and while

**Summary:** Two in-class questions that test the operators and the `while` loop. The expected answers from the slide notes are included.

**5.9 – What messages will the following code display?**

```csharp
int number = 5;
number++;
MessageBox.Show(number.ToString());
number--;
MessageBox.Show(number.ToString());
```

Answer: `6`, then `5`.

**5.10 – How many times will the following loop iterate?**

```csharp
int count = 0;
while (count < 4)
{
    MessageBox.Show(count.ToString());
    count++;
}
```

Answer: 4 times, displaying `0`, `1`, `2`, `3`.

## 6. The for Loop

**Summary:** A `for` loop is designed for loops that use a counter. Its header holds three parts: an *initialization* (runs once), a *test* (checked before each iteration), and an *update* (runs after each iteration). Like `while`, it is a pretest loop. The counter can go up by any amount or count backward.

General format:

```csharp
for (InitializationExpression; TestExpression; UpdateExpression)
{
}
```

Declaring the counter in the initialization expression, or before the loop:

```csharp
// Declare the count variable in the
// initialization expression.
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

int count;
for (count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

Other update expressions:

```csharp
// Increment by 10.
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

// Counting backward.
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

## 7. The Squares Application

**Summary:** A lab-practice form that uses a `for` loop to display the squares of the numbers 1 through 10 in a ListBox when the user clicks Go.

**Form: Squares**

| Control | Name |
|---|---|
| ListBox | `outputListBox` |
| Button (Go) | `goButton` |

Expected output in the list box:

```
The square of 1 is 1
The square of 2 is 4
The square of 3 is 9
The square of 4 is 16
The square of 5 is 25
The square of 6 is 36
The square of 7 is 49
The square of 8 is 64
The square of 9 is 81
The square of 10 is 100
```

## 8. The do-while Loop

**Summary:** A `do-while` loop is a *posttest* loop: it runs the body once and only then tests the condition. This guarantees at least one iteration, even if the condition is false from the start. Note the required semicolon after the `while (...)`.

General format:

```csharp
do
{
    statements…
} while (BooleanExpression);
```

Will you see the message box? Yes, once, because the body runs before the test:

```csharp
int number = 1;
do
{
    MessageBox.Show(number.ToString());
} while (number < 0);
```

Will you see the message box? No, because the condition is false from the start:

```csharp
int number = 1;
while (number < 0)
{
    MessageBox.Show(number.ToString());
}
```

**Checkpoint questions:**

- 5.15 What is a posttest loop?
- 5.16 What is the difference between the `while` loop and the `do-while` loop?
- 5.17 How many times will the following loop iterate? (Answer: once, since the body runs before the test.)

```csharp
int count = 0;
do
{
    MessageBox.Show(count.ToString());
    count++;
} while (count < 0);
```

## 9. Using Files for Data Storage

**Summary:** When a program needs to keep data for later, it saves it in a file. Working with a file always takes three steps: open the file, process it (read or write), and close it. There are text files and binary files; this chapter only covers text files. In .NET, `StreamWriter` writes to a text file and `StreamReader` reads from one. (This section has no code.)

## 10. Writing Data to a File

**Summary:** Create a `StreamWriter`, open the file with `File.CreateText` (erases existing contents) or `File.AppendText` (keeps existing contents and adds to the end), write with `WriteLine` (adds a newline) or `Write` (no newline), then `Close` the file. A path can be given, and strings with backslashes should be prefixed with `@`.

Create a new file:

```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();
```

Append to an existing file:

```csharp
StreamWriter outputFile;
outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");
outputFile.Close();
```

Specifying the file location:

```csharp
StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");

outbufile = File.CreateText("D:\\C#\\Last_Update_C#\\CA232\\EndBalanceCalc\\bin\\Debug\\listocurse1.doc");
```

`WriteLine` versus `Write` (screenshot of two Notepad files):

| Method | Result in the file |
|---|---|
| `WriteLine` | `One`, `Two`, `Three` each on its own line |
| `Write` | `OneTwoThree` on a single line |

## 11. Reading Data from a File

**Summary:** Create a `StreamReader`, open the file with `File.OpenText`, then read it with `ReadLine` (one line), `Read` (one character), `ReadToEnd` (the whole file), or read everything at once with `File.ReadAllText`. Close the reader when finished.

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");
```

Read the whole file at once with `File.ReadAllText`:

```csharp
string text;
text = File.ReadAllText("lstcourse.doc");
listBox1.Items.Add(text);
```

Read to the end with `ReadToEnd`:

```csharp
StreamReader read;

read = File.OpenText("lstcourse.doc");

string content;
content = read.ReadToEnd();
listBox1.Items.Add(content);
read.Close();
```

Read one character with `Read`:

```csharp
StreamReader read;
read = File.OpenText("lstcourse.doc");
char content;
content = (char)read.Read();
listBox1.Items.Add(content);
read.Close();
```

Read one line with `ReadLine`:

```csharp
StreamReader read;
read = File.OpenText("lstcourse.doc");
string content;
content = read.ReadLine();
read.Close();
```

## 12. Reading a File with a Loop

**Summary:** A `StreamReader` has a Boolean property `EndOfStream` that becomes `true` when the end of the file is reached. Looping until `EndOfStream` is true lets you read every line, however many there are. Wrapping it in `try/catch` handles problems such as a missing file.

Two equivalent ways to write the loop condition:

```csharp
while (inputFile.EndOfStream == false)
{
}

while (!inputFile.EndOfStream)
{
}
```

Full example with `try/catch`:

```csharp
StreamReader reader;
try
{
    reader = File.OpenText("D:\\C#\\Last_Update_C#\\CA232\\EndBalanceCalc\\bin\\Debug\\listocurse1.doc");

    while (reader.EndOfStream == false)
    {
        string line;
        line = reader.ReadLine();
        listBox1.Items.Add(line);
    }
    reader.Close();
}

catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

## 13. OpenFileDialog and SaveFileDialog

**Summary:** These controls show the standard Windows *Open* and *Save As* dialog boxes. They are invisible controls: they appear in the component tray, not on the form. Call `ShowDialog()` to display them. It returns a `DialogResult` (`OK` or `Cancel`) telling you which button the user clicked. The chosen path is stored in the `FileName` property, and `InitialDirectory` sets the folder shown first.

Showing the Open dialog:

```csharp
private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}
```

Detecting the user's choice:

```csharp
DialogResult result = openFileDialog.ShowDialog();
if (result == DialogResult.OK)
{
}
else if (result == DialogResult.Cancel)
{
}
```

Opening the selected file, and setting the starting folder:

```csharp
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.Filename);
}

openFileDialog.InitialDirectory = @"C:\Data";
```

Example: Open dialog with OK or Cancel handling:

```csharp
StreamReader reader;

DialogResult result = openFileDialog1.ShowDialog();

if (result == DialogResult.OK)
{
    // open the file using the selected path
    reader = File.OpenText("Path");
    string readline;
    readline = reader.ReadLine();
    listBox1.Items.Add (readline);
    reader.Close();
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Wala Cancalay");
}
```

Example: using `FileName` and reading every line:

```csharp
StreamReader reader;

openFileDialog1.ShowDialog();
reader = File.OpenText(openFileDialog1.FileName);
while (reader.EndOfStream == false)
{
    string lines;
    lines = reader.ReadLine();
    listBox1.Items.Add(lines);
}
reader.Close();
```

Save As dialog:

```csharp
saveFileDialog.ShowDialog()

if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
}

if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(openFile.Filename);
}
```

> Note: the slide's last snippet uses `openFile.Filename`, which looks like a slip. It should use `saveFileDialog.FileName`, as in the next example.

Example: saving a file with the Save dialog:

```csharp
StreamWriter write;

DialogResult result = saveFileDialog1.ShowDialog();

if (result == DialogResult.OK)
{
    // create the file using the selected path
    write = File.CreateText(saveFileDialog1.FileName);
    write.WriteLine("Mohamed");
    write.Close();
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Wala Cancalay");
}
```

## 14. Random Numbers

**Summary:** The `Random` class generates random numbers. Create one `Random` object, then call `Next()` for a random integer (0 to 2,147,483,647), `Next(max)` for a number from 0 up to but not including `max`, or `NextDouble()` for a decimal from 0.0 up to (but not including) 1.0.

```csharp
Random rand = new Random();

int number1 = rand.Next();
double number2 = rand.NextDouble();
```

Syntax for a limited range: `RandomObject.Next(max + 1)` gives 0 to `max`. For example, 0 to 99:

```csharp
int number = rand.Next(100);
```

## 15. The Load Event

**Summary:** When an application starts, its form is loaded into memory and a `Load` event fires. Double-clicking the form in the Designer creates an empty handler. Any code placed inside it runs when the form is launched, which makes it a good place for setup work.

Empty handler:

```csharp
private void Form1_Load(object sender, EventArgs e)
{

}
```

With code (runs as soon as the form appears):

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```