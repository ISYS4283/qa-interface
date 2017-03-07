Imports System.Data.SqlClient
Public Class CreateQuestion
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283jpucket;Trusted_Connection=yes;"}
        Dim sqlcmd As SqlCommand

        Dim query As String
        query = "INSERT INTO questions ([question]) VALUES (@question);"

        Try
            sqlcmd = New SqlCommand(query, sqlcon)
            sqlcmd.Parameters.AddWithValue("@question", tbQuestion.Text)
            sqlcon.Open()
            sqlcmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End Try
    End Sub
End Class
