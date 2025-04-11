namespace Task_21_09
{
    class Program
    {
        /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
         * • поиск билета с максимальной суммой,
         * • билета с минимальной суммой,
         * • выведите список билетов с багажом
         * • выведите список люготных билетов
         */
        static void Main(string[] args)
        {
            // Генерация и вывод всех сгенерированных билетов
            List<FlightTicket> flightTickets = GenerateFlightTickets(10);
            Console.WriteLine("Все сгенерированные билеты:");
            foreach (var ticket in flightTickets)
            {
                Console.WriteLine(ticket.GetTicketInfo());
            }

            // Поиск билета с максимальной и минимальной ценой
            FlightTicket maxPriceTicket = null;
            FlightTicket minPriceTicket = null;

            for (int i = 0; i < flightTickets.Count; i++)
            {
                if (maxPriceTicket == null || flightTickets[i].TicketPrice > maxPriceTicket.TicketPrice)
                {
                    maxPriceTicket = flightTickets[i];
                }

                if (minPriceTicket == null || flightTickets[i].TicketPrice < minPriceTicket.TicketPrice)
                {
                    minPriceTicket = flightTickets[i];
                }
            }

            Console.WriteLine("\nБилет с максимальной ценой:");
            Console.WriteLine(maxPriceTicket.GetTicketInfo());
            Console.WriteLine("\nБилет с минимальной ценой:");
            Console.WriteLine(minPriceTicket.GetTicketInfo());

            Console.WriteLine("\nБилеты с багажом:");
            foreach (var ticket in flightTickets)
            {
                if (ticket.BaggageCount > 0)
                {
                    Console.WriteLine(ticket.GetTicketInfo());
                }
            }

            Console.WriteLine("\nЛьготные билеты:");
            foreach (var ticket in flightTickets)
            {
                if (ticket.HasDiscount)
                {
                    Console.WriteLine(ticket.GetTicketInfo());
                }
            }
        }
        /// <summary>
        /// Генерирует список билетов на самолет с указанным количеством.
        /// </summary>
        /// <param name="count">Количество билетов для генерации.</param>
        /// <returns>Список сгенерированных билетов.</returns>
        static List<FlightTicket> GenerateFlightTickets(int count)
        {
            Random randomGenerator = new Random();
            List<FlightTicket> flightTickets = new List<FlightTicket>();

            for (int i = 1; i <= count; i++)
            {
                double price = randomGenerator.Next(1000, 5000);
                int baggageCount = randomGenerator.Next(0, 4);
                bool hasDiscount = randomGenerator.Next(0, 2) == 1; // Случайное определение скидки

                FlightTicket ticket = new FlightTicket(i, price, baggageCount, hasDiscount);
                flightTickets.Add(ticket);
            }

            return flightTickets;
        }
    }
}
