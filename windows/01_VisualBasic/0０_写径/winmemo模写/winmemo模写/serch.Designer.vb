<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serch
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
        Me.cancel = New System.Windows.Forms.Button()
        Me.snext = New System.Windows.Forms.Button()
        Me.sw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(489, 197)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(65, 23)
        Me.cancel.TabIndex = 7
        Me.cancel.Text = "キャンセル"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'snext
        '
        Me.snext.Location = New System.Drawing.Point(433, 197)
        Me.snext.Name = "snext"
        Me.snext.Size = New System.Drawing.Size(50, 23)
        Me.snext.TabIndex = 6
        Me.snext.Text = "次へ"
        Me.snext.UseVisualStyleBackColor = True
        '
        'sw
        '
        Me.sw.Location = New System.Drawing.Point(254, 235)
        Me.sw.Name = "sw"
        Me.sw.Size = New System.Drawing.Size(300, 19)
        Me.sw.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "検索する文字列を入力してください。"
        '
        'serch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.snext)
        Me.Controls.Add(Me.sw)
        Me.Controls.Add(Me.Label1)
        Me.Name = "serch"
        Me.Text = "-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancel As Button
    Friend WithEvents snext As Button
    Friend WithEvents sw As TextBox
    Friend WithEvents Label1 As Label
End Class
