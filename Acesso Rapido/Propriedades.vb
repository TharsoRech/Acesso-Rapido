
Public Class Propriedades
    Public IsfolderPR As Boolean = False
    Public Isfolder As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Caminho.Text <> "" Then
                Process.Start(Caminho.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        Try
            Dim found As Boolean = False
            If IsfolderPR = False Then
                If MetroTabControl1.SelectedTab.Text = "Propriedades" And MetroTextBox1.Text = "" Then
                    Dim arrHeaders(35)
                    Dim shell As New Shell32.Shell
                    Dim objFolder As Shell32.Folder
                    Dim file As String = Caminho.Text & "\" & Descricao.Text
                    objFolder = shell.NameSpace(Caminho.Text)
                    If IO.File.Exists(Caminho.Text & "\" & Descricao.Text) = False Then
                        If Isfolder Then
                            objFolder = shell.NameSpace(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(file)))
                        Else
                            objFolder = shell.NameSpace(IO.Path.GetDirectoryName(file))
                        End If
                    End If
                    For i = 0 To 34
                        arrHeaders(i) = objFolder.GetDetailsOf(objFolder.Items, i)
                    Next
                    For Each strFileName In objFolder.Items
                        For i = 0 To 34
                            If objFolder.GetDetailsOf(strFileName, i) <> "" Then
                                If arrHeaders(i).ToString = "Nome" Then
                                    If Isfolder Then
                                        If objFolder.GetDetailsOf(strFileName, i) = (Descricao.Text) = False Then
                                            Exit For
                                        End If
                                    Else
                                        If objFolder.GetDetailsOf(strFileName, i).Contains(Descricao.Text) = False Then
                                            Exit For
                                        End If
                                    End If
                                End If
                                MetroTextBox1.Text = MetroTextBox1.Text & arrHeaders(i) & ": " & objFolder.GetDetailsOf(strFileName, i) & Environment.NewLine
                                End If
                        Next
                    Next
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Form1.asadmin = True Then
                Process.Start(Caminho.Text)
            Else
                Login.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class