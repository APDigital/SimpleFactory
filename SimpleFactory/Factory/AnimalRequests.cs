using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    public class AnimalRequests
    {
        internal static List<string> GetFoodsByBreed(string breed)
        {
            List<string> AnimalsAppropriateFoods = new List<string>();
            if (breed == "Tiger"|| breed == "Bear" || breed == "Lion")
            {
                List<string> ListOfCarnivorFoods = new List<string>(new string[]
                {
                    "Deer",
                    "Salmon",
                    "Pigs"
                });
                AnimalsAppropriateFoods = ListOfCarnivorFoods;
                
            }
            else 
            {
                List<string> ListOfHerbivorFoods = new List<string>(new string[]
               {
                    "Grass",
                    "Watermelon",
                    "Mango"
               });
                AnimalsAppropriateFoods = ListOfHerbivorFoods;
            }
           
            return AnimalsAppropriateFoods;
        }
    }
}
