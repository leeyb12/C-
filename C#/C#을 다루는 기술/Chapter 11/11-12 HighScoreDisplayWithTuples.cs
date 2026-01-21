// 지역 변수를 튜플을 사용하도록 리팩터링

public void DisplayHighScoreForDate(LocalDate date)
{
    var filteredGames = allGames.Where(game => game.Date == date);
    (string player, int score) highest = (null, -1);
    foreach (var game in filteredGames)
    {
        if (game.Score > highest.score)
        {
            highest = (game.PlayerName, game.Score);
        }
    }
    Console.WriteLine(highest.player == null
        ? "No games played"
        : $"Highest score was {highest.score} by {highest.player}");
}