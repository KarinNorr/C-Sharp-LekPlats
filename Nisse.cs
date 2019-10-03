using System;

namespace jultomten
{
    class Nisse
    {
        // Automatisk Egenskap
        // Ett så kallat backingfield skapas automatiskt av C# i det dolda.
        public int Age { get; set; }
        
        // En readonly Egenskap
        public string Name { get; }

        public string Experties { get; set; }

        public static string[] allExperties = new string[] {
            "Woodwork",
            "Smartphones",
            "Painting",
            "Injection Molding",
            "Iron Casting",
            "Potpurie",
            "Textiles",
            "Faschion",
            "Music",
            "Automobiles"
        };

        public Nisse(string name, int age)
        {
            Name = name;
            Age = age;

            // Kallar på en metod ifrån konstruktor.
            // Notera att det går att komma åt metoder ifrån klassen även
            // om det inte finns någon instans då metodanropet sker här.
            GenerateExperties();
        }

        private void GenerateExperties()
        {
            Random rand = new Random();
            int index = rand.Next(0, 10);
            Experties = allExperties[index];
        }

        public override string ToString()
        {
            string str = "";
            str = string.Format(
                "Denna nisse heter {0} och är {1} år. \nDess expertis är {2}.",
                Name, Age, Experties);
                return str;
        }

    }
}