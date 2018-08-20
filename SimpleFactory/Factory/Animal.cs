using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    public class Animal
    {
        public Animal(string breed, string animalName, int animalAge)
        {
            Breed = breed;
            AnimalName = animalName;
            AnimalAge = animalAge;
            GetAnimalFavouriteFoods();
        }
        public string Breed { get; set; }
        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }
        public List<string> GetAnimalFavouriteFoods()
        {
            string breed = Breed;
            string animalName = AnimalName;
            int animalAge = AnimalAge;

            List<string> favouriteFoods = AnimalRequests.GetFoodsByBreed(breed);
            return favouriteFoods;
        }
    }
}
