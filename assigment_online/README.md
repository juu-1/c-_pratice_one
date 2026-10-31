# File Handling in C# Windows Forms

## 1. Project Overview

This project demonstrates file handling in C# using Windows Forms. It shows how to create, write, read, clear, and delete a text file using different file handling methods.

The file used in this project is `reading.doc`, and the output is displayed in `listBox1`.

## 2. Differences Between the Previous Code and the Current Code

### Previous Code

The previous code included additional checks and more detailed file handling.

- Used `File.Exists()` to check whether the file existed before reading or deleting it.
- Displayed a message when the file did not exist.
- Used `StreamReader` to read the file in blocks.
- Used `Encoding.UTF8.GetString()` to convert bytes into text.
- Split the text into separate lines before displaying it in the ListBox.
- Used `using` in some places to close file resources automatically.

### Current Code

The current code is simpler and easier for beginners to understand.

- Uses `File.CreateText()` to create and write to the file.
- Uses `File.ReadLines()` to read the file line by line.
- Uses `File.ReadAllLines()` to read all lines into an array.
- Uses `StreamReader.ReadBlock()` to read a fixed number of characters at a time.
- Uses `File.ReadAllBytes()` to read the file as bytes.
- Uses `listBox1.Items.Clear()` to clear the ListBox.
- Uses `File.WriteAllText()` to remove the file's existing text.
- Uses `File.Delete()` to delete the entire file.

## 3. Comparison Table

| Feature | Previous Code | Current Code |
|---|---|---|
| File existence | Checks with `File.Exists()` | Does not check in advance |
| Reading lines | Uses file-existence checks | Uses simpler reading methods |
| Reading blocks | Uses `StreamReader` | Uses `StreamReader` |
| Reading bytes | Splits text into lines | Displays the text as one ListBox item |
| Error handling | Displays messages for missing files | May produce an exception if the file is missing |
| Code complexity | More checks and conditions | Shorter and easier to follow |

## 4. File Handling Methods

### `File.CreateText()`
Creates a text file and opens it for writing. If the file already exists, its previous content is overwritten.

### `File.ReadLines()`
Reads the contents of a file one line at a time.

### `File.ReadAllLines()`
Reads all lines from a file and returns them as a string array.

### `StreamReader.ReadBlock()`
Reads a specified number of characters from a file into a character array.

### `File.ReadAllBytes()`
Reads the entire file as an array of bytes.

### `File.WriteAllText()`
Writes text to a file. Passing an empty string clears the existing content while keeping the file.

### `File.Delete()`
Deletes the specified file.

## 5. Why Does "The File Does Not Exist" Appear?

This message appears when the program cannot find `reading.doc` at the specified location.

Possible reasons include:

1. The file has not been created yet.
2. The Write File button has not been clicked.
3. The file is saved in a different directory.
4. The program is using a different file path.

### Solution

Click the **Write File** button first, then use the reading buttons.

For a more reliable solution, use the same file path for creating, reading, and deleting the file.

```csharp
string filePath = Path.Combine(
    Application.StartupPath,
    "reading.doc"
);
```

Use `filePath` consistently in all file operations.

## 6. Conclusion

The previous code was more careful because it checked whether the file existed before performing certain operations. The current code is shorter and easier for beginners to understand, but it needs additional checks to handle missing files safely.

Both versions demonstrate important C# file handling concepts, including creating, reading, writing, clearing, and deleting files.
