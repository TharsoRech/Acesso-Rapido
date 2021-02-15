Public Class AdicionarAtalho
    Public Lastsize As Integer = 0
    Public LastLoc As Integer = 0
    Public LastColumn As Integer = 0
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim currentlocation As Integer = 40
            For Each x1 As GongSolutions.Shell.ShellItem In ShellView1.SelectedItems
                Dim p1 As New Atalho
                p1.PictureBox1.BackgroundImage = x1.ShellIcon.ToBitmap
                p1.Nome = x1.DisplayName
                If IO.Directory.Exists(x1.FileSystemPath) = False Then
                    p1.Patch = ShellView1.CurrentFolder.FileSystemPath
                Else
                    p1.Patch = x1.FileSystemPath
                End If
                p1.MetroButton1.Text = x1.DisplayName
                p1.Isfolder = x1.IsFolder
                p1.isFolderPR = False
                p1.Pasta = Form1.CurrentFolder.Text
                p1.Adicionadoem = "Adicionado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                p1.Extensao = IO.Path.GetExtension(x1.FileSystemPath)
                If Form1.Navegador.Controls.Count = 0 Then
                    p1.Location = New Point(0, 40)
                Else
                    p1.Location = New Point(0, currentlocation + 75 / 2)
                    currentlocation = p1.Location.Y
                End If
                Form1.Navegador.Controls.Add(p1)
                Form1.Addatalho(Form1.convertto(p1), Form1.database.Pastas)

            Next
            If Form1.CurrentFolder.Text = "Inicio" Then
                Form1.Navegador.Controls.Clear()
                Form1.Reload()
            Else
                Form1.Navegador.Controls.Clear()
                Form1.Reload(Form1.CurrentFolder.Text, Form1.database.Pastas)
            End If
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub


End Class