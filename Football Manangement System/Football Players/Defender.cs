using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class Defender : FootballPlayer
    {
        public int Tackles { get; set; }
        public int Clearances { get; set; }

        public Defender(string Name, int JerseyNumber, int Age, bool IsInjured,int Tackles,int Clearances):base(Name, JerseyNumber, Age, IsInjured)
        {
            this.Tackles = Tackles;
            this.Clearances = Clearances;
        }

        public override void Play()
        {
            Console.WriteLine($"The Defender {Name} is Playing");
        }

        public override void Train()
        {
            Console.WriteLine($"The Defender {Name} is training");
        }
    }
}
