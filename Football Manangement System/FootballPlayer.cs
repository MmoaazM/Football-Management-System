using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Football_Manangement_System
{
    public abstract class FootballPlayer
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public int Age { get; set; }
        public bool IsInjured { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }

        public FootballPlayer(string Name,int JerseyNumber,int Age,bool IsInjured)
        {
            this.Name = Name;
            this.JerseyNumber = JerseyNumber;
            this.Age = Age;
            this.IsInjured = IsInjured;
            Goals = 0;
            Assists = 0;
        }

        public abstract void Play();
        public virtual void Train()
        {
            Console.WriteLine($"The Player {Name} is Training");
        }

        public void Injure()
        {
            Console.WriteLine($"The Player {Name}is Injured");
            IsInjured = true;
        }
        public void Recover()
        {
            Console.WriteLine($"The Player {Name}is Recovered");
            IsInjured = false;
        }
        public void ScoreGoal()
        {
            Console.WriteLine($"The Player {Name}Scored a Goal");
            Goals++;
        }
        public void MakeAssist()
        {
            Console.WriteLine($"The Player {Name}Maked Assist");
            Assists++;
        }
    }
}
