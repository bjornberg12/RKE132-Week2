// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter yout age:");


string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old. ");
if (isAgeNumber)
{
    if (userAgeNum >=  13)
    {
        Console.WriteLine("Welcome to instagram");
    }
    else
    {
        Console.WriteLine("You are to young");
    }

} else
{
    Console.WriteLine("Could not read your age");
}


//int userAge = int.Parse(Console.ReadLine());

//if (userAge >= 13)
//{

//    Console.WriteLine("Welcome to instagram");
//} 
//else
//{
//    Console.WriteLine("You are 2 young 4 instaram");
//}


