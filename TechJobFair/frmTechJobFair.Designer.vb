<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechJobFair
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBuilding = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Button()
        Me.picJobFair = New System.Windows.Forms.PictureBox()
        CType(Me.picJobFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(25, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Tech Job Fair"
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(42, 62)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(174, 18)
        Me.lblPhrase.TabIndex = 1
        Me.lblPhrase.Text = "All Students are Welcome"
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(58, 156)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(142, 32)
        Me.lblDetails.TabIndex = 2
        Me.lblDetails.Text = "View Job For Details"
        Me.lblDetails.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(84, 239)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 18)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "May 2, 2016"
        '
        'lblBuilding
        '
        Me.lblBuilding.AutoSize = True
        Me.lblBuilding.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuilding.Location = New System.Drawing.Point(52, 278)
        Me.lblBuilding.Name = "lblBuilding"
        Me.lblBuilding.Size = New System.Drawing.Size(154, 18)
        Me.lblBuilding.TabIndex = 4
        Me.lblBuilding.Text = "Located in Lochlan Hall"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(92, 317)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(75, 18)
        Me.lblRoom.TabIndex = 5
        Me.lblRoom.Text = "Room 101"
        '
        'lblExit
        '
        Me.lblExit.Location = New System.Drawing.Point(58, 445)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(142, 32)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "Exit Window"
        Me.lblExit.UseVisualStyleBackColor = True
        '
        'picJobFair
        '
        Me.picJobFair.Location = New System.Drawing.Point(278, 12)
        Me.picJobFair.Name = "picJobFair"
        Me.picJobFair.Size = New System.Drawing.Size(249, 492)
        Me.picJobFair.TabIndex = 7
        Me.picJobFair.TabStop = False
        '
        'frmTechJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 516)
        Me.Controls.Add(Me.picJobFair)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblBuilding)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTechJobFair"
        CType(Me.picJobFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblDetails As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblBuilding As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents lblExit As Button
    Friend WithEvents picJobFair As PictureBox
End Class
