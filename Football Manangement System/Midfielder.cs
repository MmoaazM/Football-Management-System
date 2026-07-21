using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class Midfielder : FootballPlayer
    {
        public int Passes { get; set; }
        public int KeyPasses { get; set; }
        public Midfielder(string Name, int JerseyNumber, int Age, bool IsInjured,int Passes,int KeyPasses) : base(Name, JerseyNumber, Age, IsInjured)
        {
            this.Passes = Passes;
            this.KeyPasses = KeyPasses;
        }

        public override void Play()
        {
            Console.WriteLine($"The Midfielder {Name} is Playing");
        }
        public override void Train()
        {
            Console.WriteLine($"The Midfielder {Name} is Training");
        }
    }
}
