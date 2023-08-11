Public Class EscapableTextBox
    Inherits System.Windows.Forms.TextBox



    ' PRIVATE EVENT HANDLERS
    Private Sub TbxKeyDown(sender As EscapableTextBox, e As KeyEventArgs) Handles Me.KeyDown
        ' pressing esc or enter keys will break focus
        If {Keys.Escape, Keys.Enter}.Contains(e.KeyCode) Then
            sender.FindForm().ActiveControl = Nothing
        End If
    End Sub
End Class
