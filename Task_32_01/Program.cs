namespace Task_32_01
{
    /*разобрать пример, последовательно воспроизвести его в своем проекте. добавить в репозиторий под
     * номером Task_32_01
     * расширить пример с колобком дополнительной логикой:
     * добавить препятствия не из мира животных, которые будут затормаживать его перемещение
     */
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; private set; }
        public bool IsAlive { get; private set; }

        public Kolobok()
        {
            Position = 0;
            Speed = 3;
            IsAlive = true;
        }

        public void Roll()
        {
            Position++;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }

        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }
        //после встречи с какими-либо неживыми объектами скорость колобка уменьшается
        public void MeetObstacle(Obstacle obstacle)
        {
            Speed = obstacle.SlowDown(Speed);
            Console.WriteLine($"Колобок встретил {obstacle.Name} и замедлился! Новая скорость: {Speed}");
        }

        public abstract class Obstacle
        {
            public string Name { get; }
            protected Obstacle(string name)
            {
                Name = name;
            }
            public abstract int SlowDown(int currentSpeed);
        }

        public class Fence : Obstacle
        {
            public Fence() : base("забор") { }
            public override int SlowDown(int currentSpeed)
            {
                return Math.Max(1, currentSpeed - 1); //при встрече с забором скорость колобка уменьшается на 1 при этом она не может быть меньше 1
            }
        }

        public class FallenTrees : Obstacle
        {
            public FallenTrees() : base("упавшие деревья") { }
            public override int SlowDown(int currentSpeed)
            {
                return Math.Max(1, currentSpeed - 1); //при встрече с деревьями скорость колобка уменьшается на 1 при этом она не может быть меньше 1

            }
        }

        public abstract class Animal
        {
            public string Name { get; }
            protected Animal(string name)
            {
                Name = name;
            }
            public abstract bool CanEat(Kolobok kolobok);
        }

        public class Hare : Animal
        {
            public Hare() : base("Заяц") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return false;
            }
        }

        public class Wolf : Animal
        {
            public Wolf() : base("Волк") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return false;
            }
        }

        public class Bear : Animal
        {
            public Bear() : base("Медведь") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return false;
            }
        }

        public class Fox : Animal
        {
            public Fox() : base("Лиса") { }
            public override bool CanEat(Kolobok kolobok)
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<object> encounters = new List<object>
        {
            new Hare(),
            new Fence(),
            new Wolf(),
            new Bear(),
            new FallenTrees(),
            new Fox()
        };

            foreach (var encounter in encounters)
            {
                kolobok.Roll();

                if (!kolobok.IsAlive)
                    break;

                if (encounter is Animal animal)
                    kolobok.MeetAnimal(animal);
                else if (encounter is Obstacle obstacle)
                    kolobok.MeetObstacle(obstacle);
            }

            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }
}
