using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100. 
/// Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla. 
/// Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa. 
namespace Har4Teht3
{
    class Vahvistin
    {
        private int volume;
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public int TweakVolume()
        {
            Console.Write("Give a new volume value (1-100): ");
            Volume = int.Parse(Console.ReadLine());
            return Volume;

        }
        public void Amp()
        {

        }
    }
}
