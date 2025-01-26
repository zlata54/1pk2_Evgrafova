using System;
using System.Runtime.InteropServices.Marshalling;

namespace Task_04_09
{
    internal class Program
    {
        /*В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран.
         * То есть найти и вывести уникальные элементы массива. (LINQ использовать нельзя)
         * 
         */
        static void Main(string[] args)
        {
              int[] numbers = new int[50];
              Random rnd = new Random();
            Console.WriteLine("Элементы,которые встречаются только один раз:");

              for (int i = 0; i < numbers.Length; i++)
              {
                  numbers[i] = rnd.Next(1,11);
                  int count = 0;

                  for (int j = 0; j < numbers.Length; j++)
                  {
                        if (numbers[i] == numbers[j])
                        {
                            count++;
                        }
                  }

                  if (count == 1)
                  {
                    Console.WriteLine(numbers[i]);
                  }
              }
        }

    }
    
}
