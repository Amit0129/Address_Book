namespace AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AdressBookBuilder adressBookBuilder = new AdressBookBuilder();

            bool check = true;
            while (check)
            {

                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City Name");
                string city = Console.ReadLine();


                Console.WriteLine("Enter State Name");
                string state = Console.ReadLine();

                Console.WriteLine("Enter  Zip number");
                string zip = Console.ReadLine();

                Console.WriteLine("Enter Phone Number");
                string pnoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();

                adressBookBuilder.AddAdressBook(firstName, lastName, address, city, state, zip, pnoneNumber, email);

                Console.WriteLine("If you want to add another Enter Y ");
                string addOrNot = Console.ReadLine().ToLower();

                if (addOrNot == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            adressBookBuilder.DisplayAddressBook();


            Console.WriteLine("Choose : \n1) To Edit A Contact Details\n2) To Delete A Contact Details");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //For Editiang A Person Contact Details
                    Console.WriteLine("Enter a person name u want to Edit Details");
                    string editName = Console.ReadLine();
                    adressBookBuilder.EditContact(editName);
                    adressBookBuilder.DisplayAddressBook();   //To Check Editing Work Or not
                    break;
                case 2:
                    //For Deleate A Person Contact Details
                    Console.WriteLine("Enter a person name u want to remove");
                    string name = Console.ReadLine();
                    adressBookBuilder.RemoveContact(name);
                    //adressBookBuilder.DisplayAddressBook();   //To check Detetation Work Or not
                    break;
                default:
                    Console.WriteLine("Please Choose 1 for Edit Or 2 for Delete");
                    break;
            }
           

            





        }
    }
}