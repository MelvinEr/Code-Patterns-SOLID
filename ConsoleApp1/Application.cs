using System;

namespace ConsoleApp1
{
    class Application : IApplication
    {
        public ICustomerHandler CustomerHandler { get; set; }
        public IPetHandler PetHandler { get; set; }
        public Application(IPetHandler petHandler, ICustomerHandler customerHandler)
        {
            PetHandler = petHandler;
            CustomerHandler = customerHandler;            
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine(
                    "Välj Åtgärd:\n" +
                    "1. Registrera ny kund\n" +
                    "2. Registrera nytt djur\n" +
                    "3. Visa registrerade kunder\n" +
                    "4. Visa registrerade djur\n" +
                    "5. Visa vilka djur som tillhör vilken ägare\n" +
                    "6. Anmäl inlämning av djur\n" +
                    "7. Anmäl hämtning av djur\n" +
                    "8. Visa inlämnade djur och dess ägare\n" +
                    "9. Extratjänster för ditt djur\n"
                    );
                var action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        CustomerHandler.RegisterCustomer();
                        break;
                    case ConsoleKey.D2:
                        PetHandler.RegisterPet();
                        break;
                    case ConsoleKey.D3:
                        CustomerHandler.DisplayCustomers();
                        break;
                    case ConsoleKey.D4:
                        PetHandler.DisplayAllPets();
                        break;
                    case ConsoleKey.D5:
                        PetHandler.DisplayOwners();
                        break;
                    case ConsoleKey.D6:
                        PetHandler.SubmitPet();
                        break;
                    case ConsoleKey.D7:
                        PetHandler.RetrievePet();
                        break;
                    case ConsoleKey.D8:
                        PetHandler.DisplaySubmittedPets();
                        break;
                    case ConsoleKey.D9:
                        PetHandler.PetServices();
                        break;
                    default:
                        Console.WriteLine("något gick fel lol");
                        break;
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
