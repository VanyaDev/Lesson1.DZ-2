using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson1.DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название продукта:");
            string input = Console.ReadLine();
            Console.WriteLine("Введите количество:");
            string inputA = Console.ReadLine();
            float A = float.Parse(inputA.Replace(".", ","));
            Console.WriteLine("Введите единицу измерения:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Введите цену продукта:");
            string inputC = Console.ReadLine();
            float C = float.Parse(inputA.Replace(".", ","));
            Console.Clear();
            Console.WriteLine("Название продукта: " + input);
            Console.WriteLine("Количество: " + inputA);
            Console.WriteLine("Единица измерения: " + inputB);
            Console.WriteLine("Цена продукта: " + inputC);
        }
    }
}
            
           
       
