Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()
        Dim csvHeader As String = "Company, Name, EmailAddress" & vbCr
        Dim csvBody As New StringBuilder
        'build body
        For Each c As Customer In list
            csvBody.Append(c.Company & ", ")
            csvBody.Append(c.Name & ", ")
            csvBody.Append(c.EmailAddress & vbCr)
        Next
        ViewBag.CsvReport = csvHeader & csvBody.ToString()
        Return View()

    End Function

End Class
