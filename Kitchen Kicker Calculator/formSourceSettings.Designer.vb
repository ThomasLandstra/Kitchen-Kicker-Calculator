<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSourceSettings
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
        Me.btnSrcSave = New System.Windows.Forms.Button()
        Me.tblSrcMaterials = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtbxLenFr = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxLenBa = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxLenCr = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxHeight = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxCutWidth = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxSrcWidth = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxSrcLength = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dtbxGapCr = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.lblProjectSettings = New System.Windows.Forms.Label()
        Me.tblSrcMaterials.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSrcSave
        '
        Me.btnSrcSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSrcSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrcSave.Location = New System.Drawing.Point(371, 171)
        Me.btnSrcSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSrcSave.Name = "btnSrcSave"
        Me.btnSrcSave.Size = New System.Drawing.Size(200, 34)
        Me.btnSrcSave.TabIndex = 31
        Me.btnSrcSave.Text = "Save Source Materials"
        Me.btnSrcSave.UseVisualStyleBackColor = True
        '
        'tblSrcMaterials
        '
        Me.tblSrcMaterials.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblSrcMaterials.ColumnCount = 6
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.76714!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.777!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.76714!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.777!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.13472!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.777!))
        Me.tblSrcMaterials.Controls.Add(Me.Label1, 0, 0)
        Me.tblSrcMaterials.Controls.Add(Me.Label27, 0, 1)
        Me.tblSrcMaterials.Controls.Add(Me.Label28, 0, 2)
        Me.tblSrcMaterials.Controls.Add(Me.Label29, 2, 0)
        Me.tblSrcMaterials.Controls.Add(Me.Label30, 2, 1)
        Me.tblSrcMaterials.Controls.Add(Me.Label31, 4, 0)
        Me.tblSrcMaterials.Controls.Add(Me.Label32, 4, 1)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxLenFr, 1, 0)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxLenBa, 1, 1)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxLenCr, 1, 2)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxHeight, 3, 0)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxCutWidth, 3, 1)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxSrcWidth, 5, 0)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxSrcLength, 5, 1)
        Me.tblSrcMaterials.Controls.Add(Me.Label33, 2, 2)
        Me.tblSrcMaterials.Controls.Add(Me.dtbxGapCr, 3, 2)
        Me.tblSrcMaterials.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tblSrcMaterials.Location = New System.Drawing.Point(11, 42)
        Me.tblSrcMaterials.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblSrcMaterials.Name = "tblSrcMaterials"
        Me.tblSrcMaterials.RowCount = 3
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblSrcMaterials.Size = New System.Drawing.Size(875, 119)
        Me.tblSrcMaterials.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Front Board Length"
        '
        'Label27
        '
        Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoEllipsis = True
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 41)
        Me.Label27.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(166, 37)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Back Board Length"
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoEllipsis = True
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 80)
        Me.Label28.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(166, 39)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Cross Brace Length"
        '
        'Label29
        '
        Me.Label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoEllipsis = True
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(295, 2)
        Me.Label29.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(166, 25)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "Kitchen Height"
        '
        'Label30
        '
        Me.Label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoEllipsis = True
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(295, 41)
        Me.Label30.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(166, 25)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Cut Width"
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoEllipsis = True
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(587, 2)
        Me.Label31.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(161, 25)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Source Width"
        '
        'Label32
        '
        Me.Label32.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoEllipsis = True
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(587, 41)
        Me.Label32.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(161, 25)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "Source Length"
        '
        'dtbxLenFr
        '
        Me.dtbxLenFr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxLenFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLenFr.Location = New System.Drawing.Point(175, 2)
        Me.dtbxLenFr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxLenFr.MaxLength = 15
        Me.dtbxLenFr.Millimetres = CType(0US, UShort)
        Me.dtbxLenFr.Name = "dtbxLenFr"
        Me.dtbxLenFr.Size = New System.Drawing.Size(114, 29)
        Me.dtbxLenFr.TabIndex = 36
        Me.dtbxLenFr.Text = " 0 m"
        Me.dtbxLenFr.Unit = "m"
        '
        'dtbxLenBa
        '
        Me.dtbxLenBa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxLenBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLenBa.Location = New System.Drawing.Point(175, 41)
        Me.dtbxLenBa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxLenBa.MaxLength = 15
        Me.dtbxLenBa.Millimetres = CType(0US, UShort)
        Me.dtbxLenBa.Name = "dtbxLenBa"
        Me.dtbxLenBa.Size = New System.Drawing.Size(114, 29)
        Me.dtbxLenBa.TabIndex = 37
        Me.dtbxLenBa.Text = " 0 m"
        Me.dtbxLenBa.Unit = "m"
        '
        'dtbxLenCr
        '
        Me.dtbxLenCr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxLenCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLenCr.Location = New System.Drawing.Point(175, 80)
        Me.dtbxLenCr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxLenCr.MaxLength = 15
        Me.dtbxLenCr.Millimetres = CType(0US, UShort)
        Me.dtbxLenCr.Name = "dtbxLenCr"
        Me.dtbxLenCr.Size = New System.Drawing.Size(114, 29)
        Me.dtbxLenCr.TabIndex = 38
        Me.dtbxLenCr.Text = " 0 m"
        Me.dtbxLenCr.Unit = "m"
        '
        'dtbxHeight
        '
        Me.dtbxHeight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxHeight.Location = New System.Drawing.Point(467, 2)
        Me.dtbxHeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxHeight.MaxLength = 15
        Me.dtbxHeight.Millimetres = CType(0US, UShort)
        Me.dtbxHeight.Name = "dtbxHeight"
        Me.dtbxHeight.Size = New System.Drawing.Size(114, 29)
        Me.dtbxHeight.TabIndex = 39
        Me.dtbxHeight.Text = " 0 m"
        Me.dtbxHeight.Unit = "m"
        '
        'dtbxCutWidth
        '
        Me.dtbxCutWidth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxCutWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxCutWidth.Location = New System.Drawing.Point(467, 41)
        Me.dtbxCutWidth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxCutWidth.MaxLength = 10
        Me.dtbxCutWidth.Millimetres = CType(0US, UShort)
        Me.dtbxCutWidth.Name = "dtbxCutWidth"
        Me.dtbxCutWidth.Size = New System.Drawing.Size(114, 29)
        Me.dtbxCutWidth.TabIndex = 40
        Me.dtbxCutWidth.Text = " 0 m"
        Me.dtbxCutWidth.Unit = "m"
        '
        'dtbxSrcWidth
        '
        Me.dtbxSrcWidth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxSrcWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxSrcWidth.Location = New System.Drawing.Point(754, 2)
        Me.dtbxSrcWidth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxSrcWidth.MaxLength = 15
        Me.dtbxSrcWidth.Millimetres = CType(0US, UShort)
        Me.dtbxSrcWidth.Name = "dtbxSrcWidth"
        Me.dtbxSrcWidth.Size = New System.Drawing.Size(118, 29)
        Me.dtbxSrcWidth.TabIndex = 41
        Me.dtbxSrcWidth.Text = " 0 m"
        Me.dtbxSrcWidth.Unit = "m"
        '
        'dtbxSrcLength
        '
        Me.dtbxSrcLength.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxSrcLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxSrcLength.Location = New System.Drawing.Point(754, 41)
        Me.dtbxSrcLength.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxSrcLength.MaxLength = 15
        Me.dtbxSrcLength.Millimetres = CType(0US, UShort)
        Me.dtbxSrcLength.Name = "dtbxSrcLength"
        Me.dtbxSrcLength.Size = New System.Drawing.Size(118, 29)
        Me.dtbxSrcLength.TabIndex = 42
        Me.dtbxSrcLength.Text = " 0 m"
        Me.dtbxSrcLength.Unit = "m"
        '
        'Label33
        '
        Me.Label33.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoEllipsis = True
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(295, 80)
        Me.Label33.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(166, 25)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Cross Brace Gap"
        '
        'dtbxGapCr
        '
        Me.dtbxGapCr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbxGapCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxGapCr.Location = New System.Drawing.Point(467, 80)
        Me.dtbxGapCr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbxGapCr.MaxLength = 15
        Me.dtbxGapCr.Millimetres = CType(0US, UShort)
        Me.dtbxGapCr.Name = "dtbxGapCr"
        Me.dtbxGapCr.Size = New System.Drawing.Size(114, 29)
        Me.dtbxGapCr.TabIndex = 44
        Me.dtbxGapCr.Text = " 0 m"
        Me.dtbxGapCr.Unit = "m"
        '
        'lblProjectSettings
        '
        Me.lblProjectSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProjectSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectSettings.Location = New System.Drawing.Point(331, 10)
        Me.lblProjectSettings.Name = "lblProjectSettings"
        Me.lblProjectSettings.Size = New System.Drawing.Size(283, 30)
        Me.lblProjectSettings.TabIndex = 29
        Me.lblProjectSettings.Text = "Source Material Settings"
        '
        'formSourceSettings
        '
        Me.AcceptButton = Me.btnSrcSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 212)
        Me.Controls.Add(Me.btnSrcSave)
        Me.Controls.Add(Me.tblSrcMaterials)
        Me.Controls.Add(Me.lblProjectSettings)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(909, 249)
        Me.Name = "formSourceSettings"
        Me.Text = "formSourceSettings"
        Me.tblSrcMaterials.ResumeLayout(False)
        Me.tblSrcMaterials.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSrcSave As Button
    Friend WithEvents tblSrcMaterials As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents dtbxLenFr As DistanceTextBox
    Friend WithEvents dtbxLenBa As DistanceTextBox
    Friend WithEvents dtbxLenCr As DistanceTextBox
    Friend WithEvents dtbxHeight As DistanceTextBox
    Friend WithEvents dtbxCutWidth As DistanceTextBox
    Friend WithEvents dtbxSrcWidth As DistanceTextBox
    Friend WithEvents dtbxSrcLength As DistanceTextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents dtbxGapCr As DistanceTextBox
    Friend WithEvents lblProjectSettings As Label
End Class
