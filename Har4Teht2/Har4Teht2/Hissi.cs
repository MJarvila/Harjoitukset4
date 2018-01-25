using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. 
/// Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään hissi haluttuun kerrokseen 
/// (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. 
/// Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila. 

namespace Har4Teht2
{
    class Hissi
    {
        static private int FloorMin = 1;
        static private int FloorMax = 5;

        public int CurrentFloor = 1;
        public int FloorToBe { get; set; }

        public int UseElevator()
        {
            Console.Write("Please enter the floor number (1-5): ");
            FloorToBe = int.Parse(Console.ReadLine());
            if (FloorToBe >= FloorMin && FloorToBe <= FloorMax)
            {
                CurrentFloor = FloorToBe;
                return FloorToBe;
            }
            else
            {
                Console.WriteLine("You can't move to a floor that doesn't exist!");
                return UseElevator();
            }
        }

        public void TellFloor()
        {
            Console.WriteLine("You are now at floor " + FloorToBe);
        }

    }
}
