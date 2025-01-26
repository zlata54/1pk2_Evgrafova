namespace Task_02_04
{
    internal class Program
    {
        /*Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату)
         * произведите расчет является ли пользователь совершеннолетним на текущую дату и выведите
         * соответствующее сообщение об этом
         */
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите год вашего рождения полностью:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер вашего месяца рождения:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день вашего рождения:");
            int day = int.Parse(Console.ReadLine());
            DateTime BirthDate=new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;
            int age=currentDate.Year-BirthDate.Year;
            if (currentDate<BirthDate.AddYears(age))
            { age--; }
            if (age < 18)
            { Console.WriteLine("Вы несовершеннолетний"); }
            else { Console.WriteLine("Вы совершеннолетний"); }

            
        }
    }
}
