## discous chapter2


## Topics 


3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants

3.9 Declaring Variables as Fields
3.10 Using the Math Class
3.11 More G U I Details
3.12 Using the Debugger to Locate Logic Errors

## 3.1 Reading Input with TextBox Control

## TextBox control
--a rectangular area
can accept keyboard input from the user
located in the Common Control group of the Toolbox
double click to add it to the form
default name is textBoxn


## The Text Property


A TextBox control’s Text property stores the user inputs
Text property accepts only string values, e.g.

textBox1.Text = "";
textBox1.Text = string.Empty;
textBox1.Clear();


## 3.2 A First Look at Variables

A variable is a storage location in memory
A variable name represents the memory location

in c# you must declare a variable in a program before
using it to store data


The syntax to declare variables is:

## DataType VariableName;


## Data Types

The data type specifies the type of data a variable can hold
## primitive data types
Primitive” means basic / simple / built-in.
In C#, primitive data types are already defined by the language, not created by you.


## Variable Names

A variable name identifies a variable
Always choose a meaningful name for variables
Basic naming conventions are:
the first character must be a letter (upper or lowercase) or an underscore (_)
the name cannot contain spaces
do not use C#keywords or reserved words
  
  ## String Variables

  A string is a combination of characters 
  A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers
  The value of a string variable is assigned on the right of the = operator surrounded by a pair of double quotes:
        productDescription = "Jamhuuriya University";
        

        The following assigns the productDescription string to a Label control named productLabel:

   productLabel = productDescription;

   You can also display a string variable in a Message Box:

   MessageBox.Show(productDescription);

  ## String Concatenation

  Concatenation is the appending of one string to the end of another string
  ## + operator is used for concatenation

  Concatenation can happen between a string and another data type
  int and string
  double and string

  12 + " apples";
  "Total is " + 25.75;


  ## Local Variables and Scope



  A local variable belongs to the method in which it was declared
  Only statements inside that method can access the variable
  Scope describes the part of a program in which a variable may be accessed
  Lifetime of a variable is the time period during which the variable exists in memory while the program is executing
  A local variable is created in memory when the method in which it is declared starts executing. When the method ends, all the method’s local variables are destroyed.


  ##  Duplicate Variable Names

  You cannot declare two variables with the same name in the same scope. 
  For example, if you declare a variable named productDescription in an event handler, you cannot declare another variable with that name in the same event handler. 
  You can, however, have variables of the same name declared in different methods
  ## Assignment Compatibility 


  You can assign a value to a variable only if the value is compatible with the variable’s data type.
   Only strings are compatible with the string data type
     





     Discouse chapter1

over view

This paractice show how to : -create string variable -combine two string variable -store the combined variable in another variable -display the output

1.create variable

The variable that was created are : Fname :Which store the first name Sname :Which store the second name Fullname :Which store the full name

The following screenshot shows how the varibale was created creating variable

concatination

Full Name Concatenation A simple C# Windows Forms application that combines a user's first name and last name into a full name.

Description

Concatenate two strings.. Code // Process of concatenation fullName = Fname + " " + Sname; The following screenshot shows how to concatinate (Screeenshots\Concatination.png)

output

The concatenated full name is displayed in the FullName TextBox.

// Output
FullName.Text = fullname;
The following screenshot shows how to concatinate
(week1\Screeenshots\displayingoutput.png)


