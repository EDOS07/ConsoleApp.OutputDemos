// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Differents datatypes

/* 
 * text - string
 *  integers - int 
 *  decimal - double, float, decimal
 *  logical - bool 
 *  */

string name = "Trevoir Williands";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given the naw {0}", name); // Formatted String

int age = 23;
int retirementYaersLeft = 42;
int retirementAge = age + retirementYaersLeft;

Console.WriteLine(age);

Console.WriteLine("My age is: " +  age);

Console.WriteLine("My retirement age is: " + retirementYaersLeft);

bool isRetired  = false;
Console.WriteLine("Am I retired? " + isRetired);