using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har4Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank Panzer = new Tank();


            Console.Write("Enter tank name: "); Panzer.Name = Console.ReadLine();
            Console.Write("Enter tank type: "); Panzer.Type = Console.ReadLine();
            Console.Write("Enter tank crew quantity: "); Panzer.CrewCount = int.Parse(Console.ReadLine());
            Panzer.AccelerateTo();
            Panzer.SlowTo();


            Panzer.PrintTank();

        }
    }
}
