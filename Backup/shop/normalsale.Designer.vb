<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Normalsale
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Normalsale))
        Me.Label12 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.dates = New System.Windows.Forms.DateTimePicker
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtbal = New System.Windows.Forms.TextBox
        Me.txtpay = New System.Windows.Forms.TextBox
        Me.txtdisco = New System.Windows.Forms.TextBox
        Me.txttotalamount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Order1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet6 = New shop.saleDataSet6
        Me.Order1TableAdapter = New shop.saleDataSet6TableAdapters.order1TableAdapter
        Me.billid1 = New System.Windows.Forms.ComboBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.billid = New System.Windows.Forms.Label
        Me.net = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.Order1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AccessibleDescription = Nothing
        Me.Label12.AccessibleName = Nothing
        resources.ApplyResources(Me.Label12, "Label12")
        Me.ErrorProvider1.SetError(Me.Label12, resources.GetString("Label12.Error"))
        Me.Label12.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label12, CType(resources.GetObject("Label12.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label12, CType(resources.GetObject("Label12.IconPadding"), Integer))
        Me.Label12.Name = "Label12"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     inid, initemname, inunitprice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         inventery"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [inventery] ([inid], [initemname], [inunitprice]) VALUES (@inid, @ini" & _
            "temname, @inunitprice);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT inid, initemname, inunitprice FROM inventery WHE" & _
            "RE (inid = @inid)"
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@inid", System.Data.SqlDbType.Int, 0, "inid"), New System.Data.SqlClient.SqlParameter("@initemname", System.Data.SqlDbType.VarChar, 0, "initemname"), New System.Data.SqlClient.SqlParameter("@inunitprice", System.Data.SqlDbType.Money, 0, "inunitprice")})
        '
        'dates
        '
        Me.dates.AccessibleDescription = Nothing
        Me.dates.AccessibleName = Nothing
        resources.ApplyResources(Me.dates, "dates")
        Me.dates.BackgroundImage = Nothing
        Me.dates.CalendarFont = Nothing
        Me.dates.CustomFormat = Nothing
        Me.ErrorProvider1.SetError(Me.dates, resources.GetString("dates.Error"))
        Me.dates.Font = Nothing
        Me.dates.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ErrorProvider1.SetIconAlignment(Me.dates, CType(resources.GetObject("dates.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.dates, CType(resources.GetObject("dates.IconPadding"), Integer))
        Me.dates.Name = "dates"
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@inid", System.Data.SqlDbType.Int, 0, "inid"), New System.Data.SqlClient.SqlParameter("@initemname", System.Data.SqlDbType.VarChar, 0, "initemname"), New System.Data.SqlClient.SqlParameter("@inunitprice", System.Data.SqlDbType.Money, 0, "inunitprice"), New System.Data.SqlClient.SqlParameter("@Original_inid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_initemname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_initemname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inunitprice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inunitprice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_inid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_initemname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_initemname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inunitprice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inunitprice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = Nothing
        Me.Label11.AccessibleName = Nothing
        resources.ApplyResources(Me.Label11, "Label11")
        Me.ErrorProvider1.SetError(Me.Label11, resources.GetString("Label11.Error"))
        Me.Label11.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label11, CType(resources.GetObject("Label11.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label11, CType(resources.GetObject("Label11.IconPadding"), Integer))
        Me.Label11.Name = "Label11"
        '
        'txtbal
        '
        Me.txtbal.AccessibleDescription = Nothing
        Me.txtbal.AccessibleName = Nothing
        resources.ApplyResources(Me.txtbal, "txtbal")
        Me.txtbal.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.txtbal, resources.GetString("txtbal.Error"))
        Me.txtbal.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.txtbal, CType(resources.GetObject("txtbal.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.txtbal, CType(resources.GetObject("txtbal.IconPadding"), Integer))
        Me.txtbal.Name = "txtbal"
        '
        'txtpay
        '
        Me.txtpay.AccessibleDescription = Nothing
        Me.txtpay.AccessibleName = Nothing
        resources.ApplyResources(Me.txtpay, "txtpay")
        Me.txtpay.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.txtpay, resources.GetString("txtpay.Error"))
        Me.txtpay.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.txtpay, CType(resources.GetObject("txtpay.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.txtpay, CType(resources.GetObject("txtpay.IconPadding"), Integer))
        Me.txtpay.Name = "txtpay"
        '
        'txtdisco
        '
        Me.txtdisco.AccessibleDescription = Nothing
        Me.txtdisco.AccessibleName = Nothing
        resources.ApplyResources(Me.txtdisco, "txtdisco")
        Me.txtdisco.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.txtdisco, resources.GetString("txtdisco.Error"))
        Me.txtdisco.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.txtdisco, CType(resources.GetObject("txtdisco.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.txtdisco, CType(resources.GetObject("txtdisco.IconPadding"), Integer))
        Me.txtdisco.Name = "txtdisco"
        '
        'txttotalamount
        '
        Me.txttotalamount.AccessibleDescription = Nothing
        Me.txttotalamount.AccessibleName = Nothing
        resources.ApplyResources(Me.txttotalamount, "txttotalamount")
        Me.txttotalamount.BackgroundImage = Nothing
        Me.txttotalamount.Cursor = System.Windows.Forms.Cursors.Default
        Me.ErrorProvider1.SetError(Me.txttotalamount, resources.GetString("txttotalamount.Error"))
        Me.txttotalamount.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.txttotalamount, CType(resources.GetObject("txttotalamount.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.txttotalamount, CType(resources.GetObject("txttotalamount.IconPadding"), Integer))
        Me.txttotalamount.Name = "txttotalamount"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.ErrorProvider1.SetError(Me.Label10, resources.GetString("Label10.Error"))
        Me.Label10.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label10, CType(resources.GetObject("Label10.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label10, CType(resources.GetObject("Label10.IconPadding"), Integer))
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.ErrorProvider1.SetError(Me.Label9, resources.GetString("Label9.Error"))
        Me.Label9.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label9, CType(resources.GetObject("Label9.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label9, CType(resources.GetObject("Label9.IconPadding"), Integer))
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.ErrorProvider1.SetError(Me.Label8, resources.GetString("Label8.Error"))
        Me.Label8.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label8, CType(resources.GetObject("Label8.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label8, CType(resources.GetObject("Label8.IconPadding"), Integer))
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.ErrorProvider1.SetError(Me.Label7, resources.GetString("Label7.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.Label7, CType(resources.GetObject("Label7.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label7, CType(resources.GetObject("Label7.IconPadding"), Integer))
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.ErrorProvider1.SetError(Me.Label6, resources.GetString("Label6.Error"))
        Me.Label6.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label6, CType(resources.GetObject("Label6.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label6, CType(resources.GetObject("Label6.IconPadding"), Integer))
        Me.Label6.Name = "Label6"
        '
        'Order1BindingSource
        '
        Me.Order1BindingSource.DataMember = "order1"
        Me.Order1BindingSource.DataSource = Me.SaleDataSet6
        '
        'SaleDataSet6
        '
        Me.SaleDataSet6.DataSetName = "saleDataSet6"
        Me.SaleDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order1TableAdapter
        '
        Me.Order1TableAdapter.ClearBeforeFill = True
        '
        'billid1
        '
        Me.billid1.AccessibleDescription = Nothing
        Me.billid1.AccessibleName = Nothing
        resources.ApplyResources(Me.billid1, "billid1")
        Me.billid1.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.billid1, resources.GetString("billid1.Error"))
        Me.billid1.Font = Nothing
        Me.billid1.FormattingEnabled = True
        Me.ErrorProvider1.SetIconAlignment(Me.billid1, CType(resources.GetObject("billid1.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.billid1, CType(resources.GetObject("billid1.IconPadding"), Integer))
        Me.billid1.Name = "billid1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        resources.ApplyResources(Me.ErrorProvider1, "ErrorProvider1")
        '
        'billid
        '
        Me.billid.AccessibleDescription = Nothing
        Me.billid.AccessibleName = Nothing
        resources.ApplyResources(Me.billid, "billid")
        Me.ErrorProvider1.SetError(Me.billid, resources.GetString("billid.Error"))
        Me.billid.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.billid, CType(resources.GetObject("billid.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.billid, CType(resources.GetObject("billid.IconPadding"), Integer))
        Me.billid.Name = "billid"
        '
        'net
        '
        Me.net.AccessibleDescription = Nothing
        Me.net.AccessibleName = Nothing
        resources.ApplyResources(Me.net, "net")
        Me.net.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.net, resources.GetString("net.Error"))
        Me.net.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.net, CType(resources.GetObject("net.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.net, CType(resources.GetObject("net.IconPadding"), Integer))
        Me.net.Name = "net"
        '
        'Label13
        '
        Me.Label13.AccessibleDescription = Nothing
        Me.Label13.AccessibleName = Nothing
        resources.ApplyResources(Me.Label13, "Label13")
        Me.ErrorProvider1.SetError(Me.Label13, resources.GetString("Label13.Error"))
        Me.Label13.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Label13, CType(resources.GetObject("Label13.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label13, CType(resources.GetObject("Label13.IconPadding"), Integer))
        Me.Label13.Name = "Label13"
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleDescription = Nothing
        Me.DataGridView1.AccessibleName = Nothing
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BackgroundImage = Nothing
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.ErrorProvider1.SetError(Me.DataGridView1, resources.GetString("DataGridView1.Error"))
        Me.DataGridView1.Font = Nothing
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.ErrorProvider1.SetIconAlignment(Me.DataGridView1, CType(resources.GetObject("DataGridView1.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.DataGridView1, CType(resources.GetObject("DataGridView1.IconPadding"), Integer))
        Me.DataGridView1.Name = "DataGridView1"
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        resources.ApplyResources(Me.Column4, "Column4")
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        resources.ApplyResources(Me.Column5, "Column5")
        Me.Column5.Name = "Column5"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AccessibleDescription = Nothing
        Me.StatusStrip1.AccessibleName = Nothing
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.StatusStrip1, resources.GetString("StatusStrip1.Error"))
        Me.StatusStrip1.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.StatusStrip1, CType(resources.GetObject("StatusStrip1.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.StatusStrip1, CType(resources.GetObject("StatusStrip1.IconPadding"), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AccessibleDescription = Nothing
        Me.ToolStripStatusLabel1.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.BackgroundImage = Nothing
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = Nothing
        Me.Button1.AccessibleName = Nothing
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackgroundImage = Nothing
        Me.ErrorProvider1.SetError(Me.Button1, resources.GetString("Button1.Error"))
        Me.Button1.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Button1, CType(resources.GetObject("Button1.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Button1, CType(resources.GetObject("Button1.IconPadding"), Integer))
        Me.Button1.Image = Global.shop.My.Resources.Resources.Delete
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = Nothing
        Me.Button2.AccessibleName = Nothing
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.BackgroundImage = Global.shop.My.Resources.Resources.cabinet
        Me.ErrorProvider1.SetError(Me.Button2, resources.GetString("Button2.Error"))
        Me.Button2.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Button2, CType(resources.GetObject("Button2.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Button2, CType(resources.GetObject("Button2.IconPadding"), Integer))
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AccessibleDescription = Nothing
        Me.Button3.AccessibleName = Nothing
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackgroundImage = Global.shop.My.Resources.Resources.Speech_Bubble
        Me.ErrorProvider1.SetError(Me.Button3, resources.GetString("Button3.Error"))
        Me.Button3.Font = Nothing
        Me.ErrorProvider1.SetIconAlignment(Me.Button3, CType(resources.GetObject("Button3.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Button3, CType(resources.GetObject("Button3.IconPadding"), Integer))
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Normalsale
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.net)
        Me.Controls.Add(Me.billid1)
        Me.Controls.Add(Me.billid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dates)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtbal)
        Me.Controls.Add(Me.txtpay)
        Me.Controls.Add(Me.txtdisco)
        Me.Controls.Add(Me.txttotalamount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MaximizeBox = False
        Me.Name = "Normalsale"
        Me.ShowInTaskbar = False
        CType(Me.Order1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dates As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtbal As System.Windows.Forms.TextBox
    Friend WithEvents txtpay As System.Windows.Forms.TextBox
    Friend WithEvents txtdisco As System.Windows.Forms.TextBox
    Friend WithEvents txttotalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SaleDataSet6 As shop.saleDataSet6
    Friend WithEvents Order1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order1TableAdapter As shop.saleDataSet6TableAdapters.order1TableAdapter
    Friend WithEvents billid1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents billid As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents net As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
