// Declare variables

string firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender;
bool working = false;

// Prompt the user for input
Console.WriteLine("Plaese enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Plaese enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Plaese enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Plaese enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Plaese enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you Workin? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Proccess the data
int workingYearsRemaining = retirementAge - age;

// Output the Results to the user
        
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");


