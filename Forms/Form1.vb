Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Form1
    Dim PATH As String = "C:\Users\Trizzia Loren\source\repos\Forms"
    Public Property JsonConvert As Object
    Public Property Newtonsoft As Object

    Class formInput
        Public name As String
        Public age As Int32
        Public address As String
    End Class

    Private Sub TextAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextAge_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextAge.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextAge.Text = digitsOnly.Replace(TextAge.Text, "")
    End Sub

    Private Sub SaveTxt_Click(sender As Object, e As EventArgs) Handles SaveTxt.Click
        My.Computer.FileSystem.WriteAllText(PATH & ".txt", "", True)
        Dim objWriter As New System.IO.StreamWriter(PATH & ".txt")

        objWriter.WriteLine("Name:" & ControlChars.Tab & ControlChars.Tab & TextName.Text)
        objWriter.WriteLine("Age:" & ControlChars.Tab & ControlChars.Tab & TextAge.Text)
        objWriter.WriteLine("Address:" & ControlChars.Tab & TextAddress.Text)

        objWriter.Close()
    End Sub

    Private Sub SaveXml_Click(sender As Object, e As EventArgs) Handles SaveXml.Click
        Dim xmlDeclaration As New XDeclaration("1.0", "UTF-8", "yes")
        Dim doc As XDocument =
            New XDocument(xmlDeclaration,
                          New XElement("Form",
                                       New XElement("name", "" & TextName.Text),
                                       New XElement("age", "" & TextAge.Text),
                                       New XElement("address", "" & TextAddress.Text)
                                      )
                          )

        doc.Save(PATH & ".xml")
    End Sub

    Private Sub SaveJson_Click(sender As Object, e As EventArgs) Handles SaveJson.Click
        Dim inp As formInput = New formInput()
        inp.name = TextName.Text
        inp.age = Convert.ToInt32(TextAge.Text)
        inp.address = TextAddress.Text

        My.Computer.FileSystem.WriteAllText(PATH & "JSON.txt", JsonConvert.SerializeObject(inp, Newtonsoft.Json.Formatting.Indented), False)
    End Sub
End Class
