Imports System.Data
Imports System.Data.SqlClient
Public Class crpayreport
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Dim DS As DataSet = New DataSet
    Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    Dim da As New SqlClient.SqlDataAdapter
    Private Sub crpayreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            da.SelectCommand = New SqlCommand
            da.SelectCommand.Connection = CON
            da.SelectCommand.CommandType = CommandType.Text
            CON.Open()
            da.SelectCommand.CommandText = "SELECT * FROM credit where crid = '" & crditpay.txtid.Text.Trim & "'"
            da.Fill(DS, "credit")
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim ob As New creditre1
        ob.SetDataSource(DS.Tables(0))
        CrystalReportViewer1.ReportSource = ob
        DS.Clear()
    End Sub
End Class