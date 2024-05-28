Imports System.Data.OleDb

Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.oledb.4.0; Data source=C:\Users\maria\Desktop\SistemaMatriculaINUED2\Base De Datos\MatriculaINUED(2002-2003).mdb")
        Try
            con.Open()

            Dim query = "Select * from maestro"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)

            Chart1.Series("Series1").XValueMember = "nombremaestro"
            Chart1.Series("Series1").YValueMembers = "edadmaestro"
            Chart1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try
    End Sub
End Class