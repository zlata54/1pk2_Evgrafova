namespace Task_03_09
{
    internal class Program
    {
        /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть 
         * копеек отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет
         * вклад составит не менее y рублей.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент вклада:");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную целевую сумму:");
            double y = Convert.ToDouble(Console.ReadLine());
            int year = 0;
            while (x < y)
            {
                x = Math.Truncate(x * (1 + p / 100));
                year++;
            }
            Console.WriteLine($"Вклад составит не менее {y} рублей через {year} лет");
        }
    }
}
