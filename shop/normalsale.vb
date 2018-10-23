Imports System.Data
Imports System.Data.SqlClient
Public Class Normalsale
    Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Dim DS As DataSet = New DataSet
    Dim x As Double
    Dim y As Double
    Dim DA As SqlDataAdapter = New SqlDataAdapter("select itemid,itemname,qty,price from order1", CON)
    Private Sub normalsale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SaleDataSet6.order1' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'SaleDataSet2.order1' table. You can move, or remove it, as needed.
        'Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select max(cashid+1) from cash"
        DR = COM.ExecuteReader
        Do While DR.Read
            billid1.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
        Label7.Text = 0
    End Sub
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim Codes As String = " "
            Dim iname As String = " "
            Dim Prices As String = " "
            Dim Qtys As String = " "
            Dim oid As String = " "
            Dim row As Integer = DataGridView1.CurrentCell.RowIndex
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                Codes = Codes + DataGridView1(0, i).Value.ToString() + ","
                iname = iname + DataGridView1(1, i).Value.ToString() + ","
                Prices = Prices + DataGridView1(2, i).Value.ToString() + ","
                Qtys = Qtys + DataGridView1(3, i).Value.ToString() + ","
                'x = x + DataGridView1(4, i).Value
                oid = oid + billid.Text + ","
            Next i
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "cusorder"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@orderid", oid)
                .Parameters.AddWithValue("@itemid", Codes)
                .Parameters.AddWithValue("@itemname", iname)
                .Parameters.AddWithValue("@qty", Qtys)
                .Parameters.AddWithValue("@price", Prices)
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "Save sussed "
        Catch ex As Exception
            ToolStripStatusLabel1.Text = (ex.Message)
        End Try
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "cashs"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@cusid", "0")
                .Parameters.AddWithValue("@billid", billid.Text)
                .Parameters.AddWithValue("@cusdate", dates.Value.Day)
                .Parameters.AddWithValue("@totalamount", CType(txttotalamount.Text, Decimal))
                .Parameters.AddWithValue("@payment", CType(txtpay.Text, Decimal))
                .Parameters.AddWithValue("@discount", CType(txtdisco.Text, Decimal))
                .Parameters.AddWithValue("@balance", CType(txtbal.Text, Decimal))
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "save sueesed from paticular database"
            'MsgBox("Save")
            billid.Text = Val(billid.Text) + 1
        Catch ex As Exception
            ToolStripStatusLabel1.Text = (ex.Message)
        End Try
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' txtprice.Text = Val(price.Text) * Val(txtqty.Text)
        'x = x + Val(txtprice.Text)
        txttotalamount.Text = x
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtbal.Clear()
        txtdisco.Clear()
        txttotalamount.Clear()
        net.Clear()
        txtpay.Clear()
        Label7.Text = ""
        x = 0
        txttotalamount.Clear()
        Try
            Dim row As Integer = DataGridView1.CurrentCell.RowIndex
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                DataGridView1(0, i).Value = ""
                DataGridView1(1, i).Value = ""
                DataGridView1(2, i).Value = ""
                DataGridView1(3, i).Value = ""
                DataGridView1(4, i).Value = ""
            Next i
        Catch ex As Exception

        End Try
       
        DataGridView1.Focus()
    End Sub

    Private Sub txtdisco_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdisco.Validating
        If Val(txtdisco.Text) > (Val(txttotalamount.Text) * 10 / 100) Then
            ErrorProvider1.SetError(txtdisco, "discount more then 10% to total amount")
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub billid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billid1.SelectedIndexChanged
        billid.Text = billid1.Text
        billid1.Visible = False
    End Sub

  
    Private Sub txtdisco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdisco.TextChanged
        net.Text = Val(txttotalamount.Text) - Val(txtdisco.Text)
    End Sub

    Private Sub txtpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpay.TextChanged
        txtbal.Text = Val(txtpay.Text) - Val(net.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cashreport.Show()
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
                        Label7.Text = DataGridView1(4, row).Value
                    Catch ex As Exception

                    End Try
                    SendKeys.Send("{TAB}")
            End Select
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txttotalamount_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txttotalamount.MouseClick
        Try
            Dim i As Integer
            'for ( i = 0; i < dataGridView1.RowCount - 1; i++)
            For i = 0 To DataGridView1.RowCount - 2
                y = y + DataGridView1(4, i).Value
                'Label7.Text = +Val(txttotalamount.Text)
                'x = x + DataGridView1(4, i).Value
            Next i
            txttotalamount.Text = y
        Catch ex As Exception

        End Try
        
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
            txttotalamount.Text = y
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttotalamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalamount.TextChanged

    End Sub
End Class