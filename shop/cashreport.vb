Imports System.Data
Imports System.Data.SqlClient
Public Class cashreport
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Dim DS As DataSet = New DataSet
    Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    Dim da As New SqlClient.SqlDataAdapter
   
    
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            da.SelectCommand = New SqlCommand
            da.SelectCommand.Connection = CON
            da.SelectCommand.CommandType = CommandType.Text
            CON.Open()
            da.SelectCommand.CommandText = "SELECT * FROM cash where cashid = '" & Normalsale.billid.Text.Trim & "'"
            da.Fill(DS, "cash")
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim ob As New bill1
        ob.SetDataSource(DS.Tables(0))
        CrystalReportViewer1.ReportSource = ob
        DS.Clear()
    End Sub
End Class