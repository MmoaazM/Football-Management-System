using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class Squad<T> where T:FootballPlayer // All Methods Here Need Implimentation
    {
        private List<T> _players=new();
        public void AddPlayer(T player)
        {
            if (_players.Contains(player)) return;
            _players.Add(player);
        }
        public void RemovePlayer(int jerseyNumber)
        {
            T playerToRemove = _players.FirstOrDefault(p => p.JerseyNumber == jerseyNumber);
            if (playerToRemove == null)
                return;
            _players.Remove(playerToRemove);
        }
        public List<T> GetPlayersByPosition(string position) 
        {
            List<T> matchedPlayer = new();
            foreach(var player in _players)
            {
                if (player.GetType().Name.Equals(position, StringComparison.OrdinalIgnoreCase))
                {
                    matchedPlayer.Add(player);
                }
            }
            return matchedPlayer;
        }
        public List<T> GetTopScorers(int count) 
        {
            List<T> matchedPlayer = new();
            _players.Sort((a, b) => b.Goals.CompareTo(a.Goals));
            for(int i = 0; i < count; i++)
            {
                matchedPlayer.Add(_players[i]);
            }

            return matchedPlayer;
        }
        public int GetAverageRating() // How To Implement This ??
        {
            return 0;
        }

        public void DisplayAll()
        {
            foreach(var player in _players)
            {
                Console.WriteLine($"{player.Name}");
            }
        }
        public List<T> GetAll()
        {
            return _players;
        }
    }
}
