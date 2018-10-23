Imports System.Data
Imports System.Data.SqlClient
Public Class crditpay
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader

    Private Sub crditpay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
        Dim COM As SqlCommand = New SqlCommand
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select cusfname,cuslname from customer"
        DR = COM.ExecuteReader
        Do While DR.Read
            txtname.Items.Add(DR.GetValue(0) + DR.GetValue(1))
        Loop
        CON.Close()
    End Sub

    Private Sub txtname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.SelectedIndexChanged
        Label10.Text = txtname.Text
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdates.TextChanged

    End Sub

    Private Sub findid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findid.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select cuslname,cusintial,crid from customer where  cusid='" & txtid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                Label10.Text = DR.GetValue(0)
                Label11.Text = DR.GetValue(1)
                txtcrid.Text = DR.GetValue(2)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select crtotalamount,crpayment,crbalance,cusdate from credit where  crid='" & txtcrid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read

                totalamount.Text = DR.GetValue(0)
                txtpayment.Text = DR.GetValue(1)
                'txtbalance.Text = DR.GetValue(2)
                txtdates.Text = DR.GetValue(3)
                txtbalance.Text = (DR.GetValue(0) - DR.GetValue(1))
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub findname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findname.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select cusid,cusintial,crid from customer where  cusfname+cuslname='" & txtname.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                txtid.Text = DR.GetValue(0)
                Label11.Text = DR.GetValue(1)
                txtcrid.Text = DR.GetValue(2)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select crtotalamount,crpayment,crbalance,cusdate from credit where  crid='" & txtcrid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read

                totalamount.Text = DR.GetValue(0)
                txtpayment.Text = DR.GetValue(1)
                txtbalance.Text = DR.GetValue(2)
                txtdates.Text = DR.GetValue(3)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub crfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crfind.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select crtotalamount,crpayment,crbalance,cusdate,cusid from credit where  crid='" & txtcrid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read

                totalamount.Text = DR.GetValue(0)
                txtpayment.Text = DR.GetValue(1)
                txtbalance.Text = DR.GetValue(2)
                txtdates.Text = DR.GetValue(3)
                txtid.Text = DR.GetValue(4)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select cuslname,cusintial,crid from customer where  cusid='" & txtid.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                Label10.Text = DR.GetValue(0)
                Label11.Text = DR.GetValue(1)
                txtcrid.Text = DR.GetValue(2)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            COM.CommandText = "crditpay"
            COM.CommandType = CommandType.StoredProcedure
            With COM
                .Parameters.AddWithValue("@crid", txtcrid.Text)
                '.Parameters.AddWithValue("@cusdate", Datenow.Value)
                .Parameters.AddWithValue("@crpayment", CType(txtnewpay.Text, Decimal))
            End With
            CON.Open()
            COM.ExecuteNonQuery()
            CON.Close()
            ToolStripStatusLabel1.Text = "save sueesed from paticular database"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnewpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnewpay.TextChanged
        txtnowbalance.Text = Val(txtbalance.Text) - Val(txtnewpay.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        crreport.Show()
    End Sub
End Class