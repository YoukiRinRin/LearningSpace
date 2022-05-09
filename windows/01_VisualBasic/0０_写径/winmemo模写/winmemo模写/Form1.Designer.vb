<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Filef = New System.Windows.Forms.ToolStripMenuItem()
        Me.開く = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ow = New System.Windows.Forms.ToolStripMenuItem()
        Me.fclose = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditE = New System.Windows.Forms.ToolStripMenuItem()
        Me.検索 = New System.Windows.Forms.ToolStripMenuItem()
        Me.行に移動 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeC = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftJIS = New System.Windows.Forms.ToolStripMenuItem()
        Me.cUnicode = New System.Windows.Forms.ToolStripMenuItem()
        Me.sFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tc = New System.Windows.Forms.TabControl()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.lines = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Od = New System.Windows.Forms.OpenFileDialog()
        Me.Status.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Filef
        '
        Me.Filef.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開く, Me.Ow, Me.fclose, Me.終了})
        Me.Filef.Name = "Filef"
        Me.Filef.Size = New System.Drawing.Size(67, 20)
        Me.Filef.Text = "ファイル(&F)"
        '
        '開く
        '
        Me.開く.Name = "開く"
        Me.開く.Size = New System.Drawing.Size(180, 22)
        Me.開く.Text = "開く(&O)"
        '
        'Ow
        '
        Me.Ow.Name = "Ow"
        Me.Ow.Size = New System.Drawing.Size(180, 22)
        Me.Ow.Text = "上書き保存(&A)"
        '
        'fclose
        '
        Me.fclose.Name = "fclose"
        Me.fclose.Size = New System.Drawing.Size(180, 22)
        Me.fclose.Text = "閉じる(&C)"
        '
        '終了
        '
        Me.終了.Name = "終了"
        Me.終了.Size = New System.Drawing.Size(180, 22)
        Me.終了.Text = "終了(&X)"
        '
        'EditE
        '
        Me.EditE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.検索, Me.行に移動})
        Me.EditE.Name = "EditE"
        Me.EditE.Size = New System.Drawing.Size(57, 20)
        Me.EditE.Text = "編集(&E)"
        '
        '検索
        '
        Me.検索.Name = "検索"
        Me.検索.Size = New System.Drawing.Size(180, 22)
        Me.検索.Text = "検索(&S)"
        '
        '行に移動
        '
        Me.行に移動.Name = "行に移動"
        Me.行に移動.Size = New System.Drawing.Size(180, 22)
        Me.行に移動.Text = "行に移動(&G)"
        '
        'CodeC
        '
        Me.CodeC.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShiftJIS, Me.cUnicode})
        Me.CodeC.Name = "CodeC"
        Me.CodeC.Size = New System.Drawing.Size(82, 20)
        Me.CodeC.Text = "文字コード(&C)"
        '
        'ShiftJIS
        '
        Me.ShiftJIS.Name = "ShiftJIS"
        Me.ShiftJIS.Size = New System.Drawing.Size(180, 22)
        Me.ShiftJIS.Text = "Shift-JIS(&S)"
        '
        'cUnicode
        '
        Me.cUnicode.Name = "cUnicode"
        Me.cUnicode.Size = New System.Drawing.Size(180, 22)
        Me.cUnicode.Text = "Unicode(&U)"
        '
        'sFont
        '
        Me.sFont.Name = "sFont"
        Me.sFont.Size = New System.Drawing.Size(66, 20)
        Me.sFont.Text = "フォント(&F)"
        '
        'Tc
        '
        Me.Tc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tc.Location = New System.Drawing.Point(0, 24)
        Me.Tc.Name = "Tc"
        Me.Tc.SelectedIndex = 0
        Me.Tc.Size = New System.Drawing.Size(800, 404)
        Me.Tc.TabIndex = 4
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lines})
        Me.Status.Location = New System.Drawing.Point(0, 428)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(800, 22)
        Me.Status.TabIndex = 5
        Me.Status.Text = "StatusStrip1"
        '
        'lines
        '
        Me.lines.Name = "lines"
        Me.lines.Size = New System.Drawing.Size(26, 17)
        Me.lines.Text = "line"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Filef, Me.EditE, Me.CodeC, Me.sFont})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Od
        '
        Me.Od.DefaultExt = "txt"
        Me.Od.Filter = "txt file(*.txt)|*.txt|All File(*.*)|*.*"
        Me.Od.Title = "File Open"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tc)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Filef As ToolStripMenuItem
    Friend WithEvents 開く As ToolStripMenuItem
    Friend WithEvents Ow As ToolStripMenuItem
    Friend WithEvents fclose As ToolStripMenuItem
    Friend WithEvents 終了 As ToolStripMenuItem
    Friend WithEvents EditE As ToolStripMenuItem
    Friend WithEvents 検索 As ToolStripMenuItem
    Friend WithEvents 行に移動 As ToolStripMenuItem
    Friend WithEvents CodeC As ToolStripMenuItem
    Friend WithEvents ShiftJIS As ToolStripMenuItem
    Friend WithEvents cUnicode As ToolStripMenuItem
    Friend WithEvents sFont As ToolStripMenuItem
    Friend WithEvents Tc As TabControl
    Friend WithEvents Status As StatusStrip
    Friend WithEvents lines As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Od As OpenFileDialog
End Class
