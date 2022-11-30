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
                    
                
           //For Editiang A Person Contact Details
           
           Console.WriteLine("Enter a person name u want to Edit Details");
           string editName = Console.ReadLine();
           adressBookBuilder.EditContact(editName);
           adressBookBuilder.DisplayAddressBook();
                    


            

        }
    }
}