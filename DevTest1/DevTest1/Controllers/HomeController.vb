Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        Dim sb As New StringBuilder()
        sb.Append("Company, Name, EmailAddress" & vbCr)

        'build body
        For Each c As Customer In list
            sb.Append($"{c.Company}, {c.Name}, {c.EmailAddress}" + vbCr)
        Next

        ViewBag.CsvReport = sb.ToString()

        Return View()

    End Function

End Class
