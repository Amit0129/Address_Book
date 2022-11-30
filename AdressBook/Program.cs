namespace AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
            
            adressBookBuilder.AddAdressBook("Amit", "Kumar", "Odisha", "Dknl", "Odisha", "759023", "7978861488", "amit@gmail.com");
            adressBookBuilder.AddAdressBook("Manit", "Kumar", "Odisha", "Dknl", "Odisha", "759023", "7978861488", "amit@gmail.com");
            adressBookBuilder.AddAdressBook("Mamata", "Kumar", "Odisha", "Dknl", "Odisha", "759023", "7978861488", "amit@gmail.com");
            adressBookBuilder.AddAdressBook("Mayadhar", "Kumar", "Odisha", "Dknl", "Odisha", "759023", "7978861488", "amit@gmail.com");
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
                    adressBookBuilder.DisplayAddressBook();
                    break;
                case 2:
                    //For Deleate A Person Contact Details
                    Console.WriteLine("Enter a person name u want to remove");
                    string name = Console.ReadLine();
                    adressBookBuilder.RemoveContact(name);
                    adressBookBuilder.DisplayAddressBook();
                    break;
                default:
                    Console.WriteLine("Please Choose 1 for Edit Or 2 for Delete");
                    break;
            }
           

            





        }
    }
}