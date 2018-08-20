using System;

public class Program
{
    public static void Main()
    {
        var team = new Team("Champions");
        var playerCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < playerCount; i++)
        {
            var playerArg = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var player = new Person(playerArg[0], playerArg[1], int.Parse(playerArg[2]), double.Parse(playerArg[3]));
            team.AddPlayer(player);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}