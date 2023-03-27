Imports System.Data.SqlClient

Public Class UsuariosOK
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Panel3.Visible = True
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try

            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombres", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@Login", TxtUsuario.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()

        Catch ex As Exception : MsgBox(ex.Message)

        End Try


    End Sub
    Sub MOSTRAR()
        Dim DT As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(DT)
            DataListado.DataSource = DT
            cerrar()
            MOSTRAR()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Shared Function DataSource() As DataTable
        Throw New NotImplementedException()
    End Function
End Class