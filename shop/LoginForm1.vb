Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm1
    Dim COM As SqlCommand = New SqlCommand
    Dim DR As SqlDataReader
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim x As String
        If (pa.Text.Length = 0) Then
            MsgBox("Enter the pass word")
        Else

            If (pa.Text = pass.Text) Then
                MDIParent1.Show()
                Me.Visible = False
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


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub un_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles un.SelectedIndexChanged
        
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub pa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pa.TextChanged

    End Sub
End Class
