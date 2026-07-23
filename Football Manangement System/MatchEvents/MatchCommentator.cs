using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System.MatchEvents
{
    public class MatchCommentator
    {
        public void PlayerScored(string player)=>
            Console.WriteLine($"Commentator : {player} Scored A Goaaaaal !!!");

        public void PlayerGetRedCard(string player)=>
            Console.WriteLine($"Commentator : {player} Get A RedCard !!!");


        /// The Commentator Should Continue Implementing The Rest Of The Events

    }
}
