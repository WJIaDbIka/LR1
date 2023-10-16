
namespace GameClasses
{
    class GameAccount
    {
        public string UserName { get; set; }
        private int currentRating;
        public int CurrentRating { get { return currentRating; } set {
                if(value < 1)
            {
                    currentRating = 1;
                }
            else
                {
                    currentRating = value;
                }
            } }
        private List<Game> gameHistory = new List<Game>();

        public GameAccount(string userName, int currentRaiting)
        {
            UserName = userName;
            CurrentRating = currentRaiting;
        }

        public void WinGame(string opponentName, int rating)
        {
            ValidateRating(rating);
            CurrentRating += rating;
            gameHistory.Add(new Game(opponentName, true, CurrentRating, gameHistory.Count));
        }

        public void LoseGame(string opponentName, int rating)
        {
            ValidateRating(rating);
            CurrentRating -= rating;
            gameHistory.Add(new Game(opponentName, false, CurrentRating, gameHistory.Count));
        }

        public void GetStats()
        {
            Console.WriteLine($"Game History for {UserName}:");
            Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10} {4, -10}", "Opponent", "Result", "Rating", "Game Index", "Game Count");
            for (int i = 0; i < gameHistory.Count; i++)
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10} {4, -10}", gameHistory[i].OpponentName,
                                  gameHistory[i].IsWin ? "Win" : "Loss",
                                  gameHistory[i].Rating,
                                  gameHistory[i].Id,
                                  gameHistory[i].GameCount);
            }
        }

        private void ValidateRating(int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative.");
            }
        }
    }
}
