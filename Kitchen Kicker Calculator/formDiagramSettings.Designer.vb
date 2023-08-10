<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDiagramSettings
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
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.etbxWidthCr = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.etbxWidthFr = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.etbxWidthBa = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBBColour = New System.Windows.Forms.Button()
        Me.btnFBColour = New System.Windows.Forms.Button()
        Me.btnCBColour = New System.Windows.Forms.Button()
        Me.cdColourDialog = New System.Windows.Forms.ColorDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tblMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblMain.ColumnCount = 2
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblMain.Controls.Add(Me.etbxWidthCr, 1, 5)
        Me.tblMain.Controls.Add(Me.etbxWidthFr, 1, 4)
        Me.tblMain.Controls.Add(Me.etbxWidthBa, 1, 3)
        Me.tblMain.Controls.Add(Me.Label1, 0, 0)
        Me.tblMain.Controls.Add(Me.Label2, 0, 1)
        Me.tblMain.Controls.Add(Me.Label3, 0, 2)
        Me.tblMain.Controls.Add(Me.Label4, 0, 3)
        Me.tblMain.Controls.Add(Me.Label5, 0, 4)
        Me.tblMain.Controls.Add(Me.Label6, 0, 5)
        Me.tblMain.Controls.Add(Me.btnBBColour, 1, 0)
        Me.tblMain.Controls.Add(Me.btnFBColour, 1, 1)
        Me.tblMain.Controls.Add(Me.btnCBColour, 1, 2)
        Me.tblMain.Location = New System.Drawing.Point(9, 10)
        Me.tblMain.Margin = New System.Windows.Forms.Padding(2)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 6
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.Size = New System.Drawing.Size(291, 185)
        Me.tblMain.TabIndex = 0
        '
        'etbxWidthCr
        '
        Me.etbxWidthCr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etbxWidthCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxWidthCr.Location = New System.Drawing.Point(235, 153)
        Me.etbxWidthCr.MaxLength = 2
        Me.etbxWidthCr.Name = "etbxWidthCr"
        Me.etbxWidthCr.Size = New System.Drawing.Size(32, 23)
        Me.etbxWidthCr.TabIndex = 13
        '
        'etbxWidthFr
        '
        Me.etbxWidthFr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etbxWidthFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxWidthFr.Location = New System.Drawing.Point(235, 123)
        Me.etbxWidthFr.MaxLength = 2
        Me.etbxWidthFr.Name = "etbxWidthFr"
        Me.etbxWidthFr.Size = New System.Drawing.Size(32, 23)
        Me.etbxWidthFr.TabIndex = 12
        '
        'etbxWidthBa
        '
        Me.etbxWidthBa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etbxWidthBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxWidthBa.Location = New System.Drawing.Point(235, 93)
        Me.etbxWidthBa.MaxLength = 2
        Me.etbxWidthBa.Name = "etbxWidthBa"
        Me.etbxWidthBa.Size = New System.Drawing.Size(32, 23)
        Me.etbxWidthBa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Back Board Colour"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Front Board Colour"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cross Brace Colour"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Back Board Stroke Width"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Front Board Stroke Width"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 150)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cross Brace Stroke Width"
        '
        'btnBBColour
        '
        Me.btnBBColour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnBBColour.Location = New System.Drawing.Point(236, 4)
        Me.btnBBColour.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBBColour.Name = "btnBBColour"
        Me.btnBBColour.Size = New System.Drawing.Size(51, 22)
        Me.btnBBColour.TabIndex = 6
        Me.btnBBColour.UseVisualStyleBackColor = True
        '
        'btnFBColour
        '
        Me.btnFBColour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnFBColour.Location = New System.Drawing.Point(236, 34)
        Me.btnFBColour.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFBColour.Name = "btnFBColour"
        Me.btnFBColour.Size = New System.Drawing.Size(51, 22)
        Me.btnFBColour.TabIndex = 7
        Me.btnFBColour.UseVisualStyleBackColor = True
        '
        'btnCBColour
        '
        Me.btnCBColour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnCBColour.Location = New System.Drawing.Point(236, 64)
        Me.btnCBColour.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCBColour.Name = "btnCBColour"
        Me.btnCBColour.Size = New System.Drawing.Size(51, 22)
        Me.btnCBColour.TabIndex = 8
        Me.btnCBColour.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(101, 208)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.MinimumSize = New System.Drawing.Size(108, 28)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Settings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'formDiagramSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 247)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tblMain)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(327, 243)
        Me.Name = "formDiagramSettings"
        Me.Text = "Settings"
        Me.tblMain.ResumeLayout(False)
        Me.tblMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBBColour As Button
    Friend WithEvents btnFBColour As Button
    Friend WithEvents btnCBColour As Button
    Friend WithEvents cdColourDialog As ColorDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents etbxWidthCr As EscapableTextBox
    Friend WithEvents etbxWidthFr As EscapableTextBox
    Friend WithEvents etbxWidthBa As EscapableTextBox
End Class
