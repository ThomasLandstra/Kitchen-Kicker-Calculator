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
        Me.lblColourBa = New System.Windows.Forms.Label()
        Me.lblColourFr = New System.Windows.Forms.Label()
        Me.lblColourCr = New System.Windows.Forms.Label()
        Me.lblStrokeBa = New System.Windows.Forms.Label()
        Me.lblStrokeFr = New System.Windows.Forms.Label()
        Me.lblStrokeCr = New System.Windows.Forms.Label()
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
        Me.tblMain.Controls.Add(Me.lblColourBa, 0, 0)
        Me.tblMain.Controls.Add(Me.lblColourFr, 0, 1)
        Me.tblMain.Controls.Add(Me.lblColourCr, 0, 2)
        Me.tblMain.Controls.Add(Me.lblStrokeBa, 0, 3)
        Me.tblMain.Controls.Add(Me.lblStrokeFr, 0, 4)
        Me.tblMain.Controls.Add(Me.lblStrokeCr, 0, 5)
        Me.tblMain.Controls.Add(Me.btnBBColour, 1, 0)
        Me.tblMain.Controls.Add(Me.btnFBColour, 1, 1)
        Me.tblMain.Controls.Add(Me.btnCBColour, 1, 2)
        Me.tblMain.Location = New System.Drawing.Point(12, 12)
        Me.tblMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 6
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666!))
        Me.tblMain.Size = New System.Drawing.Size(388, 228)
        Me.tblMain.TabIndex = 0
        '
        'etbxWidthCr
        '
        Me.etbxWidthCr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etbxWidthCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxWidthCr.Location = New System.Drawing.Point(314, 194)
        Me.etbxWidthCr.Margin = New System.Windows.Forms.Padding(4)
        Me.etbxWidthCr.MaxLength = 2
        Me.etbxWidthCr.Name = "etbxWidthCr"
        Me.etbxWidthCr.Size = New System.Drawing.Size(41, 26)
        Me.etbxWidthCr.TabIndex = 13
        '
        'etbxWidthFr
        '
        Me.etbxWidthFr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etbxWidthFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxWidthFr.Location = New System.Drawing.Point(314, 156)
        Me.etbxWidthFr.Margin = New System.Windows.Forms.Padding(4)
        Me.etbxWidthFr.MaxLength = 2
        Me.etbxWidthFr.Name = "etbxWidthFr"
        Me.etbxWidthFr.Size = New System.Drawing.Size(41, 26)
        Me.etbxWidthFr.TabIndex = 12
        '
        'etbxWidthBa
        '
        Me.etbxWidthBa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etbxWidthBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxWidthBa.Location = New System.Drawing.Point(314, 118)
        Me.etbxWidthBa.Margin = New System.Windows.Forms.Padding(4)
        Me.etbxWidthBa.MaxLength = 2
        Me.etbxWidthBa.Name = "etbxWidthBa"
        Me.etbxWidthBa.Size = New System.Drawing.Size(41, 26)
        Me.etbxWidthBa.TabIndex = 2
        '
        'lblColourBa
        '
        Me.lblColourBa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColourBa.AutoEllipsis = True
        Me.lblColourBa.AutoSize = True
        Me.lblColourBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourBa.Location = New System.Drawing.Point(3, 0)
        Me.lblColourBa.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblColourBa.Name = "lblColourBa"
        Me.lblColourBa.Size = New System.Drawing.Size(304, 24)
        Me.lblColourBa.TabIndex = 0
        Me.lblColourBa.Text = "Back Board Colour"
        '
        'lblColourFr
        '
        Me.lblColourFr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColourFr.AutoEllipsis = True
        Me.lblColourFr.AutoSize = True
        Me.lblColourFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourFr.Location = New System.Drawing.Point(3, 38)
        Me.lblColourFr.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblColourFr.Name = "lblColourFr"
        Me.lblColourFr.Size = New System.Drawing.Size(304, 24)
        Me.lblColourFr.TabIndex = 1
        Me.lblColourFr.Text = "Front Board Colour"
        '
        'lblColourCr
        '
        Me.lblColourCr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColourCr.AutoEllipsis = True
        Me.lblColourCr.AutoSize = True
        Me.lblColourCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourCr.Location = New System.Drawing.Point(3, 76)
        Me.lblColourCr.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblColourCr.Name = "lblColourCr"
        Me.lblColourCr.Size = New System.Drawing.Size(304, 24)
        Me.lblColourCr.TabIndex = 2
        Me.lblColourCr.Text = "Cross Brace Colour"
        '
        'lblStrokeBa
        '
        Me.lblStrokeBa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStrokeBa.AutoEllipsis = True
        Me.lblStrokeBa.AutoSize = True
        Me.lblStrokeBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrokeBa.Location = New System.Drawing.Point(3, 114)
        Me.lblStrokeBa.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblStrokeBa.Name = "lblStrokeBa"
        Me.lblStrokeBa.Size = New System.Drawing.Size(304, 24)
        Me.lblStrokeBa.TabIndex = 3
        Me.lblStrokeBa.Text = "Back Board Stroke Width"
        '
        'lblStrokeFr
        '
        Me.lblStrokeFr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStrokeFr.AutoEllipsis = True
        Me.lblStrokeFr.AutoSize = True
        Me.lblStrokeFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrokeFr.Location = New System.Drawing.Point(3, 152)
        Me.lblStrokeFr.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblStrokeFr.Name = "lblStrokeFr"
        Me.lblStrokeFr.Size = New System.Drawing.Size(304, 24)
        Me.lblStrokeFr.TabIndex = 4
        Me.lblStrokeFr.Text = "Front Board Stroke Width"
        '
        'lblStrokeCr
        '
        Me.lblStrokeCr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStrokeCr.AutoEllipsis = True
        Me.lblStrokeCr.AutoSize = True
        Me.lblStrokeCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrokeCr.Location = New System.Drawing.Point(3, 190)
        Me.lblStrokeCr.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblStrokeCr.Name = "lblStrokeCr"
        Me.lblStrokeCr.Size = New System.Drawing.Size(304, 24)
        Me.lblStrokeCr.TabIndex = 5
        Me.lblStrokeCr.Text = "Cross Brace Stroke Width"
        '
        'btnBBColour
        '
        Me.btnBBColour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnBBColour.Location = New System.Drawing.Point(315, 5)
        Me.btnBBColour.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBBColour.Name = "btnBBColour"
        Me.btnBBColour.Size = New System.Drawing.Size(68, 28)
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
        Me.btnFBColour.Location = New System.Drawing.Point(315, 43)
        Me.btnFBColour.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFBColour.Name = "btnFBColour"
        Me.btnFBColour.Size = New System.Drawing.Size(68, 28)
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
        Me.btnCBColour.Location = New System.Drawing.Point(315, 81)
        Me.btnCBColour.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCBColour.Name = "btnCBColour"
        Me.btnCBColour.Size = New System.Drawing.Size(68, 28)
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
        Me.btnSave.Location = New System.Drawing.Point(135, 256)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.MinimumSize = New System.Drawing.Size(144, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Settings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'formDiagramSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 304)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tblMain)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(430, 288)
        Me.Name = "formDiagramSettings"
        Me.Text = "Settings"
        Me.tblMain.ResumeLayout(False)
        Me.tblMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents lblColourBa As Label
    Friend WithEvents lblColourFr As Label
    Friend WithEvents lblColourCr As Label
    Friend WithEvents lblStrokeBa As Label
    Friend WithEvents lblStrokeFr As Label
    Friend WithEvents lblStrokeCr As Label
    Friend WithEvents btnBBColour As Button
    Friend WithEvents btnFBColour As Button
    Friend WithEvents btnCBColour As Button
    Friend WithEvents cdColourDialog As ColorDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents etbxWidthCr As EscapableTextBox
    Friend WithEvents etbxWidthFr As EscapableTextBox
    Friend WithEvents etbxWidthBa As EscapableTextBox
End Class
