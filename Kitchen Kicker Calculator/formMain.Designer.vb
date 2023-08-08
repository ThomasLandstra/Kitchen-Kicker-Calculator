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
        Me.smiExportDiagram = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiDiagramPrefrences = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDiagram = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxmFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.smiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstrpMainForm = New System.Windows.Forms.MenuStrip()
        Me.pnlEditor = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tblProjectOuts = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblWaste = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.btnSrcSave = New System.Windows.Forms.Button()
        Me.tblElementOuts = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCrossBraces = New System.Windows.Forms.Label()
        Me.lblElOutCr = New System.Windows.Forms.Label()
        Me.lblElOutBa = New System.Windows.Forms.Label()
        Me.lblBackBoards = New System.Windows.Forms.Label()
        Me.lblFrontBoards = New System.Windows.Forms.Label()
        Me.lblElOutFr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tblSrcMaterials = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblProjectSettings = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblLinealMeters = New System.Windows.Forms.Label()
        Me.btnSeeMockup = New System.Windows.Forms.Button()
        Me.btnDelElement = New System.Windows.Forms.Button()
        Me.btnNewElement = New System.Windows.Forms.Button()
        Me.cmbxElement = New System.Windows.Forms.ComboBox()
        Me.pnlSpacer = New System.Windows.Forms.Panel()
        Me.sdSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.sdImageSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.pnlDiagram = New System.Windows.Forms.Panel()
        Me.btnSaveDiagram = New System.Windows.Forms.Button()
        Me.pbxDiagramBox = New System.Windows.Forms.PictureBox()
        Me.btnToEditor = New System.Windows.Forms.Button()
        Me.odOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dtbxLinearMetres = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.etbxExtraCr = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.etbxExtraBa = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.etbxExtraFr = New Kitchen_Kicker_Calculator.EscapableTextBox()
        Me.dtbxLenFr = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxLenBa = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxLenCr = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxHeight = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxCutWidth = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxSrcWidth = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxSrcLength = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.dtbxGapCr = New Kitchen_Kicker_Calculator.DistanceTextBox()
        Me.ctxmDiagram.SuspendLayout()
        Me.ctxmFile.SuspendLayout()
        Me.mstrpMainForm.SuspendLayout()
        Me.pnlEditor.SuspendLayout()
        Me.tblProjectOuts.SuspendLayout()
        Me.tblElementOuts.SuspendLayout()
        Me.tblSrcMaterials.SuspendLayout()
        Me.pnlDiagram.SuspendLayout()
        CType(Me.pbxDiagramBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ctxmDiagram.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiExportDiagram, Me.smiDiagramPrefrences})
        Me.ctxmDiagram.Name = "ctxmDiagram"
        Me.ctxmDiagram.OwnerItem = Me.mniDiagram
        Me.ctxmDiagram.ShowImageMargin = False
        Me.ctxmDiagram.Size = New System.Drawing.Size(184, 52)
        '
        'smiExportDiagram
        '
        Me.smiExportDiagram.Name = "smiExportDiagram"
        Me.smiExportDiagram.Size = New System.Drawing.Size(183, 24)
        Me.smiExportDiagram.Text = "Save Diagram"
        '
        'smiDiagramPrefrences
        '
        Me.smiDiagramPrefrences.Name = "smiDiagramPrefrences"
        Me.smiDiagramPrefrences.Size = New System.Drawing.Size(183, 24)
        Me.smiDiagramPrefrences.Text = "Diagram Prefrences"
        '
        'mniDiagram
        '
        Me.mniDiagram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mniDiagram.DropDown = Me.ctxmDiagram
        Me.mniDiagram.Name = "mniDiagram"
        Me.mniDiagram.Size = New System.Drawing.Size(89, 27)
        Me.mniDiagram.Text = "Diagram"
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
        Me.pnlEditor.Controls.Add(Me.Label26)
        Me.pnlEditor.Controls.Add(Me.tblProjectOuts)
        Me.pnlEditor.Controls.Add(Me.dtbxLinearMetres)
        Me.pnlEditor.Controls.Add(Me.btnSrcSave)
        Me.pnlEditor.Controls.Add(Me.tblElementOuts)
        Me.pnlEditor.Controls.Add(Me.tblSrcMaterials)
        Me.pnlEditor.Controls.Add(Me.lblProjectSettings)
        Me.pnlEditor.Controls.Add(Me.lblOutput)
        Me.pnlEditor.Controls.Add(Me.lblLinealMeters)
        Me.pnlEditor.Controls.Add(Me.btnSeeMockup)
        Me.pnlEditor.Controls.Add(Me.btnDelElement)
        Me.pnlEditor.Controls.Add(Me.btnNewElement)
        Me.pnlEditor.Controls.Add(Me.cmbxElement)
        Me.pnlEditor.Controls.Add(Me.pnlSpacer)
        Me.pnlEditor.Location = New System.Drawing.Point(11, 34)
        Me.pnlEditor.Name = "pnlEditor"
        Me.pnlEditor.Size = New System.Drawing.Size(960, 457)
        Me.pnlEditor.TabIndex = 32
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(762, 164)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(151, 26)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Project Output"
        '
        'tblProjectOuts
        '
        Me.tblProjectOuts.ColumnCount = 3
        Me.tblProjectOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProjectOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProjectOuts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProjectOuts.Controls.Add(Me.Label7, 2, 0)
        Me.tblProjectOuts.Controls.Add(Me.Label6, 1, 0)
        Me.tblProjectOuts.Controls.Add(Me.Label5, 0, 0)
        Me.tblProjectOuts.Controls.Add(Me.Label17, 0, 6)
        Me.tblProjectOuts.Controls.Add(Me.lblWaste, 2, 6)
        Me.tblProjectOuts.Controls.Add(Me.Label12, 2, 5)
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
        Me.tblProjectOuts.Location = New System.Drawing.Point(703, 195)
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
        Me.Label7.Size = New System.Drawing.Size(67, 22)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Extras"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(219, 154)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 22)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "--"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'btnSrcSave
        '
        Me.btnSrcSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrcSave.Location = New System.Drawing.Point(272, 272)
        Me.btnSrcSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSrcSave.Name = "btnSrcSave"
        Me.btnSrcSave.Size = New System.Drawing.Size(169, 30)
        Me.btnSrcSave.TabIndex = 28
        Me.btnSrcSave.Text = "Save Source Materials"
        Me.btnSrcSave.UseVisualStyleBackColor = True
        '
        'tblElementOuts
        '
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
        Me.tblElementOuts.Location = New System.Drawing.Point(703, 38)
        Me.tblElementOuts.Name = "tblElementOuts"
        Me.tblElementOuts.RowCount = 4
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblElementOuts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblElementOuts.Size = New System.Drawing.Size(252, 123)
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
        Me.Label4.Size = New System.Drawing.Size(67, 22)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Extras"
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
        'tblSrcMaterials
        '
        Me.tblSrcMaterials.ColumnCount = 6
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblSrcMaterials.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
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
        Me.tblSrcMaterials.Location = New System.Drawing.Point(12, 133)
        Me.tblSrcMaterials.Name = "tblSrcMaterials"
        Me.tblSrcMaterials.RowCount = 3
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblSrcMaterials.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblSrcMaterials.Size = New System.Drawing.Size(671, 126)
        Me.tblSrcMaterials.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Front Board Length"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 45)
        Me.Label27.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 39)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Back Board Length"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 87)
        Me.Label28.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 39)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Cross Brace Length"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(225, 3)
        Me.Label29.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(70, 39)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "Kitchen Height"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(225, 45)
        Me.Label30.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 20)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Cut Width"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(447, 3)
        Me.Label31.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(67, 39)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Source Width"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(447, 45)
        Me.Label32.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 39)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "Source Length"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(225, 87)
        Me.Label33.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 39)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Cross Brace Gap"
        '
        'lblProjectSettings
        '
        Me.lblProjectSettings.AutoSize = True
        Me.lblProjectSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectSettings.Location = New System.Drawing.Point(248, 100)
        Me.lblProjectSettings.Name = "lblProjectSettings"
        Me.lblProjectSettings.Size = New System.Drawing.Size(275, 29)
        Me.lblProjectSettings.TabIndex = 20
        Me.lblProjectSettings.Text = "Source Material Settings"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(753, 7)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(164, 26)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.Text = "Element Output"
        '
        'lblLinealMeters
        '
        Me.lblLinealMeters.AutoSize = True
        Me.lblLinealMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinealMeters.Location = New System.Drawing.Point(6, 39)
        Me.lblLinealMeters.Name = "lblLinealMeters"
        Me.lblLinealMeters.Size = New System.Drawing.Size(131, 25)
        Me.lblLinealMeters.TabIndex = 6
        Me.lblLinealMeters.Text = "Linear Metres"
        '
        'btnSeeMockup
        '
        Me.btnSeeMockup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeeMockup.Location = New System.Drawing.Point(556, 5)
        Me.btnSeeMockup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSeeMockup.Name = "btnSeeMockup"
        Me.btnSeeMockup.Size = New System.Drawing.Size(115, 30)
        Me.btnSeeMockup.TabIndex = 3
        Me.btnSeeMockup.Text = "See Mockup"
        Me.btnSeeMockup.UseVisualStyleBackColor = True
        '
        'btnDelElement
        '
        Me.btnDelElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNewElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmbxElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxElement.FormattingEnabled = True
        Me.cmbxElement.Location = New System.Drawing.Point(4, 4)
        Me.cmbxElement.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxElement.Name = "cmbxElement"
        Me.cmbxElement.Size = New System.Drawing.Size(254, 33)
        Me.cmbxElement.TabIndex = 0
        '
        'pnlSpacer
        '
        Me.pnlSpacer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSpacer.Location = New System.Drawing.Point(693, 0)
        Me.pnlSpacer.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSpacer.Name = "pnlSpacer"
        Me.pnlSpacer.Size = New System.Drawing.Size(2, 457)
        Me.pnlSpacer.TabIndex = 1
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
        'pnlDiagram
        '
        Me.pnlDiagram.Controls.Add(Me.btnSaveDiagram)
        Me.pnlDiagram.Controls.Add(Me.pbxDiagramBox)
        Me.pnlDiagram.Controls.Add(Me.btnToEditor)
        Me.pnlDiagram.Location = New System.Drawing.Point(11, 34)
        Me.pnlDiagram.Name = "pnlDiagram"
        Me.pnlDiagram.Size = New System.Drawing.Size(960, 457)
        Me.pnlDiagram.TabIndex = 33
        Me.pnlDiagram.Visible = False
        '
        'btnSaveDiagram
        '
        Me.btnSaveDiagram.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDiagram.Location = New System.Drawing.Point(658, 418)
        Me.btnSaveDiagram.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveDiagram.Name = "btnSaveDiagram"
        Me.btnSaveDiagram.Size = New System.Drawing.Size(144, 34)
        Me.btnSaveDiagram.TabIndex = 7
        Me.btnSaveDiagram.Text = "Save Diagram"
        Me.btnSaveDiagram.UseVisualStyleBackColor = True
        '
        'pbxDiagramBox
        '
        Me.pbxDiagramBox.BackColor = System.Drawing.Color.White
        Me.pbxDiagramBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxDiagramBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxDiagramBox.Location = New System.Drawing.Point(5, 5)
        Me.pbxDiagramBox.Name = "pbxDiagramBox"
        Me.pbxDiagramBox.Padding = New System.Windows.Forms.Padding(10)
        Me.pbxDiagramBox.Size = New System.Drawing.Size(950, 410)
        Me.pbxDiagramBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDiagramBox.TabIndex = 4
        Me.pbxDiagramBox.TabStop = False
        '
        'btnToEditor
        '
        Me.btnToEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToEditor.Location = New System.Drawing.Point(811, 418)
        Me.btnToEditor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnToEditor.Name = "btnToEditor"
        Me.btnToEditor.Size = New System.Drawing.Size(144, 34)
        Me.btnToEditor.TabIndex = 3
        Me.btnToEditor.Text = "Go To Editor"
        Me.btnToEditor.UseVisualStyleBackColor = True
        '
        'odOpenDialog
        '
        Me.odOpenDialog.DefaultExt = "csv"
        Me.odOpenDialog.Filter = "CSV Files|*.csv"
        '
        'dtbxLinearMetres
        '
        Me.dtbxLinearMetres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLinearMetres.Location = New System.Drawing.Point(118, 37)
        Me.dtbxLinearMetres.MaxLength = 15
        Me.dtbxLinearMetres.Millimetres = CType(0US, UShort)
        Me.dtbxLinearMetres.Name = "dtbxLinearMetres"
        Me.dtbxLinearMetres.Size = New System.Drawing.Size(133, 29)
        Me.dtbxLinearMetres.TabIndex = 40
        Me.dtbxLinearMetres.Text = " 0 m"
        Me.dtbxLinearMetres.Unit = "m"
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
        'etbxExtraFr
        '
        Me.etbxExtraFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etbxExtraFr.Location = New System.Drawing.Point(193, 33)
        Me.etbxExtraFr.MaxLength = 2
        Me.etbxExtraFr.Name = "etbxExtraFr"
        Me.etbxExtraFr.Size = New System.Drawing.Size(50, 29)
        Me.etbxExtraFr.TabIndex = 36
        '
        'dtbxLenFr
        '
        Me.dtbxLenFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLenFr.Location = New System.Drawing.Point(114, 3)
        Me.dtbxLenFr.MaxLength = 15
        Me.dtbxLenFr.Millimetres = CType(0US, UShort)
        Me.dtbxLenFr.Name = "dtbxLenFr"
        Me.dtbxLenFr.Size = New System.Drawing.Size(100, 29)
        Me.dtbxLenFr.TabIndex = 36
        Me.dtbxLenFr.Text = " 0 m"
        Me.dtbxLenFr.Unit = "m"
        '
        'dtbxLenBa
        '
        Me.dtbxLenBa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLenBa.Location = New System.Drawing.Point(114, 45)
        Me.dtbxLenBa.MaxLength = 15
        Me.dtbxLenBa.Millimetres = CType(0US, UShort)
        Me.dtbxLenBa.Name = "dtbxLenBa"
        Me.dtbxLenBa.Size = New System.Drawing.Size(100, 29)
        Me.dtbxLenBa.TabIndex = 37
        Me.dtbxLenBa.Text = " 0 m"
        Me.dtbxLenBa.Unit = "m"
        '
        'dtbxLenCr
        '
        Me.dtbxLenCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxLenCr.Location = New System.Drawing.Point(114, 87)
        Me.dtbxLenCr.MaxLength = 15
        Me.dtbxLenCr.Millimetres = CType(0US, UShort)
        Me.dtbxLenCr.Name = "dtbxLenCr"
        Me.dtbxLenCr.Size = New System.Drawing.Size(100, 29)
        Me.dtbxLenCr.TabIndex = 38
        Me.dtbxLenCr.Text = " 0 m"
        Me.dtbxLenCr.Unit = "m"
        '
        'dtbxHeight
        '
        Me.dtbxHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxHeight.Location = New System.Drawing.Point(336, 3)
        Me.dtbxHeight.MaxLength = 15
        Me.dtbxHeight.Millimetres = CType(0US, UShort)
        Me.dtbxHeight.Name = "dtbxHeight"
        Me.dtbxHeight.Size = New System.Drawing.Size(100, 29)
        Me.dtbxHeight.TabIndex = 39
        Me.dtbxHeight.Text = " 0 m"
        Me.dtbxHeight.Unit = "m"
        '
        'dtbxCutWidth
        '
        Me.dtbxCutWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxCutWidth.Location = New System.Drawing.Point(336, 45)
        Me.dtbxCutWidth.MaxLength = 10
        Me.dtbxCutWidth.Millimetres = CType(0US, UShort)
        Me.dtbxCutWidth.Name = "dtbxCutWidth"
        Me.dtbxCutWidth.Size = New System.Drawing.Size(100, 29)
        Me.dtbxCutWidth.TabIndex = 40
        Me.dtbxCutWidth.Text = " 0 m"
        Me.dtbxCutWidth.Unit = "m"
        '
        'dtbxSrcWidth
        '
        Me.dtbxSrcWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxSrcWidth.Location = New System.Drawing.Point(558, 3)
        Me.dtbxSrcWidth.MaxLength = 15
        Me.dtbxSrcWidth.Millimetres = CType(0US, UShort)
        Me.dtbxSrcWidth.Name = "dtbxSrcWidth"
        Me.dtbxSrcWidth.Size = New System.Drawing.Size(100, 29)
        Me.dtbxSrcWidth.TabIndex = 41
        Me.dtbxSrcWidth.Text = " 0 m"
        Me.dtbxSrcWidth.Unit = "m"
        '
        'dtbxSrcLength
        '
        Me.dtbxSrcLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxSrcLength.Location = New System.Drawing.Point(558, 45)
        Me.dtbxSrcLength.MaxLength = 15
        Me.dtbxSrcLength.Millimetres = CType(0US, UShort)
        Me.dtbxSrcLength.Name = "dtbxSrcLength"
        Me.dtbxSrcLength.Size = New System.Drawing.Size(100, 29)
        Me.dtbxSrcLength.TabIndex = 42
        Me.dtbxSrcLength.Text = " 0 m"
        Me.dtbxSrcLength.Unit = "m"
        '
        'dtbxGapCr
        '
        Me.dtbxGapCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbxGapCr.Location = New System.Drawing.Point(336, 87)
        Me.dtbxGapCr.MaxLength = 15
        Me.dtbxGapCr.Millimetres = CType(0US, UShort)
        Me.dtbxGapCr.Name = "dtbxGapCr"
        Me.dtbxGapCr.Size = New System.Drawing.Size(100, 29)
        Me.dtbxGapCr.TabIndex = 44
        Me.dtbxGapCr.Text = " 0 m"
        Me.dtbxGapCr.Unit = "m"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 503)
        Me.Controls.Add(Me.mstrpMainForm)
        Me.Controls.Add(Me.pnlEditor)
        Me.Controls.Add(Me.pnlDiagram)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formMain"
        Me.Text = "Kitchen Kicker Calculator"
        Me.ctxmDiagram.ResumeLayout(False)
        Me.ctxmFile.ResumeLayout(False)
        Me.mstrpMainForm.ResumeLayout(False)
        Me.mstrpMainForm.PerformLayout()
        Me.pnlEditor.ResumeLayout(False)
        Me.pnlEditor.PerformLayout()
        Me.tblProjectOuts.ResumeLayout(False)
        Me.tblProjectOuts.PerformLayout()
        Me.tblElementOuts.ResumeLayout(False)
        Me.tblElementOuts.PerformLayout()
        Me.tblSrcMaterials.ResumeLayout(False)
        Me.tblSrcMaterials.PerformLayout()
        Me.pnlDiagram.ResumeLayout(False)
        CType(Me.pbxDiagramBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ctxmDiagram As ContextMenuStrip
    Friend WithEvents smiExportDiagram As ToolStripMenuItem
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
    Friend WithEvents btnSeeMockup As Button
    Friend WithEvents btnDelElement As Button
    Friend WithEvents btnNewElement As Button
    Friend WithEvents lblLinealMeters As Label
    Friend WithEvents lblFrontBoards As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents pnlSpacer As Panel
    Friend WithEvents lblElOutCr As Label
    Friend WithEvents lblCrossBraces As Label
    Friend WithEvents lblElOutBa As Label
    Friend WithEvents lblBackBoards As Label
    Friend WithEvents lblElOutFr As Label
    Friend WithEvents sdSaveDialog As SaveFileDialog
    Friend WithEvents sdImageSaveDialog As SaveFileDialog
    Friend WithEvents pnlDiagram As Panel
    Friend WithEvents btnToEditor As Button
    Friend WithEvents pbxDiagramBox As PictureBox
    Friend WithEvents btnSaveDiagram As Button
    Friend WithEvents tblSrcMaterials As TableLayoutPanel
    Friend WithEvents lblProjectSettings As Label
    Friend WithEvents tblElementOuts As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents odOpenDialog As OpenFileDialog
    Friend WithEvents smiDiagramPrefrences As ToolStripMenuItem
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnSrcSave As Button
    Friend WithEvents dtbxLenFr As DistanceTextBox
    Friend WithEvents dtbxLenBa As DistanceTextBox
    Friend WithEvents dtbxLenCr As DistanceTextBox
    Friend WithEvents dtbxHeight As DistanceTextBox
    Friend WithEvents dtbxCutWidth As DistanceTextBox
    Friend WithEvents dtbxSrcWidth As DistanceTextBox
    Friend WithEvents dtbxSrcLength As DistanceTextBox
    Friend WithEvents dtbxLinearMetres As DistanceTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tblProjectOuts As TableLayoutPanel
    Friend WithEvents lblPrjExtraCr As Label
    Friend WithEvents lblPrjExtraBa As Label
    Friend WithEvents lblPrjExtraFr As Label
    Friend WithEvents lblSheetsUsed As Label
    Friend WithEvents Label12 As Label
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
    Friend WithEvents Label33 As Label
    Friend WithEvents dtbxGapCr As DistanceTextBox
    Friend WithEvents etbxExtraCr As EscapableTextBox
    Friend WithEvents etbxExtraBa As EscapableTextBox
    Friend WithEvents etbxExtraFr As EscapableTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
