Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        Dim csvHeader As String = "Company, Name, EmailAddress" & vbCr
        Dim sb As New System.Text.StringBuilder
        'build body
        For Each c As Customer In list
            'csvBody &= c.Company & ", "
            'csvBody &= c.Name & ", "
            'csvBody &= c.EmailAddress & vbCr
            sb.AppendLine($"{c.Company}, {c.Name}, {c.EmailAddress}")
        Next
        Dim csvBody As String = sb.ToString()
        ViewBag.CsvReport = csvHeader & csvBody

        Return View()

    End Function

End Class
