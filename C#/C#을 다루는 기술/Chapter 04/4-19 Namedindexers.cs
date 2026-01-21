// 명명된 인덱서를 통한 접근 

Application app = new Application { Visible = false };

// C# 4 이전 방식
object missing = Type.Missing;
SynonymInfo info = app.get_SynonymInfo("method", ref missing);

Console.WriteLine("'method' has {0} meanings", info.MeaningCount);

info = app.SynonymInfo{"index"};  // 명명된 인덱서를 사용하여 코드를 단순화
Console.WriteLine("'index' has {0} meanings", info.MeaningCount);