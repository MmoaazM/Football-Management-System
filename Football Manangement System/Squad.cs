using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class Squad<T> where T:FootballPlayer // All Methods Here Need Implimentation
    {
        private List<T> _players;
        public void AddPlayer(T player) { }
        public void RemovePlayer(int jerseyNumber) { }
        public List<T> GetPlayersByPosition(string position) { return null; }
        public List<T> GetTopScorers(int count) { return null; }
        public int GetAverageRating() { return 0; }
    }
}
