Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class MDIParent1
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub CashSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashSaleToolStripMenuItem.Click
        Normalsale.MdiParent = Me
        Normalsale.Show()
    End Sub

    Private Sub CreditSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditSaleToolStripMenuItem.Click
        crditsale.MdiParent = Me
        crditsale.Show()
    End Sub

    Private Sub ItemDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDetailsToolStripMenuItem.Click
        itemdetails.MdiParent = Me
        itemdetails.Show()
    End Sub

    Private Sub CriditSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriditSaleToolStripMenuItem.Click
        crditsale.MdiParent = Me
        crditsale.Show()
    End Sub

    Private Sub CreditPayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditPayToolStripMenuItem.Click
        crditpay.MdiParent = Me
        crditpay.Show()
    End Sub

    Private Sub PriceChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceChangeToolStripMenuItem.Click
        price_change.MdiParent = Me
        price_change.Show()
    End Sub

    
    Private Sub WarrentyDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrentyDetailToolStripMenuItem1.Click
        warrenty.MdiParent = Me
        warrenty.Show()
    End Sub

    Private Sub AddNewItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewItemToolStripMenuItem.Click
        inventry.MdiParent = Me
        inventry.Show()
    End Sub


    Private Sub WarrentyAddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrentyAddToolStripMenuItem.Click
        nwarrenty.MdiParent = Me
        nwarrenty.Show()
    End Sub

    
    Private Sub ChangePassWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user.MdiParent = Me
        user.Show()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewUserToolStripMenuItem.Click
        newuser.MdiParent = Me
        newuser.Show()
    End Sub

    Private Sub CashSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashSToolStripMenuItem.Click
        cashreport2.MdiParent = Me
        cashreport2.Show()
    End Sub

    Private Sub CreditSaleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditSaleToolStripMenuItem1.Click
        creditreport.MdiParent = Me
        creditreport.Show()
    End Sub

    Private Sub InvoiceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceReportToolStripMenuItem.Click
        itemreport.MdiParent = Me
        itemreport.Show()
    End Sub

    Private Sub WarrentyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrentyReportToolStripMenuItem.Click
        warrentyreport.MdiParent = Me
        warrentyreport.Show()
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Normalsale.MdiParent = Me
        Normalsale.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        crditsale.MdiParent = Me
        crditsale.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        crditpay.MdiParent = Me
        crditpay.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        warrenty.MdiParent = Me
        warrenty.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        'Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cashreport2.MdiParent = Me
        cashreport2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        creditreport.MdiParent = Me
        creditreport.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        warrentyreport.MdiParent = Me
        warrentyreport.Show()
    End Sub


    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseHover
        Panel1.Visible = True
    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        Panel1.Visible = False
    End Sub



    Private Sub Button11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseHover
        Panel1.Visible = True
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        inventry.MdiParent = Me
        inventry.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        itemdetails.MdiParent = Me
        itemdetails.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        itemreport.MdiParent = Me
        itemreport.Show()
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
        Dim COM As SqlCommand = New SqlCommand
        COM.Connection = CON
        CON.Open()
        COM.CommandText = "Select nam1 from username"
        DR = COM.ExecuteReader
        Do While DR.Read
            un.Items.Add(DR.GetValue(0))
        Loop
        CON.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim x As String
        If (pa.Text.Length = 0) Then
            MsgBox("Enter the pass word")
        Else

            If (pa.Text = pass.Text) Then
                Panel2.Visible = False
                SaleMenuToolStripMenuItem.Enabled = True
                CriditToolStripMenuItem.Enabled = True
                PriceControlToolStripMenuItem.Enabled = True
                WarrentyDetailToolStripMenuItem.Enabled = True
                SummaryReportsToolStripMenuItem.Enabled = True
                UserAccountsCreateToolStripMenuItem.Enabled = True
                Button11.Visible = True
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                Button4.Enabled = True
                Button5.Enabled = True
                Button6.Enabled = True
                Button7.Enabled = True





            Else
                x = MsgBox("Password Enter Error", vbInformation, MsgBoxStyle.OkCancel)
                If x = vbOK Then
                    pa.Clear()
                    pa.Focus()
                Else
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub un_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles un.SelectedIndexChanged
        Try
            Dim CON As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=sale;Integrated Security=True")
            Dim COM As SqlCommand = New SqlCommand
            COM.Connection = CON
            CON.Open()
            COM.CommandText = "Select passwor from username where nam1='" & un.Text.Trim & "'"
            DR = COM.ExecuteReader
            Do While DR.Read
                pass.Text = DR.GetValue(0)
            Loop
            CON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub ChangePasswordToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        user.MdiParent = Me
        user.Show()
    End Sub
End Class
