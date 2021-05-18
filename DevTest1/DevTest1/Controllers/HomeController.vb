Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        Dim csvHeader As String = "Company, Name, EmailAddress" & vbCr
        Dim csvBody As String = ""
        Dim csvBodySB = New StringBuilder()

        'build body
        For Each c As Customer In list
            csvBodySB.Append(c.Company)
            csvBodySB.Append(", ")
            csvBodySB.Append(c.Name)
            csvBodySB.Append(", ")
            csvBodySB.Append(c.EmailAddress)
            csvBodySB.Append(vbCr)
            'csvBody &= c.Company & ", "
            'csvBody &= c.Name & ", "
            'csvBody &= c.EmailAddress & vbCr
        Next

        ViewBag.CsvReport = csvHeader & csvBodySB.ToString()

        Return View()

    End Function

End Class
