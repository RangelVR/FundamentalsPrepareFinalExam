using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string pattern = @"(@#+)[A-Z]{1}[a-zA-Z0-9]{4,}[A-Z]{1}(@#+)";
            

            for (int i = 0; i < input; i++)
            {
                string barCode = Console.ReadLine();
                Match match = Regex.Match(barCode, pattern);
                string productGroup = string.Empty;

                if (match.Success)
                {
                    foreach (var ch in barCode)
                    {
                        if (char.IsDigit(ch))
                        {
                            productGroup += ch;
                        }
                    }
                    if (productGroup.Length > 0)
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
