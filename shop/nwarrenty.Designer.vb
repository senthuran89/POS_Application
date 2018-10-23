<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nwarrenty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nwarrenty))
        Me.itemname = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.warr = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.InitemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InwarrentyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet5 = New shop.saleDataSet5
        Me.InventeryTableAdapter = New shop.saleDataSet5TableAdapters.inventeryTableAdapter
        Me.sa = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'itemname
        '
        Me.itemname.FormattingEnabled = True
        Me.itemname.Location = New System.Drawing.Point(70, 52)
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(140, 21)
        Me.itemname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item Name"
        '
        'warr
        '
        Me.warr.FormattingEnabled = True
        Me.warr.Items.AddRange(New Object() {"Yes", "No"})
        Me.warr.Location = New System.Drawing.Point(70, 122)
        Me.warr.Name = "warr"
        Me.warr.Size = New System.Drawing.Size(140, 21)
        Me.warr.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Warenty Change"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(190, 231)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(116, 20)
        Me.id.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InitemnameDataGridViewTextBoxColumn, Me.InwarrentyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InventeryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(244, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(280, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'InitemnameDataGridViewTextBoxColumn
        '
        Me.InitemnameDataGridViewTextBoxColumn.DataPropertyName = "initemname"
        Me.InitemnameDataGridViewTextBoxColumn.HeaderText = "initemname"
        Me.InitemnameDataGridViewTextBoxColumn.Name = "InitemnameDataGridViewTextBoxColumn"
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
        Me.InventeryBindingSource.DataSource = Me.SaleDataSet5
        '
        'SaleDataSet5
        '
        Me.SaleDataSet5.DataSetName = "saleDataSet5"
        Me.SaleDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventeryTableAdapter
        '
        Me.InventeryTableAdapter.ClearBeforeFill = True
        '
        'sa
        '
        Me.sa.BackgroundImage = Global.shop.My.Resources.Resources.cabinet
        Me.sa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sa.Location = New System.Drawing.Point(190, 192)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(162, 59)
        Me.sa.TabIndex = 0
        Me.sa.Text = "Save Changes"
        Me.sa.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 244)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(580, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'nwarrenty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 266)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.sa)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.warr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.itemname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "nwarrenty"
        Me.ShowInTaskbar = False
        Me.Text = "New warrenty"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sa As System.Windows.Forms.Button
    Friend WithEvents itemname As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents warr As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SaleDataSet5 As shop.saleDataSet5
    Friend WithEvents InventeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventeryTableAdapter As shop.saleDataSet5TableAdapters.inventeryTableAdapter
    Friend WithEvents InitemnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InwarrentyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
