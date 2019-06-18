Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        Dim csvHeader As String = "Company, Name, EmailAddress" & vbCr
        Dim csvBody As String = ""
        Dim csvBodyStringBuilder As StringBuilder = New StringBuilder()
        ''build body
        'For Each c As Customer In list
        '    csvBody &= c.Company & ", "
        '    csvBody &= c.Name & ", "
        '    csvBody &= c.EmailAddress & vbCr
        'Next

        'build body
        For Each c As Customer In list
            csvBodyStringBuilder.Append(c.Company)
            csvBodyStringBuilder.Append(",")
            csvBodyStringBuilder.Append(c.Name)
            csvBodyStringBuilder.Append(",")
            csvBodyStringBuilder.Append(c.EmailAddress)
            csvBodyStringBuilder.Append(vbCr)
        Next

        'ViewBag.CsvReport = csvHeader & csvBody
        ViewBag.CsvReport = csvHeader & csvBodyStringBuilder.ToString()

        Return View()

    End Function

End Class
