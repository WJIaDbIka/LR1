
namespace GameClasses
{
    class Game
    {
        public string OpponentName { get; }
        public bool IsWin { get; }
        public int Rating { get; }
        public int GameCount { get; set; }
        public static int GameId;
        public int Id { get; set; }

        public Game(string opponentName, bool isWin, int rating, int gameCount)
        {
            OpponentName = opponentName;
            IsWin = isWin;
            Rating = rating;
            GameCount = gameCount;
            GameId += 10;
            Id = GameId;
        }
    }
}
