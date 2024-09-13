// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, please select your gender m/f: ");
char userGender =  Char.Parse(Console.ReadLine());
Console.WriteLine("Please enter your last name:");

string userLastname = Console.ReadLine();

if (userGender == "m")
{
    Console.WriteLine($"Hello, Mr {userLastname}!");

}
else if (userGender == "f")
{
    Console.WriteLine($"Hello, Ms {userLastname}!");

}
else
{
    Console.WriteLine($"WElcome {userLastname}");
}


//Console.WriteLine($"Welcome, {userGender}");