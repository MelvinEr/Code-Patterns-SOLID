using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IPetHandler
    {
        void RegisterPet();
        void DisplayAllPets();
        void DisplayOwners();
        void DisplaySubmittedPets();
        void PetServices();
        void RetrievePet();
        void SubmitPet();
    }
}