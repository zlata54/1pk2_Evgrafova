namespace Task_04_06
{
    internal class Program
    {
        /*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа
         * по модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но 
         * не может быть двух равных по модулю. В полученном массиве найти наибольшее по модулю число.
         */
        static void Main() 
         {
            int count = 10;
            int[] numbers = new int[count];
            Random random = new Random();
            int number;

            for (int i = 0; i < count; i++)
            {
                    bool unique;
                    do
                    {
                        number = random.Next(-count, count + 1);
                        unique = true;
                        for (int j = 0; j < i; j++)
                        {
                            if (Math.Abs(numbers[j]) == Math.Abs(number))
                            {
                                unique = false;
                                break;
                            }
                        }
                    } while (!unique);

                    numbers[i] = number;
                    Console.WriteLine("Сгенерированное число: " + numbers[i]);
            }

            int maxMagnitude = numbers[0];
            for (int i = 1; i < count; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(maxMagnitude))
                {
                    maxMagnitude = numbers[i];
                }
            }

              Console.WriteLine($"Наибольшее по модулю число: {maxMagnitude}");
         }
    }
    
}
