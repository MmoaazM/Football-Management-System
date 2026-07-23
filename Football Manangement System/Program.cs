using System;

using Football_Manangement_System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("--- 1. CREATING PLAYERS (OOP) ---\n");

        var salah = new Forward("Mohamed Salah", 10, 31, false, 100);
        var trezeguet = new Forward("Trezeguet", 7, 29, false, 110);
        var hegazi = new Defender("Ahmed Hegazi", 6, 32, false, 30, 100);
        var marmoush = new Forward("Omar Marmoush", 14, 24, false, 200);
        var elShenawy = new GoalKeeper("Mohamed El-Shenawy", 1, 33, false, 12);




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

        Console.WriteLine("--- 4. INDEXERS ---\n");

        // By position
        Console.WriteLine($"Player at index 0: {team[0]?.Name}");

        // By jersey number
        var playerByNumber = team[10, true];
        Console.WriteLine($"Player with jersey #10: {playerByNumber?.Name}");

        // By name
        var playerByName = team["Mohamed Salah"];
        Console.WriteLine($"Player named 'Salah': {playerByName?.Name}");

        Console.WriteLine("\n--- 5. GENERICS ---\n");

        var forwardSquad = new Squad<Forward>();
        forwardSquad.AddPlayer(salah);
        forwardSquad.AddPlayer(trezeguet);
        forwardSquad.AddPlayer(marmoush);
        forwardSquad.DisplayAll();

        var forwardStats = new StatsCalculator<Forward>();
        var allForwards = forwardSquad.GetAll();
        Console.WriteLine($"Forward average goals: {forwardStats.CalculateAverageGoals(allForwards)}");
    }
}

