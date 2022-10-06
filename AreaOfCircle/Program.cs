using System;

Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.WriteLine("Enter Length:");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Width:");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Area:");
double area = double.Parse(Console.ReadLine());

Console.WriteLine("Perimeter:");
double perimeter = double.Parse(Console.ReadLine());

if (area <= 250)
{
    Console.WriteLine("This is a smaller room.");
}
else if (area >= 650)
{
    Console.WriteLine("This is a Larger room.");
}
else
{
    Console.WriteLine("This is a medium-sized room.");
}

Console.WriteLine("Thank you for using the Room Detail Generator");

