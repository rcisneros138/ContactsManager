using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactBook
{
    class UserInterface
    {
        ContactCreator contactCreator;
        ContactManager<long, string> contactsDictionary;
        public UserInterface()
        {
            contactCreator = new ContactCreator();
            contactsDictionary = new ContactManager<long, string>();
        }
        public void BeginUI()
        {
           

            Console.WriteLine("create new contact? y/n");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y")
            {
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Phone Number: ");
                long phone = Convert.ToInt64(Console.ReadLine());
                Contact newContact = contactCreator.createNewContact(name, phone);
                contactsDictionary.addContact(newContact.contactPhoneNumber, newContact.contactName);
                BeginUI();
            }
            else
            {
                Console.WriteLine("Enter a phone number (without Dashes) to find the name corresponding with it: ");
                string  name = contactsDictionary.getContactName(Convert.ToInt64( Console.ReadLine()));
                Console.WriteLine(name);
                //Console.ReadLine();
                BeginUI();
            }
        }
    }
}
