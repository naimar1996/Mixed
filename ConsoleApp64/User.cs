using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PIN
        {
            get
            {
                return pin;
            }
            set
            {
                if ( pin == 7)
                {
                    pin = value;
                }
                else 
                {
                  throw new Exception();
                }
            }
        }
        private int pin;
        public RegistrationMonth RegistrationMonth { get; set; }
        private RegistrationMonth registrationmonth;
        public User(string name, string surname, int pin, RegistrationMonth registrationmonth)
        {
            Name = name;
            Surname = surname;
            PIN = pin;
            RegistrationMonth = registrationmonth;
        }

        public string GetDetails()
        {
            return $"{Name},{Surname},{PIN},{RegistrationMonth}";
        }
    }
}
