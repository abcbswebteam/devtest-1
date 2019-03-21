Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        Dim csvHeader As String = "Company, Name, EmailAddress" & vbCr
        Dim csvBody As StringBuilder = New StringBuilder()

        'build body
        For Each c As Customer In list
            csvBody.Append(c.Company).Append(",").Append(c.Name).Append(",").Append("c.EmailAddress").AppendLine()
        Next

        ViewBag.CsvReport = csvHeader & csvBody.ToString()

        Return View()

    End Function

End Class
