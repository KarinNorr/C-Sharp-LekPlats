using System;

namespace jultomten
{
    class Släde
    {
        private int maxFart;
        private int maxVikt;
        private int renkrafter;

        public Släde(int renar)
        {
            this.renkrafter = renar;
        }


        // Exempel av en överalagring av metod från ärvd klass object.
        public override string ToString()
        {
            string str;
            str = string.Format(
                "Speed Daemon 2000. Antal renar i spann: {0}",
                renkrafter);
            return str;
        }
    }
}