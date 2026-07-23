using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class Match
    {
        public event Action<string> GoalScored; //DONE
        public event Action<string> PlayerInjured; //DONE
        public event Action<string> RedCard;    //DONE
        public event Action MatchStarted;       //DONE
        public event Action MatchEnded;         //DONE
        public event Action<string, string> Substitute;

        public void MatchStarts()
        {
            Console.WriteLine("The Match Starts Now");
            MatchStarted?.Invoke();
        }

        public void MatchEnds()
        {
            Console.WriteLine("The Match Ends Now");
            MatchEnded?.Invoke();
        }

        public void Goaaal(string scorer) => GoalScored?.Invoke(scorer);
        public void InjuryFor(string player) => PlayerInjured?.Invoke(player);
        public void ARedCard(string player) => RedCard?.Invoke(player);
        public void MakeSubstitution(string playerIn, string playerOut) => Substitute?.Invoke(playerIn, playerOut);
    }
}
