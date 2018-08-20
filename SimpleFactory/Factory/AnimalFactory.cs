using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    public static class AnimalFactory
    {
        public static Animal GetAnimal(string breed, string animalName, int animalAge)
        {
            return new Animal(breed, animalName, animalAge);
        }
    }
}
