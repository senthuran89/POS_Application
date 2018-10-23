<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crditpay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crditpay))
        Me.txtdates = New System.Windows.Forms.TextBox
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtcrdate = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.findname = New System.Windows.Forms.Button
        Me.crfind = New System.Windows.Forms.Button
        Me.Datenow = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.txtnewpay = New System.Windows.Forms.TextBox
        Me.txtnowbalance = New System.Windows.Forms.TextBox
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.txtpayment = New System.Windows.Forms.TextBox
        Me.totalamount = New System.Windows.Forms.TextBox
        Me.txtcrid = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.findid = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdates
        '
        Me.txtdates.Location = New System.Drawing.Point(420, 161)
        Me.txtdates.Name = "txtdates"
        Me.txtdates.Size = New System.Drawing.Size(116, 20)
        Me.txtdates.TabIndex = 38
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_cusid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cusintial", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cusintial", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cusintial", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusintial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cuslname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cuslname", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cuslname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuslname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crid", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crid", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cusid", System.Data.SqlDbType.Int, 0, "cusid"), New System.Data.SqlClient.SqlParameter("@cusintial", System.Data.SqlDbType.[Char], 0, "cusintial"), New System.Data.SqlClient.SqlParameter("@cuslname", System.Data.SqlDbType.VarChar, 0, "cuslname"), New System.Data.SqlClient.SqlParameter("@crid", System.Data.SqlDbType.Int, 0, "crid"), New System.Data.SqlClient.SqlParameter("@Original_cusid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cusintial", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cusintial", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cusintial", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusintial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cuslname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cuslname", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cuslname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuslname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crid", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crid", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [customer] ([cusid], [cusintial], [cuslname], [crid]) VALUES (@cusid," & _
            " @cusintial, @cuslname, @crid);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT cusid, cusintial, cuslname, crid FROM cu" & _
            "stomer WHERE (cusid = @cusid)"
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cusid", System.Data.SqlDbType.Int, 0, "cusid"), New System.Data.SqlClient.SqlParameter("@cusintial", System.Data.SqlDbType.[Char], 0, "cusintial"), New System.Data.SqlClient.SqlParameter("@cuslname", System.Data.SqlDbType.VarChar, 0, "cuslname"), New System.Data.SqlClient.SqlParameter("@crid", System.Data.SqlDbType.Int, 0, "crid")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT     crid, cusdate, crtotalamount, crpayment, crbalance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         credi" & _
            "t"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(560, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Duration"
        '
        'txtcrdate
        '
        Me.txtcrdate.Location = New System.Drawing.Point(563, 161)
        Me.txtcrdate.Name = "txtcrdate"
        Me.txtcrdate.Size = New System.Drawing.Size(81, 20)
        Me.txtcrdate.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(511, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Credit Sale Date"
        '
        'findname
        '
        Me.findname.BackgroundImage = Global.shop.My.Resources.Resources.browse1
        Me.findname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findname.Location = New System.Drawing.Point(403, 41)
        Me.findname.Name = "findname"
        Me.findname.Size = New System.Drawing.Size(63, 33)
        Me.findname.TabIndex = 34
        Me.findname.Text = "Find"
        Me.findname.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.findname.UseVisualStyleBackColor = True
        '
        'crfind
        '
        Me.crfind.BackgroundImage = Global.shop.My.Resources.Resources.browse1
        Me.crfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.crfind.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.crfind.Location = New System.Drawing.Point(574, 38)
        Me.crfind.Name = "crfind"
        Me.crfind.Size = New System.Drawing.Size(70, 36)
        Me.crfind.TabIndex = 33
        Me.crfind.Text = "Find"
        Me.crfind.UseVisualStyleBackColor = True
        '
        'Datenow
        '
        Me.Datenow.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datenow.Location = New System.Drawing.Point(514, 100)
        Me.Datenow.Name = "Datenow"
        Me.Datenow.Size = New System.Drawing.Size(111, 20)
        Me.Datenow.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Payment on now"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(421, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Date"
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_crid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cusdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cusdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cusdate", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crtotalamount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crtotalamount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crtotalamount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crtotalamount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crpayment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crpayment", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crpayment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crpayment", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crbalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crbalance", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crbalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crbalance", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@crid", System.Data.SqlDbType.Int, 0, "crid"), New System.Data.SqlClient.SqlParameter("@cusdate", System.Data.SqlDbType.SmallDateTime, 0, "cusdate"), New System.Data.SqlClient.SqlParameter("@crtotalamount", System.Data.SqlDbType.Money, 0, "crtotalamount"), New System.Data.SqlClient.SqlParameter("@crpayment", System.Data.SqlDbType.Money, 0, "crpayment"), New System.Data.SqlClient.SqlParameter("@crbalance", System.Data.SqlDbType.Money, 0, "crbalance")})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Now Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Pay ment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Total Credit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Crdit Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Customer id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Customer Name"
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@crid", System.Data.SqlDbType.Int, 0, "crid"), New System.Data.SqlClient.SqlParameter("@cusdate", System.Data.SqlDbType.SmallDateTime, 0, "cusdate"), New System.Data.SqlClient.SqlParameter("@crtotalamount", System.Data.SqlDbType.Money, 0, "crtotalamount"), New System.Data.SqlClient.SqlParameter("@crpayment", System.Data.SqlDbType.Money, 0, "crpayment"), New System.Data.SqlClient.SqlParameter("@crbalance", System.Data.SqlDbType.Money, 0, "crbalance"), New System.Data.SqlClient.SqlParameter("@Original_crid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cusdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cusdate", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cusdate", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cusdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crtotalamount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crtotalamount", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crtotalamount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crtotalamount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crpayment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crpayment", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crpayment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crpayment", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_crbalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "crbalance", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_crbalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "crbalance", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     cusid, cusintial, cuslname, crid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         customer"
        '
        'txtnewpay
        '
        Me.txtnewpay.Location = New System.Drawing.Point(38, 240)
        Me.txtnewpay.Name = "txtnewpay"
        Me.txtnewpay.Size = New System.Drawing.Size(116, 20)
        Me.txtnewpay.TabIndex = 17
        '
        'txtnowbalance
        '
        Me.txtnowbalance.Location = New System.Drawing.Point(217, 240)
        Me.txtnowbalance.Name = "txtnowbalance"
        Me.txtnowbalance.Size = New System.Drawing.Size(116, 20)
        Me.txtnowbalance.TabIndex = 18
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(308, 161)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(86, 20)
        Me.txtbalance.TabIndex = 19
        '
        'txtpayment
        '
        Me.txtpayment.Location = New System.Drawing.Point(195, 161)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(86, 20)
        Me.txtpayment.TabIndex = 14
        '
        'totalamount
        '
        Me.totalamount.Location = New System.Drawing.Point(49, 161)
        Me.totalamount.Name = "totalamount"
        Me.totalamount.Size = New System.Drawing.Size(116, 20)
        Me.totalamount.TabIndex = 15
        '
        'txtcrid
        '
        Me.txtcrid.Location = New System.Drawing.Point(476, 46)
        Me.txtcrid.Name = "txtcrid"
        Me.txtcrid.Size = New System.Drawing.Size(91, 20)
        Me.txtcrid.TabIndex = 16
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(49, 46)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(116, 20)
        Me.txtid.TabIndex = 20
        '
        'txtname
        '
        Me.txtname.FormattingEnabled = True
        Me.txtname.Location = New System.Drawing.Point(253, 44)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 21)
        Me.txtname.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(191, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(107, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Balance"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.shop.My.Resources.Resources.Speech_Bubble
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(346, 286)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 41)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "bill"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'findid
        '
        Me.findid.BackgroundImage = Global.shop.My.Resources.Resources.browse1
        Me.findid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findid.Location = New System.Drawing.Point(171, 41)
        Me.findid.Name = "findid"
        Me.findid.Size = New System.Drawing.Size(72, 33)
        Me.findid.TabIndex = 43
        Me.findid.Text = "find"
        Me.findid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.findid.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.shop.My.Resources.Resources.cabinet
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(481, 286)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 41)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 317)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(694, 22)
        Me.StatusStrip1.TabIndex = 48
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'crditpay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 339)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.findid)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtdates)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtcrdate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.findname)
        Me.Controls.Add(Me.crfind)
        Me.Controls.Add(Me.Datenow)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnewpay)
        Me.Controls.Add(Me.txtnowbalance)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.totalamount)
        Me.Controls.Add(Me.txtcrid)
        Me.Controls.Add(Me.txtid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "crditpay"
        Me.ShowInTaskbar = False
        Me.Text = "Credit pay"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdates As System.Windows.Forms.TextBox
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcrdate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents findname As System.Windows.Forms.Button
    Friend WithEvents crfind As System.Windows.Forms.Button
    Friend WithEvents Datenow As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtnewpay As System.Windows.Forms.TextBox
    Friend WithEvents txtnowbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtpayment As System.Windows.Forms.TextBox
    Friend WithEvents totalamount As System.Windows.Forms.TextBox
    Friend WithEvents txtcrid As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.ComboBox
    Friend WithEvents findid As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
