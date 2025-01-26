namespace Task_04_08
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов,
         * значения которых равны
         * 
         */
        static void Main(string[] args)
        { 
                Random random = new Random();
                int[] numbers = new int[50];

                for (int i = 0; i < numbers.Length; i++)
                { 
                    numbers[i] = random.Next(1, 101);
                }

                int totalPairs = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            totalPairs++;
                        }
                    }
                }

                Console.WriteLine($"Общее количество пар: {totalPairs}");
            }
        }
    }
