Imports System.Data
Imports System.Data.SqlClient
Public Class warrenty
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
        Dim COM As SqlCommand = New SqlCommand
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select initemname from inventery"
        DR = COM.ExecuteReader
        Do While DR.Read
            itemname.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select cusid from customer"
        DR = COM.ExecuteReader
        Do While DR.Read
            cusid.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
        
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select max(wid+1) from warranty"
        DR = COM.ExecuteReader
        Do While DR.Read
            wid.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
    End Sub


    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select cusintial,cuslname,cusdate from customer where  cusid='" & cusid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                inti.Text = DR.GetValue(0)
                txtname.Text = DR.GetValue(1)
                dates.Text = DR.GetValue(2)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dura.TextChanged

    End Sub

    Private Sub itemname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemname.SelectedIndexChanged
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select inwarrenty,inid from inventery where initemname='" & itemname.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                warr.Text = DR.GetValue(0)
                ind.Text = DR.GetValue(1)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sa.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "warrentychange"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@wid", wid.Text)
                .Parameters.AddWithValue("@cusid", cusid.Text)
                .Parameters.AddWithValue("@witemname", itemname.Text)
                .Parameters.AddWithValue("@wdate", date1.Value)
                .Parameters.AddWithValue("@wdetail", detail.Text)
                .Parameters.AddWithValue("@inid", ind.Text)
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = ("save sueesed from paticular database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cusid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cusid.SelectedIndexChanged

    End Sub
End Class