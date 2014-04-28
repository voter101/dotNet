using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._2
{
    public class Person
    {
        public int PersonId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Phone { get; private set; }

        public Person(int nPersonId, string sFirstName, string sLastName,
            int nAge, int nPhone)
        {
            PersonId = nPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
            Phone = nPhone;
        }
    }
}
