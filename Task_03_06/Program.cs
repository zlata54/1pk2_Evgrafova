namespace Task_03_06
{
    internal class Program
    {
        /*Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.
         * 
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine(" x  | y=|x| ");
            Console.WriteLine("____|_______");
            for (double x = -4; x <= 4.0; x += 0.5)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{Math.Round(x,1),-4}|{Math.Round(y,1),-9}"); 
            }
        }
    }
}
