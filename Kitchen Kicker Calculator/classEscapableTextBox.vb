Public Class EscapableTextBox
    Inherits System.Windows.Forms.TextBox

    Private Sub TbxKeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' esc & enter will break focus
        If {Keys.Escape, Keys.Enter}.Contains(e.KeyCode) Then
            FindForm().ActiveControl = Nothing
        End If
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub
End Class
