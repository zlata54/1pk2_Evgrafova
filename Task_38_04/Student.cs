using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04
{
    /// <summary>
    /// Класс для хранения информации о студенте
    /// </summary>
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
