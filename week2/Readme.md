Chapter 2 – Processing Data

This repository contains my study notes and practice exercises for Chapter 2: Processing Data from Starting Out with Visual C#.

📚 Topics Covered

- TextBox Controls
- Variables
- Data Types
- Variable Naming Rules
- String Variables
- String Concatenation
- Local Variables and Scope
- Initializing Variables
- Numeric Data Types
- Numeric Literals
- Type Casting
- "var" Keyword
- Arithmetic Operations
- Order of Operations
- Integer Division
- Numeric Input with "Parse()"
- Displaying Values with "ToString()"
- Number Formatting
- Exception Handling
- "try-catch"
- Constants
- Fields
- "Math" Class
- Tab Order and Focus
- Access Keys
- Colors and Background Images
- GroupBox and Panel Controls
- Logic Errors
- Debugging
- Breakpoints
- Locals and Watch Windows
- Single-Stepping

💻 Technologies

- C#
- Visual Studio
- Windows Forms

🎯 Purpose

The purpose of this chapter is to understand how to store, process, calculate, and display data in C# Windows Forms applications.

🧠 Key Concepts

Variables

Variables are used to store data in a program.

Data Types

Common data types include:

int
double
decimal
string

Parse()

"Parse()" can be used to convert text input into a numeric value.

int number = int.Parse(textBox1.Text);

ToString()

"ToString()" converts a value into text so it can be displayed.

label1.Text = number.ToString();

Exception Handling

"try-catch" is used to handle exceptions that may occur while a program is running.

try
{
    int number = int.Parse(textBox1.Text);
}
catch
{
    MessageBox.Show("Invalid input");
}

Constants

A "const" value cannot be changed after it is declared.

const double PI = 3.14159;

Debugging

Debugging helps find and fix errors in a program.

Important debugging tools include:

- Breakpoints
- Locals Window
- Watch Window
- Single-Stepping

📌 Summary

This chapter focuses on processing data in C# by using:

Input → Variables → Processing → Output

It also introduces exception handling and debugging techniques for Windows Forms applications.

📖 Reference

Starting Out with Visual C#, Sixth Edition
Chapter 2 – Processing Data