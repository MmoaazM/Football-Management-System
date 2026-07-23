using System;

using Football_Manangement_System;
using Football_Manangement_System.MatchEvents;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("--- 1. CREATING PLAYERS (OOP) ---\n");

        var salah = new Forward("Mohamed Salah", 10, 31, false, 100);
        salah.Goals = 30;
        salah.Assists = 20;

        var trezeguet = new Forward("Trezeguet", 7, 29, false, 110);
        trezeguet.Goals = 25;
        trezeguet.Assists = 5;

        var hegazi = new Defender("Ahmed Hegazi", 6, 32, true, 30, 100);
        hegazi.Goals = 3;
        hegazi.Assists = 0;

        var marmoush = new Forward("Omar Marmoush", 14, 24, false, 200);
        marmoush.Goals = 27;
        marmoush.Assists = 10;

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


        Console.WriteLine("\n--- 6. DELEGATES ---\n");

        var reportGenerator = new TeamReportGenerator();

        // Named method
        static bool IsStarPlayer(FootballPlayer player) { return player.Goals > 20; }
        reportGenerator.GenerateReport(team.ToList(), "Star Players", IsStarPlayer);

        // Anonymous method
        reportGenerator.GenerateReport(team.ToList(), "Veteran Players",
            delegate (FootballPlayer p) { return p.Age >= 30; });

        // Lambda expression
        reportGenerator.GenerateReport(team.ToList(), "Injured Players",
            p => p.IsInjured);





        Console.WriteLine("\n--- 7. GENERIC DELEGATES ---\n");

        var analyzer = new TeamAnalyzer();

        // Func - Calculate total goals
        int totalGoals = analyzer.CalculateTeamStat(team.ToList(), p => p.Goals);
        Console.WriteLine($"Total team goals: {totalGoals}");

        // Action - Apply operation to all
        Console.WriteLine("\nApplying training to all players:");
        analyzer.ApplyToAllPlayers(team.ToList(), p => p.Train());

        // Predicate - Find players
        var youngPlayers = analyzer.FindPlayers(team.ToList(), p => p.Age < 25);
        Console.WriteLine($"\nYoung players (<25): {youngPlayers.Count}");




        Console.WriteLine("\n--- 8. EXTENSION METHODS ---\n");

        foreach (var player in team)
        {
            Console.WriteLine($"{player.Name}: {player.GetRating()}");
            if (player.IsStarPlayer())
            {
                player.PrintStats();
                Console.WriteLine($"Value: ${player.GetValue():F2}\n");
            }
        }

        // Team extensions
        team.PrintTeamReport();


        Console.WriteLine("\n--- 8. EVENTS ---\n");

        var match = new Match();
        var commentator = new MatchCommentator();
        var fans = new Fans("Al Ahly");
        var coach = new Coach("Koller");

        // Subscribe to events
        match.GoalScored += commentator.PlayerScored;
        match.GoalScored += fans.PlayerScoredGoal;
        match.GoalScored += coach.PlayerScoredGoal;

        // Run the match
        match.MatchStarts();
        match.Goaaal("salah");
        match.InjuryFor("Hegazi");
        match.Goaaal("Trezeguet");
    }
}

