<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_Name = New System.Windows.Forms.Label()
        Me.lb_Kind = New System.Windows.Forms.Label()
        Me.lb_birth = New System.Windows.Forms.Label()
        Me.lb_Habit = New System.Windows.Forms.Label()
        Me.lb_Seikaku = New System.Windows.Forms.Label()
        Me.lb_clothes = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.どうぶつの森図鑑.My.Resources.Resources._10226618i
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lb_Name
        '
        Me.lb_Name.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Name.Location = New System.Drawing.Point(296, 12)
        Me.lb_Name.Name = "lb_Name"
        Me.lb_Name.Size = New System.Drawing.Size(139, 54)
        Me.lb_Name.TabIndex = 1
        Me.lb_Name.Text = "しずえ"
        '
        'lb_Kind
        '
        Me.lb_Kind.AutoSize = True
        Me.lb_Kind.Location = New System.Drawing.Point(479, 41)
        Me.lb_Kind.Name = "lb_Kind"
        Me.lb_Kind.Size = New System.Drawing.Size(23, 12)
        Me.lb_Kind.TabIndex = 2
        Me.lb_Kind.Text = "イヌ"
        '
        'lb_birth
        '
        Me.lb_birth.AutoSize = True
        Me.lb_birth.Location = New System.Drawing.Point(306, 87)
        Me.lb_birth.Name = "lb_birth"
        Me.lb_birth.Size = New System.Drawing.Size(41, 12)
        Me.lb_birth.TabIndex = 3
        Me.lb_birth.Text = "誕生日"
        '
        'lb_Habit
        '
        Me.lb_Habit.AutoSize = True
        Me.lb_Habit.Location = New System.Drawing.Point(397, 87)
        Me.lb_Habit.Name = "lb_Habit"
        Me.lb_Habit.Size = New System.Drawing.Size(29, 12)
        Me.lb_Habit.TabIndex = 4
        Me.lb_Habit.Text = "口癖"
        '
        'lb_Seikaku
        '
        Me.lb_Seikaku.AutoSize = True
        Me.lb_Seikaku.Location = New System.Drawing.Point(306, 125)
        Me.lb_Seikaku.Name = "lb_Seikaku"
        Me.lb_Seikaku.Size = New System.Drawing.Size(29, 12)
        Me.lb_Seikaku.TabIndex = 5
        Me.lb_Seikaku.Text = "性格"
        '
        'lb_clothes
        '
        Me.lb_clothes.AutoSize = True
        Me.lb_clothes.Location = New System.Drawing.Point(397, 125)
        Me.lb_clothes.Name = "lb_clothes"
        Me.lb_clothes.Size = New System.Drawing.Size(48, 12)
        Me.lb_clothes.TabIndex = 6
        Me.lb_clothes.Text = "好きな服"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.lb_clothes)
        Me.Controls.Add(Me.lb_Seikaku)
        Me.Controls.Add(Me.lb_Habit)
        Me.Controls.Add(Me.lb_birth)
        Me.Controls.Add(Me.lb_Kind)
        Me.Controls.Add(Me.lb_Name)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lb_Name As Label
    Friend WithEvents lb_Kind As Label
    Friend WithEvents lb_birth As Label
    Friend WithEvents lb_Habit As Label
    Friend WithEvents lb_Seikaku As Label
    Friend WithEvents lb_clothes As Label
End Class
