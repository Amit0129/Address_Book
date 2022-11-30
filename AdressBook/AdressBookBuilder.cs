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
                Console.WriteLine($"Contact details First Name :: {item.Value.firstName} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details Last Name :: {item.Value.lastName} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details Address :: {item.Value.address} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details City :: {item.Value.city} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details State :: {item.Value.state} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details Zip :: {item.Value.zip} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details Phone Number :: {item.Value.phoneNumber} --- Key Is {item.Key}");
                Console.WriteLine($"Contact details Email Adress :: {item.Value.eMail} --- Key Is {item.Key}");
                Console.WriteLine();
            }
        }
        public void EditContact(string name)
        {
            foreach (var item in addressBookMap)
            {
                if (item.Key == name)
                {
                    Console.WriteLine("Choose The Option :\n 1) First Name\n 2) last name\n 3) for adress\n 4) for city\n 5) for state\n 6) for zip\n 7) for phone number\n 8) for email ");
                    int change = Convert.ToInt32(Console.ReadLine());

                    switch (change)
                    {
                        case 1:
                            Console.WriteLine("Enter the first name");
                            item.Value.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the last name");
                            item.Value.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the address");
                            item.Value.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the city");
                            item.Value.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the state");
                            item.Value.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the zip");
                            item.Value.zip = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter the phone number");
                            item.Value.phoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter the email");
                            item.Value.eMail = Console.ReadLine();
                            break;

                    }
                }
            }
        }
        

    }
}
