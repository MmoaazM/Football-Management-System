using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class StatsCalculator<T> where T : FootballPlayer
    {
        public int CalculateAverageGoals(List<T> players) 
        {
            int sumOfGoals = 0;
            foreach(var player in players)
            {
                sumOfGoals += player.Goals;
            }
            return sumOfGoals / players.Count;
        }
        public int CalculateAverageAge(List<T> players) 
        {
            int sumOfAges = 0;
            foreach (var player in players)
            {
                sumOfAges += player.Age;
            }
            return sumOfAges / players.Count;
        }
        public FootballPlayer GetBestPlayer(List<T> players)
        {
            int sumOfGoalsAndAssists = players[0].Goals+players[0].Assists;
            var sum=0;
            T bestPlayer=players[0];
            foreach(var player in players)
            {
                sum = player.Goals + player.Assists;
                if (sum > sumOfGoalsAndAssists)
                {
                    sumOfGoalsAndAssists = sum;
                    bestPlayer = player;
                }
            }
            return bestPlayer;
        }
        public FootballPlayer GetWorstPlayer(List<T> players) 
        {
            int sumOfGoalsAndAssists = players[0].Goals + players[0].Assists;
            var sum = 0;
            T worstPlayer = players[0];
            foreach (var player in players)
            {
                sum = player.Goals + player.Assists;
                if (sum < sumOfGoalsAndAssists)
                {
                    sumOfGoalsAndAssists = sum;
                    worstPlayer = player;
                }
            }
            return worstPlayer;
        }

    }
}
