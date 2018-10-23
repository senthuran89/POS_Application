<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventry))
        Me.txtdescri = New System.Windows.Forms.TextBox
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.InidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InitemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InunitpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntotalcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InmadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InonhandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InwarrentyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet3 = New shop.saleDataSet3
        Me.warranty = New System.Windows.Forms.ComboBox
        Me.txtunitprce = New System.Windows.Forms.TextBox
        Me.onhand = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.type = New System.Windows.Forms.ComboBox
        Me.txtinnama = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.InventeryTableAdapter = New shop.saleDataSet3TableAdapters.inventeryTableAdapter
        Me.txtinid = New System.Windows.Forms.ComboBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtmade = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(63, 222)
        Me.txtdescri.Multiline = True
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(303, 67)
        Me.txtdescri.TabIndex = 8
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(335, 156)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(109, 20)
        Me.txttotal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Item Descriptian"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InidDataGridViewTextBoxColumn, Me.InitemnameDataGridViewTextBoxColumn, Me.IntypeDataGridViewTextBoxColumn, Me.InqtyDataGridViewTextBoxColumn, Me.InunitpriceDataGridViewTextBoxColumn, Me.IntotalcostDataGridViewTextBoxColumn, Me.IndescriptionDataGridViewTextBoxColumn, Me.InmadeDataGridViewTextBoxColumn, Me.InonhandDataGridViewTextBoxColumn, Me.InwarrentyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InventeryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(678, 209)
        Me.DataGridView1.TabIndex = 36
        '
        'InidDataGridViewTextBoxColumn
        '
        Me.InidDataGridViewTextBoxColumn.DataPropertyName = "inid"
        Me.InidDataGridViewTextBoxColumn.HeaderText = "inid"
        Me.InidDataGridViewTextBoxColumn.Name = "InidDataGridViewTextBoxColumn"
        '
        'InitemnameDataGridViewTextBoxColumn
        '
        Me.InitemnameDataGridViewTextBoxColumn.DataPropertyName = "initemname"
        Me.InitemnameDataGridViewTextBoxColumn.HeaderText = "initemname"
        Me.InitemnameDataGridViewTextBoxColumn.Name = "InitemnameDataGridViewTextBoxColumn"
        '
        'IntypeDataGridViewTextBoxColumn
        '
        Me.IntypeDataGridViewTextBoxColumn.DataPropertyName = "intype"
        Me.IntypeDataGridViewTextBoxColumn.HeaderText = "intype"
        Me.IntypeDataGridViewTextBoxColumn.Name = "IntypeDataGridViewTextBoxColumn"
        '
        'InqtyDataGridViewTextBoxColumn
        '
        Me.InqtyDataGridViewTextBoxColumn.DataPropertyName = "inqty"
        Me.InqtyDataGridViewTextBoxColumn.HeaderText = "inqty"
        Me.InqtyDataGridViewTextBoxColumn.Name = "InqtyDataGridViewTextBoxColumn"
        '
        'InunitpriceDataGridViewTextBoxColumn
        '
        Me.InunitpriceDataGridViewTextBoxColumn.DataPropertyName = "inunitprice"
        Me.InunitpriceDataGridViewTextBoxColumn.HeaderText = "inunitprice"
        Me.InunitpriceDataGridViewTextBoxColumn.Name = "InunitpriceDataGridViewTextBoxColumn"
        '
        'IntotalcostDataGridViewTextBoxColumn
        '
        Me.IntotalcostDataGridViewTextBoxColumn.DataPropertyName = "intotalcost"
        Me.IntotalcostDataGridViewTextBoxColumn.HeaderText = "intotalcost"
        Me.IntotalcostDataGridViewTextBoxColumn.Name = "IntotalcostDataGridViewTextBoxColumn"
        '
        'IndescriptionDataGridViewTextBoxColumn
        '
        Me.IndescriptionDataGridViewTextBoxColumn.DataPropertyName = "indescription"
        Me.IndescriptionDataGridViewTextBoxColumn.HeaderText = "indescription"
        Me.IndescriptionDataGridViewTextBoxColumn.Name = "IndescriptionDataGridViewTextBoxColumn"
        '
        'InmadeDataGridViewTextBoxColumn
        '
        Me.InmadeDataGridViewTextBoxColumn.DataPropertyName = "inmade"
        Me.InmadeDataGridViewTextBoxColumn.HeaderText = "inmade"
        Me.InmadeDataGridViewTextBoxColumn.Name = "InmadeDataGridViewTextBoxColumn"
        '
        'InonhandDataGridViewTextBoxColumn
        '
        Me.InonhandDataGridViewTextBoxColumn.DataPropertyName = "inonhand"
        Me.InonhandDataGridViewTextBoxColumn.HeaderText = "inonhand"
        Me.InonhandDataGridViewTextBoxColumn.Name = "InonhandDataGridViewTextBoxColumn"
        '
        'InwarrentyDataGridViewTextBoxColumn
        '
        Me.InwarrentyDataGridViewTextBoxColumn.DataPropertyName = "inwarrenty"
        Me.InwarrentyDataGridViewTextBoxColumn.HeaderText = "inwarrenty"
        Me.InwarrentyDataGridViewTextBoxColumn.Name = "InwarrentyDataGridViewTextBoxColumn"
        '
        'InventeryBindingSource
        '
        Me.InventeryBindingSource.DataMember = "inventery"
        Me.InventeryBindingSource.DataSource = Me.SaleDataSet3
        '
        'SaleDataSet3
        '
        Me.SaleDataSet3.DataSetName = "saleDataSet3"
        Me.SaleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'warranty
        '
        Me.warranty.FormattingEnabled = True
        Me.warranty.Items.AddRange(New Object() {"Yes", "No"})
        Me.warranty.Location = New System.Drawing.Point(402, 268)
        Me.warranty.Name = "warranty"
        Me.warranty.Size = New System.Drawing.Size(122, 21)
        Me.warranty.TabIndex = 9
        '
        'txtunitprce
        '
        Me.txtunitprce.Location = New System.Drawing.Point(187, 156)
        Me.txtunitprce.Name = "txtunitprce"
        Me.txtunitprce.Size = New System.Drawing.Size(124, 20)
        Me.txtunitprce.TabIndex = 4
        '
        'onhand
        '
        Me.onhand.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.onhand.Location = New System.Drawing.Point(460, 155)
        Me.onhand.Name = "onhand"
        Me.onhand.Size = New System.Drawing.Size(90, 20)
        Me.onhand.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(399, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Item Made"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(474, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Item onhand"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(399, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Item Warranty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Itemtotalcost"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(63, 156)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(79, 20)
        Me.txtqty.TabIndex = 3
        '
        'type
        '
        Me.type.FormattingEnabled = True
        Me.type.Items.AddRange(New Object() {"class type", "electical", "cable", "metal", "Plastic tube", "pvc", "other"})
        Me.type.Location = New System.Drawing.Point(460, 90)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(90, 21)
        Me.type.TabIndex = 2
        '
        'txtinnama
        '
        Me.txtinnama.Location = New System.Drawing.Point(63, 90)
        Me.txtinnama.Name = "txtinnama"
        Me.txtinnama.Size = New System.Drawing.Size(347, 20)
        Me.txtinnama.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Item Qty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Item Unitprice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Item Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Item Id"
        '
        'InventeryTableAdapter
        '
        Me.InventeryTableAdapter.ClearBeforeFill = True
        '
        'txtinid
        '
        Me.txtinid.FormattingEnabled = True
        Me.txtinid.Location = New System.Drawing.Point(63, 40)
        Me.txtinid.Name = "txtinid"
        Me.txtinid.Size = New System.Drawing.Size(140, 21)
        Me.txtinid.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 547)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(706, 22)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'txtmade
        '
        Me.txtmade.FormattingEnabled = True
        Me.txtmade.Items.AddRange(New Object() {"usa", "uk", "japan", "istal", "sony multi national", "pansonic", "pakistan", "indean", "toyato"})
        Me.txtmade.Location = New System.Drawing.Point(402, 227)
        Me.txtmade.Name = "txtmade"
        Me.txtmade.Size = New System.Drawing.Size(122, 21)
        Me.txtmade.TabIndex = 38
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.shop.My.Resources.Resources.Delete
        Me.Button2.Location = New System.Drawing.Point(598, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 60)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "clear"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.shop.My.Resources.Resources.cabinet
        Me.Button1.Location = New System.Drawing.Point(546, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.shop.My.Resources.Resources._Stop
        Me.Button3.Location = New System.Drawing.Point(598, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 64)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Exit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'inventry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 569)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtmade)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtinid)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.warranty)
        Me.Controls.Add(Me.txtunitprce)
        Me.Controls.Add(Me.onhand)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.txtinnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "inventry"
        Me.ShowInTaskbar = False
        Me.Text = "inventry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtdescri As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents warranty As System.Windows.Forms.ComboBox
    Friend WithEvents txtunitprce As System.Windows.Forms.TextBox
    Friend WithEvents onhand As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents type As System.Windows.Forms.ComboBox
    Friend WithEvents txtinnama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaleDataSet3 As shop.saleDataSet3
    Friend WithEvents InventeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventeryTableAdapter As shop.saleDataSet3TableAdapters.inventeryTableAdapter
    Friend WithEvents InidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitemnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InunitpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntotalcostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InmadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InonhandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InwarrentyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtinid As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtmade As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
