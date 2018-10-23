Imports System.Data
Imports System.Data.SqlClient
Public Class crditsale
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Dim x As Double
    Dim y As Double
    Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    Dim DA As SqlDataAdapter = New SqlDataAdapter("select itemid,itemname,qty,price from order1", CON)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim Codes As String = " "
            Dim iname As String = " "
            Dim Prices As String = " "
            Dim Qtys As String = " "
            Dim OID As String = " "
            Dim row As Integer = DataGridView1.CurrentCell.RowIndex
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                Codes = Codes + DataGridView1(0, i).Value.ToString() + ","
                iname = iname + DataGridView1(1, i).Value.ToString() + ","
                Prices = Prices + DataGridView1(2, i).Value.ToString() + ","
                Qtys = Qtys + DataGridView1(3, i).Value.ToString() + ","
                OID = OID + DataGridView1(5, i).Value.ToString() + ","
                'x = x + DataGridView1(4, i).Value
            Next i
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "cusorder"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@orderid", OID)
                .Parameters.AddWithValue("@itemid", Codes)
                .Parameters.AddWithValue("@itemname", iname)
                .Parameters.AddWithValue("@qty", Qtys)
                .Parameters.AddWithValue("@price", Prices)
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "save sueesed from paticular database "

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "crditstore"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@cusid", txtcusid.Text)
                .Parameters.AddWithValue("@cusintial", initial.Text)
                .Parameters.AddWithValue("@cusfname", txtfname.Text)
                .Parameters.AddWithValue("@cuslname", txtlname.Text)
                .Parameters.AddWithValue("@cusaddress", txtaddress.Text)
                .Parameters.AddWithValue("@custp", txtcustp.Text)
                .Parameters.AddWithValue("@cusemail", txtemail.Text)
                .Parameters.AddWithValue("@cusdate", cusdate.Value)
                .Parameters.AddWithValue("@cusstatus", status.Text)
                .Parameters.AddWithValue("@billid", txtbillid.Text)
                .Parameters.AddWithValue("@crid", txtbillid.Text)
                .Parameters.AddWithValue("@crtotalamount", CType(txtamount.Text, Decimal))
                .Parameters.AddWithValue("@crpayment", CType(txtpayment.Text, Decimal))
                .Parameters.AddWithValue("@crdiscount", CType(txtdiscount.Text, Decimal))
                .Parameters.AddWithValue("@crbalance", CType(txtbalance.Text, Decimal))
                .Parameters.AddWithValue("@crterms", terms.Text)
                .Parameters.AddWithValue("@crinterst", "0")
                .Parameters.AddWithValue("@crinterms", "-")
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "Save sussed. "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Try
    '        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    '        Dim COM As SqlCommand = New SqlCommand
    '        COM.Connection = CON
    '        COM.CommandText = "cusorder1"
    '        COM.CommandType = CommandType.StoredProcedure
    '        With COM
    '            .Parameters.AddWithValue("@orderid", txtcusid.Text)
    '            .Parameters.AddWithValue("@itemid", txtitem.Text)
    '            .Parameters.AddWithValue("@itemname", txtitemname.Text)
    '            .Parameters.AddWithValue("@qty", txtqty.Text)
    '            .Parameters.AddWithValue("@price", CType(txtprice.Text, Decimal))
    '        End With
    '        CON.Open()
    '        COM.ExecuteNonQuery()
    '        CON.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Me.Order1TableAdapter.Fill(Me.SaleDataSet1.order1)
    '    Dim x As Double
    '    x = x + (Val(txtqty.Text) * Val(txtprice.Text))
    '    Label24.Text = Val(Label10.Text) + x
    '    txtamount.Text = Label24.Text
    'End Sub

    Private Sub crditsale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SaleDataSet1.order1' table. You can move, or remove it, as needed.
        ComboBox1.Focus()
        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
        Dim COM As SqlCommand = New SqlCommand
        'COM.Connection = CON
        'CON.Open()
        'COM.CommandText = "Select initemname from inventery"
        'DR = COM.ExecuteReader
        'Do While DR.Read
        '    txtitemname.Items.Add(DR.GetValue(0))
        'Loop
        'CON.Close()
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select max(cusid+1) from customer"
        DR = COM.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
        'txtitem.Visible = False
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select max(crid+1) from credit"
        DR = COM.ExecuteReader
        Do While DR.Read
            ComboBox2.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        txtbillid.Text = ComboBox2.Text
        ComboBox2.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtcusid.Text = ComboBox1.Text
        ComboBox1.Visible = False
    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub txtfname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtfname.Validating
        If txtfname.Text.Length < 3 Then
            ErrorProvider1.SetError(txtfname, "You Enter The Customer First Name More then Two letters..")
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtlname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtlname.Validating
        If txtlname.Text.Length < 3 Then
            ErrorProvider1.SetError(txtlname, "You Enter The Customer Last Name More then Two letters..")
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtaddress_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtaddress.Validating
        If txtaddress.Text.Length <= 0 Then
            ErrorProvider1.SetError(txtaddress, "You Enter The Customer Address Important..")
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtdiscount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdiscount.Validating
        Try
            If txtdiscount.Text < 0 Then
                ErrorProvider1.SetError(txtdiscount, "You Enter discount Price only")
                e.Cancel = True
            Else
                If txtdiscount.Text < 10 Or txtdiscount.Text <= Val(txtamount.Text * 10 / 100) Then
                    e.Cancel = False
                    ErrorProvider1.Clear()
                Else
                    ErrorProvider1.SetError(txtdiscount, "Enter the Discount Price more then 10 to 10% in to total price")
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            Dim x As String
            x = MsgBox("Only allow price amount", MsgBoxStyle.OkOnly, "Message")
            If (x = vbOK) Then
                txtdiscount.Text = ""
                txtdiscount.Focus()
            End If
        End Try
        net.Text = Val(txtamount.Text) - Val(txtdiscount.Text)
    End Sub

    Private Sub txtpayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpayment.TextChanged
        txtbalance.Text = Val(txtpayment.Text) - Val(net.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            txtcusid.Text = (Val(txtcusid.Text) + 1)
            txtbillid.Text = (Val(txtbillid.Text) + 1)
            txtfname.Clear()
            txtlname.Clear()
            txtaddress.Clear()
            txtcustp.Clear()
            txtemail.Clear()

            txtamount.Clear()
            txtdiscount.Clear()
            net.Clear()
            txtbalance.Clear()
            txtpayment.Clear()
            Dim row As Integer = DataGridView1.CurrentCell.RowIndex
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                DataGridView1(0, i).Value = ""
                DataGridView1(1, i).Value = ""
                DataGridView1(2, i).Value = ""
                DataGridView1(3, i).Value = ""
                DataGridView1(4, i).Value = ""
                DataGridView1(5, i).Value = ""
            Next i
        Catch ex As Exception

        End Try
        
        ' DataGridView1(0, 0).Value = ""
    End Sub

    'Private Sub txtitemname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemname.SelectedIndexChanged
    '    Try
    '        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    '        Dim COM As SqlCommand = New SqlCommand
    '        COM.Connection = CON
    '        CON.Open()
    '        COM.CommandText = "Select inid,initemname,inunitprice from inventery where initemname='" & txtitemname.Text.Trim & "'"
    '        DR = COM.ExecuteReader
    '        Do While DR.Read
    '            txtitem.Text = DR.GetValue(0)
    '            txtprice.Text = DR.GetValue(2)
    '        Loop
    '        CON.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        crreport.Show()
    End Sub


    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
            Dim row As Integer = DataGridView1.CurrentCell.RowIndex
            Dim co As String
            co = DataGridView1(0, row).Value.ToString
            Select Case (col)

                Case 1
                    Try
                        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
                        Dim COM As SqlCommand = New SqlCommand
                        COM.Connection = CON
                        CON.Open()
                        COM.CommandText = "Select inid,initemname,inunitprice from inventery where inid='" & co & "'"
                        DR = COM.ExecuteReader
                        Do While DR.Read

                            'DataGridView1(0, row).Value = DR.GetValue(0)

                            DataGridView1(1, row).Value = DR.GetValue(1)
                            DataGridView1(2, row).Value = DR.GetValue(2)
                        Loop
                        CON.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    SendKeys.Send("{TAB}{TAB}")
                Case 4
                    Try
                        DataGridView1(4, row).Value = DataGridView1(2, row).Value * DataGridView1(3, row).Value
                        Label24.Text = DataGridView1(4, row).Value
                    Catch ex As Exception

                    End Try
                    SendKeys.Send("{TAB}")
                Case 5
                    Try
                        DataGridView1(5, row).Value = txtcusid.Text
                    Catch ex As Exception

                    End Try
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtamount_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtamount.MouseClick
        Try
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                y = y + DataGridView1(4, i).Value
                'Label7.Text = +Val(txttotalamount.Text)
                'x = x + DataGridView1(4, i).Value
            Next i
            txtamount.Text = y
        Catch ex As Exception

        End Try

    End Sub
    Private Sub txtdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged
        net.Text = Val(txtamount.Text) - Val(txtdiscount.Text)
    End Sub

    Private Sub DataGridView1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Leave
        Try
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                y = y + DataGridView1(4, i).Value
                'Label7.Text = +Val(txttotalamount.Text)
                'x = x + DataGridView1(4, i).Value
            Next i
            txtamount.Text = y
        Catch ex As Exception

        End Try
    End Sub
End Class