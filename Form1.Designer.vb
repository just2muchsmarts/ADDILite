﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnJCLJOBFilename = New System.Windows.Forms.Button()
        Me.txtJCLJOBFolderName = New System.Windows.Forms.TextBox()
        Me.btnSourceFolder = New System.Windows.Forms.Button()
        Me.txtSourceFolderName = New System.Windows.Forms.TextBox()
        Me.txtJCLProclibFoldername = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnOutputFolder = New System.Windows.Forms.Button()
        Me.txtOutputFoldername = New System.Windows.Forms.TextBox()
        Me.btnADDILite = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDelimiter = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnJCLProclibFolder = New System.Windows.Forms.Button()
        Me.lblCopybookMessage = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.cbLogStmt = New System.Windows.Forms.CheckBox()
        Me.lblJobFileCount = New System.Windows.Forms.Label()
        Me.lblProcessingJob = New System.Windows.Forms.Label()
        Me.lblProcessingSource = New System.Windows.Forms.Label()
        Me.lblProcessingWorksheet = New System.Windows.Forms.Label()
        Me.cbScanModeOnly = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnJCLJOBFilename
        '
        Me.btnJCLJOBFilename.Location = New System.Drawing.Point(13, 13)
        Me.btnJCLJOBFilename.Name = "btnJCLJOBFilename"
        Me.btnJCLJOBFilename.Size = New System.Drawing.Size(247, 40)
        Me.btnJCLJOBFilename.TabIndex = 0
        Me.btnJCLJOBFilename.Text = "JCL JOB Folder:"
        Me.btnJCLJOBFilename.UseVisualStyleBackColor = True
        '
        'txtJCLJOBFolderName
        '
        Me.txtJCLJOBFolderName.Location = New System.Drawing.Point(267, 20)
        Me.txtJCLJOBFolderName.Name = "txtJCLJOBFolderName"
        Me.txtJCLJOBFolderName.Size = New System.Drawing.Size(824, 26)
        Me.txtJCLJOBFolderName.TabIndex = 1
        '
        'btnSourceFolder
        '
        Me.btnSourceFolder.Location = New System.Drawing.Point(12, 157)
        Me.btnSourceFolder.Name = "btnSourceFolder"
        Me.btnSourceFolder.Size = New System.Drawing.Size(248, 40)
        Me.btnSourceFolder.TabIndex = 6
        Me.btnSourceFolder.Text = "Source Folder:"
        Me.btnSourceFolder.UseVisualStyleBackColor = True
        '
        'txtSourceFolderName
        '
        Me.txtSourceFolderName.Location = New System.Drawing.Point(266, 164)
        Me.txtSourceFolderName.Name = "txtSourceFolderName"
        Me.txtSourceFolderName.Size = New System.Drawing.Size(823, 26)
        Me.txtSourceFolderName.TabIndex = 7
        '
        'txtJCLProclibFoldername
        '
        Me.txtJCLProclibFoldername.Location = New System.Drawing.Point(267, 118)
        Me.txtJCLProclibFoldername.Name = "txtJCLProclibFoldername"
        Me.txtJCLProclibFoldername.Size = New System.Drawing.Size(824, 26)
        Me.txtJCLProclibFoldername.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOutputFolder
        '
        Me.btnOutputFolder.Location = New System.Drawing.Point(10, 207)
        Me.btnOutputFolder.Name = "btnOutputFolder"
        Me.btnOutputFolder.Size = New System.Drawing.Size(248, 40)
        Me.btnOutputFolder.TabIndex = 10
        Me.btnOutputFolder.Text = "Output Folder:"
        Me.btnOutputFolder.UseVisualStyleBackColor = True
        '
        'txtOutputFoldername
        '
        Me.txtOutputFoldername.Location = New System.Drawing.Point(266, 214)
        Me.txtOutputFoldername.Name = "txtOutputFoldername"
        Me.txtOutputFoldername.Size = New System.Drawing.Size(823, 26)
        Me.txtOutputFoldername.TabIndex = 11
        '
        'btnADDILite
        '
        Me.btnADDILite.Location = New System.Drawing.Point(10, 253)
        Me.btnADDILite.Name = "btnADDILite"
        Me.btnADDILite.Size = New System.Drawing.Size(96, 53)
        Me.btnADDILite.TabIndex = 13
        Me.btnADDILite.Text = "ADDILite"
        Me.btnADDILite.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(456, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Delimiter:"
        '
        'txtDelimiter
        '
        Me.txtDelimiter.Location = New System.Drawing.Point(537, 268)
        Me.txtDelimiter.Name = "txtDelimiter"
        Me.txtDelimiter.Size = New System.Drawing.Size(31, 26)
        Me.txtDelimiter.TabIndex = 12
        Me.txtDelimiter.Text = "|"
        Me.txtDelimiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1013, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 37)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnJCLProclibFolder
        '
        Me.btnJCLProclibFolder.Location = New System.Drawing.Point(12, 111)
        Me.btnJCLProclibFolder.Name = "btnJCLProclibFolder"
        Me.btnJCLProclibFolder.Size = New System.Drawing.Size(248, 40)
        Me.btnJCLProclibFolder.TabIndex = 4
        Me.btnJCLProclibFolder.Text = "JCL Proclib Folder:"
        Me.btnJCLProclibFolder.UseVisualStyleBackColor = True
        '
        'lblCopybookMessage
        '
        Me.lblCopybookMessage.AutoSize = True
        Me.lblCopybookMessage.Location = New System.Drawing.Point(28, 309)
        Me.lblCopybookMessage.Name = "lblCopybookMessage"
        Me.lblCopybookMessage.Size = New System.Drawing.Size(641, 20)
        Me.lblCopybookMessage.TabIndex = 15
        Me.lblCopybookMessage.Text = "Select JCL JOB, ProcLib, Source, and Output buttons then click ADDILite to proces" &
    "s files."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 454)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1087, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'cbLogStmt
        '
        Me.cbLogStmt.AutoSize = True
        Me.cbLogStmt.Location = New System.Drawing.Point(283, 269)
        Me.cbLogStmt.Name = "cbLogStmt"
        Me.cbLogStmt.Size = New System.Drawing.Size(141, 24)
        Me.cbLogStmt.TabIndex = 17
        Me.cbLogStmt.Text = "Log Stmt Array"
        Me.cbLogStmt.UseVisualStyleBackColor = True
        '
        'lblJobFileCount
        '
        Me.lblJobFileCount.AutoSize = True
        Me.lblJobFileCount.Location = New System.Drawing.Point(263, 58)
        Me.lblJobFileCount.Name = "lblJobFileCount"
        Me.lblJobFileCount.Size = New System.Drawing.Size(161, 20)
        Me.lblJobFileCount.TabIndex = 18
        Me.lblJobFileCount.Text = "JCL Job files found: 0"
        '
        'lblProcessingJob
        '
        Me.lblProcessingJob.AutoSize = True
        Me.lblProcessingJob.Location = New System.Drawing.Point(38, 343)
        Me.lblProcessingJob.Name = "lblProcessingJob"
        Me.lblProcessingJob.Size = New System.Drawing.Size(121, 20)
        Me.lblProcessingJob.TabIndex = 19
        Me.lblProcessingJob.Text = "Processing Job:"
        '
        'lblProcessingSource
        '
        Me.lblProcessingSource.AutoSize = True
        Me.lblProcessingSource.Location = New System.Drawing.Point(56, 373)
        Me.lblProcessingSource.Name = "lblProcessingSource"
        Me.lblProcessingSource.Size = New System.Drawing.Size(146, 20)
        Me.lblProcessingSource.TabIndex = 20
        Me.lblProcessingSource.Text = "Processing Source:"
        '
        'lblProcessingWorksheet
        '
        Me.lblProcessingWorksheet.AutoSize = True
        Me.lblProcessingWorksheet.Location = New System.Drawing.Point(75, 406)
        Me.lblProcessingWorksheet.Name = "lblProcessingWorksheet"
        Me.lblProcessingWorksheet.Size = New System.Drawing.Size(176, 20)
        Me.lblProcessingWorksheet.TabIndex = 21
        Me.lblProcessingWorksheet.Text = "Processing Worksheet: "
        '
        'cbScanModeOnly
        '
        Me.cbScanModeOnly.AutoSize = True
        Me.cbScanModeOnly.Location = New System.Drawing.Point(112, 269)
        Me.cbScanModeOnly.Name = "cbScanModeOnly"
        Me.cbScanModeOnly.Size = New System.Drawing.Size(151, 24)
        Me.cbScanModeOnly.TabIndex = 22
        Me.cbScanModeOnly.Text = "Scan Mode Only"
        Me.cbScanModeOnly.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 489)
        Me.Controls.Add(Me.cbScanModeOnly)
        Me.Controls.Add(Me.lblProcessingWorksheet)
        Me.Controls.Add(Me.lblProcessingSource)
        Me.Controls.Add(Me.lblProcessingJob)
        Me.Controls.Add(Me.lblJobFileCount)
        Me.Controls.Add(Me.cbLogStmt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblCopybookMessage)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtDelimiter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnADDILite)
        Me.Controls.Add(Me.txtOutputFoldername)
        Me.Controls.Add(Me.btnOutputFolder)
        Me.Controls.Add(Me.txtJCLProclibFoldername)
        Me.Controls.Add(Me.btnJCLProclibFolder)
        Me.Controls.Add(Me.txtSourceFolderName)
        Me.Controls.Add(Me.btnSourceFolder)
        Me.Controls.Add(Me.txtJCLJOBFolderName)
        Me.Controls.Add(Me.btnJCLJOBFilename)
        Me.Name = "Form1"
        Me.Text = "ADDILite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnJCLJOBFilename As Button
    Friend WithEvents txtJCLJOBFolderName As TextBox
    Friend WithEvents btnSourceFolder As Button
    Friend WithEvents txtSourceFolderName As TextBox
    Friend WithEvents txtJCLProclibFoldername As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnOutputFolder As Button
    Friend WithEvents txtOutputFoldername As TextBox
    Friend WithEvents btnADDILite As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDelimiter As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnJCLProclibFolder As Button
    Friend WithEvents lblCopybookMessage As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents cbLogStmt As CheckBox
    Friend WithEvents lblJobFileCount As Label
    Friend WithEvents lblProcessingJob As Label
    Friend WithEvents lblProcessingSource As Label
    Friend WithEvents lblProcessingWorksheet As Label
    Friend WithEvents cbScanModeOnly As CheckBox
End Class
