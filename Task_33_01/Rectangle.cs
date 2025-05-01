using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_01
{
    internal class Rectangle : IDrawable
    {
        private int firstLeg;
        private int secondLeg;
        public int FirstLeg
        {
            get => firstLeg;
            set
            {
                if (value < 1)
                    throw new ArgumentException("первый катет должен быть больше 1");
                else
                    firstLeg = value;
                    
            }
        }
        public int SecondLeg
        {
            get => secondLeg;
            set
            {
                if (value < 1)
                    throw new ArgumentException("второй катет должен быть больше 1");
                else
                    secondLeg = value;
                    
            }
        }

        public Rectangle(int firstLeg, int secondLeg)
        {
            FirstLeg = firstLeg;
            SecondLeg = secondLeg;
        }

        public void Draw()
        {
            Console.WriteLine();
            for (int i = 1; i <= FirstLeg; i++)
            {
                // Точный расчет количества звезд с округлением для правильного построения по запросу (углы из-за этого могут быть тупыми)
                int stars = (int)Math.Ceiling((double)SecondLeg * i / FirstLeg);
                for (int j = 0; j < stars; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        } 
    }
}

