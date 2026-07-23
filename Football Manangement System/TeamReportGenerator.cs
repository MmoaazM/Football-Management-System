using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class TeamReportGenerator
    {
        public delegate bool PlayerFilter(FootballPlayer p);
        public void GenerateReport(List<FootballPlayer>players,string title,PlayerFilter filter)
        {
            Console.WriteLine($"Team Report for {title} is being Generated ...");
            var matchedPlayers = new List<FootballPlayer>();

            foreach(var player in players)
            {
                if (filter(player))
                {
                    matchedPlayers.Add(player);
                }
            }

            Console.WriteLine("Displaying Matching Players .....");
            if(matchedPlayers.Count==0)
            {
                Console.WriteLine("No Matching Players");
                return;
            }

            foreach(var player in matchedPlayers)
            {
                Console.WriteLine($"Name : { player.Name}  JerseyNumber  : {player.JerseyNumber}");
            }
            Console.WriteLine();
        }
    }
}
