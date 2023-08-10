Public Class formDiagramSettings
    Dim test As UInt16 = 0
    Private Sub UpdateColours() Handles MyBase.Load
        btnBBColour.BackColor = My.Settings.clrBackBoard
        btnCBColour.BackColor = My.Settings.clrCrossBrace
        btnFBColour.BackColor = My.Settings.clrFrontBoard
        etbxWidthBa.Text = My.Settings.bytWidthBa
        etbxWidthFr.Text = My.Settings.bytWidthFr
        etbxWidthCr.Text = My.Settings.bytWidthCr
    End Sub

    Private Sub BtnColourClick(sender As Button, e As EventArgs) Handles btnBBColour.Click, btnFBColour.Click, btnCBColour.Click
        Dim drResult As DialogResult = cdColourDialog.ShowDialog()

        If drResult <> vbCancel Then
            ' Update colour of buttons
            Select Case sender.Name
                Case "btnBBColour"
                    btnBBColour.BackColor = cdColourDialog.Color
                Case "btnFBColour"
                    btnFBColour.BackColor = cdColourDialog.Color
                Case "btnCBColour"
                    btnCBColour.BackColor = cdColourDialog.Color
            End Select
        End If
    End Sub

    Private Sub TextBoxFocusLost(sender As TextBox, e As EventArgs) Handles etbxWidthBa.LostFocus, etbxWidthFr.LostFocus, etbxWidthCr.TextChanged
        ' Validate input
        Dim strInput As String = sender.Text

        ' Exit sub if input is a number less than 19
        If IsNumeric(strInput) Then
            If Val(strInput) < 19 Then
                Exit Sub
            End If
        End If

        ' Revert inputs back to original value
        Select Case sender.Name
            Case "etbxWidthBa"
                etbxWidthBa.Text = My.Settings.bytWidthBa.ToString()
            Case "etbxWidthFr"
                etbxWidthFr.Text = My.Settings.bytWidthFr.ToString()
            Case "etbxWidthCr"
                etbxWidthCr.Text = My.Settings.bytWidthCr.ToString()
        End Select
    End Sub

    Private Sub SaveButtonClick() Handles btnSave.Click
        test = tblMain.Controls.OfType(Of Label)()(0).Size.Width
        My.Settings.clrBackBoard = btnBBColour.BackColor
        My.Settings.clrFrontBoard = btnFBColour.BackColor
        My.Settings.clrCrossBrace = btnCBColour.BackColor
        My.Settings.bytWidthBa = Val(etbxWidthBa.Text)
        My.Settings.bytWidthFr = Val(etbxWidthFr.Text)
        My.Settings.bytWidthCr = Val(etbxWidthCr.Text)
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub FormResized() Handles MyBase.Resize
        Dim bytFontSize As Byte = Math.Floor(tblMain.Height / 6 - 8)
        If bytFontSize > 30 Then
            bytFontSize = 30
        End If
        If bytFontSize < 5 Then
            bytFontSize = 5
        End If

        For Each lbl In tblMain.Controls.OfType(Of Label)()
            lbl.Font = New Font(Font.Name, bytFontSize, unit:=GraphicsUnit.Pixel)
        Next

        For Each etbx In tblMain.Controls.OfType(Of EscapableTextBox)()
            etbx.Font = New Font(Font.Name, bytFontSize - 4, unit:=GraphicsUnit.Pixel)
        Next

        btnSave.Font = New Font(Font.Name, bytFontSize - 4, unit:=GraphicsUnit.Pixel)
    End Sub
End Class