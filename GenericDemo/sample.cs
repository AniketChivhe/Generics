using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class sample
    {
        // Generic Method
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            //for (int i = 0; i < inputArray.Length; i = i + 2)
            //{
            //    Console.WriteLine(inputArray[i]);
            //}
            Console.WriteLine("----------------------------------");
        }

    }

    //Generic Class
    public class PrintArray<T>
    {
        private T[] inputArray;
        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrint()
        {
            foreach (var element in inputArray) 
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}




