using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System.MatchEvents
{
    public class Coach
    {
        public void PlayerScoredGoal(string player) =>
           Console.WriteLine($"Coach : Good Job {player},[whislte]:- TEAM LET'S DO THE REMONTADA");
    }
}
