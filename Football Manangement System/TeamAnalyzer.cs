using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class TeamAnalyzer
    {
        public int CalculateTeamStat(List<FootballPlayer>players,Func<FootballPlayer,int>selector)
        {
            int result=0;
            foreach(var player in players)
            {
                result += selector(player);
            }
            return result;
        }

        public void ApplyToAllPlayers(List<FootballPlayer> players, Action<FootballPlayer> applyChange)
        {
            foreach (var player in players)
                applyChange(player);
        }

        public List<FootballPlayer> FindPlayers(List<FootballPlayer> players, Predicate<FootballPlayer> filter)
        {
            var returnedPlayers = new List<FootballPlayer>();
            foreach(var player in players)
            {
                if (filter(player))
                {
                    returnedPlayers.Add(player);
                }
            }
            return returnedPlayers;
        }
    }
}
