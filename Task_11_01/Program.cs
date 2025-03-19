namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
         * местами. Проверьте, изменились ли значения переменных вне метода 
         */
        static void Main(string[] args)
        {
            //запрашиваем два целых числа и выводим их до и после вызова метода
            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Значения переменных перед вызовом метода: x = {x}, y = {y}");

            Swap(x, y);

            Console.WriteLine($"После вызова метода: x = {x}, y = {y}");
        }

        static void Swap(int x, int y)
        {
            int a = x;
            x = y;      
            y = a;    
            Console.WriteLine($"Внутри метода: x = {x}, y = {y}");
        }

    }
}
    

