Public Class formSourceSettings
    Private Sub FormLoaded() Handles MyBase.Load
        dtbxSrcLength.Text = dstrSrcLength.Text
        dtbxSrcWidth.Text = dstrSrcWidth.Text
        dtbxLenBa.Text = dstrLenBa.Text
        dtbxLenFr.Text = dstrLenFr.Text
        dtbxLenCr.Text = dstrLenCr.Text
        dtbxCutWidth.Text = dstrCutWidth.Text
        dtbxHeight.Text = dstrHeight.Text
        dtbxGapCr.Text = dstrGapCr.Text
    End Sub

    Private Sub FormShown() Handles MyBase.Shown
        For Each cntrl As Control In tblSrcMaterials.Controls
            If TypeOf cntrl Is Label Then
                AddHandler cntrl.Click, AddressOf UnfocusElementOnClick
            End If
        Next
    End Sub

    Private Sub UnfocusElementOnClick() Handles MyBase.Click, tblSrcMaterials.Click
        ActiveControl = Nothing
    End Sub

    Private Sub SourceDimensionsChanged(dtbx As DistanceTextBox, e As EventArgs) Handles dtbxLenFr.LostFocus, dtbxLenBa.LostFocus, dtbxLenCr.LostFocus, dtbxHeight.LostFocus, dtbxCutWidth.LostFocus, dtbxSrcWidth.LostFocus, dtbxSrcLength.LostFocus, dtbxGapCr.LostFocus
        Dim boolIsValidEntry As Boolean = IsValidSrcLengths(dtbxSrcLength, dtbxSrcWidth) And dtbx.Millimetres <> 0

        Select Case dtbx.Name
            Case "dtbxLenFr"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrLenFr.Text
                End If
                dstrLenFr.Text = dtbx.Text
                My.Settings.strLenFr = dstrLenFr.Text
            Case "dtbxLenBa"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrLenBa.Text
                End If
                dstrLenBa.Text = dtbx.Text
                My.Settings.strLenBa = dstrLenBa.Text
            Case "dtbxLenCr"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrLenCr.Text
                End If
                dstrLenCr.Text = dtbx.Text
                My.Settings.strLenCr = dstrLenCr.Text
            Case "dtbxHeight"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrHeight.Text
                End If
                dstrHeight.Text = dtbx.Text
                My.Settings.strHeight = dstrHeight.Text
            Case "dtbxCutWidth"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrCutWidth.Text
                End If
                dstrCutWidth.Text = dtbx.Text
                My.Settings.strCutWidth = dstrCutWidth.Text
            Case "dtbxSrcLength"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrSrcLength.Text
                End If
                dstrSrcLength.Text = dtbx.Text
                My.Settings.strSrcLength = dstrSrcLength.Text
            Case "dtbxSrcWidth"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrSrcWidth.Text
                End If
                dstrSrcWidth.Text = dtbx.Text
                My.Settings.strSrcWidth = dstrSrcWidth.Text
            Case "dtbxGapCr"
                If Not boolIsValidEntry Then
                    dtbx.Text = dstrGapCr.Text
                End If
                dstrGapCr.Text = dtbx.Text
                My.Settings.strGapCr = dstrGapCr.Text
        End Select
    End Sub
    Private Sub SaveGlobalSettings() Handles btnSrcSave.Click
        My.Settings.Save()
    End Sub

    Private Sub FormResized() Handles MyBase.Resize
        Dim bytFontSize As Byte = Math.Floor(tblSrcMaterials.Height / 4 - 8)
        If bytFontSize > 20 Then
            bytFontSize = 20
        End If
        If bytFontSize < 5 Then
            bytFontSize = 5
        End If

        For Each lbl In tblSrcMaterials.Controls.OfType(Of Label)()
            lbl.Font = New Font(Font.Name, bytFontSize, unit:=GraphicsUnit.Pixel)
        Next

        For Each dtbx In tblSrcMaterials.Controls.OfType(Of DistanceTextBox)()
            dtbx.Font = New Font(Font.Name, bytFontSize - 4, unit:=GraphicsUnit.Pixel)
        Next
    End Sub
End Class