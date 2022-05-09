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
        Me.Btn_Apply = New System.Windows.Forms.Button()
        Me.Chkb_Hidden = New System.Windows.Forms.CheckBox()
        Me.Chkb_ReadOnly = New System.Windows.Forms.CheckBox()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Lbl_GetFileLocation = New System.Windows.Forms.LinkLabel()
        Me.Lbl_GetFileExtension = New System.Windows.Forms.Label()
        Me.Lbl_GetFileName = New System.Windows.Forms.Label()
        Me.Lbl_GetFileHidden = New System.Windows.Forms.Label()
        Me.Lbl_GetFileSystem = New System.Windows.Forms.Label()
        Me.Lbl_GetFileReadOnly = New System.Windows.Forms.Label()
        Me.Lbl_GetFileCreatedDate = New System.Windows.Forms.Label()
        Me.Lbl_GetFileSize = New System.Windows.Forms.Label()
        Me.Lbl_GetFileTotalWords = New System.Windows.Forms.Label()
        Me.Lbl_GetFileTotalChars = New System.Windows.Forms.Label()
        Me.Lbl_GetFileTotalLines = New System.Windows.Forms.Label()
        Me.Lbl_FileSystem = New System.Windows.Forms.Label()
        Me.Lbl_FileReadOnly = New System.Windows.Forms.Label()
        Me.Lbl_FileHidden = New System.Windows.Forms.Label()
        Me.Lbl_FileCreatedDate = New System.Windows.Forms.Label()
        Me.Lbl_FileSize = New System.Windows.Forms.Label()
        Me.Lbl_FileLocation = New System.Windows.Forms.Label()
        Me.Lbl_FileTotalWords = New System.Windows.Forms.Label()
        Me.Lbl_FileTotalChars = New System.Windows.Forms.Label()
        Me.Lbl_FileExtension = New System.Windows.Forms.Label()
        Me.Lbl_FileTotalLines = New System.Windows.Forms.Label()
        Me.Lbl_FileName = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Apply
        '
        Me.Btn_Apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Apply.Location = New System.Drawing.Point(383, 332)
        Me.Btn_Apply.Name = "Btn_Apply"
        Me.Btn_Apply.Size = New System.Drawing.Size(101, 27)
        Me.Btn_Apply.TabIndex = 87
        Me.Btn_Apply.Text = "Apply"
        Me.Btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Apply.UseVisualStyleBackColor = True
        '
        'Chkb_Hidden
        '
        Me.Chkb_Hidden.AutoSize = True
        Me.Chkb_Hidden.Location = New System.Drawing.Point(305, 337)
        Me.Chkb_Hidden.Name = "Chkb_Hidden"
        Me.Chkb_Hidden.Size = New System.Drawing.Size(59, 16)
        Me.Chkb_Hidden.TabIndex = 86
        Me.Chkb_Hidden.Text = "Hidden"
        Me.Chkb_Hidden.UseVisualStyleBackColor = True
        '
        'Chkb_ReadOnly
        '
        Me.Chkb_ReadOnly.AutoSize = True
        Me.Chkb_ReadOnly.Location = New System.Drawing.Point(213, 337)
        Me.Chkb_ReadOnly.Name = "Chkb_ReadOnly"
        Me.Chkb_ReadOnly.Size = New System.Drawing.Size(73, 16)
        Me.Chkb_ReadOnly.TabIndex = 85
        Me.Chkb_ReadOnly.Text = "ReadOnly"
        Me.Chkb_ReadOnly.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Exit.Location = New System.Drawing.Point(490, 332)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(101, 27)
        Me.Btn_Exit.TabIndex = 84
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Lbl_GetFileLocation
        '
        Me.Lbl_GetFileLocation.AutoSize = True
        Me.Lbl_GetFileLocation.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileLocation.Location = New System.Drawing.Point(375, 120)
        Me.Lbl_GetFileLocation.Name = "Lbl_GetFileLocation"
        Me.Lbl_GetFileLocation.Size = New System.Drawing.Size(87, 13)
        Me.Lbl_GetFileLocation.TabIndex = 83
        Me.Lbl_GetFileLocation.TabStop = True
        Me.Lbl_GetFileLocation.Text = "Loading..."
        '
        'Lbl_GetFileExtension
        '
        Me.Lbl_GetFileExtension.AutoSize = True
        Me.Lbl_GetFileExtension.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileExtension.Location = New System.Drawing.Point(375, 158)
        Me.Lbl_GetFileExtension.Name = "Lbl_GetFileExtension"
        Me.Lbl_GetFileExtension.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileExtension.TabIndex = 82
        Me.Lbl_GetFileExtension.Text = "Loadding..."
        '
        'Lbl_GetFileName
        '
        Me.Lbl_GetFileName.AutoSize = True
        Me.Lbl_GetFileName.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileName.Location = New System.Drawing.Point(375, 139)
        Me.Lbl_GetFileName.Name = "Lbl_GetFileName"
        Me.Lbl_GetFileName.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileName.TabIndex = 81
        Me.Lbl_GetFileName.Text = "Loadding..."
        '
        'Lbl_GetFileHidden
        '
        Me.Lbl_GetFileHidden.AutoSize = True
        Me.Lbl_GetFileHidden.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileHidden.Location = New System.Drawing.Point(375, 291)
        Me.Lbl_GetFileHidden.Name = "Lbl_GetFileHidden"
        Me.Lbl_GetFileHidden.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileHidden.TabIndex = 80
        Me.Lbl_GetFileHidden.Text = "Loadding..."
        '
        'Lbl_GetFileSystem
        '
        Me.Lbl_GetFileSystem.AutoSize = True
        Me.Lbl_GetFileSystem.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileSystem.Location = New System.Drawing.Point(375, 310)
        Me.Lbl_GetFileSystem.Name = "Lbl_GetFileSystem"
        Me.Lbl_GetFileSystem.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileSystem.TabIndex = 79
        Me.Lbl_GetFileSystem.Text = "Loadding..."
        '
        'Lbl_GetFileReadOnly
        '
        Me.Lbl_GetFileReadOnly.AutoSize = True
        Me.Lbl_GetFileReadOnly.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileReadOnly.Location = New System.Drawing.Point(375, 272)
        Me.Lbl_GetFileReadOnly.Name = "Lbl_GetFileReadOnly"
        Me.Lbl_GetFileReadOnly.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileReadOnly.TabIndex = 78
        Me.Lbl_GetFileReadOnly.Text = "Loadding..."
        '
        'Lbl_GetFileCreatedDate
        '
        Me.Lbl_GetFileCreatedDate.AutoSize = True
        Me.Lbl_GetFileCreatedDate.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileCreatedDate.Location = New System.Drawing.Point(375, 253)
        Me.Lbl_GetFileCreatedDate.Name = "Lbl_GetFileCreatedDate"
        Me.Lbl_GetFileCreatedDate.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileCreatedDate.TabIndex = 77
        Me.Lbl_GetFileCreatedDate.Text = "Loadding..."
        '
        'Lbl_GetFileSize
        '
        Me.Lbl_GetFileSize.AutoSize = True
        Me.Lbl_GetFileSize.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileSize.Location = New System.Drawing.Point(375, 234)
        Me.Lbl_GetFileSize.Name = "Lbl_GetFileSize"
        Me.Lbl_GetFileSize.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileSize.TabIndex = 76
        Me.Lbl_GetFileSize.Text = "Loadding..."
        '
        'Lbl_GetFileTotalWords
        '
        Me.Lbl_GetFileTotalWords.AutoSize = True
        Me.Lbl_GetFileTotalWords.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileTotalWords.Location = New System.Drawing.Point(375, 215)
        Me.Lbl_GetFileTotalWords.Name = "Lbl_GetFileTotalWords"
        Me.Lbl_GetFileTotalWords.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileTotalWords.TabIndex = 75
        Me.Lbl_GetFileTotalWords.Text = "Loadding..."
        '
        'Lbl_GetFileTotalChars
        '
        Me.Lbl_GetFileTotalChars.AutoSize = True
        Me.Lbl_GetFileTotalChars.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileTotalChars.Location = New System.Drawing.Point(375, 196)
        Me.Lbl_GetFileTotalChars.Name = "Lbl_GetFileTotalChars"
        Me.Lbl_GetFileTotalChars.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileTotalChars.TabIndex = 74
        Me.Lbl_GetFileTotalChars.Text = "Loadding..."
        '
        'Lbl_GetFileTotalLines
        '
        Me.Lbl_GetFileTotalLines.AutoSize = True
        Me.Lbl_GetFileTotalLines.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GetFileTotalLines.Location = New System.Drawing.Point(375, 177)
        Me.Lbl_GetFileTotalLines.Name = "Lbl_GetFileTotalLines"
        Me.Lbl_GetFileTotalLines.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_GetFileTotalLines.TabIndex = 73
        Me.Lbl_GetFileTotalLines.Text = "Loadding..."
        '
        'Lbl_FileSystem
        '
        Me.Lbl_FileSystem.AutoSize = True
        Me.Lbl_FileSystem.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileSystem.Location = New System.Drawing.Point(210, 310)
        Me.Lbl_FileSystem.Name = "Lbl_FileSystem"
        Me.Lbl_FileSystem.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_FileSystem.TabIndex = 72
        Me.Lbl_FileSystem.Text = "File System:"
        '
        'Lbl_FileReadOnly
        '
        Me.Lbl_FileReadOnly.AutoSize = True
        Me.Lbl_FileReadOnly.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileReadOnly.Location = New System.Drawing.Point(210, 272)
        Me.Lbl_FileReadOnly.Name = "Lbl_FileReadOnly"
        Me.Lbl_FileReadOnly.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_FileReadOnly.TabIndex = 71
        Me.Lbl_FileReadOnly.Text = "File ReadOnly:"
        '
        'Lbl_FileHidden
        '
        Me.Lbl_FileHidden.AutoSize = True
        Me.Lbl_FileHidden.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileHidden.Location = New System.Drawing.Point(210, 291)
        Me.Lbl_FileHidden.Name = "Lbl_FileHidden"
        Me.Lbl_FileHidden.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_FileHidden.TabIndex = 70
        Me.Lbl_FileHidden.Text = "File Hidden:"
        '
        'Lbl_FileCreatedDate
        '
        Me.Lbl_FileCreatedDate.AutoSize = True
        Me.Lbl_FileCreatedDate.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileCreatedDate.Location = New System.Drawing.Point(210, 253)
        Me.Lbl_FileCreatedDate.Name = "Lbl_FileCreatedDate"
        Me.Lbl_FileCreatedDate.Size = New System.Drawing.Size(151, 13)
        Me.Lbl_FileCreatedDate.TabIndex = 69
        Me.Lbl_FileCreatedDate.Text = "File Created Date:"
        '
        'Lbl_FileSize
        '
        Me.Lbl_FileSize.AutoSize = True
        Me.Lbl_FileSize.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileSize.Location = New System.Drawing.Point(210, 234)
        Me.Lbl_FileSize.Name = "Lbl_FileSize"
        Me.Lbl_FileSize.Size = New System.Drawing.Size(87, 13)
        Me.Lbl_FileSize.TabIndex = 68
        Me.Lbl_FileSize.Text = "File Size:"
        '
        'Lbl_FileLocation
        '
        Me.Lbl_FileLocation.AutoSize = True
        Me.Lbl_FileLocation.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileLocation.Location = New System.Drawing.Point(210, 120)
        Me.Lbl_FileLocation.Name = "Lbl_FileLocation"
        Me.Lbl_FileLocation.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_FileLocation.TabIndex = 67
        Me.Lbl_FileLocation.Text = "File Location:"
        '
        'Lbl_FileTotalWords
        '
        Me.Lbl_FileTotalWords.AutoSize = True
        Me.Lbl_FileTotalWords.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileTotalWords.Location = New System.Drawing.Point(210, 215)
        Me.Lbl_FileTotalWords.Name = "Lbl_FileTotalWords"
        Me.Lbl_FileTotalWords.Size = New System.Drawing.Size(159, 13)
        Me.Lbl_FileTotalWords.TabIndex = 66
        Me.Lbl_FileTotalWords.Text = "File Total Word(s):"
        '
        'Lbl_FileTotalChars
        '
        Me.Lbl_FileTotalChars.AutoSize = True
        Me.Lbl_FileTotalChars.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileTotalChars.Location = New System.Drawing.Point(210, 196)
        Me.Lbl_FileTotalChars.Name = "Lbl_FileTotalChars"
        Me.Lbl_FileTotalChars.Size = New System.Drawing.Size(159, 13)
        Me.Lbl_FileTotalChars.TabIndex = 65
        Me.Lbl_FileTotalChars.Text = "File Total Char(s):"
        '
        'Lbl_FileExtension
        '
        Me.Lbl_FileExtension.AutoSize = True
        Me.Lbl_FileExtension.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileExtension.Location = New System.Drawing.Point(210, 158)
        Me.Lbl_FileExtension.Name = "Lbl_FileExtension"
        Me.Lbl_FileExtension.Size = New System.Drawing.Size(127, 13)
        Me.Lbl_FileExtension.TabIndex = 64
        Me.Lbl_FileExtension.Text = "File Extension:"
        '
        'Lbl_FileTotalLines
        '
        Me.Lbl_FileTotalLines.AutoSize = True
        Me.Lbl_FileTotalLines.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileTotalLines.Location = New System.Drawing.Point(210, 177)
        Me.Lbl_FileTotalLines.Name = "Lbl_FileTotalLines"
        Me.Lbl_FileTotalLines.Size = New System.Drawing.Size(159, 13)
        Me.Lbl_FileTotalLines.TabIndex = 63
        Me.Lbl_FileTotalLines.Text = "File Total Line(s):"
        '
        'Lbl_FileName
        '
        Me.Lbl_FileName.AutoSize = True
        Me.Lbl_FileName.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FileName.Location = New System.Drawing.Point(210, 139)
        Me.Lbl_FileName.Name = "Lbl_FileName"
        Me.Lbl_FileName.Size = New System.Drawing.Size(87, 13)
        Me.Lbl_FileName.TabIndex = 62
        Me.Lbl_FileName.Text = "File Name:"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(210, 92)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(248, 16)
        Me.Lbl_Title.TabIndex = 61
        Me.Lbl_Title.Text = "File Information Details"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Apply)
        Me.Controls.Add(Me.Chkb_Hidden)
        Me.Controls.Add(Me.Chkb_ReadOnly)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Lbl_GetFileLocation)
        Me.Controls.Add(Me.Lbl_GetFileExtension)
        Me.Controls.Add(Me.Lbl_GetFileName)
        Me.Controls.Add(Me.Lbl_GetFileHidden)
        Me.Controls.Add(Me.Lbl_GetFileSystem)
        Me.Controls.Add(Me.Lbl_GetFileReadOnly)
        Me.Controls.Add(Me.Lbl_GetFileCreatedDate)
        Me.Controls.Add(Me.Lbl_GetFileSize)
        Me.Controls.Add(Me.Lbl_GetFileTotalWords)
        Me.Controls.Add(Me.Lbl_GetFileTotalChars)
        Me.Controls.Add(Me.Lbl_GetFileTotalLines)
        Me.Controls.Add(Me.Lbl_FileSystem)
        Me.Controls.Add(Me.Lbl_FileReadOnly)
        Me.Controls.Add(Me.Lbl_FileHidden)
        Me.Controls.Add(Me.Lbl_FileCreatedDate)
        Me.Controls.Add(Me.Lbl_FileSize)
        Me.Controls.Add(Me.Lbl_FileLocation)
        Me.Controls.Add(Me.Lbl_FileTotalWords)
        Me.Controls.Add(Me.Lbl_FileTotalChars)
        Me.Controls.Add(Me.Lbl_FileExtension)
        Me.Controls.Add(Me.Lbl_FileTotalLines)
        Me.Controls.Add(Me.Lbl_FileName)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Apply As Button
    Friend WithEvents Chkb_Hidden As CheckBox
    Friend WithEvents Chkb_ReadOnly As CheckBox
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Lbl_GetFileLocation As LinkLabel
    Friend WithEvents Lbl_GetFileExtension As Label
    Friend WithEvents Lbl_GetFileName As Label
    Friend WithEvents Lbl_GetFileHidden As Label
    Friend WithEvents Lbl_GetFileSystem As Label
    Friend WithEvents Lbl_GetFileReadOnly As Label
    Friend WithEvents Lbl_GetFileCreatedDate As Label
    Friend WithEvents Lbl_GetFileSize As Label
    Friend WithEvents Lbl_GetFileTotalWords As Label
    Friend WithEvents Lbl_GetFileTotalChars As Label
    Friend WithEvents Lbl_GetFileTotalLines As Label
    Friend WithEvents Lbl_FileSystem As Label
    Friend WithEvents Lbl_FileReadOnly As Label
    Friend WithEvents Lbl_FileHidden As Label
    Friend WithEvents Lbl_FileCreatedDate As Label
    Friend WithEvents Lbl_FileSize As Label
    Friend WithEvents Lbl_FileLocation As Label
    Friend WithEvents Lbl_FileTotalWords As Label
    Friend WithEvents Lbl_FileTotalChars As Label
    Friend WithEvents Lbl_FileExtension As Label
    Friend WithEvents Lbl_FileTotalLines As Label
    Friend WithEvents Lbl_FileName As Label
    Friend WithEvents Lbl_Title As Label
End Class
