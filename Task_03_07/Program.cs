namespace Task_03_07
{
    internal class Program
    {
        /*Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела
         * v = g t , где 2 g = 9,8 м/с2 – ускорение свободного падения
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine(" t | v=g*t ");
            Console.WriteLine("___|_______");
            for (double t = 0; t <= 10; t += 0.5)
            {
                double g = 9.8;
                double v = g * t;
                Console.WriteLine($"{t,-3}|{Math.Round(v,1),-6}");
            }
        }
    }
}
