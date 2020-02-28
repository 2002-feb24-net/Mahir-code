using System;
namespace yearcomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age in seconds: ");
            double ageinseconds = double.Parse(Console.ReadLine());
            double yourearthage = CalculateEarthAge(ageinseconds);
            double marsyear = yourearthage/1.9;
            double mercuryyear = yourearthage/.2;
            double venusyear = yourearthage/.6;
            double jupiteryear = yourearthage/11.9;
            double saturnyear = yourearthage/29.5;
            double uranusyear = yourearthage/84;
            double neptuneyear = yourearthage/164.8;
            
            Console.WriteLine($"Your age on Mercury is {mercuryyear}.");
            Console.WriteLine($"Your age on Venus is {venusyear}.");
            Console.WriteLine($"Your age on Earth is {yourearthage}.");
            Console.WriteLine($"Your age on Mars is {marsyear}.");
            Console.WriteLine($"Your age on Jupiter is {jupiteryear}.");
            Console.WriteLine($"Your age on Saturn is {saturnyear}.");
            Console.WriteLine($"Your age on Uranus is {uranusyear}.");
            Console.WriteLine($"Your age on Neptune is {neptuneyear}.");
            }
            static double CalculateEarthAge(double ageSeconds)
            {
                double earthSeconds = 31536000;
                return ageSeconds/earthSeconds;
            }
                    
                    
        
    }
}