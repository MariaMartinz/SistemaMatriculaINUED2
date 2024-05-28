Imports System.Data.OleDb
Public Class frmBuscar
    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGrafica_Click(sender As Object, e As EventArgs) Handles btnGrafica.Click
        frmGrafica.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.oledb.4.0; Data source=C:\Users\maria\Desktop\SistemaMatriculaINUED2\Base De Datos\MatriculaINUED(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Registro Encontrado", , "Buscar")

            Dim query = "Select * from maestro where nombremaestro Like '" & txtBuscar.Text & "%'"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try
    End Sub
End Class