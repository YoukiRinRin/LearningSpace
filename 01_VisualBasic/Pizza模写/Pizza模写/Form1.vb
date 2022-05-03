Public Class Form1



    Private _creditCardType As String = "N/A"

    Public Property CreditCardType As String
        Get
            Return _creditCardType
        End Get
        Set(value As String)
            _creditCardType = value
        End Set
    End Property

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

    End Sub

    Private Sub mtbCCNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbCCNumber.MaskInputRejected
        Me.txtWarning.Text = "Credit card number is invalid"
    End Sub

    Private Sub drpExpiryYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpExpiryYear.SelectedIndexChanged

    End Sub

    Private Sub drpExpiryMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpExpiryMonth.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub txtWarning_TextChanged(sender As Object, e As EventArgs) Handles txtWarning.TextChanged

    End Sub

    Private Sub txtCCHolder_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCCHolder.MaskInputRejected
        Me.txtWarning.Text = "Credot card holder is invalid"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCreditCardType.Text = _creditCardType
        Me.drpExpiryMonth.SelectedItem = Date.Now.Month.ToString()
        Me.drpExpiryYear.SelectedItem = Date.Now.Year.ToString()



    End Sub

    Private Sub drpEY_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles drpExpiryYear.SelectedIndexChanged
        CheckInputValidty()
    End Sub


    Private Sub CheckInputValidity()
        Dim isCCHolderValid = False

        If Me.txtCCHolder.TextLength > 2 Then
            isCCHolderValid = True
        Else
            isCCHolderValid = False
        End If

        Dim IsCCNumberVaild = False
        If Not mtbCCNumber.MaskFull Then
            Me.txtWarning.Text = "Credit card number is invalid"
            IsCCNumberVaild = False
        Else
            Me.txtWarning.Text = String.Empty
        End If

        If isCCHolderValid And IsCCNumberVaild And isCreditCardExpiryValid Then
            Me.btnAccept.Enabled = True
        Else
            Me.btnAccept.Enabled = False

        End If



    End Sub



End Class
