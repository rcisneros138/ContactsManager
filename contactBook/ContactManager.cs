using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactBook
{
   public class ContactManager<tkey, tvalue>
    {
        Dictionary<tkey, tvalue> contactInfo;
        private tvalue name;

        public ContactManager()
        {
            contactInfo = new Dictionary<tkey, tvalue>();
            
        }

        public tvalue getContactName(tkey phoneNumber)
        {
            try
            {
                name = contactInfo[phoneNumber];
            }
            catch
            {
                Console.WriteLine("no contact found with that number ");
            }
           
            return name;
        }
        

        public void addContact(tkey phoneNumber, tvalue name)
        {
            contactInfo.Add(phoneNumber, name);
        }

        
    }
}
