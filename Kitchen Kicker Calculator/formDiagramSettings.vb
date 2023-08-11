Public Class formDiagramSettings
    ' VARIABLES
    Dim test As UInt16 = 0

    ' EVENT HANDLERS
    '' Form events
    Private Sub UpdateColours() Handles MyBase.Load
        ' When form loads update all inputs to be value stored in settings
        btnBBColour.BackColor = My.Settings.clrBackBoard
        btnCBColour.BackColor = My.Settings.clrCrossBrace
        btnFBColour.BackColor = My.Settings.clrFrontBoard
        etbxWidthBa.Text = My.Settings.bytWidthBa
        etbxWidthFr.Text = My.Settings.bytWidthFr
        etbxWidthCr.Text = My.Settings.bytWidthCr
    End Sub
    Private Sub AdjustFont() Handles MyBase.Resize ' On resize adjust font
        ' Font size = table height / table row count - 8 (for padding)
        Dim bytFontSize As Byte = Math.Floor(tblMain.Height / tblMain.RowCount - 8)

        ' Clamp font size to valid range of 5-30
        If bytFontSize > 30 Then
            bytFontSize = 30
        End If
        If bytFontSize < 5 Then
            bytFontSize = 5
        End If

        ' Apply font to components
        For Each lbl In tblMain.Controls.OfType(Of Label)()
            lbl.Font = New Font(Font.Name, bytFontSize, unit:=GraphicsUnit.Pixel)
        Next

        ' Buttons and textboxes have slightly smaller fonts for extra padding
        For Each etbx In tblMain.Controls.OfType(Of EscapableTextBox)()
            etbx.Font = New Font(Font.Name, bytFontSize - 4, unit:=GraphicsUnit.Pixel)
        Next
        btnSave.Font = New Font(Font.Name, bytFontSize - 4, unit:=GraphicsUnit.Pixel)
    End Sub

    '' Inputs changed
    Private Sub BtnColourClick(btnSender As Button, e As EventArgs) Handles btnBBColour.Click, btnFBColour.Click, btnCBColour.Click
        ' Get colour selected
        Dim drResult As DialogResult = cdColourDialog.ShowDialog()

        ' Ensure that dialog action wasn't cancelled
        If drResult <> vbCancel Then Exit Sub

        ' Find which button was clicked
        ' Update colour depending on which button was clicked
        Select Case btnSender.Name
            Case "btnBBColour"
                btnBBColour.BackColor = cdColourDialog.Color
            Case "btnFBColour"
                btnFBColour.BackColor = cdColourDialog.Color
            Case "btnCBColour"
                btnCBColour.BackColor = cdColourDialog.Color
        End Select
    End Sub
    Private Sub TextBoxFocusLost(tbxSender As EscapableTextBox, e As EventArgs) Handles etbxWidthBa.LostFocus, etbxWidthFr.LostFocus, etbxWidthCr.TextChanged
        ' Validate input
        Dim strInput As String = tbxSender.Text

        ' Exit sub if input is a number less than 19
        If IsNumeric(strInput) Then
            If Val(strInput) < 20 Then
                Exit Sub
            End If
        End If

        ' Revert inputs back to original value because input was invalid
        Select Case tbxSender.Name
            Case "etbxWidthBa"
                etbxWidthBa.Text = My.Settings.bytWidthBa.ToString()
            Case "etbxWidthFr"
                etbxWidthFr.Text = My.Settings.bytWidthFr.ToString()
            Case "etbxWidthCr"
                etbxWidthCr.Text = My.Settings.bytWidthCr.ToString()
        End Select
        Warning("Maximum Value is 20")
    End Sub
    Private Sub SaveButtonClick() Handles btnSave.Click
        ' Set settings values to be equal to input control values
        My.Settings.clrBackBoard = btnBBColour.BackColor
        My.Settings.clrFrontBoard = btnFBColour.BackColor
        My.Settings.clrCrossBrace = btnCBColour.BackColor
        My.Settings.bytWidthBa = Val(etbxWidthBa.Text)
        My.Settings.bytWidthFr = Val(etbxWidthFr.Text)
        My.Settings.bytWidthCr = Val(etbxWidthCr.Text)

        ' Save and close
        My.Settings.Save()
        Me.Close()
    End Sub
End Class