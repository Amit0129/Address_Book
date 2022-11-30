namespace AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
            adressBookBuilder.AddAdressBook("Amit", "Kumar", "Odisha", "Dhenkanal", "Odisha", "759023", "7978865380","Amit199@gmail.com");
            adressBookBuilder.DisplayAddressBook();

            

        }
    }
}