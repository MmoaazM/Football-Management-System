using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System.MatchEvents
{
    public class Coach
    {
        private string name;

        public Coach(string name)
        {
            this.name = name;
        }

        public void PlayerScoredGoal(string player) =>
           Console.WriteLine($"Coach : Good Job {player},[whistle]:- LET'S DO THE REMONTADA");
    }
}
