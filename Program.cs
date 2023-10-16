using GameClasses;
class Program
{
    static void Main()
    {
        Game.GameId = 1000;
        GameAccount player1 = new GameAccount("Player1", 10);
        GameAccount player2 = new GameAccount("Player2", 12);

        player1.WinGame("Player2", 50);
        player2.LoseGame("Player1", 50);

        player1.LoseGame("Player2", 30);
        player2.WinGame("Player1", 30);

        player1.LoseGame("Player2", 30);
        player2.WinGame("Player1", 30);

        player1.LoseGame("Player2", 30);
        player2.WinGame("Player1", 30);

        player1.GetStats();
        Console.WriteLine();
        player2.GetStats();
    }
}