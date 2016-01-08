using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactBook
{
    public class Contact : Person
    {
        private string name;
        private long phoneNumber;
        private string email;
        public Contact(string contactName, long contactPhone)
        {
            name = contactName;
            phoneNumber = contactPhone;
        }

        public string contactName
        {
            get { return name; }
            set { name = value; }
        }
        public long contactPhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    


    }
}
