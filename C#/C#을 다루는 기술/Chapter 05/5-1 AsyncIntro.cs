// 비동기적으로 웹 페이지의 길이를 출력

public class AsyncIntro : Form
{
    private static readonly HttpClient client = new HttpClient();
    private readonly Label label;
    private readonly Button button;
    private AsyncIntro()
    {
        label = new Label
        {
            Location = new Point(10, 20),
            Text = "Length"
        };
        button = new Button
        {
            Location = new Point(10, 50),
            Text = "Click"
        };
        button.Click += DisplayWebSiteLength;  // 이벤트 핸들러 지정
        AutoSize = true;
        Controls.Add(label);
        Controls.Add(button);
    }

    async void DisplayWebSiteLength(object sender, EventArgs e)
    {
        label.Text = "Fetching...";

        // 페이지로부터 내용을 가져옴
        string text = await client.GetStringAsync(
            "https://csharpindepth.com");

        label.Text = text.Length.ToString();  // UI를 갱신
    }

    static void Main()
    {
        Application.Run(new AsyncIntro());  // 시작 지점: 폼을 실행
    }
}