Public Class Form1
    Public database As Database = New Database
    Public LastFolder As String = ""
    Public selectitem As Atalho
    Public asadmin As Boolean = False
    Dim currentlocation As Integer = 40
    Dim countsearch As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim folderdatabase As String = My.Application.Info.DirectoryPath & "\"
            If IO.Directory.Exists(My.Settings.DatabaseLocation) And My.Settings.DatabaseLocation <> "" Then
                folderdatabase = My.Settings.DatabaseLocation & "\"
            Else
                My.Settings.DatabaseLocation = folderdatabase
                My.Settings.Save()
            End If
            If IO.Directory.Exists(My.Settings.DataLocate) Then
                folderdatabase = My.Settings.DataLocate & "\"
                My.Settings.DatabaseLocation = folderdatabase
                My.Settings.Save()
            End If
            If IO.File.Exists(folderdatabase & "Database.ar") Then
                Dim infoReader As System.IO.FileInfo
                infoReader = My.Computer.FileSystem.GetFileInfo(folderdatabase & "Database.ar")
                Dim sizeInBytes As Long = infoReader.Length
                If IO.File.Exists(folderdatabase & "DatabaseBKP.ar") Then
                    Dim infoReader1 As System.IO.FileInfo
                    infoReader1 = My.Computer.FileSystem.GetFileInfo(folderdatabase & "DatabaseBKP.ar")
                    Dim sizeInBytes1 As Long = infoReader1.Length
                    If sizeInBytes = 0 Then
                        IO.File.Delete(folderdatabase & "Database.ar")
                        IO.File.Copy(folderdatabase & "DatabaseBKP.ar", folderdatabase & "Database.ar", True)
                        Application.Restart()
                    End If
                Else
                    IO.File.Copy(folderdatabase & "Database.ar", folderdatabase & "DatabaseBKP.ar", True)
                End If
            End If
            If IO.File.Exists(folderdatabase & "Database.ar") Then
                Dim seri As New ObjectSerializer(Of Database)
                database = seri.GetSerializedObject(folderdatabase & "Database.ar")
                save()
                IO.File.Copy(folderdatabase & "Database.ar", folderdatabase & "DatabaseBKP.ar", True)
            Else
                IO.File.Create(folderdatabase & "Database.ar").Close()
                database = New Database
                database.Pastas = New List(Of Folder)
                database.Atalhos = New List(Of Atalhos)
                save()
                Dim seri3 As New ObjectSerializer(Of Database)
                database = seri3.GetSerializedObject(folderdatabase & "Database.ar")
            End If
            LastFolder = "Inicio"
            CurrentFolder.Text = LastFolder
            Navegador.Controls.Clear()
            Reload()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Reload()
        Try
            Dim count1 As Integer = 0

            Dim nextlevelcount As Integer = 1
            Dim currentlocation As Integer = 40
            For Each f1 As Folder In database.Pastas
                Dim p1 As New Atalho
                p1.MetroButton1.Text = f1.Nome
                p1.Isfolder = True
                p1.PictureBox1.BackgroundImage = ImageList1.Images(0)
                p1.Nome = f1.Nome
                p1.isFolderPR = f1.IsFolderPR
                p1.Adicionadoem = f1.Adicionadoem
                If Navegador.Controls.Count = 0 Then
                    p1.Location = New Point(0, 40)
                Else
                    p1.Location = New Point(0, currentlocation + 75 / 2)
                    currentlocation = p1.Location.Y
                End If
                Navegador.Controls.Add(p1)
                Application.DoEvents()
            Next
            For Each at1 As Atalhos In database.Atalhos
                Dim p1 As New Atalho
                If at1.Isfolder Then
                    p1.PictureBox1.BackgroundImage = ImageList1.Images(1)
                    p1.PictureBox1.BackgroundImageLayout = ImageLayout.Center
                Else
                    If IO.File.Exists(at1.Patch) Then
                        p1.PictureBox1.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon(at1.Patch).ToBitmap
                    Else
                        p1.PictureBox1.BackgroundImage = ImageList1.Images(2)
                    End If
                End If
                p1.Acessadooem = at1.Acessadoem
                p1.Patch = at1.Patch
                p1.MetroButton1.Text = at1.Nome
                p1.Isfolder = at1.Isfolder
                p1.Nome = at1.Nome
                p1.Adicionadoem = at1.Adicionadoem
                at1.Pasta = at1.Pasta
                p1.Extensao = at1.Extensao
                If Navegador.Controls.Count = 0 Then
                    p1.Location = New Point(0, 40)
                Else
                    p1.Location = New Point(0, currentlocation + 75 / 2)
                    currentlocation = p1.Location.Y
                End If
                Navegador.Controls.Add(p1)
                Application.DoEvents()
            Next

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Reload(ByVal foldername As String, ByVal pastas As List(Of Folder))
        Try
            Dim currentlocation As Integer = 40
            If pastas.Count > 0 Then
                For Each f19 As Folder In pastas
                    If f19.Nome = foldername Then
                        For Each f1 As Folder In f19.Pastas
                            Dim p1 As New Atalho
                            p1.MetroButton1.Text = f1.Nome
                            p1.Isfolder = True
                            p1.Pasta = f1.Pasta
                            p1.PictureBox1.BackgroundImage = ImageList1.Images(0)
                            p1.Nome = f1.Nome
                            p1.isFolderPR = f1.IsFolderPR
                            p1.Adicionadoem = f1.Adicionadoem
                            If Navegador.Controls.Count = 0 Then
                                p1.Location = New Point(0, 40)
                            Else
                                p1.Location = New Point(0, currentlocation + 75 / 2)
                                currentlocation = p1.Location.Y
                            End If
                            Navegador.Controls.Add(p1)
                        Next
                        For Each at1 As Atalhos In f19.Arquivos
                            Dim p1 As New Atalho
                            If at1.Isfolder Then
                                p1.PictureBox1.BackgroundImage = ImageList1.Images(1)
                            Else
                                If IO.File.Exists(at1.Patch & "\" & at1.Nome & at1.Extensao) Then
                                    p1.PictureBox1.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon(at1.Patch & "\" & at1.Nome & at1.Extensao).ToBitmap
                                Else
                                    p1.PictureBox1.BackgroundImage = ImageList1.Images(2)
                                End If
                            End If
                            p1.Acessadooem = at1.Acessadoem
                            p1.Patch = at1.Patch
                            p1.MetroButton1.Text = at1.Nome
                            p1.Isfolder = at1.Isfolder
                            p1.Nome = at1.Nome
                            p1.Adicionadoem = at1.Adicionadoem
                            p1.Extensao = at1.Extensao
                            at1.Pasta = at1.Pasta
                            If Navegador.Controls.Count = 0 Then
                                p1.Location = New Point(0, 40)
                            Else
                                p1.Location = New Point(0, currentlocation + 75 / 2)
                                currentlocation = p1.Location.Y
                            End If
                            Navegador.Controls.Add(p1)
                        Next
                    Else
                        Reload(foldername, f19.Pastas)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Try
            AdicionarAtalho.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NovaPastaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaPastaToolStripMenuItem.Click
        Try



            Dim currentlocation As Integer = 40
            If asadmin = True Then
                Dim Prompt As String = "Informe o nome da pasta"
                Dim Titulo As String = "Adicionar pasta"
                Dim valorRetornado As String = ""
                valorRetornado = InputBox(Prompt, Titulo)
                If valorRetornado = "" Then
                    Exit Sub
                End If
                Dim p1 As New Atalho
                Dim f1 As New Folder
                f1.Criadoem = DateAndTime.Now.ToString
                f1.CriadoPor = Environment.UserName
                f1.Nome = valorRetornado
                f1.Pasta = CurrentFolder.Text
                f1.IsFolderPR = True
                f1.Adicionadoem = "Adicionado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                p1.MetroButton1.Text = valorRetornado
                p1.PictureBox1.BackgroundImage = ImageList1.Images(0)

                p1.isFolderPR = True
                p1.Adicionadoem = "Adicionado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName

                If Navegador.Controls.Count = 0 Then
                    p1.Location = New Point(0, 40)
                Else
                    p1.Location = New Point(0, currentlocation + 75 / 2)
                    currentlocation = p1.Location.Y
                End If
                Navegador.Controls.Add(p1)
                If CurrentFolder.Text = "Inicio" Then
                    database.Pastas.Add(f1)
                Else
                    Searchfolder(database.Pastas, f1, CurrentFolder.Text)
                End If
                save()
                Navegador.Controls.Clear()
                If CurrentFolder.Text = "Inicio" Then
                    Navegador.Controls.Clear()
                    Reload()
                Else
                    Navegador.Controls.Clear()
                    Reload(CurrentFolder.Text, database.Pastas)
                End If
            Else
                Login.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub save()
        Try
            Dim seri As New ObjectSerializer(Of Database)
            seri.SaveSerializedObject(database, My.Settings.DatabaseLocation & "Database.ar")
        Catch ex As Exception

        End Try
    End Sub





    Public Sub Addatalho(ByVal at As Atalhos, ByVal fold1 As List(Of Folder))
        Try
            If database.Pastas.Count = 0 Or CurrentFolder.Text = "Inicio" Then
                database.Atalhos.Add(at)
                save()
                Exit Sub
            End If
            For Each f1 As Folder In fold1
                If f1.Nome = CurrentFolder.Text Then
                    f1.Arquivos.Add(at)
                    save()
                    Exit Sub
                Else
                    Addatalho(at, f1.Pastas)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub


    Public Sub removeratalho(ByVal at As Atalhos, ByVal fold1 As List(Of Folder))
        Try
            Dim found As Boolean = False
            If CurrentFolder.Text = "Inicio" Then
                For Each x1 As Atalhos In database.Atalhos
                    If x1.Nome = at.Nome Then
                        database.Atalhos.Remove(x1)
                        Exit For
                    End If
                Next
                For Each x10 As Folder In fold1
                    If x10.Nome = at.Nome Then
                        database.Pastas.Remove(x10)
                        Exit For
                    End If
                Next
                save()
                Navegador.Controls.Clear()
                Reload()
            Else
                For Each f1 As Folder In fold1
                    If at.Pasta = "" Then
                        at.Pasta = CurrentFolder.Text
                        save()
                    End If
                    If f1.Nome = at.Pasta Then
                        If f1.Pastas.Count > 0 Then
                            For Each f2 As Folder In f1.Pastas
                                If f2.Nome = at.Nome Then
                                    f1.Pastas.Remove(f2)
                                    save()
                                    Navegador.Controls.Clear()
                                    Reload(f1.Nome, database.Pastas)
                                    found = True
                                    Exit For
                                End If
                            Next
                            For Each f12 As Atalhos In f1.Arquivos
                                If f12.Nome = at.Nome Then
                                    f1.Arquivos.Remove(f12)
                                    save()
                                    Navegador.Controls.Clear()
                                    Reload(f1.Nome, database.Pastas)
                                    found = True
                                    Exit For
                                End If
                            Next
                        Else
                            For Each f2 As Atalhos In f1.Arquivos
                                If f2.Nome = at.Nome Then
                                    f1.Arquivos.Remove(f2)
                                    save()
                                    Navegador.Controls.Clear()
                                    Reload(f1.Nome, database.Pastas)
                                    found = True
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                    If found = False Then
                        removeratalho(at, f1.Pastas)
                    End If
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub acessaratalho(ByVal at As Atalhos, ByVal fold1 As List(Of Folder), ByVal acessadoem As String)
        Try
            Dim found As Boolean = False
            If CurrentFolder.Text = "Inicio" Then
                For Each x1 As Atalhos In database.Atalhos
                    If x1.Nome = at.Nome Then
                        x1.Acessadoem = acessadoem
                        Exit For
                    End If
                Next
                save()
            Else
                For Each f1 As Folder In fold1
                    If at.Pasta = "" Then
                        at.Pasta = CurrentFolder.Text
                        save()
                    End If
                    If f1.Nome = at.Pasta Then
                        If f1.Pastas.Count > 0 Then
                            For Each f12 As Atalhos In f1.Arquivos
                                If f12.Nome = at.Nome Then
                                    f12.Acessadoem = acessadoem
                                    save()
                                    found = True
                                    Exit For
                                End If
                            Next
                        Else
                            For Each f2 As Atalhos In f1.Arquivos
                                If f2.Nome = at.Nome Then
                                    f2.Acessadoem = acessadoem
                                    save()
                                    found = True
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                    If found = False Then
                        acessaratalho(at, f1.Pastas, acessadoem)
                    Else
                        Application.DoEvents()
                    End If
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Searchfolderremove(ByVal f1 As Folder, ByVal at As Atalhos)
        Try
            If f1.Pastas.Count > 0 Then
                For Each f10 As Folder In f1.Pastas
                    If f10.Nome = at.Pasta Then
                        For Each f2 As Folder In f10.Pastas
                            If f2.Nome = at.Nome Then
                                f10.Pastas.Remove(f2)
                                save()
                                Navegador.Controls.Clear()
                                Reload(f1.Nome, database.Pastas)
                                Exit For
                            End If
                        Next
                    Else
                        Searchfolderremove(f10, at)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Searchfilerremove(ByVal f1 As String, ByVal at As Atalhos, ByVal pastas As List(Of Folder))
        Try
            If pastas.Count > 0 Then
                For Each f10 As Folder In pastas
                    If f10.Nome = at.Pasta Then
                        f10.Arquivos.Remove(at)
                        save()
                        Navegador.Controls.Clear()
                        Reload(f10.Nome, database.Pastas)
                        Exit For
                    Else
                        Searchfilerremove(f1, at, f10.Pastas)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function convertto(ByVal at As Atalho) As Atalhos
        Dim newat As New Atalhos
        Try
            newat.Nome = at.Nome
            newat.Patch = at.Patch
            newat.isFolderPR = at.isFolderPR
            newat.Isfolder = at.Isfolder
            newat.Pasta = at.Pasta
            newat.Extensao = at.Extensao
            newat.Adicionadoem = at.Adicionadoem
            Return newat
        Catch ex As Exception
            Return newat
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MetroPanel1.Dock = DockStyle.Bottom Then
                MetroPanel1.Dock = DockStyle.Top
                Button5.Visible = True
                Button2.Visible = True
                Button3.Visible = True
                Button4.Visible = True
                LastFolder = CurrentFolder.Text
            End If
            Navegador.Controls.Clear()
            If LastFolder = "Inicio" Then
                Reload()
                CurrentFolder.Text = "Inicio"
                Application.DoEvents()
                Exit Sub
            End If
            Reload(LastFolder, database.Pastas)
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If asadmin = True Then
                AdicionarAtalho.Show()
            Else
                Login.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try



            Dim currentlocation As Integer = 40
            If asadmin = True Then

                Dim Prompt As String = "Informe o nome da pasta"
                Dim Titulo As String = "Adicionar pasta"
                Dim valorRetornado As String = ""
                valorRetornado = InputBox(Prompt, Titulo)
                If valorRetornado = "" Then
                    Exit Sub
                End If
                Dim p1 As New Atalho
                Dim f1 As New Folder
                f1.Criadoem = DateAndTime.Now.ToString
                f1.CriadoPor = Environment.UserName
                f1.Nome = valorRetornado
                f1.Pasta = CurrentFolder.Text
                f1.IsFolderPR = True
                f1.Adicionadoem = "Adicionado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName
                p1.MetroButton1.Text = valorRetornado
                p1.PictureBox1.BackgroundImage = ImageList1.Images(0)

                p1.AutoSize = True
                p1.Nome = valorRetornado
                p1.isFolderPR = True
                p1.Adicionadoem = "Adicionado em:" & Space(2) & DateAndTime.Now.ToString & ",Por:" & Space(2) & Environment.UserName

                If Navegador.Controls.Count = 0 Then
                    p1.Location = New Point(0, 40)
                Else
                    p1.Location = New Point(0, currentlocation + 75 / 2)
                    currentlocation = p1.Location.Y
                End If
                Navegador.Controls.Add(p1)
                If CurrentFolder.Text = "Inicio" Then
                    database.Pastas.Add(f1)
                Else
                    Searchfolder(database.Pastas, f1, CurrentFolder.Text)
                End If
                save()

                If CurrentFolder.Text = "Inicio" Then
                    Navegador.Controls.Clear()
                    Reload()
                Else
                    Navegador.Controls.Clear()
                    Reload(CurrentFolder.Text, database.Pastas)
                End If
            Else
                Login.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Searchfolder(ByVal f1 As List(Of Folder), ByVal at As Folder, ByVal currentfoldertext As String)
        Try
            If f1.Count > 0 Then
                For Each f10 As Folder In f1
                    If f10.Nome = currentfoldertext Then
                        f10.Pastas.Add(at)
                        save()
                    Else
                        Searchfolder(f10.Pastas, at, currentfoldertext)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If CurrentFolder.Text = "Inicio" Then
                Exit Sub
            End If
            Navegador.Controls.Clear()
            Searchfolderandreload(database.Pastas, CurrentFolder.Text)
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Searchfolderandreload(ByVal f1 As List(Of Folder), ByVal currentfoldertext As String)
        Try
            If f1.Count > 0 Then
                For Each f10 As Folder In f1
                    If f10.Nome = currentfoldertext Then
                        If f10.Pasta = "Inicio" Then
                            Reload()
                            CurrentFolder.Text = "Inicio"
                            Exit Sub
                        End If
                        Reload(f10.Pasta, database.Pastas)
                        CurrentFolder.Text = f10.Pasta
                    Else
                        Searchfolderandreload(f10.Pastas, currentfoldertext)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Try
                If CurrentFolder.Text = "Inicio" Then
                    Navegador.Controls.Clear()
                    Reload()
                Else
                    Navegador.Controls.Clear()
                    Reload(CurrentFolder.Text, database.Pastas)
                End If
                Application.DoEvents()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            countsearch = 0
            Navegador.Controls.Clear()
            pesquisar(Pesquisartexto.Text)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub pesquisar(ByVal texto As String)
        Try
            currentlocation = 40
            For Each f19 As Folder In database.Pastas
                For Each f1 As Folder In f19.Pastas
                    If f1.Nome.ToLower.Contains(texto.ToLower) Or findbetween(f1.Nome, texto) = True Then
                        countsearch = countsearch + 1
                        Dim p1 As New Atalho
                        p1.MetroButton1.Text = f1.Nome
                        p1.Isfolder = True
                        p1.Pasta = f1.Pasta
                        p1.PictureBox1.BackgroundImage = ImageList1.Images(0)
                        p1.Nome = f1.Nome
                        p1.isFolderPR = f1.IsFolderPR
                        p1.Adicionadoem = f1.Adicionadoem
                        If Navegador.Controls.Count = 0 Then
                            p1.Location = New Point(0, 40)
                        Else
                            p1.Location = New Point(0, currentlocation + 75 / 2)
                            currentlocation = p1.Location.Y
                        End If
                        Navegador.Controls.Add(p1)
                    End If
                Next
                For Each at1 As Atalhos In f19.Arquivos
                    If at1.Nome.ToLower.Contains(texto.ToLower) Or findbetween(at1.Nome, texto) = True Then
                        countsearch = countsearch + 1
                        Dim p1 As New Atalho
                        If at1.Isfolder Then
                            p1.PictureBox1.BackgroundImage = ImageList1.Images(1)
                        Else
                            If IO.File.Exists(at1.Patch & "\" & at1.Nome & at1.Extensao) Then
                                p1.PictureBox1.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon(at1.Patch & "\" & at1.Nome & at1.Extensao).ToBitmap
                            Else
                                p1.PictureBox1.BackgroundImage = ImageList1.Images(2)
                            End If
                        End If
                        p1.Acessadooem = at1.Acessadoem
                        p1.Patch = at1.Patch
                        p1.MetroButton1.Text = at1.Nome
                        p1.Isfolder = at1.Isfolder
                        p1.Nome = at1.Nome
                        p1.Adicionadoem = at1.Adicionadoem
                        p1.Extensao = at1.Extensao
                        at1.Pasta = at1.Pasta
                        If Navegador.Controls.Count = 0 Then
                            p1.Location = New Point(0, 40)
                        Else
                            p1.Location = New Point(0, currentlocation + 75 / 2)
                            currentlocation = p1.Location.Y
                        End If
                        Navegador.Controls.Add(p1)
                    End If
                Next
                If f19.Pastas.Count > 0 Then
                    pesquisar(texto, f19.Pastas)
                End If
            Next
            If countsearch = 0 Then
                CurrentFolder.Text = "Inicio"
                Button5.PerformClick()
                MetroFramework.MetroMessageBox.Show(Me, "Nenhum arquivo ou pasta achada com essa descrição ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function findbetween(ByVal texto As String, ByVal palavra As String) As Boolean
        Dim find As Boolean = False
        Try
            Dim words() As String = texto.Split(Microsoft.VisualBasic.ChrW(32))
            For Each word As String In words
                If word.ToLower.Contains(palavra.ToLower) Then
                    find = True
                    Return find
                End If
            Next
            Return find
        Catch ex As Exception
            Return find
        End Try
    End Function
    Public Sub pesquisar(ByVal texto As String, ByVal listadepastas As List(Of Folder))
        Try
            For Each f19 As Folder In listadepastas
                For Each f1 As Folder In f19.Pastas
                    If f1.Nome.ToLower.Contains(texto.ToLower) Or findbetween(f1.Nome, texto) = True Then
                        countsearch = countsearch + 1
                        Dim p1 As New Atalho
                        p1.MetroButton1.Text = f1.Nome
                        p1.Isfolder = True
                        p1.Pasta = f1.Pasta
                        p1.PictureBox1.BackgroundImage = ImageList1.Images(0)
                        p1.Nome = f1.Nome
                        p1.isFolderPR = f1.IsFolderPR
                        p1.Adicionadoem = f1.Adicionadoem
                        If Navegador.Controls.Count = 0 Then
                            p1.Location = New Point(0, 40)
                        Else
                            p1.Location = New Point(0, currentlocation + 75 / 2)
                            currentlocation = p1.Location.Y
                        End If
                        Navegador.Controls.Add(p1)
                    End If
                Next
                For Each at1 As Atalhos In f19.Arquivos
                    If at1.Nome.ToLower.Contains(texto.ToLower) Or findbetween(at1.Nome, texto) = True Then
                        countsearch = countsearch + 1
                        Dim p1 As New Atalho
                        If at1.Isfolder Then
                            p1.PictureBox1.BackgroundImage = ImageList1.Images(1)
                        Else
                            If IO.File.Exists(at1.Patch & "\" & at1.Nome & at1.Extensao) Then
                                p1.PictureBox1.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon(at1.Patch & "\" & at1.Nome & at1.Extensao).ToBitmap
                            Else
                                p1.PictureBox1.BackgroundImage = ImageList1.Images(2)
                            End If
                        End If
                        p1.Acessadooem = at1.Acessadoem
                        p1.Patch = at1.Patch
                        p1.MetroButton1.Text = at1.Nome
                        p1.Isfolder = at1.Isfolder
                        p1.Nome = at1.Nome
                        p1.Adicionadoem = at1.Adicionadoem
                        p1.Extensao = at1.Extensao
                        at1.Pasta = at1.Pasta
                        If Navegador.Controls.Count = 0 Then
                            p1.Location = New Point(0, 40)
                        Else
                            p1.Location = New Point(0, currentlocation + 75 / 2)
                            currentlocation = p1.Location.Y
                        End If
                        Navegador.Controls.Add(p1)
                    End If
                Next
                If f19.Pastas.Count > 0 Then
                    pesquisar(texto, f19.Pastas)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
