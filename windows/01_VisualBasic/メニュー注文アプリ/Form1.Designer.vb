<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 商品注文アプリ
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
        Dim Button1 As System.Windows.Forms.Button
        Me.Menu1 = New System.Windows.Forms.PictureBox()
        Me.Menu2 = New System.Windows.Forms.PictureBox()
        Me.Menu3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Button1 = New System.Windows.Forms.Button()
        CType(Me.Menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Button1.Location = New System.Drawing.Point(477, 363)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(204, 47)
        Button1.TabIndex = 8
        Button1.Text = "購入する"
        Button1.UseVisualStyleBackColor = True
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'Menu1
        '
        Me.Menu1.Location = New System.Drawing.Point(34, 31)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(173, 144)
        Me.Menu1.TabIndex = 0
        Me.Menu1.TabStop = False
        '
        'Menu2
        '
        Me.Menu2.Location = New System.Drawing.Point(306, 31)
        Me.Menu2.Name = "Menu2"
        Me.Menu2.Size = New System.Drawing.Size(173, 144)
        Me.Menu2.TabIndex = 1
        Me.Menu2.TabStop = False
        '
        'Menu3
        '
        Me.Menu3.Location = New System.Drawing.Point(580, 31)
        Me.Menu3.Name = "Menu3"
        Me.Menu3.Size = New System.Drawing.Size(173, 144)
        Me.Menu3.TabIndex = 2
        Me.Menu3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(34, 181)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 19)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(306, 181)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 19)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(580, 181)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(103, 19)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        '商品注文アプリ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Menu3)
        Me.Controls.Add(Me.Menu2)
        Me.Controls.Add(Me.Menu1)
        Me.Name = "商品注文アプリ"
        Me.Text = "商品注文アプリ"
        CType(Me.Menu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu1 As PictureBox
    Friend WithEvents Menu2 As PictureBox
    Friend WithEvents Menu3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label3 As Label
End Class
