<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemdetails))
        Me.itemname = New System.Windows.Forms.ComboBox
        Me.inid = New System.Windows.Forms.TextBox
        Me.Save = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.qty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.unit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.des = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.made = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.onhand = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.warr = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'itemname
        '
        Me.itemname.FormattingEnabled = True
        Me.itemname.Location = New System.Drawing.Point(69, 11)
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(116, 21)
        Me.itemname.TabIndex = 0
        '
        'inid
        '
        Me.inid.Location = New System.Drawing.Point(373, 12)
        Me.inid.Name = "inid"
        Me.inid.Size = New System.Drawing.Size(116, 20)
        Me.inid.TabIndex = 1
        '
        'Save
        '
        Me.Save.BackgroundImage = Global.shop.My.Resources.Resources.browse1
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Save.Location = New System.Drawing.Point(509, 10)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(87, 34)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Find"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Qty"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(69, 77)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(116, 20)
        Me.qty.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item Unit Price"
        '
        'unit
        '
        Me.unit.Location = New System.Drawing.Point(373, 77)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(116, 20)
        Me.unit.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Warrenty"
        '
        'des
        '
        Me.des.Location = New System.Drawing.Point(69, 122)
        Me.des.Multiline = True
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(244, 45)
        Me.des.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "On Hand"
        '
        'made
        '
        Me.made.Location = New System.Drawing.Point(373, 147)
        Me.made.Name = "made"
        Me.made.Size = New System.Drawing.Size(116, 20)
        Me.made.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Made By"
        '
        'onhand
        '
        Me.onhand.Location = New System.Drawing.Point(373, 197)
        Me.onhand.Name = "onhand"
        Me.onhand.Size = New System.Drawing.Size(116, 20)
        Me.onhand.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Item Descriptian"
        '
        'warr
        '
        Me.warr.Location = New System.Drawing.Point(69, 197)
        Me.warr.Name = "warr"
        Me.warr.Size = New System.Drawing.Size(116, 20)
        Me.warr.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "."
        '
        'itemdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 253)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.warr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.onhand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.made)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.des)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.unit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.inid)
        Me.Controls.Add(Me.itemname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "itemdetails"
        Me.ShowInTaskbar = False
        Me.Text = "Itemdetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents itemname As System.Windows.Forms.ComboBox
    Friend WithEvents inid As System.Windows.Forms.TextBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents qty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents unit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents des As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents made As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents onhand As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents warr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
