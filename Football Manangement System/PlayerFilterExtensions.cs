using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public static class PlayerFilterExtensions
    {
        public static bool IsStarPlayer(this FootballPlayer player) => player.Goals > 20;
        public static bool IsVeteran(this FootballPlayer player) => player.Age > 30;
        public static bool IsInjured(this FootballPlayer player) => player.IsInjured;
        public static bool IsGoalKeeper(this FootballPlayer player) => player is GoalKeeper;
        public static bool HasMinimumGoals(this FootballPlayer player, int minGoals) => player.Goals <= minGoals;
        public static bool ByPosition(this FootballPlayer player, string position) => player.GetType().Name.Equals(position, StringComparison.OrdinalIgnoreCase);
        public static double GetRating(this FootballPlayer player)
        {
            double rating = 5.0 + (player.Goals * 0.1) + (player.Assists * 0.05);
            return Math.Min(rating, 10.0);
        } // this body is the real Rating system do
        public static void PrintStats(this FootballPlayer player) =>
            Console.WriteLine($"{player.Name}: Goals={player.Goals}, Assists={player.Assists}, Age={player.Age}"); 
        public static double GetValue(this FootballPlayer player)
        {
            double baseValue = 1_000_000;
            double ageMultiplier = player.Age < 27 ? 1.5 : 0.8;
            return (baseValue + (player.Goals * 50_000) + (player.Assists * 20_000)) * ageMultiplier;
        } // this body based on the real market assessments
    }
}
