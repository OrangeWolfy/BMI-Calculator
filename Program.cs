using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body mass index calculator.");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Please insert the requested values:");
            while (true)
            {
                Console.Write("\nYour height(cm): ");
                string? stringHeight = Console.ReadLine();
                double height = Convert.ToDouble(string.IsNullOrEmpty(stringHeight) ? 0 : stringHeight);

                Console.Write("Your weight(kg): ");
                string? stringWeight = Console.ReadLine();
                double weight = Convert.ToDouble(string.IsNullOrEmpty(stringWeight) ? 0 : stringWeight);

                double BMI = 0;
                if (height != 0 && weight != 0)
                {
                    BMI = (Convert.ToDouble(((double)weight / Math.Pow(((double)height / 100), 2)).ToString().Remove(4)));
                }
                Console.WriteLine("-----------------------------------------");
                Console.Write("Your BMI is: " + BMI + ". ");
                switch (BMI)
                {
                    case < 18.6:
                        Console.Write("Your underweight.\n");
                        break;
                    case < 24.9:
                        Console.Write("Your normal.\n");
                        break;
                    case < 29.9:
                        Console.Write("Your overweight.\n");
                        break;
                    case < 34.9:
                        Console.Write("Your obese.\n");
                        break;
                    default:
                        Console.Write("Your extremly obese.\n");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}