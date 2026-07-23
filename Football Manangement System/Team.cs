using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Football_Manangement_System
{
    public class Team : IEnumerable<FootballPlayer>
    {
        public string Name { get; set; }
        private List<FootballPlayer> Players;
        public string CoachName { get; set; }

        public Team(string Name,string CoachName)
        {
            this.Name = Name;
            this.CoachName = CoachName;
            Players = new List<FootballPlayer>();
        }

        public void AddPlayer(FootballPlayer newPlayer)
        {
            if (!Players.Contains(newPlayer))
            {
                Players.Add(newPlayer);
                Console.WriteLine($"The New User {newPlayer} Added Successfully");
                return;
            }

            Console.WriteLine("The Player Already Exists");
                
        }
        public void RemovePlayer(int JerseyNumber) 
        {
            var player = Players.FirstOrDefault(p => p.JerseyNumber == JerseyNumber);
            if (player != null)
            {
                Players.Remove(player);
                Console.WriteLine($"The Player {player.Name} Has Been Removed successfully");
            }
        } 
        public void DisplaySquad()
        {
            Console.WriteLine("All Players Info :-");
            foreach(var player in Players)
            {
                Console.WriteLine($"{player.JerseyNumber} {player.Name} ------> Age {player.Age} - IsInjured {player.IsInjured} - Number Of Goals {player.Goals} - Number Of Assists {player.Assists}");
            }
        }
        public float CalculateAverageAge()
        {
            if (Players.Count == 0)
            {
                Console.WriteLine("The Team Is Empty");
                return 0;
            } 
            float sumOfAge = 0;
            foreach(var player in Players)
            {
                sumOfAge += player.Age;
            }
            return sumOfAge / Players.Count;
        }

        public int GetTotalGoals() =>Players.Sum(p => p.Goals);
        public FootballPlayer GetTopScorer()
        {
            FootballPlayer topScorer=Players.FirstOrDefault();
            foreach(var player in Players)
            {
                if (player.Goals > topScorer.Goals)
                    topScorer = player;
            }
            return topScorer;
        }
        public FootballPlayer this[int index]
        {
            get 
            {
                if(index>=0 && index<Players.Count) return Players[index];
                return null;

            }
            set 
            {
                if (index >= 0 && index < Players.Count)
                    Players[index] = value;
            }
        }

        public FootballPlayer this[int jerseyNumber,bool byNumber]
        {
            get
            {
                if (byNumber)
                {
                    var player = Players.FirstOrDefault(p => p.JerseyNumber == jerseyNumber);
                    return player;
                }
                return null;
               
            }
        }

        public FootballPlayer this[string name] => Players.FirstOrDefault(p => p.Name == name);

        //public int this[string position,string statistics]
        //{

        //}


        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            foreach (var player in Players)
                yield return player;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerable<FootballPlayer> GetStarPlayers()
        {
            foreach(var player in Players)
            {
                if (player.IsStarPlayer())
                    yield return player;
            }
        }

        public IEnumerable<FootballPlayer> GetInjuredPlayers()
        {
            foreach (var player in Players)
            {
                if (player.IsInjured)
                    yield return player;
            }
        }

        public IEnumerable<FootballPlayer> GetPlayersByAgeRange(int min , int max)
        {
            foreach (var player in Players)
            {
                if (player.Age>=min && player.Age<=max)
                    yield return player;
            }
        }

        public IEnumerable<FootballPlayer> GetPlayersSortedByGoals()
        {
            Players.Sort((a,b)=>b.Goals.CompareTo(a.Goals));

            foreach (var player in Players)
            { 
                yield return player;
            }
        }

        public IEnumerable<FootballPlayer> GetPlayersByPosition(string position)
        {
            foreach (var player in Players)
            {
                if (player.GetType().Name.Equals(position, StringComparison.OrdinalIgnoreCase))
                    yield return player;
            }
        }


    }
}
