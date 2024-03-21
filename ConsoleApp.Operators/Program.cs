// See https://aka.ms/new-console-template for more information



Console.Write("Please the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Please the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/* Math Operations and operators */

// Add numbers
int sum = num1 + num2;

//multiply
int product = num1 * num2;

//Division
int quotien = num1 / num2;

//Subtraction
int difference = num1 - num2;

//Modulus
int mod = num1 % num2;

Console.WriteLine("***************** Match Results *******************+");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {product}");
Console.WriteLine($"Product: {quotien}");
Console.WriteLine($"Qutient: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("****************** End Match Results *********************");

/* Logic Operations and operato */


var isGreaterthan = num1 > num2;
bool isLessthan = num1 < num2;
bool IsEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("************************** Logic Results *********************************");
Console.WriteLine();
Console.WriteLine($"Is Grater Than: {isGreaterthan}");
Console.WriteLine($"Is Less Than: {isLessthan}");
Console.WriteLine($"Is Equal To: {IsEqualTo}");
Console.WriteLine($"Is Greater than or Equeal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("*************** End Logic Results ****************");

/* Assingment Operatons and Operators */

Console.Write("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
// int IncreaseValue = num1 + randomValue;

Console.WriteLine("************************** Assignment Results *********************************");
Console.WriteLine();
//num1 = num1 + randomValue;
num1 += randomValue;
Console.WriteLine($"Num 1 increased by 5: {num1}");
//num1 = num1 - randomValue;
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by 3: {num1}");
//num1 = num1 * randomValue;
num1 *= 2;
Console.WriteLine($"Num 1 divided by 2: {num1}");
//num1 = num1 % randomValue;
num1 %= 2;
Console.WriteLine($"Num 1 mod by 2: {num1}");
//num1 = num1 * randomValue;
num1 *= 10;
Console.WriteLine($"Num  multipl1ed by 10: {num1}");

Console.WriteLine();
Console.WriteLine($"Num 1: {num1}");
Console.WriteLine();
Console.WriteLine("*************** End Assignment Results ****************");