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
            Console.WriteLine($"Welcome to Temperature Converter Example");
            Console.WriteLine($"Enter a temperature and its unit (C or F):");
            float value = Convert.ToSingle(Console.ReadLine());
            string scale = Console.ReadLine() ?? ""; //avoiding nullable
            Console.WriteLine($"Converted: {value} {scale} = {TempConvert(value, scale)}");
        }
    }
}