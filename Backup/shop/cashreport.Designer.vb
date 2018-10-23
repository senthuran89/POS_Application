<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashreport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashreport))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DataSet11 = New shop.DataSet1
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.bill11 = New shop.bill1
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     cash.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         cash"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=sale;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cashid", System.Data.SqlDbType.Int, 0, "cashid"), New System.Data.SqlClient.SqlParameter("@cusid", System.Data.SqlDbType.Int, 0, "cusid"), New System.Data.SqlClient.SqlParameter("@cashdate", System.Data.SqlDbType.SmallDateTime, 0, "cashdate"), New System.Data.SqlClient.SqlParameter("@totalamount", System.Data.SqlDbType.Money, 0, "totalamount"), New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Money, 0, "discount"), New System.Data.SqlClient.SqlParameter("@payment", System.Data.SqlDbType.Money, 0, "payment"), New System.Data.SqlClient.SqlParameter("@balance", System.Data.SqlDbType.Money, 0, "balance")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cashid", System.Data.SqlDbType.Int, 0, "cashid"), New System.Data.SqlClient.SqlParameter("@cusid", System.Data.SqlDbType.Int, 0, "cusid"), New System.Data.SqlClient.SqlParameter("@cashdate", System.Data.SqlDbType.SmallDateTime, 0, "cashdate"), New System.Data.SqlClient.SqlParameter("@totalamount", System.Data.SqlDbType.Money, 0, "totalamount"), New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Money, 0, "discount"), New System.Data.SqlClient.SqlParameter("@payment", System.Data.SqlDbType.Money, 0, "payment"), New System.Data.SqlClient.SqlParameter("@balance", System.Data.SqlDbType.Money, 0, "balance"), New System.Data.SqlClient.SqlParameter("@Original_cashid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cashid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cusid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cusid", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cusid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cashdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cashdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cashdate", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cashdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_totalamount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "totalamount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_totalamount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "totalamount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_discount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_payment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "payment", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_payment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_balance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "balance", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_balance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "balance", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cashid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cashid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cusid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cusid", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cusid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cashdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cashdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cashdate", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cashdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_totalamount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "totalamount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_totalamount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "totalamount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_discount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_payment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "payment", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_payment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_balance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "balance", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_balance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "balance", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cash", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cashid", "cashid"), New System.Data.Common.DataColumnMapping("cusid", "cusid"), New System.Data.Common.DataColumnMapping("cashdate", "cashdate"), New System.Data.Common.DataColumnMapping("totalamount", "totalamount"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("payment", "payment"), New System.Data.Common.DataColumnMapping("balance", "balance")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(431, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Enabled = False
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Blue
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.bill11
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(592, 566)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'cashreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(592, 566)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "cashreport"
        Me.Text = "cashreport"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataSet11 As shop.DataSet1
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bill11 As shop.bill1
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
