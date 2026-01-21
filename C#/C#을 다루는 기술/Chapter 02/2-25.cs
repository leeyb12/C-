// C# 1 네임스페이스 별칭 기능의 사용 예

using System;

// 네임스페이스 별칭 지정
using WinForms = System.Windows.Forms;
using WebForms = System.Web.UI.WebControls;

class Test
{
    static void Main()
    {
        // 타입의 이름을 구분하기 위해 별칭 사용
        Console.WriteLine(typeof(WinForms.Button));
        Console.WriteLine(typeof(WinForms.Button));
    }
}