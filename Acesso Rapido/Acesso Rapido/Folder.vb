<Serializable>
Public Class Folder
    Public Nome As String = ""
    Public Arquivos As New List(Of Atalhos)
    Public Criadoem As String = ""
    Public CriadoPor As String = ""
    Public Pastas As New List(Of Folder)
    Public Pasta As String = ""
    Public IsFolderPR As Boolean = False
    Public Adicionadoem As String = ""
End Class
