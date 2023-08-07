<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSettings
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxCBWidth = New System.Windows.Forms.TextBox()
        Me.tbxFBWidth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBBColour = New System.Windows.Forms.Button()
        Me.btnFBColour = New System.Windows.Forms.Button()
        Me.btnCBColour = New System.Windows.Forms.Button()
        Me.tbxBBWidth = New System.Windows.Forms.TextBox()
        Me.cdColourDialog = New System.Windows.Forms.ColorDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tbxCBWidth, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxFBWidth, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBBColour, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnFBColour, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCBColour, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxBBWidth, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(238, 382)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbxCBWidth
        '
        Me.tbxCBWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCBWidth.Location = New System.Drawing.Point(190, 318)
        Me.tbxCBWidth.MaxLength = 2
        Me.tbxCBWidth.Name = "tbxCBWidth"
        Me.tbxCBWidth.Size = New System.Drawing.Size(45, 26)
        Me.tbxCBWidth.TabIndex = 11
        Me.tbxCBWidth.Text = "1"
        '
        'tbxFBWidth
        '
        Me.tbxFBWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFBWidth.Location = New System.Drawing.Point(190, 255)
        Me.tbxFBWidth.MaxLength = 2
        Me.tbxFBWidth.Name = "tbxFBWidth"
        Me.tbxFBWidth.Size = New System.Drawing.Size(45, 26)
        Me.tbxFBWidth.TabIndex = 10
        Me.tbxFBWidth.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Back Board Colour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Front Board Colour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cross Brace Colour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Back Board Stroke Width"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 48)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Front Board Stroke Width"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 48)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cross Brace Stroke Width"
        '
        'btnBBColour
        '
        Me.btnBBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnBBColour.Location = New System.Drawing.Point(187, 0)
        Me.btnBBColour.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBBColour.Name = "btnBBColour"
        Me.btnBBColour.Size = New System.Drawing.Size(30, 30)
        Me.btnBBColour.TabIndex = 6
        Me.btnBBColour.UseVisualStyleBackColor = True
        '
        'btnFBColour
        '
        Me.btnFBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnFBColour.Location = New System.Drawing.Point(187, 63)
        Me.btnFBColour.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFBColour.Name = "btnFBColour"
        Me.btnFBColour.Size = New System.Drawing.Size(30, 30)
        Me.btnFBColour.TabIndex = 7
        Me.btnFBColour.UseVisualStyleBackColor = True
        '
        'btnCBColour
        '
        Me.btnCBColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCBColour.ForeColor = System.Drawing.Color.Transparent
        Me.btnCBColour.Location = New System.Drawing.Point(187, 126)
        Me.btnCBColour.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCBColour.Name = "btnCBColour"
        Me.btnCBColour.Size = New System.Drawing.Size(30, 30)
        Me.btnCBColour.TabIndex = 8
        Me.btnCBColour.UseVisualStyleBackColor = True
        '
        'tbxBBWidth
        '
        Me.tbxBBWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBBWidth.Location = New System.Drawing.Point(190, 192)
        Me.tbxBBWidth.MaxLength = 2
        Me.tbxBBWidth.Name = "tbxBBWidth"
        Me.tbxBBWidth.Size = New System.Drawing.Size(45, 26)
        Me.tbxBBWidth.TabIndex = 9
        Me.tbxBBWidth.Text = "1"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(30, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 38)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Settings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'formSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formSettings"
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbxCBWidth As TextBox
    Friend WithEvents tbxFBWidth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBBColour As Button
    Friend WithEvents btnFBColour As Button
    Friend WithEvents btnCBColour As Button
    Friend WithEvents tbxBBWidth As TextBox
    Friend WithEvents cdColourDialog As ColorDialog
    Friend WithEvents btnSave As Button
End Class
