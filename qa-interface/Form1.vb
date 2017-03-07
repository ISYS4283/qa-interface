Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Questions
    Private Sub LoadQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadQuestionsToolStripMenuItem.Click
        loadQuestions()
    End Sub

    Private Sub CreateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateQuestionToolStripMenuItem.Click
        CreateQuestion.ShowDialog()
        loadQuestions()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim question_id As String = dgvQuestions.Item("id", dgvQuestions.CurrentRow.Index).Value.ToString()
        Dim question As String = dgvQuestions.Item("question", dgvQuestions.CurrentRow.Index).Value.ToString()

        Dim editQuestion As New EditQuestion(question_id, question)
        Call editQuestion.ShowDialog()
        loadQuestions()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim confirm As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirm = DialogResult.Yes Then
            Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283jpucket;Trusted_Connection=yes;"}
            Dim sqlcmd As SqlCommand

            Dim query As String
            query = "DELETE FROM questions WHERE [id] = @question_id;"

            Try
                sqlcmd = New SqlCommand(query, sqlcon)
                Dim question_id As String = dgvQuestions.Item("id", dgvQuestions.CurrentRow.Index).Value.ToString()
                sqlcmd.Parameters.AddWithValue("@question_id", question_id)
                sqlcon.Open()
                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw ex
            Finally
                If sqlcon.State = ConnectionState.Open Then
                    sqlcon.Close()
                End If
                loadQuestions()
            End Try
        End If
    End Sub

    Private Sub loadQuestions()
        Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283jpucket;Trusted_Connection=yes;"}
        Dim sqlcmd As SqlCommand
        Dim sqlda As SqlDataAdapter
        Dim sqldataset As DataSet

        Dim query As String
        query = "SELECT * FROM questions ORDER BY created_at DESC;"

        Try
            sqlcon.Open()
            sqlcmd = New SqlCommand(query, sqlcon)
            sqlda = New SqlDataAdapter(sqlcmd)
            sqldataset = New DataSet
            sqlda.Fill(sqldataset)
            If sqldataset.Tables.Count > 0 Then
                dgvQuestions.Refresh()
                dgvQuestions.DataSource = sqldataset.Tables(0)
            End If
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

