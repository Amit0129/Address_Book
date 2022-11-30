using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    internal class AdressBookBuilder
    {
         Dictionary<string, Model> addressBookMap = new Dictionary<string, Model>();
        //public AdressBookBuilder()
        //{
        //    this.addressBookMap = new Dictionary<string, Model>();
        //}

        public void AddAdressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber,string eMail)
        {
            Model model = new Model(firstName, lastName, address, city, state, zip, phoneNumber, eMail);
            addressBookMap.Add(firstName, model);
        }
        public void DisplayAddressBook()
        {
            foreach (var item in addressBookMap)
            {
                Console.WriteLine($"Contact details First Name :: {item.Value.firstName} Key Is {item.Key}");
                Console.WriteLine($"Contact details Last Name :: {item.Value.lastName} Key Is {item.Key}");
                Console.WriteLine($"Contact details Address :: {item.Value.address} Key Is {item.Key}");
                Console.WriteLine($"Contact details City :: {item.Value.city} Key Is {item.Key}");
                Console.WriteLine($"Contact details State :: {item.Value.state} Key Is {item.Key}");
                Console.WriteLine($"Contact details Zip :: {item.Value.zip} Key Is {item.Key}");
                Console.WriteLine($"Contact details Phone Number :: {item.Value.phoneNumber} Key Is {item.Key}");
                Console.WriteLine($"Contact details Phone Number :: {item.Value.eMail} Key Is {item.Key}");
            }
        }
    }
}
