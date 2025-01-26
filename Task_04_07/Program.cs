namespace Task_04_07
{
    internal class Program
    {
        /*В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
         * отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и
         * средний рост для мальчиков и девочек. При выводе избавиться от отрицательных значений.
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] heights = new double[30];

            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(-190, 190);
            }
                int boysCount = 0;
                int girlsCount = 0;
                double boysTotalHeight = 0;
                double girlsTotalHeight = 0;

                foreach (var height in heights)
                {
                    if (height < 0)
                    {
                        boysCount++;
                        boysTotalHeight += Math.Abs(height);
                    }
                    else
                    {
                        girlsCount++;
                        girlsTotalHeight += height;
                    }
                }

                double averageBoysHeight = boysCount > 0 ? boysTotalHeight / boysCount : 0;
                double averageGirlsHeight = girlsCount > 0 ? girlsTotalHeight / girlsCount : 0;

                Console.WriteLine($"Количество мальчиков: {boysCount}");
                Console.WriteLine($"Количество девочек: {girlsCount}");
                Console.WriteLine($"Средний рост мальчиков: {averageBoysHeight:F2}");
                Console.WriteLine($"Средний рост девочек: {averageGirlsHeight:F2}");
        }
    }
}
