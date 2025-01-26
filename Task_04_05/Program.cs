using System;

namespace Task_04_05
{
    internal class Program
    {
        /*В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее
         * количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками 
         * за месяц и отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома
         * в диапазоне от 0 – нет осадков, до 300 мм выпавших осадков.
         */
        static void Main(string[] args) 
        {
            int[] precipitation = new int[30];
            Random rnd = new Random();

                for (int i = 0; i < 30; i++)
                {
                    precipitation[i] = rnd.Next(0, 301);
                }

                int maxPrecipitation = 0;
                int maxPrecipitationDay = 0;
                int totalForDecade;

                for (int decade = 0; decade < 3; decade++)
                {
                    totalForDecade = 0;

                    for (int day = decade * 10; day < (decade + 1) * 10; day++)
                    {
                        totalForDecade += precipitation[day];

                        if (precipitation[day] > maxPrecipitation)
                        {
                            maxPrecipitation = precipitation[day];
                            maxPrecipitationDay = day + 1;
                        }
                    }

                    Console.WriteLine("Общее количество осадков за декаду " + (decade + 1) + ": " + totalForDecade + " мм");
                }

                Console.WriteLine("День с самыми сильными осадками: " + maxPrecipitationDay + " день, " + maxPrecipitation + " мм");

            int noRainDays = 0;
            for (int day = 0; day < 30; day++)
            {
                if (precipitation[day] == 0)
                {
                    Console.WriteLine((day + 1) + " день");
                    noRainDays++;
                }
            }

            Console.WriteLine("Количество дней без осадков: " + noRainDays);
        }
        }
    }
    
