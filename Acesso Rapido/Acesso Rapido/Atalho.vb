Public Class Atalho
    Public Nome As String = ""
    Public Patch As String = ""
    Public Pasta As String = ""
    Public Isfolder As Boolean = False
    Public isFolderPR As Boolean = False
    Public Adicionadoem As String = ""
    Public Acessadooem As String = ""
    Public Extensao As String = ""


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click, Me.Click
        Try
            Form1.selectitem = Me
            If IO.File.Exists(Patch) Then
                Process.Start(Patch)
                Acessadooem = "Acessado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                Form1.acessaratalho(Form1.convertto(Me), Form1.database.Pastas, Acessadooem)
            Else
                If isFolderPR Then
                    Form1.LastFolder = Form1.CurrentFolder.Text
                    Form1.CurrentFolder.Text = Nome
                    Form1.Navegador.Controls.Clear()
                    Form1.Reload(Nome, Form1.database.Pastas)
                    Exit Sub
                End If
                If Isfolder Then
                    Form1.Navegador.Controls.Clear()
                    Dim newexp As New ExplorerIn
                    Form1.Navegador.Controls.Add(newexp)
                    newexp.Dock = DockStyle.Fill
                    Form1.MetroPanel1.Dock = DockStyle.Bottom
                    Form1.Button5.Visible = False
                    Form1.Button2.Visible = False
                    Form1.Button3.Visible = False
                    Form1.Button4.Visible = False
                    newexp.ShellView1.Navigate(Patch)
                End If
                If isFolderPR = False And Isfolder = False Then
                    If Nome.Contains(Extensao) Then
                        Process.Start(Patch & "\" & Nome)
                    Else
                        Process.Start(Patch & "\" & Nome & Extensao)
                    End If
                    Acessadooem = "Acessado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                    Form1.acessaratalho(Form1.convertto(Me), Form1.database.Pastas, Acessadooem)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Form1, "Arquivo não encontrado verifique se o arquivo está no caminho indicado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If Form1.asadmin = True Then
                Form1.selectitem = Me
                Form1.removeratalho(Form1.convertto(Me), Form1.database.Pastas)
                Form1.Navegador.Controls.Clear()
                If Form1.CurrentFolder.Text = "Inicio" Then
                    Form1.Reload()
                Else
                    Form1.Reload(Form1.CurrentFolder.Text, Form1.database.Pastas)
                End If

            Else
                Login.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If Isfolder Then
                If IO.Directory.Exists(Patch) Then
                    Process.Start(Patch)
                End If
            Else
                If IO.File.Exists(Patch) Then
                    Process.Start(Patch)
                    Acessadooem = "Acessado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                    Form1.acessaratalho(Form1.convertto(Me), Form1.database.Pastas, Acessadooem)
                Else
                    If Nome.Contains(Extensao) Then
                        Process.Start(Patch & "\" & Nome)
                    Else
                        Process.Start(Patch & "\" & Nome & Extensao)
                    End If
                    Acessadooem = "Acessado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                    Form1.acessaratalho(Form1.convertto(Me), Form1.database.Pastas, Acessadooem)
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Form1, "Arquivo não encontrado verifique se o arquivo está no caminho indicado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If Form1.asadmin = True Then
                If Isfolder Then
                    If IO.Directory.Exists(Patch) Then
                        Process.Start(Patch)
                    End If
                Else
                    If IO.File.Exists(Patch) Then
                        Process.Start(IO.Path.GetDirectoryName(Patch))
                    Else
                        Process.Start(Patch)
                    End If
                End If
            Else
                Login.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PropriedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriedadesToolStripMenuItem.Click
        Try
            Propriedades.Show()
            Propriedades.Descricao.Text = Nome
            Propriedades.Adicionadoem.Text = Adicionadoem
            Propriedades.Acessadoem.Text = Acessadooem
            If Isfolder Then
                Propriedades.Caminho.Text = Patch
            Else
                If IO.File.Exists(Patch) Then
                    Propriedades.Caminho.Text = IO.Path.GetDirectoryName(Patch)
                Else
                    Propriedades.Caminho.Text = Patch
                End If
            End If
            If isFolderPR Then
                Propriedades.IsfolderPR = True
                Propriedades.TabPage2.Enabled = False
            End If
            If Isfolder Then
                Propriedades.Isfolder = True
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
