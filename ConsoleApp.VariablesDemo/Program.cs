// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool 
 */

// Defining a variable and assigning a value. 
string name = "Trevoir Williams";

// Printing a variable by itself, or with some string.  
Console.WriteLine(name);
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given the name {0}", name); // Formatted string

// Defining more variables along with doing a calculation
int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;
// Invalid assignment of a value. 
//string retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " +  isRetired);