using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class Forward : FootballPlayer
    {
        public int ShotsOnTarget { get; set; }
        public Forward(string Name, int JerseyNumber, int Age, bool IsInjured,int ShotsOnTarget) : base(Name, JerseyNumber, Age, IsInjured)
        {
            this.ShotsOnTarget = ShotsOnTarget;
        }

        public override void Play()
        {
            Console.WriteLine($"The Forward {Name} is Playing");
        }
        public override void Train()
        {
            Console.WriteLine($"The Forward {Name} is Training");
        }
    }
}
