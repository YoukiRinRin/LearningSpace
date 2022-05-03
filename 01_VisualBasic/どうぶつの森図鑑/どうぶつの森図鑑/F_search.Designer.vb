<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_search
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
        Me.lb_clothes = New System.Windows.Forms.Label()
        Me.lb_Seikaku = New System.Windows.Forms.Label()
        Me.lb_Habit = New System.Windows.Forms.Label()
        Me.lb_birth = New System.Windows.Forms.Label()
        Me.lb_Kind = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DataSet11 = New どうぶつの森図鑑.DataSet1()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_clothes
        '
        Me.lb_clothes.AutoSize = True
        Me.lb_clothes.Location = New System.Drawing.Point(48, 363)
        Me.lb_clothes.Name = "lb_clothes"
        Me.lb_clothes.Size = New System.Drawing.Size(48, 12)
        Me.lb_clothes.TabIndex = 11
        Me.lb_clothes.Text = "好きな服"
        '
        'lb_Seikaku
        '
        Me.lb_Seikaku.AutoSize = True
        Me.lb_Seikaku.Location = New System.Drawing.Point(19, 153)
        Me.lb_Seikaku.Name = "lb_Seikaku"
        Me.lb_Seikaku.Size = New System.Drawing.Size(29, 12)
        Me.lb_Seikaku.TabIndex = 10
        Me.lb_Seikaku.Text = "性格"
        '
        'lb_Habit
        '
        Me.lb_Habit.AutoSize = True
        Me.lb_Habit.Location = New System.Drawing.Point(12, 363)
        Me.lb_Habit.Name = "lb_Habit"
        Me.lb_Habit.Size = New System.Drawing.Size(29, 12)
        Me.lb_Habit.TabIndex = 9
        Me.lb_Habit.Text = "口癖"
        '
        'lb_birth
        '
        Me.lb_birth.AutoSize = True
        Me.lb_birth.Location = New System.Drawing.Point(19, 122)
        Me.lb_birth.Name = "lb_birth"
        Me.lb_birth.Size = New System.Drawing.Size(41, 12)
        Me.lb_birth.TabIndex = 8
        Me.lb_birth.Text = "誕生日"
        '
        'lb_Kind
        '
        Me.lb_Kind.AutoSize = True
        Me.lb_Kind.Location = New System.Drawing.Point(19, 97)
        Me.lb_Kind.Name = "lb_Kind"
        Me.lb_Kind.Size = New System.Drawing.Size(29, 12)
        Me.lb_Kind.TabIndex = 7
        Me.lb_Kind.Text = "種類"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(513, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(260, 474)
        Me.DataGridView1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "名前"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 20
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(105, 114)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox2.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(105, 145)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox3.TabIndex = 22
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'F_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lb_clothes)
        Me.Controls.Add(Me.lb_Seikaku)
        Me.Controls.Add(Me.lb_Habit)
        Me.Controls.Add(Me.lb_birth)
        Me.Controls.Add(Me.lb_Kind)
        Me.Name = "F_search"
        Me.Text = "F_search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_clothes As Label
    Friend WithEvents lb_Seikaku As Label
    Friend WithEvents lb_Habit As Label
    Friend WithEvents lb_birth As Label
    Friend WithEvents lb_Kind As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DataSet11 As DataSet1
End Class
