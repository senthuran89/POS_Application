Imports System.Data
Imports System.Data.SqlClient
Public Class price_change
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        
    End Sub

    Private Sub price_change_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InventeryTableAdapter.Fill(Me.SaleDataSet4.inventery)
        'TODO: This line of code loads data into the 'SaleDataSet4.inventery' table. You can move, or remove it, as needed.
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
            COM.CommandText = "Select inid,inqty,inunitprice from inventery where  initemname='" & itemname.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                inid.Text = DR.GetValue(0)
                qty.Text = DR.GetValue(1)
                unit.Text = DR.GetValue(2)
            Loop
            CON.Close()
            TextBox4.Text = Val(qty.Text) * Val(unit.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox3.Clear()
        TextBox2.Clear()
        newunit.Clear()

    End Sub

    Private Sub sa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sa.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "pricechang"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@inid", inid.Text)
                .Parameters.AddWithValue("@inunitprice", CType(newunit.Text, Decimal))
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "save sueesed from paticular database"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.InventeryTableAdapter.Fill(Me.SaleDataSet4.inventery)
    End Sub

    Private Sub find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles find.Click
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
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox3.Clear()
        TextBox2.Clear()
        newunit.Clear()
    End Sub

    Private Sub newunit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newunit.TextChanged
        TextBox2.Text = Val(qty.Text) * Val(newunit.Text)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox3.Text = Val(TextBox3.Text) - Val(TextBox2.Text)
    End Sub
End Class