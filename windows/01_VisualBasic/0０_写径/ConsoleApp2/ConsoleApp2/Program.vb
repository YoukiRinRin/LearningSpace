Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim Path_Name As String = "H:\1_�摜\01_�O���r�A�A�C�h��\01_�R�Ђ���\001.jpg"
        Dim Drive_Now As String = CurDir()


        Console.WriteLine(Path_Name & "�̍쐬�����́A" & FileDateTime(Path_Name))

        Console.WriteLine(CurDir(Path_Name) & "�A�ɂ���܂�")

        Console.ReadLine()

        Dim cForm1 As New Form1()

        cForm1, showDialog()

        cForm1.Dispose()



        Private Sub FOrm1_Closing() Handles MyBase.Closing


        Select Case Hstack.GetFrame(7).GetMethod().Name
            Case "CallEindowProc"
                If hStack.FrameCount > 14 Then ThenSelect Case hStack, GetFrame(14).GetMethod().Name
                    Case "WmSysCommand"
                MessageBox.Show("�R���g���[�����j���[�������悤�ɑI�����܂���")
            Case "Wind"

        End Select

    End Sub
End Module
