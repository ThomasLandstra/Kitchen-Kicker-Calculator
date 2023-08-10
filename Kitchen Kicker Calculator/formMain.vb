﻿' DO YOURSELF A FAVOR, COLLAPSE ALL SUBS & FUNCTIONS NOW
' 
' NAMING CONVENTION:
' TYPE              :   RULE                :   EXAMPLE
' Private Variable  :   _typeNameHere       :   _ui16Millimetres
' Regular Variable  :   typeNameHere        :   ui16Millimetres
' Enum              :   EnumName            :   SaveResult
' Function          :   FunctionName        :   MainFormLoad
' Class Name        :   ClassName           :   Project
' File Name         :   typeFileName        :   cntrlDistanceTextBox
' Property          :   PropertyName        :   SpareFrontBoards
'
' Important Data Types
' PREFIX    :   TYPE/PURPISE    :   DESCRIPTION
' ui16      :   UInt16          :   An Unsigned 16 Bit Integer holding 0-65535
' cntrl     :   Control File    :   A file holding a windows forms control
' 

Imports System.Drawing.Imaging

Public Enum SaveResult
    Success
    InvalidPath
End Enum

Public Class formMain
    ' First load & project start
    Private Sub MainFormLoad() Handles MyBase.Load ' Initial load
        ' Create Default Project
        prjActiveProject = New Project
        NewKitchenElement()
    End Sub

    ' Add handlers
    Private Sub AddHandlers() Handles MyBase.Shown
        ' Add handlers of events in different forms
        AddHandler formDiagramSettings.FormClosed, AddressOf UpdateOutputs
        AddHandler formSourceSettings.btnSrcSave.Click, AddressOf UpdateOutputs

        ' Add onclick handlers to labels
        For Each cntrl As Control In tblElementOuts.Controls
            If TypeOf cntrl Is Label Then
                AddHandler cntrl.Click, AddressOf UnfocusElementOnClick
            End If
        Next
        For Each cntrl As Control In tblProjectOuts.Controls
            If TypeOf cntrl Is Label Then
                AddHandler cntrl.Click, AddressOf UnfocusElementOnClick
            End If
        Next
    End Sub
    Private Sub UnfocusElementOnClick() Handles MyBase.Click, pnlEditor.Click, tblElementOuts.Click, tblProjectOuts.Click
        ActiveControl = Nothing
    End Sub

    ' UTILITY FUNCTIONS
    Private Sub UpdateOutputs()
        ' Element outputs
        lblElOutBa.Text = keActiveElement.BackBoards
        lblElOutFr.Text = keActiveElement.FrontBoards
        lblElOutCr.Text = keActiveElement.CrossBraces
        etbxExtraBa.Text = keActiveElement.SpareBackBoards
        etbxExtraFr.Text = keActiveElement.SpareFrontBoards
        etbxExtraCr.Text = keActiveElement.SpareCrossBraces

        ' Diagram Output
        pbxDiagramBox.Image = keActiveElement.CreateDiagram()

        ' Project outputs
        lblPrjOutBa.Text = "0"
        lblPrjOutFr.Text = "0"
        lblPrjOutCr.Text = "0"

        lblPrjExtraFr.Text = "0"
        lblPrjExtraBa.Text = "0"
        lblPrjExtraCr.Text = "0"

        For Each keElement In prjActiveProject.KitchenElements
            lblPrjOutFr.Text = Str(Val(lblPrjOutFr.Text) + keElement.FrontBoards)
            lblPrjOutBa.Text = Str(Val(lblPrjOutBa.Text) + keElement.BackBoards)
            lblPrjOutCr.Text = Str(Val(lblPrjOutCr.Text) + keElement.CrossBraces)

            lblPrjExtraFr.Text = Str(Val(lblPrjExtraFr.Text) + keElement.SpareFrontBoards)
            lblPrjExtraBa.Text = Str(Val(lblPrjExtraBa.Text) + keElement.SpareBackBoards)
            lblPrjExtraCr.Text = Str(Val(lblPrjExtraCr.Text) + keElement.SpareCrossBraces)
        Next

        lblSheetsUsed.Text = prjActiveProject.SheetsUsed
        lblCutsToBeMade.Text = prjActiveProject.CutsMade
        lblWaste.Text = Str(prjActiveProject.WasteSquareMillimetreage / 1000000)
    End Sub



    ' ELEMENT DROPDOWN AND BUTTONS
    Private Sub NewKitchenElement() Handles btnNewElement.Click
        ' Create element
        keActiveElement = prjActiveProject.NewKitchenElement()

        ' Add element to combobox
        cmbxElement.Items.Add(keActiveElement.Name)
        cmbxElement.SelectedItem = keActiveElement.Name
    End Sub
    Private Sub DeleteKitchenElement() Handles btnDelElement.Click
        ' Ensure that there is more than 1 element
        If cmbxElement.Items.Count = 1 Then
            Warning("You cannot delete the last element!")
            Exit Sub
        End If

        ' Remove element
        cmbxElement.Items.Remove(cmbxElement.SelectedItem)
        prjActiveProject.KitchenElements.Remove(keActiveElement)

        ' Set active element to first element in list
        cmbxElement.SelectedIndex = 0
    End Sub
    Private Sub ChangeElement() Handles cmbxElement.SelectedValueChanged
        ' Match the selected element's name to the kitchen element
        Dim strNewElementName = cmbxElement.SelectedItem

        For Each keElement As KitchenElement In prjActiveProject.KitchenElements
            If keElement.Name = strNewElementName Then
                keActiveElement = keElement
                Exit For
            End If
        Next

        ' Update values
        dtbxLinearMetres.Text = keActiveElement.LinearString
        UpdateOutputs()
    End Sub



    ' ELEMENT INPUTS CHANGED
    ' Text Inputs
    Private Sub LinearMetresChanged() Handles dtbxLinearMetres.LostFocus
        keActiveElement.LinearString = dtbxLinearMetres.Text
        UpdateOutputs()
    End Sub
    Private Sub ExtraTextChanged(etbx As EscapableTextBox, e As EventArgs) Handles etbxExtraFr.LostFocus, etbxExtraBa.LostFocus, etbxExtraCr.LostFocus
        If Not IsNumeric(etbx.Text) Then
            Warning("You can only enter a number here")
        End If

        If Val(etbx.Text) < 0 Then
            Warning("You cannot enter a negative number here")
        End If

        Select Case etbx.Name
            Case "etbxExtraFr"
                keActiveElement.SpareFrontBoards = Val(etbx.Text)
            Case "etbxExtraBa"
                keActiveElement.SpareBackBoards = Val(etbx.Text)
            Case "etbxExtraCr"
                keActiveElement.SpareCrossBraces = Val(etbx.Text)
        End Select
        UpdateOutputs()
    End Sub


    ' MENU CONTEXT STRIP BUTTONS
    '' Functions
    Private Function PromptSaveProject() As Boolean
        If prjActiveProject.SaveFile.IsSaved Then Return True

        ' Prompt user to save
        Dim mbrSaveQ As MsgBoxResult = MsgBox("Do you want to save your current progress?", vbExclamation + vbYesNoCancel)

        If mbrSaveQ = vbCancel Then Return False
        If mbrSaveQ = vbNo Then Return True

        SaveProject()
        Return prjActiveProject.SaveFile.IsSaved
    End Function
    Private Sub PromptNewSave()
        Dim drResult = sdSaveDialog.ShowDialog()
        If drResult <> DialogResult.Cancel Then
            prjActiveProject.NewSave(sdSaveDialog.FileName)
        End If
    End Sub
    '' Buttons
    Private Sub NewProject() Handles smiNew.Click
        ' Prompt the user if they want to save
        If Not PromptSaveProject() Then ' Save aborted
            Exit Sub
        End If

        ' Create new project
        cmbxElement.Items.Clear()
        prjActiveProject = New Project
        NewKitchenElement()
    End Sub
    Private Sub OpenProject() Handles smiOpen.Click
        ' Prompt the user if they want to save
        If Not PromptSaveProject() Then ' Save aborted
            Exit Sub
        End If

        ' Get the file to open
        odOpenDialog.ShowDialog()
        Dim strSelectedPath As String = odOpenDialog.FileName

        If IsPathNothing(strSelectedPath) Then
            Exit Sub
        End If

        Dim fileOpen As IO.StreamReader
        fileOpen = My.Computer.FileSystem.OpenTextFileReader(strSelectedPath)
        Dim astrFileLines As String() = fileOpen.ReadToEnd().Split(vbLf)
        fileOpen.Close()

        If Not IsValidCSV(astrFileLines) Then
            Warning("This file is invalid!")
            Exit Sub
        End If

        ' Create new project
        cmbxElement.Items.Clear()
        prjActiveProject = New Project

        For ui16 = 1 To astrFileLines.Length - 1
            Dim strElement = astrFileLines(ui16)
            Dim strElementProps = strElement.Split(",")
            NewKitchenElement()
            keActiveElement.LinearMillimetres = Val(strElementProps(1))
            keActiveElement.SpareFrontBoards = Val(strElementProps(2))
            keActiveElement.SpareBackBoards = Val(strElementProps(3))
            keActiveElement.SpareCrossBraces = Val(strElementProps(4))
        Next

        ChangeElement()
        prjActiveProject.SaveFile.FilePath = odOpenDialog.FileName
        prjActiveProject.SaveFile.IsSaved = True
    End Sub
    Private Sub SaveProject() Handles smiSave.Click
        Dim srSaveResult As SaveResult = prjActiveProject.SaveFile.Save()
        If srSaveResult = SaveResult.InvalidPath Then
            PromptNewSave()
            ' Try to save again
            srSaveResult = prjActiveProject.SaveFile.Save()
        End If
        If srSaveResult <> SaveResult.Success Then
            Warning("There was an error whilst saving")
        End If
    End Sub
    Private Sub SaveAsProject() Handles smiSaveAs.Click
        PromptNewSave()
        Dim srSaveResult As SaveResult = prjActiveProject.SaveFile.Save()
        If srSaveResult <> SaveResult.Success Then
            Warning("There was an error whilst saving")
        End If
    End Sub


    ' DIAGRAM
    '' Change/Open pages
    Private Sub DiagramPrefrencesClick() Handles smiDiagramPreferences.Click
        formDiagramSettings.ShowDialog()
    End Sub
    Private Sub SourcePrefrencesClick() Handles smiSourcePreferences.Click
        formSourceSettings.ShowDialog()
    End Sub

    '' Save diagram
    Private Sub SaveDiagramClick() Handles btnSaveDiagram.Click
        sdImageSaveDialog.ShowDialog()
        If IsPathNothing(sdImageSaveDialog.FileName) Then
            Exit Sub
        End If

        Dim strExtension As String = sdImageSaveDialog.FileName.Split(".").Last
        Dim ifImageFormat As ImageFormat

        Select Case strExtension
            Case "jpeg"
                ifImageFormat = ImageFormat.Jpeg
            Case "png"
                ifImageFormat = ImageFormat.Png
            Case Else
                Exit Sub
        End Select

        pbxDiagramBox.Image.Save(sdImageSaveDialog.FileName, ifImageFormat)
    End Sub

    Private Sub LinearMetresChanged(sender As Object, e As EventArgs) Handles dtbxLinearMetres.LostFocus

    End Sub

    Private Sub ExtraTextChanged(sender As Object, e As EventArgs) Handles etbxExtraFr.LostFocus, etbxExtraCr.LostFocus, etbxExtraBa.LostFocus

    End Sub
End Class
