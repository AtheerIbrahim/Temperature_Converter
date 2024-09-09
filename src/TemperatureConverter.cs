// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace TemperatureConverter
{
    public class Program
    {
        public static string TempConvert(int amount, string unit)
        {
            int converter;
            string result;
            if( unit.ToUpper() == "F" )
            {
                converter = (amount-32)*5/9;
                result = $"{converter} C";
                return result;
            }
            else
            {
                converter = amount*9/5+32;
                result = $"{converter} F";
                return result;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to Temperature Converter Example:");
            Console.WriteLine(TempConvert(32, "f"));
            Console.WriteLine(TempConvert(100, "c"));
        }
    }
}