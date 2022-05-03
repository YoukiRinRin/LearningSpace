<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtWarning = New System.Windows.Forms.TextBox()
        Me.mtbCCNumber = New System.Windows.Forms.MaskedTextBox()
        Me.drpExpiryYear = New System.Windows.Forms.ComboBox()
        Me.drpExpiryMonth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.txtCCHolder = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtWarning
        '
        Me.txtWarning.Enabled = False
        Me.txtWarning.ForeColor = System.Drawing.Color.Red
        Me.txtWarning.Location = New System.Drawing.Point(319, 253)
        Me.txtWarning.Multiline = True
        Me.txtWarning.Name = "txtWarning"
        Me.txtWarning.Size = New System.Drawing.Size(199, 44)
        Me.txtWarning.TabIndex = 23
        '
        'mtbCCNumber
        '
        Me.mtbCCNumber.Location = New System.Drawing.Point(390, 157)
        Me.mtbCCNumber.Mask = "0000-0000-0000-0000"
        Me.mtbCCNumber.Name = "mtbCCNumber"
        Me.mtbCCNumber.Size = New System.Drawing.Size(112, 19)
        Me.mtbCCNumber.TabIndex = 14
        '
        'drpExpiryYear
        '
        Me.drpExpiryYear.FormattingEnabled = True
        Me.drpExpiryYear.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.drpExpiryYear.Location = New System.Drawing.Point(390, 227)
        Me.drpExpiryYear.Name = "drpExpiryYear"
        Me.drpExpiryYear.Size = New System.Drawing.Size(49, 20)
        Me.drpExpiryYear.TabIndex = 16
        Me.drpExpiryYear.Text = "2012"
        '
        'drpExpiryMonth
        '
        Me.drpExpiryMonth.FormattingEnabled = True
        Me.drpExpiryMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.drpExpiryMonth.Location = New System.Drawing.Point(390, 192)
        Me.drpExpiryMonth.Name = "drpExpiryMonth"
        Me.drpExpiryMonth.Size = New System.Drawing.Size(49, 20)
        Me.drpExpiryMonth.TabIndex = 15
        Me.drpExpiryMonth.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Expiration Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 12)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Expiration Month:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Credit Card Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Credit Card Holder:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(443, 307)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 21)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAccept.Enabled = False
        Me.btnAccept.Location = New System.Drawing.Point(319, 307)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 21)
        Me.btnAccept.TabIndex = 18
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'txtCCHolder
        '
        Me.txtCCHolder.Location = New System.Drawing.Point(390, 122)
        Me.txtCCHolder.Name = "txtCCHolder"
        Me.txtCCHolder.Size = New System.Drawing.Size(112, 19)
        Me.txtCCHolder.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtWarning)
        Me.Controls.Add(Me.mtbCCNumber)
        Me.Controls.Add(Me.drpExpiryYear)
        Me.Controls.Add(Me.drpExpiryMonth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtCCHolder)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWarning As TextBox
    Friend WithEvents mtbCCNumber As MaskedTextBox
    Friend WithEvents drpExpiryYear As ComboBox
    Friend WithEvents drpExpiryMonth As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents txtCCHolder As MaskedTextBox
End Class
