Imports System.ComponentModel.DataAnnotations
Public Class UserLogin

    <EmailAddress>
    <Required(ErrorMessage:="<font color='red'>El email es requerido</font>")>
    <Display(Name:="Correo Electrónico: ")>
    Public Property Email As String

    <StringLength(100, ErrorMessage:="<font color='red'>El número de caratcteres de {0} debe ser al menos{2}</font>", MinimumLength:=6)>
    <Required(ErrorMessage:="<font color='red'>El password es requerido</font>")>
    <Display(Name:="Password: ")>
    Public Property Password As String

    Public Property UserName As String

    Dim user As New UserDataDataContext
    Public Function Login()
        Dim query = From u In user.usuarios
                    Where u.email = Email And u.password = Password Select u
        If query.Count() > 0 Then
            'Dim query2 = From u In user.usuarios Where u.email = Email Select u
            Dim datos = query.ToList()

            For Each Dato In datos
                UserName = Dato.usuario
            Next
            Return True

        Else
            Return False
        End If
    End Function

End Class
