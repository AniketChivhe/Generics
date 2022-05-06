using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Program
    {
         static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'A', 'N', 'I', 'K', 'E', 'T' };

            //Program.toPrint(intArray);
            //Program.toPrint(doubleArray);
            //Program.toPrint(charArray);

            //using Generic Method
            Console.WriteLine("Using Generic Method");
            sample.toPrint<int>(intArray);
            sample.toPrint <double>(doubleArray);
            sample.toPrint<char>(charArray);
            //using generic class
            Console.WriteLine("Using Generic Class");
            new PrintArray<int>(intArray).ToPrint();
            new PrintArray<double>(doubleArray).ToPrint();
            new PrintArray<char>(charArray).ToPrint();
            Console.ReadKey();
        }
        
    }
}