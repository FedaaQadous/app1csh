using System;

namespace app1
{
    internal class Program
    {
       
        static double Add()
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            return a + b;
        }

        
        static double Subtract()
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            return a - b;
        }

        
        static double Multiply()
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            return a * b;
        }

        
        static double Divide()
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return 0;
            }

            return a / b;
        }

        
        static void Main(string[] args)
        {
            string choice;

            do
            {
                Console.WriteLine("\na - Add");
                Console.WriteLine("b - Subtract");
                Console.WriteLine("c - Multiply");
                Console.WriteLine("d - Divide");
                Console.WriteLine("e - Exit");

                Console.Write("Choose an option: ");
                choice = Console.ReadLine().ToLower();

                double result = 0;

                if (choice == "a")
                {
                    result = Add();
                    Console.WriteLine("Result = " + result);
                }
                else if (choice == "b")
                {
                    result = Subtract();
                    Console.WriteLine("Result = " + result);
                }
                else if (choice == "c")
                {
                    result = Multiply();
                    Console.WriteLine("Result = " + result);
                }
                else if (choice == "d")
                {
                    result = Divide();
                    Console.WriteLine("Result = " + result);
                }
                else if (choice != "e")
                {
                    Console.WriteLine("! Try again.");
                }

            } while (choice != "e");

            Console.WriteLine("end.");
        }
    }
}
