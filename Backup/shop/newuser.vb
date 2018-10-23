Imports System.Data
Imports System.Data.SqlClient
Public Class newuser
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (op.Text = np.Text) Then
            Try
                Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
                Dim COM As SqlCommand = New SqlCommand
                COM.Connection = CON
                COM.CommandText = "newuser"
                COM.CommandType = CommandType.StoredProcedure
                With COM
                    .Parameters.AddWithValue("@us", un.Text)
                    .Parameters.AddWithValue("@pa", np.Text)
                End With
                CON.Open()
                COM.ExecuteNonQuery()
                CON.Close()
                ToolStripStatusLabel1.Text = "save sueesed from paticular database"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ToolStripStatusLabel1.Text = "Your Password Wrong"
            op.Clear()
            np.Clear()
            op.Focus()
        End If
        
    End Sub

   
   
End Class