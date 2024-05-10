using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_test.data
{
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public static Person[] GetPerson()
        {
            var result = new Person[]
            {
                new Person(){LastName="Иванов", FirstName="Алексей"},
                new Person(){LastName="Марго", FirstName="Робби"},
                new Person(){LastName="Уйит", FirstName="Смит"}
            };
            return result;
        }
    }
}
