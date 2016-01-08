using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactBook
{
    class ContactCreator
    {
        public void getNewContactInfo()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Phone Number: ");
            long phone = Convert.ToInt64(Console.ReadLine());
            createNewContact(name, phone);

            
        }
        public Contact createNewContact(string name, long phoneNumber)
        {
            Contact createdContact = new Contact(name, phoneNumber);
            FileManager.saveContacts(name, phoneNumber);
            return createdContact;
        }
    }
}
