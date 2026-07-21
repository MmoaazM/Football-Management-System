using System;

using Football_Manangement_System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("--- 1. CREATING PLAYERS (OOP) ---\n");

        var salah = new Forward("Mohamed Salah", 10, 31, false,100);
        var trezeguet = new Forward("Trezeguet", 7, 29, false,110);
        var hegazi = new Defender("Ahmed Hegazi", 6, 32, false, 30,100);
        var marmoush = new Forward("Omar Marmoush", 14, 24, false, 200);
        var elShenawy = new GoalKeeper("Mohamed El-Shenawy", 1, 33,false, 12);




        Console.WriteLine("--- 2. POLYMORPHISM ---\n");

        List<FootballPlayer> players = new List<FootballPlayer> { salah, trezeguet, hegazi, marmoush, elShenawy };

        foreach (var player in players)
        {
            player.Play();  
            player.Train(); 
            Console.WriteLine();
        }

        Console.WriteLine("--- 3. CREATING TEAM ---\n");

        var team = new Team("Al Ahly SC", "Marcel Koller");
        team.AddPlayer(salah);
        team.AddPlayer(trezeguet);
        team.AddPlayer(hegazi);
        team.AddPlayer(marmoush);
        team.AddPlayer(elShenawy);

        team.DisplaySquad();
    }
}

