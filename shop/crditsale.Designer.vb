<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crditsale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crditsale))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.terms = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Order1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet1 = New shop.saleDataSet1
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.txtpayment = New System.Windows.Forms.TextBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.ComboBox
        Me.cusdate = New System.Windows.Forms.DateTimePicker
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.initial = New System.Windows.Forms.ComboBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.Order1TableAdapter = New shop.saleDataSet1TableAdapters.order1TableAdapter
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtcusid = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.txtbillid = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label23 = New System.Windows.Forms.Label
        Me.net = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtcustp = New System.Windows.Forms.MaskedTextBox
        CType(Me.Order1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_inid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_initemname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_initemname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inunitprice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inunitprice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@inid", System.Data.SqlDbType.Int, 0, "inid"), New System.Data.SqlClient.SqlParameter("@initemname", System.Data.SqlDbType.VarChar, 0, "initemname"), New System.Data.SqlClient.SqlParameter("@inunitprice", System.Data.SqlDbType.Money, 0, "inunitprice"), New System.Data.SqlClient.SqlParameter("@Original_inid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_initemname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_initemname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "initemname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inunitprice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inunitprice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inunitprice", System.Data.DataRowVersion.Original, Nothing)})
        '
        'terms
        '
        Me.terms.FormattingEnabled = True
        Me.terms.Location = New System.Drawing.Point(318, 488)
        Me.terms.Name = "terms"
        Me.terms.Size = New System.Drawing.Size(140, 21)
        Me.terms.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(315, 467)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 13)
        Me.Label20.TabIndex = 125
        Me.Label20.Text = "Discount Terms "
        '
        'Order1BindingSource
        '
        Me.Order1BindingSource.DataMember = "order1"
        Me.Order1BindingSource.DataSource = Me.SaleDataSet1
        '
        'SaleDataSet1
        '
        Me.SaleDataSet1.DataSetName = "saleDataSet1"
        Me.SaleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.shop.My.Resources.Resources.cabinet
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(14, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(482, 467)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Discount"
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(485, 487)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(116, 20)
        Me.txtdiscount.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(159, 514)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Balance"
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(162, 530)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(116, 20)
        Me.txtbalance.TabIndex = 20
        '
        'txtpayment
        '
        Me.txtpayment.Location = New System.Drawing.Point(19, 530)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(116, 20)
        Me.txtpayment.TabIndex = 19
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(162, 491)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(116, 20)
        Me.txtamount.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 514)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "Pay ment"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.shop.My.Resources.Resources.Speech_Bubble
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(125, 564)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 44)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Bill "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(399, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 51)
        Me.Label19.TabIndex = 122
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(159, 467)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "Total Amount "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 467)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Crdit Id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(526, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Customer  Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(392, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Customer TP No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(558, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Customer Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(392, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Custom Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Customer Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Customer Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Customer First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Customer Initial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Customer ID"
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"cole sale"})
        Me.status.Location = New System.Drawing.Point(561, 165)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(131, 21)
        Me.status.TabIndex = 6
        '
        'cusdate
        '
        Me.cusdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cusdate.Location = New System.Drawing.Point(395, 164)
        Me.cusdate.Name = "cusdate"
        Me.cusdate.Size = New System.Drawing.Size(116, 20)
        Me.cusdate.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(519, 205)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(199, 20)
        Me.txtemail.TabIndex = 8
        '
        'initial
        '
        Me.initial.FormattingEnabled = True
        Me.initial.Items.AddRange(New Object() {"Mr.", "Miss.", "Mr.miss.."})
        Me.initial.Location = New System.Drawing.Point(30, 77)
        Me.initial.Name = "initial"
        Me.initial.Size = New System.Drawing.Size(140, 21)
        Me.initial.TabIndex = 1
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(30, 158)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(321, 67)
        Me.txtaddress.TabIndex = 4
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(395, 116)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(297, 20)
        Me.txtlname.TabIndex = 3
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(30, 116)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(308, 20)
        Me.txtfname.TabIndex = 2
        '
        'Order1TableAdapter
        '
        Me.Order1TableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(30, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'txtcusid
        '
        Me.txtcusid.AutoSize = True
        Me.txtcusid.Location = New System.Drawing.Point(27, 40)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(52, 13)
        Me.txtcusid.TabIndex = 133
        Me.txtcusid.Text = "Label23"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(14, 491)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox2.TabIndex = 14
        '
        'txtbillid
        '
        Me.txtbillid.AutoSize = True
        Me.txtbillid.Location = New System.Drawing.Point(27, 494)
        Me.txtbillid.Name = "txtbillid"
        Me.txtbillid.Size = New System.Drawing.Size(0, 13)
        Me.txtbillid.TabIndex = 135
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(624, 467)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 137
        Me.Label23.Text = "Net Amount"
        '
        'net
        '
        Me.net.Location = New System.Drawing.Point(628, 487)
        Me.net.Name = "net"
        Me.net.Size = New System.Drawing.Size(116, 20)
        Me.net.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Nina", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(439, 37)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 33)
        Me.Label24.TabIndex = 138
        Me.Label24.Text = "00"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.shop.My.Resources.Resources.Delete
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(671, 564)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 44)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.id})
        Me.DataGridView1.Location = New System.Drawing.Point(50, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 233)
        Me.DataGridView1.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(805, 22)
        Me.StatusStrip1.TabIndex = 141
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'txtcustp
        '
        Me.txtcustp.Location = New System.Drawing.Point(395, 205)
        Me.txtcustp.Mask = "(999) 000-0000"
        Me.txtcustp.Name = "txtcustp"
        Me.txtcustp.Size = New System.Drawing.Size(100, 20)
        Me.txtcustp.TabIndex = 142
        '
        'crditsale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 633)
        Me.Controls.Add(Me.txtcustp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.net)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.txtbillid)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.terms)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.cusdate)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.initial)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "crditsale"
        Me.ShowInTaskbar = False
        Me.Text = "Credit Sale"
        CType(Me.Order1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents terms As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtpayment As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents cusdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents initial As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents SaleDataSet1 As shop.saleDataSet1
    Friend WithEvents Order1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order1TableAdapter As shop.saleDataSet1TableAdapters.order1TableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtcusid As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtbillid As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents net As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtcustp As System.Windows.Forms.MaskedTextBox
End Class
