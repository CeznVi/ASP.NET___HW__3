using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__3_Solution.Entitys
{
    public class Contact
    {
        public string Name { get; set; }
        public string MobilePhone { get; set; }
        public string? AltMobilePhone { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Имя контакта: {Name}\n" +
                   $"Мобильный телефон: {MobilePhone}\n" +
                   $"Альтернативный мобильный телефон: {(AltMobilePhone is null ? string.Empty: AltMobilePhone)}\n" +
                   $"Email: {(Email is null ? string.Empty : Email)}\n" +
                   $"Описание: {(Description is null ? string.Empty : Description)}";
        }
    }

}
