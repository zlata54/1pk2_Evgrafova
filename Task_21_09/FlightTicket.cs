using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    public class FlightTicket
    {
        public int TicketId { get; set; }
        public double TicketPrice { get; set; }
        public int BaggageCount { get; set; } // количество единиц багажа
        public bool HasDiscount { get; set; } // скидочный билет
        /// <summary>
        /// Конструктор для создания экземпляра класса <see cref="FlightTicket"/>.
        /// </summary>
        /// <param name="ticketId">Уникальный идентификатор билета.</param>
        /// <param name="ticketPrice">Цена билета.</param>
        /// <param name="baggageCount">Количество единиц багажа.</param>
        /// <param name="hasDiscount">Указывает на наличие скидки.</param>
        public FlightTicket(int ticketId, double ticketPrice, int baggageCount, bool hasDiscount)
        {
            TicketId = ticketId;
            TicketPrice = ticketPrice;
            BaggageCount = baggageCount;
            HasDiscount = hasDiscount;
        }
        /// <summary>
        /// Получает информацию о билете в виде строки.
        /// </summary>
        /// <returns>Строка с информацией о билете.</returns>
        public string GetTicketInfo()
        {
            return $"Билет №{TicketId}, Цена: {TicketPrice} рублей, Багаж: {BaggageCount} единиц, Льготный: {(HasDiscount ? "Да" : "Нет")}";
        }
    }
}
