Imports System.Data
Imports System.Data.SqlClient
Public Class itemreport
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Dim DS As DataSet = New DataSet
    Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
    Dim da As New SqlClient.SqlDataAdapter
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select initemname from inventery"
        DR = COM.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            da.SelectCommand = New SqlCommand
            da.SelectCommand.Connection = CON
            da.SelectCommand.CommandType = CommandType.Text
            CON.Open()
            da.SelectCommand.CommandText = "SELECT * FROM inventery where initemname = '" & ComboBox1.Text.Trim & "'"
            da.Fill(DS, "inventery")
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim ob As New itemReport1
        ob.SetDataSource(DS.Tables(0))
        CrystalReportViewer1.ReportSource = ob
        DS.Clear()
    End Sub
End Class