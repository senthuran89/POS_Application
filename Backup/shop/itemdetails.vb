Imports System.Data
Imports System.Data.SqlClient
Public Class itemdetails
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub itemdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub itemname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemname.SelectedIndexChanged
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select inid,inqty,inunitprice,indescription,inmade,inonhand,inwarrenty from inventery where  initemname='" & itemname.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                inid.Text = DR.GetValue(0)
                qty.Text = DR.GetValue(1)
                unit.Text = DR.GetValue(2)
                des.Text = DR.GetValue(3)
                made.Text = DR.GetValue(4)
                onhand.Text = DR.GetValue(5)
                warr.Text = DR.GetValue(6)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select initemname,inqty,inunitprice,indescription,inmade,inonhand,inwarrenty from inventery where  inid='" & inid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                Label7.Text = DR.GetValue(0)
                qty.Text = DR.GetValue(1)
                unit.Text = DR.GetValue(2)
                des.Text = DR.GetValue(3)
                made.Text = DR.GetValue(4)
                onhand.Text = DR.GetValue(5)
                warr.Text = DR.GetValue(6)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class