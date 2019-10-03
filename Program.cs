using System;
using System.Collections.Generic;

namespace jultomten
{
    class Program
    {
        static void Main(string[] args)
        {
            Tomte klas = new Tomte();

            while(true)
            {
                List<Nisse> nisseList = new List<Nisse>();
                nisseList = klas.GetNisseList();
                foreach (var nisse in nisseList)
                {
                    Console.WriteLine(nisse);
                }
                break;
            }


            Console.WriteLine("All nisse experties available:");
            Console.WriteLine("==============================");
            foreach (var item in Nisse.allExperties)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
