using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Toteuta luokka Tank, jolla on seuraavat ominaisuudet: Name (string), Type (string), CrewCount(int), Speed(float) ja SpeedMax(float) 
sekä metodit AccerelateTo(float) ja SlowTo(float). 
Toteuta ominaisuudet niin että kaikilla ominaisuuksilla on luokan sisäinen taustamuuttuja, joita luokka käyttää. 
Ominaisuudet Name ja Type ovat luettavissa sekä muutettavissa ilman rajoituksia. Ominaisuus CrewCount on luettavissa ja asetettavissa. 
Sitä asetettaessa tarkistetaan että annettu ominaisuus on sallitulla välillä: sallittu minimi on kaksi ja maksimi kuusi. 
SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena pysyvästi arvoon 100. 
Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa suoraan mutta sen arvon voi lukea. Speed-omainaisuuden arvoa voi muuttaa ainoastaan 
metodien AccerelateTo(float) ja SlowTo(float) kautta kuitenkin niin että Speed ei voi olla nollaa pienempi eikä Speedmax-arvoa suurempi. 
- minimi on nolla ja maksimi 100. Jos metodeille annettu arvo ei ole sallitulla välillä niin metodi ei muuta Speed-arvoa.
Toteuta pääohjelma TestTank, jolla testaat eri ominaisuuksien asettamista. Kysymys: Pitääkö pääohjelman ja käyttäjän metodeja kutsuessaan 
jotenkin tietää että metodi ei asettanutkaan nopeutta pyydettyyn arvoon? */

namespace Har4Teht1
{
    class Tank
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int crewMin = 2;
        private int crewMax = 6;

        private int crewCount;

        public int CrewCount
        {
            get { return crewCount; }
            set
            {
                if (value >= crewMin && value <= crewMax)
                {
                    crewCount = value;

                }
                else
                {
                    Console.WriteLine("!Incorrect amount of crew!");
                }
            } 
        }
        private static float SpeedMax = 100;
        private static float SpeedMin = 0;

        private float speed;
        public float Speed
        {
            get { return speed; }
            set
            {
                if (value <= SpeedMax && value >= SpeedMin)
                    speed = value;
                else
                {
                    speed = Speed;
                }
            }
        }

        public float AccelerateTo()
        {
            Console.Write("Please enter the desired acceleration: ");
            speed = float.Parse(Console.ReadLine());
            if (speed > SpeedMax)
            {
                Console.WriteLine("Max speed is 100!");
                speed = SpeedMax;
                return speed;
            }
            else
                return speed;
        }

        public float SlowTo()
        {
            Console.Write("Please enter the desired deacceleration: ");
            speed -= float.Parse(Console.ReadLine());
            if (speed < SpeedMin)
            {
                Console.WriteLine("You can't go in reverse! (For some reason.)");
                speed = SpeedMin;
                return speed;
            }
            else
                return speed;
        }

        public void PrintTank()
        {
            Console.WriteLine("Tank name: " + Name);
            Console.WriteLine("Tank type: " + Type);
            Console.WriteLine("Crew Count: " + CrewCount);
            Console.WriteLine("Current speed: " + Speed + " out of " + SpeedMax);


        }
        public Tank()
        {
        }
    }
}
