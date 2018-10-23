Imports System.Data
Imports System.Data.SqlClient
Public Class nwarrenty
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub nwarrenty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SaleDataSet5.inventery' table. You can move, or remove it, as needed.
        Me.InventeryTableAdapter.Fill(Me.SaleDataSet5.inventery)
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
        id.Visible = False
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
                id.Text = DR.GetValue(1)
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
            COM.CommandText = "warrentychang"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@inid", id.Text)
                .Parameters.AddWithValue("@warrenty", warr.Text)
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "save sueesed from paticular database"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.InventeryTableAdapter.Fill(Me.SaleDataSet5.inventery)
    End Sub
End Class