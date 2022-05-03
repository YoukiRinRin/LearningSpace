Imports System.IO
Imports com.lowagie.text
Imports com.lowagie.text.pdf

Public Class Form1

    Private Sub Button1_Click()

        Dim dc As New Document(PageSize.A4)

        Dim fs As FileStream = New FileStream("test.pdf", FileMode.Create, FileAccess.Write)

        fWriter.getInstance(dc, fs)

        .open()

        m fs As BaseFont = BaseFont.CreateFont("C:\Windows\fonts\msgothic.ttc,0",_
        MainMenu f As New com.lowagie.textFont(bf, 30, ComboBox.lowagie.text.Font.NORMAL)

        .setPageSIze(PageSize.A4)
        .newPage()
        .add(New Paragraph("Page1-ABCあいうPDF出力2PDF出力"))



    End Sub

End Class
