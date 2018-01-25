using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har4Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Hissi Dynamo = new Hissi();
                Dynamo.UseElevator();

                Dynamo.TellFloor();
            }

        }
    }
}
