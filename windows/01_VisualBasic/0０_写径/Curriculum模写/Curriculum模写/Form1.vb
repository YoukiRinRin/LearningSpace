Public Class Form1
    Private Sub tsGrades_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsReport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SetPreRequisiteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsLogin_Click(sender As Object, e As EventArgs)
        If tsLogin_Click.Text = "Login" Then
            LoginForm1.Show()
        Else
            visibleMenu("False")
            tsLogin.Text = "Login"
            tsLogin.Image = My.Resources.login
        End If
    End Sub

    Private Sub tsAddG_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsSearchStudent_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsStudent_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsCurriculum_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibleMenu("False")
    End Sub

    Public Sub visibleMenu(ByVal res As String)
        tsAddG.Enabled = res
        tsStudent.Enabled = res
        tsCurriculum.Enabled = res
        tsGrades.Enabled = res
        tsReport.Enabled = res
        tsUtilites.Enabled = res
        tsSearchStudent.Enabled = res


    End Sub

    Private Sub tsLogin_Click(sender As Object, e As EventArgs) Handles tsLogin.Click



    End Sub
End Class
