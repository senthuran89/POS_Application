Imports System.Data
Imports System.Data.SqlClient
Public Class inventry
    Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub inventry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select max(inid+1) from inventery"
        DR = COM.ExecuteReader
        Do While DR.Read
            txtinid.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "inventerystore"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@inid", txtinid.Text)
                .Parameters.AddWithValue("@initemname", txtinnama.Text)
                .Parameters.AddWithValue("@intype", type.Text)
                .Parameters.AddWithValue("@inqty", txtqty.Text)
                .Parameters.AddWithValue("inunitprice", CType(txtunitprce.Text, Decimal))
                .Parameters.AddWithValue("@intotalcost", CType(txttotal.Text, Decimal))
                .Parameters.AddWithValue("@indescription", txtdescri.Text)
                .Parameters.AddWithValue("@inmade", txtmade.Text)
                .Parameters.AddWithValue("@inonhand", onhand.Value)
                .Parameters.AddWithValue("@inwarranty", warranty.Text)
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "save sueesed from paticular database"
            ToolStripStatusLabel1.ForeColor = Color.Green
            txtinid.Text = Val(txtinid.Text) + 1
        Catch ex As Exception
            ToolStripStatusLabel1.Text = (ex.Message)
        End Try
        Me.InventeryTableAdapter.Fill(Me.SaleDataSet3.inventery)

    End Sub

   
    Private Sub txtunitprce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunitprce.TextChanged
        txttotal.Text = Val(txtqty.Text) * Val(txtunitprce.Text)
        txtunitprce.BackColor = Color.Cyan
    End Sub

    Private Sub txtinid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinid.SelectedIndexChanged
        txtinid.BackColor = Color.Cyan
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtinid.BackColor = Color.White
        type.BackColor = Color.White
        txtmade.BackColor = Color.White
        warranty.BackColor = Color.White
        txtmade.BackColor = Color.White
        txtinnama.Clear()
        txttotal.Clear()
        txtunitprce.Clear()
        txtqty.Clear()
        txtdescri.Clear()
        txtinnama.BackColor = Color.White
        txttotal.BackColor = Color.White
        txtunitprce.BackColor = Color.White
        txtqty.BackColor = Color.White
        txtdescri.BackColor = Color.White

    End Sub

    Private Sub txtinnama_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtinnama.Validating
        If txtinnama.Text.Length < 3 Then
            ErrorProvider1.SetError(txtinnama, "You Enter The Item Name More then Two letters..")
            ToolStripStatusLabel1.Text = "You Enter The Item Name More then Two letters.."
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.Clear()
            ToolStripStatusLabel1.Text = ""
        End If
        txtinnama.BackColor = Color.Cyan
    End Sub

    Private Sub type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.SelectedIndexChanged
        type.BackColor = Color.Cyan
    End Sub


    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        txtqty.BackColor = Color.Cyan
    End Sub

    Private Sub txttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.TextChanged
        txttotal.BackColor = Color.Cyan
    End Sub

    Private Sub txtdescri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescri.TextChanged
        txtdescri.BackColor = Color.Cyan
    End Sub

    Private Sub txtmade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtmade.BackColor = Color.Cyan
    End Sub

    Private Sub warranty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles warranty.SelectedIndexChanged
        warranty.BackColor = Color.Cyan
    End Sub

    Private Sub txtmade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmade.SelectedIndexChanged
        txtmade.BackColor = Color.Cyan
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class