Imports System.Data
Imports System.Data.SqlClient
Public Class user
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
        Dim COM As SqlCommand = New SqlCommand
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select nam1 from username"
        DR = COM.ExecuteReader
        Do While DR.Read
            un.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
    End Sub

    Private Sub un_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles un.SelectedIndexChanged
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select passwor from username where nam1='" & un.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                op.Text = DR.GetValue(0)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "newuser1"
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
    End Sub

    Private Sub pass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pass.Leave
        If (op.Text = pass.Text) Then
            np.Focus()
        Else
            pass.Focus()
            pass.Clear()
        End If
    End Sub

End Class