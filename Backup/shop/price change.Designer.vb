<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class price_change
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(price_change))
        Me.unit = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.qty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.find = New System.Windows.Forms.Button
        Me.inid = New System.Windows.Forms.TextBox
        Me.itemname = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.newunit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.sa = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.InitemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InunitpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntotalcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet4 = New shop.saleDataSet4
        Me.InventeryTableAdapter = New shop.saleDataSet4TableAdapters.inventeryTableAdapter
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'unit
        '
        Me.unit.Location = New System.Drawing.Point(54, 131)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(116, 20)
        Me.unit.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Item Unit Price"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(54, 182)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(116, 20)
        Me.qty.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Item Qty"
        '
        'find
        '
        Me.find.BackgroundImage = Global.shop.My.Resources.Resources.browse1
        Me.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.find.Location = New System.Drawing.Point(437, 30)
        Me.find.Name = "find"
        Me.find.Size = New System.Drawing.Size(103, 39)
        Me.find.TabIndex = 8
        Me.find.Text = "Find"
        Me.find.UseVisualStyleBackColor = True
        '
        'inid
        '
        Me.inid.Location = New System.Drawing.Point(315, 33)
        Me.inid.Name = "inid"
        Me.inid.Size = New System.Drawing.Size(116, 20)
        Me.inid.TabIndex = 7
        '
        'itemname
        '
        Me.itemname.FormattingEnabled = True
        Me.itemname.Location = New System.Drawing.Point(54, 32)
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(116, 21)
        Me.itemname.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(188, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 21
        '
        'newunit
        '
        Me.newunit.Location = New System.Drawing.Point(315, 131)
        Me.newunit.Name = "newunit"
        Me.newunit.Size = New System.Drawing.Size(116, 20)
        Me.newunit.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "New Unit Price"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(315, 182)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "New Total cost"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(315, 241)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 20)
        Me.TextBox3.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "ExChange"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(54, 241)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(116, 20)
        Me.TextBox4.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total cost"
        '
        'sa
        '
        Me.sa.BackgroundImage = Global.shop.My.Resources.Resources.cabinet
        Me.sa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sa.Location = New System.Drawing.Point(191, 260)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(87, 43)
        Me.sa.TabIndex = 2
        Me.sa.Text = "Save"
        Me.sa.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InitemnameDataGridViewTextBoxColumn, Me.InqtyDataGridViewTextBoxColumn, Me.InunitpriceDataGridViewTextBoxColumn, Me.IntotalcostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InventeryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(458, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(337, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'InitemnameDataGridViewTextBoxColumn
        '
        Me.InitemnameDataGridViewTextBoxColumn.DataPropertyName = "initemname"
        Me.InitemnameDataGridViewTextBoxColumn.HeaderText = "initemname"
        Me.InitemnameDataGridViewTextBoxColumn.Name = "InitemnameDataGridViewTextBoxColumn"
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
        'InventeryBindingSource
        '
        Me.InventeryBindingSource.DataMember = "inventery"
        Me.InventeryBindingSource.DataSource = Me.SaleDataSet4
        '
        'SaleDataSet4
        '
        Me.SaleDataSet4.DataSetName = "saleDataSet4"
        Me.SaleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventeryTableAdapter
        '
        Me.InventeryTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 293)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(825, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'price_change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(825, 315)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.sa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.newunit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.unit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.find)
        Me.Controls.Add(Me.inid)
        Me.Controls.Add(Me.itemname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "price_change"
        Me.ShowInTaskbar = False
        Me.Text = "price_change"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents unit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents qty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents find As System.Windows.Forms.Button
    Friend WithEvents inid As System.Windows.Forms.TextBox
    Friend WithEvents itemname As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents newunit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sa As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SaleDataSet4 As shop.saleDataSet4
    Friend WithEvents InventeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventeryTableAdapter As shop.saleDataSet4TableAdapters.inventeryTableAdapter
    Friend WithEvents InitemnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InunitpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntotalcostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
