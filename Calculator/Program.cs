using System;
using System.ComponentModel;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Calculator");

            Console.WriteLine("\n1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Modulus");
            Console.WriteLine("6 - Square Root");

            Console.Write("\nEnter the operation you want to do: ");

            try
            {
                int i = Convert.ToInt32(Console.ReadLine());

                int num1 = 0;
                int num2 = 0;
                int num3 = 0;

                switch (i)
                {
                    case 1:
                        Console.Write("Enter the first number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Addition(num1, num2);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Enter the first number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Subtraction(num1, num2);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("Enter the first number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Multiplication(num1, num2);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Write("Enter the first number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Division(num1, num2);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Write("Enter the first number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Remainder(num1, num2);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Write("Enter the number you want to find its square root: ");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Sqrt(num3);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            
            catch(Exception ex)
            {
                Console.WriteLine("Some error has occured. Press any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    static void Sqrt(int num)
    {
        Console.WriteLine(Math.Sqrt(num));
    }
    static void Addition(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }
    static void Subtraction(int num1, int num2)
    {
        Console.WriteLine(num1 - num2);
    }
    static void Multiplication(int num1, int num2)
    {
        Console.WriteLine(num1 * num2);
    }
    static void Division(int num1, int num2)
    {
        Console.WriteLine(num1 / num2);
    }
    static void Remainder(int num1, int num2)
    {
        Console.WriteLine(num1 % num2);
    }
}