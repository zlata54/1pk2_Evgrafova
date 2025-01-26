namespace Task_03_05
{
    internal class Program
    {
        /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия
         * и Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны
         * вводиться во время работы программы
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру в градусах Цельсия:");
            double maxCelsius=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру в градусах Цельсия:");
            double minCelsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг изменения температуры:");
            double step=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nТемпература в градусах Цельсия | Температура в градусах Фаренгейта");
            Console.WriteLine("--------------------------------------------------------------------");
            for(double Celsius=minCelsius;Celsius<=maxCelsius; Celsius+=step)
            {
                double Fahrenheit = Celsius * 1.8 + 32;
                Console.WriteLine($"{Celsius,31}|{Fahrenheit,34}");
            }
        }
    }
}
