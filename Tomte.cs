using System;
using System.Collections.Generic;

namespace jultomten
{
    class Tomte
    {
        private List<Nisse> nissar = new List<Nisse>();

        public Tomte(int numberOfNisses = 5)
        {
            // En tomte måste ha minst 5 nissar till förfogande.
            CreateDefaultNisses(numberOfNisses);
        }

        public void CreateDefaultNisses(int numberOfNisses)
        {
            for (int i = 0; i < numberOfNisses; i++)
            {
                Nisse nisse = new Nisse("Nisse" + i, 25);
                nissar.Add(nisse);
            }
        }

        public List<Nisse> GetNisseList()
        {
            return nissar;
        }
    }
}