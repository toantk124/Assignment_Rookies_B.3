Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Details() As ActionResult
            Return View()
        End Function

        Function ProductRating() As ActionResult
            Return View()
        End Function
    End Class
End Namespace