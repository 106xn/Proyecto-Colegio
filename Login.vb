Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TxtBoxUsuario_Click(sender As Object, e As EventArgs) Handles TxtBoxUsuario.Click
        TxtBoxUsuario.Text = ""
        TxtBoxUsuario.Focus()

    End Sub

    Private Sub TxtBoxPasswd_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPasswd.TextChanged
        TxtBoxPasswd.Text = ""
        TxtBoxPasswd.Focus()
    End Sub
End Class
