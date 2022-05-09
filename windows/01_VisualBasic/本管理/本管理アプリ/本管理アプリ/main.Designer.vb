<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.Btn_touroku = New System.Windows.Forms.Button()
        Me.Btn_etsuran = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_touroku
        '
        Me.Btn_touroku.Location = New System.Drawing.Point(138, 58)
        Me.Btn_touroku.Name = "Btn_touroku"
        Me.Btn_touroku.Size = New System.Drawing.Size(206, 84)
        Me.Btn_touroku.TabIndex = 0
        Me.Btn_touroku.Text = "図書を登録する"
        Me.Btn_touroku.UseVisualStyleBackColor = True
        '
        'Btn_etsuran
        '
        Me.Btn_etsuran.Location = New System.Drawing.Point(138, 166)
        Me.Btn_etsuran.Name = "Btn_etsuran"
        Me.Btn_etsuran.Size = New System.Drawing.Size(206, 67)
        Me.Btn_etsuran.TabIndex = 1
        Me.Btn_etsuran.Text = "登録内容を閲覧する"
        Me.Btn_etsuran.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 532)
        Me.Controls.Add(Me.Btn_etsuran)
        Me.Controls.Add(Me.Btn_touroku)
        Me.Name = "main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_touroku As Button
    Friend WithEvents Btn_etsuran As Button
End Class
