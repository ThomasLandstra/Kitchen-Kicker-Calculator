Public Class formSourceSettings
    ' EVENT HANDLERS
    '' Form loaded and shown
    Private Sub FormLoaded() Handles MyBase.Load
        ' Update text boxes with settings data
        dtbxSrcLength.Text = dstrSrcLength.Text
        dtbxSrcWidth.Text = dstrSrcWidth.Text
        dtbxLenBa.Text = dstrLenBa.Text
        dtbxLenFr.Text = dstrLenFr.Text
        dtbxLenCr.Text = dstrLenCr.Text
        dtbxCutWidth.Text = dstrCutWidth.Text
        dtbxHeight.Text = dstrHeight.Text
        dtbxGapCr.Text = dstrGapCr.Text
    End Sub
    Private Sub FormResized() Handles MyBase.Resize ' Form resized
        ' Font size = table height / table row count - 8 (for padding)
        Dim bytFontSize As Byte = Math.Floor(tblSrcMaterials.Height / tblSrcMaterials.RowCount - 12)

        ' Clamp font size to valid range of 5-30
        If bytFontSize > 30 Then
            bytFontSize = 30
        End If
        If bytFontSize < 5 Then
            bytFontSize = 5
        End If

        ' Apply font to components
        For Each lbl In tblSrcMaterials.Controls.OfType(Of Label)()
            lbl.Font = New Font(Font.Name, bytFontSize, unit:=GraphicsUnit.Pixel)
        Next

        ' Buttons and textboxes have slightly smaller fonts for extra padding
        For Each dtbx In tblSrcMaterials.Controls.OfType(Of DistanceTextBox)()
            dtbx.Font = New Font(Font.Name, bytFontSize - 4, unit:=GraphicsUnit.Pixel)
        Next
    End Sub

    '' Unfocus tools
    Private Sub UnfocusElementOnClick() Handles MyBase.Click, tblSrcMaterials.Click
        ActiveControl = Nothing
    End Sub
    Private Sub FormShown() Handles MyBase.Shown
        ' Add event handlers to unfocus on click
        For Each cntrl As Control In tblSrcMaterials.Controls
            If TypeOf cntrl Is Label Then
                AddHandler cntrl.Click, AddressOf UnfocusElementOnClick
            End If
        Next
    End Sub

    '' Inputs changed
    Private Sub InvalidSrcLengthWarning(strLength As String)
        Warning("To make this change the source sheet must have one side length of at least " & strLength)
    End Sub

    Public Function IsValidSrcLengths(dtbxCheck As DistanceTextBox) As Boolean
        ' Is the textbox one which needs to be validated
        If {"dtbxLenFr", "dtbxLenCr", "dtbxLenBa"}.Contains(dtbxCheck.Name) Then
            ' Ensure that the longest side is long enough for components
            If dtbxCheck.Millimetres + dstrCutWidth.Millimetres > ui16LenLongSide Then
                InvalidSrcLengthWarning(dtbxCheck.Text)
                Return False
            End If
        ElseIf dtbxCheck.Name = "dtbxHeight" Then
            ' Ensure short side is long enough for kitchen length
            If dtbxHeight.Millimetres > ui16LenShortSide Then
                Warning("To make this change the source sheet's shortest side must be larger than " & dstrLenCr.Text)
                Return False
            End If
        End If
        Return True

    End Function
    Private Sub SourceDimensionsChanged(dtbx As DistanceTextBox, e As EventArgs) Handles dtbxLenFr.LostFocus, dtbxLenBa.LostFocus, dtbxLenCr.LostFocus, dtbxHeight.LostFocus, dtbxCutWidth.LostFocus, dtbxSrcWidth.LostFocus, dtbxSrcLength.LostFocus, dtbxGapCr.LostFocus
        ' Check to ensure that the entry is not 0 and doesn't conflict with source sheet lengths
        Dim boolIsValidEntry As Boolean = IsValidSrcLengths(dtbx) And dtbx.Millimetres <> 0

        Select Case dtbx.Name
            Case "dtbxLenFr" ' Front Board Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrLenFr.Text
                ElseIf dtbx.Millimetres < 200 Or dtbx.Millimetres > 3500 Then
                    MsgBox("Front Board Length must be between 200mm and 3500mm")
                    dtbx.Text = dstrLenFr.Text
                End If
                dstrLenFr.Text = dtbx.Text
                My.Settings.strLenFr = dstrLenFr.Text
            Case "dtbxLenBa" ' Back Board Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrLenBa.Text
                ElseIf dtbx.Millimetres < 200 Or dtbx.Millimetres > 3500 Then
                    MsgBox("Back Board Length must be between 200mm and 3500mm")
                    dtbx.Text = dstrLenBa.Text
                End If
                dstrLenBa.Text = dtbx.Text
                My.Settings.strLenBa = dstrLenBa.Text
            Case "dtbxLenCr" ' Cross Brace Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrLenCr.Text
                ElseIf dtbx.Millimetres < 150 Or dtbx.Millimetres > 1500 Then
                    MsgBox("Cross Brace Length must be between 150mm and 1500mm")
                    dtbx.Text = dstrLenCr.Text
                End If
                dstrLenCr.Text = dtbx.Text
                My.Settings.strLenCr = dstrLenCr.Text
            Case "dtbxHeight" ' Height Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrHeight.Text
                ElseIf dtbx.Millimetres < 10 Or dtbx.Millimetres > 350 Then
                    MsgBox("Kitchen height must be between 10mm and 350mm")
                    dtbx.Text = dstrHeight.Text
                End If
                dstrHeight.Text = dtbx.Text
                My.Settings.strHeight = dstrHeight.Text
            Case "dtbxCutWidth" ' Cut Width Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrCutWidth.Text
                ElseIf dtbx.Millimetres > 25 Then
                    MsgBox("Cut width cannot be larger than 25 mm")
                    dtbx.Text = dstrCutWidth.Text
                End If
                dstrCutWidth.Text = dtbx.Text
                My.Settings.strCutWidth = dstrCutWidth.Text
            Case "dtbxSrcLength" ' Source Length Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrSrcLength.Text
                End If
                dstrSrcLength.Text = dtbx.Text
                My.Settings.strSrcLength = dstrSrcLength.Text
            Case "dtbxSrcWidth" ' Source Width Textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrSrcWidth.Text
                End If
                dstrSrcWidth.Text = dtbx.Text
                My.Settings.strSrcWidth = dstrSrcWidth.Text
            Case "dtbxGapCr" ' Cross brace gap textbox
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrGapCr.Text
                ElseIf dtbx.Millimetres < 100 Or dtbx.Millimetres > 1250 Then
                    MsgBox("Kitchen height must be between 100mm and 1250mm")
                    dtbx.Text = dstrGapCr.Text
                End If
                dstrGapCr.Text = dtbx.Text
                My.Settings.strGapCr = dstrGapCr.Text
        End Select
    End Sub
    Private Sub SaveGlobalSettings() Handles btnSrcSave.Click
        ' Save settings and close dialog
        My.Settings.Save()
        Me.Close()
    End Sub

End Class