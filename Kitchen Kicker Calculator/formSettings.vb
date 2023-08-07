Public Class formSettings
    Private Sub MainFormShown() Handles MyBase.Shown
        ' Add keypress handlers to escape textboxes
        Dim apnlPanels = Controls.OfType(Of Panel)()
        For Each pnl In apnlPanels
            Dim atbxTextBoxes = pnl.Controls.OfType(Of TextBox)()
            For Each tbx In atbxTextBoxes
                AddHandler tbx.KeyDown, AddressOf formKeyDown
            Next
        Next
    End Sub

    Private Sub formKeyDown(sender As Object, e As KeyEventArgs)
        If {Keys.Escape, Keys.Enter}.Contains(e.KeyCode) Then
            ActiveControl = Nothing
        End If
    End Sub

    Private Sub UpdateColours() Handles MyBase.Load
        btnBBColour.BackColor = My.Settings.clrBackBoard
        btnCBColour.BackColor = My.Settings.clrCrossBrace
        btnFBColour.BackColor = My.Settings.clrFrontBoard
        tbxBBWidth.Text = My.Settings.bytWidthBa
        tbxCBWidth.Text = My.Settings.bytWidthFr
        tbxFBWidth.Text = My.Settings.bytWidthCr
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

    Private Sub TextBoxFocusLost(sender As TextBox, e As EventArgs) Handles tbxBBWidth.LostFocus, tbxFBWidth.LostFocus, tbxCBWidth.TextChanged
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
            Case "tbxBBWidth"
                tbxBBWidth.Text = My.Settings.bytWidthBa.ToString()
            Case "tbxFBWidth"
                tbxFBWidth.Text = My.Settings.bytWidthFr.ToString()
            Case "tbxCBWidth"
                tbxCBWidth.Text = My.Settings.bytWidthCr.ToString()
        End Select
    End Sub

    Private Sub btnSave_Click() Handles btnSave.Click
        My.Settings.clrBackBoard = btnBBColour.BackColor
        My.Settings.clrFrontBoard = btnFBColour.BackColor
        My.Settings.clrCrossBrace = btnCBColour.BackColor
        My.Settings.bytWidthBa = Val(tbxBBWidth.Text)
        My.Settings.bytWidthFr = Val(tbxFBWidth.Text)
        My.Settings.bytWidthCr = Val(tbxCBWidth.Text)
        My.Settings.Save()
        Me.Close()
    End Sub
End Class