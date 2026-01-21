// dynamic 타입에 대한 암시적 타입 변환을 활용하여 엑셀의 범위에 값을 채움

var app = new Application { Visible = true };
app.Workbooks.Add();
Worksheet sheet = app.ActiveSheet;
Range start = sheet.Cells[1, 1];
Range end = sheet.Cells[1, 20];
sheet.Range[start, end].Value = Enumerable.Range(1, 20).ToArray();