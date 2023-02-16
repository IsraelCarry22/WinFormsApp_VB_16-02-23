Imports System.Diagnostics.Contracts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Contac()
        x.Name = Nombre_text.Text
        x.Telephone = Telef_Text.Text
        x.Birthdate = DateTime.Parse("2004/05/22")

        Datos_Text.Text = x.ToString()

    End Sub
End Class