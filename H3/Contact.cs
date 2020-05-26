using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    class Contact
    {
        string name;
        string surname;
        string phoneNumber;

        public Contact(string name, string surname, string phoneNumber) {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public string getName() {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
