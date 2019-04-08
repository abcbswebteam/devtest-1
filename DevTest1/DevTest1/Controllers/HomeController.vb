Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        'Using StringBuilder instead of String
        Dim csvHeader As StringBuilder = New StringBuilder()
        csvHeader.Append("Company, Name, EmailAddress" & vbCr)
        Dim csvBody As StringBuilder = New StringBuilder()

        'build body
        For Each c As Customer In list
            csvBody.Append(c.Company & ", " & c.Name + ", " + c.EmailAddress & vbCr)
        Next

        ViewBag.CsvReport = csvHeader.Append(csvBody)

        Return View()

    End Function

End Class
