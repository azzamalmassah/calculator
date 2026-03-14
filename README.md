# C# WinForms Calculator

A simple **Windows Forms Calculator** built with **C# and .NET** that performs basic arithmetic operations through a graphical user interface.

## Features

* Addition
* Subtraction
* Multiplication
* Division
* Delete last digit
* Clear input
* Input validation
* Division-by-zero protection
* Lock / Unlock calculator buttons

## Technologies Used

* C#
* .NET Framework
* Windows Forms

## Project Structure

```
calcu/
│
├── Program.cs
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── App.config
├── calcu.csproj
└── calcu.sln
```

## How It Works

1. The user clicks number buttons to enter values.
2. An operation (`+`, `-`, `*`, `/`) is selected.
3. The calculator stores the first number and operation.
4. After entering the second number, pressing `=` performs the calculation.
5. The result is displayed in the textbox.

## Error Handling

The application includes validation to prevent common errors:

* Invalid numeric input
* Division by zero
* Unsupported operations
