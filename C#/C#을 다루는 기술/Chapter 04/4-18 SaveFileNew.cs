// C# 4 기능을 이용하여 Word 문서를 생성하고 저장

Application app = new Application { Visible = true };
Document doc = app.Documents.Add();  // 선택적 매개변수를 이용하여 모든 인수를 생략
Paragraph para = doc.Paragraphs.Add();
para.Range.Text = "Simple new code";

doc.SaveAs2(FileName: "demo2.docx");  // 코드를 명확하게 하기 위해 명명된 인수 사용

doc.Close();
app.Application.Quit();