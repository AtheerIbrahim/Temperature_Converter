using System;
namespace TemperatureConverter
{
    public class Program
    {
        public static string TempConvert(float amount, string unit)
        {
            string result;
            if( unit.ToUpper() == "F" )
            {
                result = $"{Math.Round((amount-32)*5/9, 2)} C";
                return result;
            }
            else
            {
                result = $"{Math.Round(amount*9/5+32, 2)} F";
                return result;
            }
        }
        public static void Main(string[] args)
        {
            while (true)
            {
            try
            {
                Console.WriteLine($"Welcome to Temperature Converter Example");
                Console.WriteLine($"Enter a temperature and its unit (C or F), or type 'Quit' to exit");
                string input = Console.ReadLine() ?? ""; // avoiding nullable
                string[] parts = input.Split(" ");
                if (parts.Length >= 3)
                {
                    System.Console.WriteLine("Invalid input.");
                    continue;
                }
                
                if (parts[0].ToLower() == "quit")
                {
                    Console.WriteLine($"Program terminated.");
                    break;
                }
                
                else if(parts[1].ToUpper() != "F" && parts[1].ToUpper() != "C")
                {
                    System.Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                    continue;
                }
                
                else if( !float.TryParse(parts[0], out float degree))
                {
                    System.Console.WriteLine("Invalid input. Please enter a numeric temperature.");
                    continue;
                }

                float value = float.Parse(parts[0]);
                string scale = parts[1];
                Console.WriteLine($"Converted: {value} {scale} = {TempConvert(value, scale)}");      
            }
            catch (Exception ex)
            {
                 Console.WriteLine($"Exception :" + ex.Message);
            }
            }
        }
    }
}