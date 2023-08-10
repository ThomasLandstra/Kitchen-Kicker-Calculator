<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Me.components = New System.ComponentModel.Container()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxmDiagram = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.smiDiagramPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSourcePreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDiagram = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxmFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.smiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstrpMainForm = New System.Windows.Forms.MenuStrip()
        Me.pnlEditor = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnSaveDiagram = New System.Windows.Forms.Button()
        Me.pbxDiagramBox = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tblProjectOuts = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblWaste = New System.Windows.Forms.Label()
        Me.lblCutsToBeMade = New System.Windows.Forms.Label()
        Me.lblSheetsUsed = New System.Windows.Forms.Label()
        Me.lblPrjExtraCr = New System.Windows.Forms.Label()
        Me.lblPrjExtraBa = New System.Windows.Forms.Label()
        Me.lblPrjExtraFr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblPrjOutCr = New System.Windows.Forms.Label()
        Me.lblPrjOutBa = New System.Windows.Forms.Label()
        Me.lblPrjOutFr = New System.Windows.Forms.Label()
        Me.dtbxLinearMetres = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.tblElementOuts = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCrossBraces = New System.Windows.Forms.Label()
        Me.lblElOutCr = New System.Windows.Forms.Label()
        Me.etbxExtraCr = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.etbxExtraBa = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.lblElOutBa = New System.Windows.Forms.Label()
        Me.lblBackBoards = New System.Windows.Forms.Label()
        Me.lblFrontBoards = New System.Windows.Forms.Label()
        Me.lblElOutFr = New System.Windows.Forms.Label()
        Me.etbxExtraFr = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblLinealMeters = New System.Windows.Forms.Label()
        Me.btnDelElement = New System.Windows.Forms.Button()
        Me.btnNewElement = New System.Windows.Forms.Button()
        Me.cmbxElement = New System.Windows.Forms.ComboBox()
        Me.sdSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.sdImageSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.odOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ctxmDiagram.SuspendLayout()
        Me.ctxmFile.SuspendLayout()
        Me.mstrpMainForm.SuspendLayout()
        Me.pnlEditor.SuspendLayout()
        CType(Me.pbxDiagramBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblProjectOuts.SuspendLayout()
        Me.tblElementOuts.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ctxmDiagram
        '
        Me.ctxmDiagram.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxmDiagram.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiDiagramPreferences, Me.smiSourcePreferences})
        Me.ctxmDiagram.Name = "ctxmDiagram"
        Me.ctxmDiagram.OwnerItem = Me.mniDiagram
        Me.ctxmDiagram.ShowImageMargin = False
        Me.ctxmDiagram.Size = New System.Drawing.Size(238, 52)
        '
        'smiDiagramPreferences
        '
        Me.smiDiagramPreferences.Name = "smiDiagramPreferences"
        Me.smiDiagramPreferences.Size = New System.Drawing.Size(237, 24)
        Me.smiDiagramPreferences.Text = "Diagram Preferences"
        '
        'smiSourcePreferences
        '
        Me.smiSourcePreferences.Name = "smiSourcePreferences"
        Me.smiSourcePreferences.Size = New System.Drawing.Size(237, 24)
        Me.smiSourcePreferences.Text = "Source Material Preferences"
        '
        'mniDiagram
        '
        Me.mniDiagram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mniDiagram.DropDown = Me.ctxmDiagram
        Me.mniDiagram.Name = "mniDiagram"
        Me.mniDiagram.Size = New System.Drawing.Size(112, 27)
        Me.mniDiagram.Text = "Preferences"
        '
        'ctxmFile
        '
        Me.ctxmFile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxmFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiNew, Me.smiOpen, Me.smiSave, Me.smiSaveAs})
        Me.ctxmFile.Name = "ctxmMainFile"
        Me.ctxmFile.OwnerItem = Me.mniFile
        Me.ctxmFile.ShowImageMargin = False
        Me.ctxmFile.Size = New System.Drawing.Size(105, 100)
        '
        'smiNew
        '
        Me.smiNew.Name = "smiNew"
        Me.smiNew.Size = New System.Drawing.Size(104, 24)
        Me.smiNew.Text = "New"
        '
        'smiOpen
        '
        Me.smiOpen.Name = "smiOpen"
        Me.smiOpen.Size = New System.Drawing.Size(104, 24)
        Me.smiOpen.Text = "Open"
        '
        'smiSave
        '
        Me.smiSave.Name = "smiSave"
        Me.smiSave.Size = New System.Drawing.Size(104, 24)
        Me.smiSave.Text = "Save"
        '
        'smiSaveAs
        '
        Me.smiSaveAs.Name = "smiSaveAs"
        Me.smiSaveAs.Size = New System.Drawing.Size(104, 24)
        Me.smiSaveAs.Text = "Save As"
        '
        'mniFile
        '
        Me.mniFile.DropDown = Me.ctxmFile
        Me.mniFile.Name = "mniFile"
        Me.mniFile.Size = New System.Drawing.Size(49, 27)
        Me.mniFile.Text = "File"
        '
        'mstrpMainForm
        '
        Me.mstrpMainForm.BackColor = System.Drawing.SystemColors.Menu
        Me.mstrpMainForm.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstrpMainForm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstrpMainForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniFile, Me.mniDiagram})
        Me.mstrpMainForm.Location = New System.Drawing.Point(0, 0)
        Me.mstrpMainForm.Name = "mstrpMainForm"
        Me.mstrpMainForm.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.mstrpMainForm.Size = New System.Drawing.Size(982, 31)
        Me.mstrpMainForm.TabIndex = 1
        '
        'pnlEditor
        '
        Me.pnlEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEditor.Controls.Add(Me.btnHelp)
        Me.pnlEditor.Controls.Add(Me.btnSaveDiagram)
        Me.pnlEditor.Controls.Add(Me.pbxDiagramBox)
        Me.pnlEditor.Controls.Add(Me.Label26)
        Me.pnlEditor.Controls.Add(Me.tblProjectOuts)
        Me.pnlEditor.Controls.Add(Me.dtbxLinearMetres)
        Me.pnlEditor.Controls.Add(Me.tblElementOuts)
        Me.pnlEditor.Controls.Add(Me.lblOutput)
        Me.pnlEditor.Controls.Add(Me.lblLinealMeters)
        Me.pnlEditor.Controls.Add(Me.btnDelElement)
        Me.pnlEditor.Controls.Add(Me.btnNewElement)
        Me.pnlEditor.Controls.Add(Me.cmbxElement)
        Me.pnlEditor.Location = New System.Drawing.Point(11, 34)
        Me.pnlEditor.Name = "pnlEditor"
        Me.pnlEditor.Size = New System.Drawing.Size(960, 457)
        Me.pnlEditor.TabIndex = 32
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(903, 5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(27, 25)
        Me.btnHelp.TabIndex = 45
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnSaveDiagram
        '
        Me.btnSaveDiagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveDiagram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDiagram.Location = New System.Drawing.Point(529, 45)
        Me.btnSaveDiagram.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveDiagram.Name = "btnSaveDiagram"
        Me.btnSaveDiagram.Size = New System.Drawing.Size(144, 30)
        Me.btnSaveDiagram.TabIndex = 44
        Me.btnSaveDiagram.Text = "Save Diagram"
        Me.btnSaveDiagram.UseVisualStyleBackColor = True
        '
        'pbxDiagramBox
        '
        Me.pbxDiagramBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxDiagramBox.BackColor = System.Drawing.Color.White
        Me.pbxDiagramBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxDiagramBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxDiagramBox.Location = New System.Drawing.Point(10, 83)
        Me.pbxDiagramBox.Name = "pbxDiagramBox"
        Me.pbxDiagramBox.Padding = New System.Windows.Forms.Padding(10)
        Me.pbxDiagramBox.Size = New System.Drawing.Size(663, 369)
        Me.pbxDiagramBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDiagramBox.TabIndex = 43
        Me.pbxDiagramBox.TabStop = False
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(749, 194)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(174, 29)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Project Output"
        '
        'tblProjectOuts
        '
        Me.tblProjectOuts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblProjectOuts.ColumnCount = 3
        Me.tblProjectOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProjectOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProjectOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProjectOuts.Controls.Add(Me.Label7, 2, 0)
        Me.tblProjectOuts.Controls.Add(Me.Label6, 1, 0)
        Me.tblProjectOuts.Controls.Add(Me.Label5, 0, 0)
        Me.tblProjectOuts.Controls.Add(Me.Label17, 0, 6)
        Me.tblProjectOuts.Controls.Add(Me.lblWaste, 2, 6)
        Me.tblProjectOuts.Controls.Add(Me.lblCutsToBeMade, 2, 5)
        Me.tblProjectOuts.Controls.Add(Me.lblSheetsUsed, 2, 4)
        Me.tblProjectOuts.Controls.Add(Me.lblPrjExtraCr, 2, 3)
        Me.tblProjectOuts.Controls.Add(Me.lblPrjExtraBa, 2, 2)
        Me.tblProjectOuts.Controls.Add(Me.lblPrjExtraFr, 2, 1)
        Me.tblProjectOuts.Controls.Add(Me.Label14, 0, 5)
        Me.tblProjectOuts.Controls.Add(Me.Label15, 0, 4)
        Me.tblProjectOuts.Controls.Add(Me.Label20, 0, 3)
        Me.tblProjectOuts.Controls.Add(Me.Label19, 0, 2)
        Me.tblProjectOuts.Controls.Add(Me.Label18, 0, 1)
        Me.tblProjectOuts.Controls.Add(Me.lblPrjOutCr, 1, 3)
        Me.tblProjectOuts.Controls.Add(Me.lblPrjOutBa, 1, 2)
        Me.tblProjectOuts.Controls.Add(Me.lblPrjOutFr, 1, 1)
        Me.tblProjectOuts.Location = New System.Drawing.Point(690, 225)
        Me.tblProjectOuts.Name = "tblProjectOuts"
        Me.tblProjectOuts.RowCount = 7
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.tblProjectOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
        Me.tblProjectOuts.Size = New System.Drawing.Size(253, 211)
        Me.tblProjectOuts.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(219, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 22)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Spares"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 22)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 22)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Item"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 184)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 23)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Waste m^2"
        '
        'lblWaste
        '
        Me.lblWaste.AutoSize = True
        Me.lblWaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaste.Location = New System.Drawing.Point(219, 184)
        Me.lblWaste.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblWaste.Name = "lblWaste"
        Me.lblWaste.Size = New System.Drawing.Size(26, 23)
        Me.lblWaste.TabIndex = 33
        Me.lblWaste.Text = "--"
        Me.lblWaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCutsToBeMade
        '
        Me.lblCutsToBeMade.AutoSize = True
        Me.lblCutsToBeMade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCutsToBeMade.Location = New System.Drawing.Point(219, 154)
        Me.lblCutsToBeMade.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblCutsToBeMade.Name = "lblCutsToBeMade"
        Me.lblCutsToBeMade.Size = New System.Drawing.Size(26, 22)
        Me.lblCutsToBeMade.TabIndex = 34
        Me.lblCutsToBeMade.Text = "--"
        Me.lblCutsToBeMade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSheetsUsed
        '
        Me.lblSheetsUsed.AutoSize = True
        Me.lblSheetsUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSheetsUsed.Location = New System.Drawing.Point(219, 124)
        Me.lblSheetsUsed.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblSheetsUsed.Name = "lblSheetsUsed"
        Me.lblSheetsUsed.Size = New System.Drawing.Size(26, 22)
        Me.lblSheetsUsed.TabIndex = 35
        Me.lblSheetsUsed.Text = "--"
        Me.lblSheetsUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrjExtraCr
        '
        Me.lblPrjExtraCr.AutoSize = True
        Me.lblPrjExtraCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjExtraCr.Location = New System.Drawing.Point(219, 94)
        Me.lblPrjExtraCr.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblPrjExtraCr.Name = "lblPrjExtraCr"
        Me.lblPrjExtraCr.Size = New System.Drawing.Size(26, 22)
        Me.lblPrjExtraCr.TabIndex = 37
        Me.lblPrjExtraCr.Text = "--"
        Me.lblPrjExtraCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrjExtraBa
        '
        Me.lblPrjExtraBa.AutoSize = True
        Me.lblPrjExtraBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjExtraBa.Location = New System.Drawing.Point(219, 64)
        Me.lblPrjExtraBa.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblPrjExtraBa.Name = "lblPrjExtraBa"
        Me.lblPrjExtraBa.Size = New System.Drawing.Size(26, 22)
        Me.lblPrjExtraBa.TabIndex = 36
        Me.lblPrjExtraBa.Text = "--"
        Me.lblPrjExtraBa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrjExtraFr
        '
        Me.lblPrjExtraFr.AutoSize = True
        Me.lblPrjExtraFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjExtraFr.Location = New System.Drawing.Point(219, 34)
        Me.lblPrjExtraFr.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblPrjExtraFr.Name = "lblPrjExtraFr"
        Me.lblPrjExtraFr.Size = New System.Drawing.Size(26, 22)
        Me.lblPrjExtraFr.TabIndex = 28
        Me.lblPrjExtraFr.Text = "--"
        Me.lblPrjExtraFr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 154)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 22)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Cuts to be made"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 124)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 22)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Sheets Used"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 94)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 22)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Cross Braces"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 64)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 22)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Back Boards"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(4, 34)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 22)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Front Boards"
        '
        'lblPrjOutCr
        '
        Me.lblPrjOutCr.AutoSize = True
        Me.lblPrjOutCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjOutCr.Location = New System.Drawing.Point(167, 94)
        Me.lblPrjOutCr.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblPrjOutCr.Name = "lblPrjOutCr"
        Me.lblPrjOutCr.Size = New System.Drawing.Size(26, 22)
        Me.lblPrjOutCr.TabIndex = 18
        Me.lblPrjOutCr.Text = "--"
        Me.lblPrjOutCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrjOutBa
        '
        Me.lblPrjOutBa.AutoSize = True
        Me.lblPrjOutBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjOutBa.Location = New System.Drawing.Point(167, 64)
        Me.lblPrjOutBa.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblPrjOutBa.Name = "lblPrjOutBa"
        Me.lblPrjOutBa.Size = New System.Drawing.Size(26, 22)
        Me.lblPrjOutBa.TabIndex = 15
        Me.lblPrjOutBa.Text = "--"
        Me.lblPrjOutBa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrjOutFr
        '
        Me.lblPrjOutFr.AutoSize = True
        Me.lblPrjOutFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjOutFr.Location = New System.Drawing.Point(167, 34)
        Me.lblPrjOutFr.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblPrjOutFr.Name = "lblPrjOutFr"
        Me.lblPrjOutFr.Size = New System.Drawing.Size(26, 22)
        Me.lblPrjOutFr.TabIndex = 12
        Me.lblPrjOutFr.Text = "--"
        Me.lblPrjOutFr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtbxLinearMetres
        '
        Me.dtbxLinearMetres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLinearMetres.Location = New System.Drawing.Point(125, 48)
        Me.dtbxLinearMetres.MaxLength = 15
        Me.dtbxLinearMetres.Millimetres = CType(0US, UShort)
        Me.dtbxLinearMetres.Name = "dtbxLinearMetres"
        Me.dtbxLinearMetres.Size = New System.Drawing.Size(133, 31)
        Me.dtbxLinearMetres.TabIndex = 40
        Me.dtbxLinearMetres.Text = " 0 m"
        Me.dtbxLinearMetres.Unit = "m"
        '
        'tblElementOuts
        '
        Me.tblElementOuts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblElementOuts.ColumnCount = 3
        Me.tblElementOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblElementOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblElementOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblElementOuts.Controls.Add(Me.Label4, 2, 0)
        Me.tblElementOuts.Controls.Add(Me.Label3, 1, 0)
        Me.tblElementOuts.Controls.Add(Me.lblCrossBraces, 0, 3)
        Me.tblElementOuts.Controls.Add(Me.lblElOutCr, 1, 3)
        Me.tblElementOuts.Controls.Add(Me.etbxExtraCr, 2, 3)
        Me.tblElementOuts.Controls.Add(Me.etbxExtraBa, 2, 2)
        Me.tblElementOuts.Controls.Add(Me.lblElOutBa, 1, 2)
        Me.tblElementOuts.Controls.Add(Me.lblBackBoards, 0, 2)
        Me.tblElementOuts.Controls.Add(Me.lblFrontBoards, 0, 1)
        Me.tblElementOuts.Controls.Add(Me.lblElOutFr, 1, 1)
        Me.tblElementOuts.Controls.Add(Me.etbxExtraFr, 2, 1)
        Me.tblElementOuts.Controls.Add(Me.Label2, 0, 0)
        Me.tblElementOuts.Location = New System.Drawing.Point(690, 36)
        Me.tblElementOuts.Name = "tblElementOuts"
        Me.tblElementOuts.RowCount = 4
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblElementOuts.Size = New System.Drawing.Size(261, 123)
        Me.tblElementOuts.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(194, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 22)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Spares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 22)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Min"
        '
        'lblCrossBraces
        '
        Me.lblCrossBraces.AutoSize = True
        Me.lblCrossBraces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrossBraces.Location = New System.Drawing.Point(4, 94)
        Me.lblCrossBraces.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCrossBraces.Name = "lblCrossBraces"
        Me.lblCrossBraces.Size = New System.Drawing.Size(130, 25)
        Me.lblCrossBraces.TabIndex = 17
        Me.lblCrossBraces.Text = "Cross Braces"
        '
        'lblElOutCr
        '
        Me.lblElOutCr.AutoSize = True
        Me.lblElOutCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElOutCr.Location = New System.Drawing.Point(142, 94)
        Me.lblElOutCr.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblElOutCr.Name = "lblElOutCr"
        Me.lblElOutCr.Size = New System.Drawing.Size(26, 25)
        Me.lblElOutCr.TabIndex = 18
        Me.lblElOutCr.Text = "--"
        Me.lblElOutCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etbxExtraCr
        '
        Me.etbxExtraCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxExtraCr.Location = New System.Drawing.Point(193, 93)
        Me.etbxExtraCr.MaxLength = 2
        Me.etbxExtraCr.Name = "etbxExtraCr"
        Me.etbxExtraCr.Size = New System.Drawing.Size(50, 29)
        Me.etbxExtraCr.TabIndex = 38
        '
        'etbxExtraBa
        '
        Me.etbxExtraBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxExtraBa.Location = New System.Drawing.Point(193, 63)
        Me.etbxExtraBa.MaxLength = 2
        Me.etbxExtraBa.Name = "etbxExtraBa"
        Me.etbxExtraBa.Size = New System.Drawing.Size(50, 29)
        Me.etbxExtraBa.TabIndex = 37
        '
        'lblElOutBa
        '
        Me.lblElOutBa.AutoSize = True
        Me.lblElOutBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElOutBa.Location = New System.Drawing.Point(142, 64)
        Me.lblElOutBa.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblElOutBa.Name = "lblElOutBa"
        Me.lblElOutBa.Size = New System.Drawing.Size(26, 22)
        Me.lblElOutBa.TabIndex = 15
        Me.lblElOutBa.Text = "--"
        Me.lblElOutBa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBackBoards
        '
        Me.lblBackBoards.AutoSize = True
        Me.lblBackBoards.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackBoards.Location = New System.Drawing.Point(4, 64)
        Me.lblBackBoards.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBackBoards.Name = "lblBackBoards"
        Me.lblBackBoards.Size = New System.Drawing.Size(123, 22)
        Me.lblBackBoards.TabIndex = 14
        Me.lblBackBoards.Text = "Back Boards"
        '
        'lblFrontBoards
        '
        Me.lblFrontBoards.AutoSize = True
        Me.lblFrontBoards.BackColor = System.Drawing.Color.Transparent
        Me.lblFrontBoards.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrontBoards.Location = New System.Drawing.Point(4, 34)
        Me.lblFrontBoards.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFrontBoards.Name = "lblFrontBoards"
        Me.lblFrontBoards.Size = New System.Drawing.Size(124, 22)
        Me.lblFrontBoards.TabIndex = 9
        Me.lblFrontBoards.Text = "Front Boards"
        '
        'lblElOutFr
        '
        Me.lblElOutFr.AutoSize = True
        Me.lblElOutFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElOutFr.Location = New System.Drawing.Point(142, 34)
        Me.lblElOutFr.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.lblElOutFr.Name = "lblElOutFr"
        Me.lblElOutFr.Size = New System.Drawing.Size(26, 22)
        Me.lblElOutFr.TabIndex = 12
        Me.lblElOutFr.Text = "--"
        Me.lblElOutFr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etbxExtraFr
        '
        Me.etbxExtraFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxExtraFr.Location = New System.Drawing.Point(193, 33)
        Me.etbxExtraFr.MaxLength = 2
        Me.etbxExtraFr.Name = "etbxExtraFr"
        Me.etbxExtraFr.Size = New System.Drawing.Size(50, 29)
        Me.etbxExtraFr.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 22)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Item"
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(749, 5)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(189, 29)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.Text = "Element Output"
        '
        'lblLinealMeters
        '
        Me.lblLinealMeters.AutoSize = True
        Me.lblLinealMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinealMeters.Location = New System.Drawing.Point(3, 50)
        Me.lblLinealMeters.Name = "lblLinealMeters"
        Me.lblLinealMeters.Size = New System.Drawing.Size(144, 26)
        Me.lblLinealMeters.TabIndex = 6
        Me.lblLinealMeters.Text = "Linear Metres"
        '
        'btnDelElement
        '
        Me.btnDelElement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelElement.Location = New System.Drawing.Point(386, 4)
        Me.btnDelElement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelElement.Name = "btnDelElement"
        Me.btnDelElement.Size = New System.Drawing.Size(125, 30)
        Me.btnDelElement.TabIndex = 2
        Me.btnDelElement.Text = "Delete Element"
        Me.btnDelElement.UseVisualStyleBackColor = True
        '
        'btnNewElement
        '
        Me.btnNewElement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewElement.Location = New System.Drawing.Point(261, 4)
        Me.btnNewElement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNewElement.Name = "btnNewElement"
        Me.btnNewElement.Size = New System.Drawing.Size(125, 30)
        Me.btnNewElement.TabIndex = 1
        Me.btnNewElement.Text = "New Element"
        Me.btnNewElement.UseVisualStyleBackColor = True
        '
        'cmbxElement
        '
        Me.cmbxElement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbxElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxElement.FormattingEnabled = True
        Me.cmbxElement.Location = New System.Drawing.Point(4, 4)
        Me.cmbxElement.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxElement.Name = "cmbxElement"
        Me.cmbxElement.Size = New System.Drawing.Size(254, 33)
        Me.cmbxElement.TabIndex = 0
        '
        'sdSaveDialog
        '
        Me.sdSaveDialog.DefaultExt = "csv"
        Me.sdSaveDialog.Filter = "CSV Files|*.csv|All Files (*.*)|*.*"
        '
        'sdImageSaveDialog
        '
        Me.sdImageSaveDialog.DefaultExt = "jpeg"
        Me.sdImageSaveDialog.Filter = ".jpeg|*.jpeg|.png|*.png"
        '
        'odOpenDialog
        '
        Me.odOpenDialog.DefaultExt = "csv"
        Me.odOpenDialog.Filter = "CSV Files|*.csv"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 503)
        Me.Controls.Add(Me.mstrpMainForm)
        Me.Controls.Add(Me.pnlEditor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(998, 542)
        Me.Name = "formMain"
        Me.Text = "Kitchen Kicker Calculator"
        Me.ctxmDiagram.ResumeLayout(False)
        Me.ctxmFile.ResumeLayout(False)
        Me.mstrpMainForm.ResumeLayout(False)
        Me.mstrpMainForm.PerformLayout()
        Me.pnlEditor.ResumeLayout(False)
        Me.pnlEditor.PerformLayout()
        CType(Me.pbxDiagramBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblProjectOuts.ResumeLayout(False)
        Me.tblProjectOuts.PerformLayout()
        Me.tblElementOuts.ResumeLayout(False)
        Me.tblElementOuts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ctxmDiagram As ContextMenuStrip
    Friend WithEvents ctxmFile As ContextMenuStrip
    Friend WithEvents smiNew As ToolStripMenuItem
    Friend WithEvents smiOpen As ToolStripMenuItem
    Friend WithEvents smiSave As ToolStripMenuItem
    Friend WithEvents smiSaveAs As ToolStripMenuItem
    Friend WithEvents mniFile As ToolStripMenuItem
    Friend WithEvents mniDiagram As ToolStripMenuItem
    Friend WithEvents mstrpMainForm As MenuStrip
    Friend WithEvents pnlEditor As Panel
    Friend WithEvents cmbxElement As ComboBox
    Friend WithEvents btnDelElement As Button
    Friend WithEvents btnNewElement As Button
    Friend WithEvents lblLinealMeters As Label
    Friend WithEvents lblFrontBoards As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblElOutCr As Label
    Friend WithEvents lblCrossBraces As Label
    Friend WithEvents lblElOutBa As Label
    Friend WithEvents lblBackBoards As Label
    Friend WithEvents lblElOutFr As Label
    Friend WithEvents sdSaveDialog As SaveFileDialog
    Friend WithEvents sdImageSaveDialog As SaveFileDialog
    Friend WithEvents tblElementOuts As TableLayoutPanel
    Friend WithEvents odOpenDialog As OpenFileDialog
    Friend WithEvents smiDiagramPreferences As ToolStripMenuItem
    Friend WithEvents dtbxLinearMetres As DistanceTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tblProjectOuts As TableLayoutPanel
    Friend WithEvents lblPrjExtraCr As Label
    Friend WithEvents lblPrjExtraBa As Label
    Friend WithEvents lblPrjExtraFr As Label
    Friend WithEvents lblSheetsUsed As Label
    Friend WithEvents lblCutsToBeMade As Label
    Friend WithEvents lblWaste As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblPrjOutFr As Label
    Friend WithEvents lblPrjOutCr As Label
    Friend WithEvents lblPrjOutBa As Label
    Friend WithEvents etbxExtraCr As EscapableTextBox
    Friend WithEvents etbxExtraBa As EscapableTextBox
    Friend WithEvents etbxExtraFr As EscapableTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pbxDiagramBox As PictureBox
    Friend WithEvents smiSourcePreferences As ToolStripMenuItem
    Friend WithEvents btnSaveDiagram As Button
    Friend WithEvents btnHelp As Button
End Class
