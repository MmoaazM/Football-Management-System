using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class GoalKeeper : FootballPlayer
    {
        public int CleanSheets { get; set; }
        public GoalKeeper(string Name, int JerseyNumber, int Age, bool IsInjured,int CleanSheets) : base(Name, JerseyNumber, Age, IsInjured)
        {
            this.CleanSheets = CleanSheets;
        }

        public override void Play()
        {
            Console.WriteLine($"The GoalKeeper {Name} is Playing");
        }
        public override void Train()
        {
            Console.WriteLine($"The GoalKeeper {Name} is Training");
        }
    }
}
