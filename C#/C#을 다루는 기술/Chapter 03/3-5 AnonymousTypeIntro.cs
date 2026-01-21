// Name과 Score 속성을 가진 익명 타입

// Name과 Score 속성을 가진 익명 타입의 객체를 생성
var player = new
{
    Name = "Tony",
    Score = 3500
};

// 속성값을 출력
Console.WriteLine("Player name: {0}", player.Name);
Console.WriteLine("Player score: {0}", player.Score);