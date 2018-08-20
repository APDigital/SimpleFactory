using SimpleFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalBreed = "Tiger";
            string animalName = "tigger";
            int animalAge = 4;
            Animal animalDetails = AnimalFactory.GetAnimal(animalBreed, animalName, animalAge);

           List<string> favouriteFoods = animalDetails.GetAnimalFavouriteFoods();
            Console.WriteLine("Animal Name: {0}", animalName);
            Console.WriteLine("Animal Breed {0}", animalBreed);
            Console.WriteLine("AnimalAge: {0}", animalAge);
            foreach (var item in favouriteFoods)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
