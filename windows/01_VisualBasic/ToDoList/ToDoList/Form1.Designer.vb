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
        Me.Date_ToDo = New System.Windows.Forms.DateTimePicker()
        Me.Tx_ToDo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.date_select = New System.Windows.Forms.DateTimePicker()
        Me.list_todo = New System.Windows.Forms.ListBox()
        Me.bt_del = New System.Windows.Forms.Button()
        Me.bt_hyoji = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Date_ToDo
        '
        Me.Date_ToDo.Location = New System.Drawing.Point(12, 31)
        Me.Date_ToDo.Name = "Date_ToDo"
        Me.Date_ToDo.Size = New System.Drawing.Size(200, 19)
        Me.Date_ToDo.TabIndex = 0
        '
        'Tx_ToDo
        '
        Me.Tx_ToDo.Location = New System.Drawing.Point(13, 89)
        Me.Tx_ToDo.Name = "Tx_ToDo"
        Me.Tx_ToDo.Size = New System.Drawing.Size(199, 19)
        Me.Tx_ToDo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "予定を入力"
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(12, 130)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(75, 23)
        Me.bt_add.TabIndex = 3
        Me.bt_add.Text = "追加"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'date_select
        '
        Me.date_select.Location = New System.Drawing.Point(258, 30)
        Me.date_select.Name = "date_select"
        Me.date_select.Size = New System.Drawing.Size(200, 19)
        Me.date_select.TabIndex = 4
        '
        'list_todo
        '
        Me.list_todo.FormattingEnabled = True
        Me.list_todo.ItemHeight = 12
        Me.list_todo.Location = New System.Drawing.Point(481, 30)
        Me.list_todo.Name = "list_todo"
        Me.list_todo.Size = New System.Drawing.Size(120, 136)
        Me.list_todo.TabIndex = 5
        '
        'bt_del
        '
        Me.bt_del.Location = New System.Drawing.Point(481, 173)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(75, 23)
        Me.bt_del.TabIndex = 6
        Me.bt_del.Text = "削除"
        Me.bt_del.UseVisualStyleBackColor = True
        '
        'bt_hyoji
        '
        Me.bt_hyoji.Location = New System.Drawing.Point(258, 71)
        Me.bt_hyoji.Name = "bt_hyoji"
        Me.bt_hyoji.Size = New System.Drawing.Size(75, 23)
        Me.bt_hyoji.TabIndex = 7
        Me.bt_hyoji.Text = "表示"
        Me.bt_hyoji.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bt_hyoji)
        Me.Controls.Add(Me.bt_del)
        Me.Controls.Add(Me.list_todo)
        Me.Controls.Add(Me.date_select)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tx_ToDo)
        Me.Controls.Add(Me.Date_ToDo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Date_ToDo As DateTimePicker
    Friend WithEvents Tx_ToDo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_add As Button
    Friend WithEvents date_select As DateTimePicker
    Friend WithEvents list_todo As ListBox
    Friend WithEvents bt_del As Button
    Friend WithEvents bt_hyoji As Button
End Class
