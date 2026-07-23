using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System.MatchEvents
{
    public class Fans
    {
        private string name;

        public Fans(string name)
        {
            this.name = name;
        }

        public void PlayerScoredGoal(string player)=>
            Console.WriteLine($"Fans : {player} Scored A Goaaaaal !!! Ole , Ole ...{player},,{player}");
    }
}
