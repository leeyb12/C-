// 날짜별 최고 점수를 출력

public void DisplayHighScoreForDate(LocalDate date)
{
    var filteredGames = allGames.Where(game => game.Date == date);
    string highestPlayer = null;
    int highestScore = -1;
    foreach (var game in filteredGames)
    {
        if (game.Score > highestScore)
        {
            highestPlayer = game.PlayerName;
            highestScore = game.Score;
        }
    }
    Console.WriteLine(highestPlayer == null
        ? "No games played"
        : $"Highest score was {highestScore} by {highestPlayer}");
}