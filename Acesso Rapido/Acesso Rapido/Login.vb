Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Senha.Text = Form1.database.Senhaadmin Then
                Form1.asadmin = True
                Form1.Text = Form1.Text & Space(2) & "- Administrador"
                Form1.Refresh()
                Me.Close()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Senha errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Senhaatual.Text = Form1.database.Senhaadmin Then
                Form1.database.Senhaadmin = NovaSenha.Text
                Form1.save()
                MetroFramework.MetroMessageBox.Show(Me, "Senha alterada com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Senha errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SenhaText_Click1(sender As Object, e As KeyEventArgs) Handles Senha.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Button2.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class