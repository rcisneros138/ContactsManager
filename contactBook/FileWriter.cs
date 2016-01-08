using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactBook
{
   public static class FileManager
    {
        public static void saveContacts(Dictionary<string,long> dictionary)
        {
            File.WriteAllLines("Contacts.txt", dictionary.Select(valuePair => string.Format("{0}{1}", valuePair.Key, valuePair.Value))); 
        }

        public static void saveContacts(string name, long phoneNumber)
        {
            
            using (StreamWriter writer = new StreamWriter("Contacts.txt"))
            {
                writer.WriteLine(name);
                writer.WriteLine(phoneNumber);
            }
        }
        public static string[] getContacts()
        {
            string[] arrayOfContacts = File.ReadAllLines("Contacts.txt");
            return arrayOfContacts;
         
        }


    }
}
