<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.dg_inp_shiwake = New System.Windows.Forms.DataGridView()
        Me.cl_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_money_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_money_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg_inp_shiwake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_inp_shiwake
        '
        Me.dg_inp_shiwake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_inp_shiwake.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_date, Me.cl_debit, Me.cl_money_1, Me.cl_credit, Me.cl_money_2})
        Me.dg_inp_shiwake.Location = New System.Drawing.Point(12, 30)
        Me.dg_inp_shiwake.Name = "dg_inp_shiwake"
        Me.dg_inp_shiwake.RowTemplate.Height = 21
        Me.dg_inp_shiwake.Size = New System.Drawing.Size(677, 354)
        Me.dg_inp_shiwake.TabIndex = 0
        '
        'cl_date
        '
        Me.cl_date.HeaderText = "日付"
        Me.cl_date.Name = "cl_date"
        '
        'cl_debit
        '
        Me.cl_debit.HeaderText = "借方項目"
        Me.cl_debit.Name = "cl_debit"
        '
        'cl_money_1
        '
        Me.cl_money_1.HeaderText = "金額"
        Me.cl_money_1.Name = "cl_money_1"
        '
        'cl_credit
        '
        Me.cl_credit.HeaderText = "貸方科目"
        Me.cl_credit.Name = "cl_credit"
        '
        'cl_money_2
        '
        Me.cl_money_2.HeaderText = "金額"
        Me.cl_money_2.Name = "cl_money_2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg_inp_shiwake)
        Me.Name = "form1"
        Me.Text = "Form1"
        CType(Me.dg_inp_shiwake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_inp_shiwake As DataGridView
    Friend WithEvents cl_date As DataGridViewTextBoxColumn
    Friend WithEvents cl_debit As DataGridViewTextBoxColumn
    Friend WithEvents cl_money_1 As DataGridViewTextBoxColumn
    Friend WithEvents cl_credit As DataGridViewTextBoxColumn
    Friend WithEvents cl_money_2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
