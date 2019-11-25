Imports System.Threading.Tasks
Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function

        <AllowAnonymous>
        Function Usuarios() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Usuarios(dato As UserLogin) As Task(Of ActionResult)

            If ModelState.IsValid Then
                If dato.Login() = True Then
                    Session("userName") = dato.UserName
                    Return View()
                Else
                    Return View("Index")
                End If
            Else
                Return View("Index")
            End If
        End Function

    End Class
End Namespace