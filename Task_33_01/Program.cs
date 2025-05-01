namespace Task_33_01
{
    internal class Program
    {
        /*самостоятельно прописать треугольник и его логику рисования в консоли для упрощения
         * - прямугольный треугольник
         */
        static void Main(string[] args)
        {
            try
            {
                List<IDrawable> list = new List<IDrawable>
                   {
                       new Circle(6),
                       new Square(2,7),
                       new Circle(10),
                       new Rectangle(9,10)
                   };


                foreach (var item in list)
                    item.Draw();

                list.Add(new Circle(0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
