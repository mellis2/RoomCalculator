using System;

namespace Lab_2._1_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            Console.Write("Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("Area: " + area);

            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("Perimeter: " + perimeter);

            Console.Write("Continue? (y/n):");
            char isContinue = char.Parse(Console.ReadLine());


            while (isContinue == 'y')
            {
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());

                area = length * width;
                Console.WriteLine("Area: " + area);


                perimeter = (length * 2) + (width * 2);
                Console.WriteLine("Perimeter: " + perimeter);

                Console.Write("Continue? (y/n):");
                isContinue = char.Parse(Console.ReadLine());
            }
            
                Console.WriteLine("Thank you for using the Room Detail Generator!");

        }
        
    }
}
