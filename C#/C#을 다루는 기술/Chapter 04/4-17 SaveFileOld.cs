// C# 4 이전 기능만을 사용하여 Word 문서를 생성하고 저장

object missing = Type.Missing;  // 문서 저장

Application app = new Application { Visible = true };  // Word 시작

// 문서 생성 및 내용 작성
Document doc = app.Documents.Add
    ref missing, ref missing,
    ref missing, ref missing;
Pararaph para = doc.Pararaphs.Add(ref missing);
para.Range.Text = "Awkward old code";

object fileName = "demo1.docx";

// 문서 저장
doc.SaveAs2(ref fileName, ref missing,
    ref missing, ref missing, ref missing,
    ref missing, ref missing, ref missing, 
    ref missing, ref missing, ref missing,
    ref missing, ref missing, ref missing,
    ref missing, ref missing);

// Word 종료
doc.Close(ref missing, ref missing, ref missing);
app.Application.Quit(
    ref missing, ref missing, ref missing);