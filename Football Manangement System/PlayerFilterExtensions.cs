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
    }
}
