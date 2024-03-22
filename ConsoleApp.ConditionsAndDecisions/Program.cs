// See https://aka.ms/new-console-template for more information

//Prompt for input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If...Else...Statement - Decide to print pass or fail based on input

Console.WriteLine("************** Simple IF Results ***************");
if (grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("plaese recommend student to student affai's office");
}
Console.WriteLine("************** Simple IF Results End ***************");


// Complex If...Else if...statement - Decide to print letter based on grade value
Console.WriteLine("************** Complex IF.. ELSE IF Results ***************");

/*
 * A: 85 - 100
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 - 64 - else if (grade >= 50 && grade <= 64)
 * F: less than 50 
 */

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{
    Console.WriteLine("Student has Failed - F");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 86 && grade <= 100)
{
    Console.WriteLine("A - Good Job");
}
else
{
    Console.WriteLine();
}


Console.WriteLine("*************** Complex IF.. ELSE IF Results End ***************");

// the rest of the application


Console.WriteLine("Thankyou for using this program");




// Dicede to print pass or fail based on input