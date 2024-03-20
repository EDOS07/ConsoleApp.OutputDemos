// Declare variables

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Plaese enter your first name");
firstName = Console.ReadLine();

Console.WriteLine("Plaese enter your last name");
lastName = Console.ReadLine();

Console.WriteLine("Plaese enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Proccess the data
int workingYearsRemaining = retirementAge - age;

// Output the Results to the user

Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working yaers remaining: {workingYearsRemaining}");