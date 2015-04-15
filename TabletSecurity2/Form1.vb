
Imports System
Imports System.Data.SqlClient
Imports Kepware.ClientAce


Public Class Form1
    Public LineC3Latch As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True
        LineC3Latch = 0

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call SecurityCheck()
        ' TextBox1.Text = Tag_1
        'TextBox2.Text = Tag_2
        txtV710.Text = Tag_1
        If Tag_1 = "True" And LineC3Latch = 0 Then
            txtV710.Text = 2
            LineC3Latch = 1
        End If
        If TextBox5.Text = "True" Then
            LineC3Latch = 0
            Tag_1 = 0
            txtV710.Text = 1
            Call UpdateSecurityCheck()
        End If
    End Sub

   


    ' Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click

    '  txtV710.Text = 2

    ' End Sub

    Private Sub ReqComplete_Click(sender As Object, e As EventArgs) Handles ReqComplete.Click
        txtV710.Text = 1

    End Sub

    Private Sub txtV710_TextChanged(sender As Object, e As EventArgs) Handles txtV710.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tag10 As Integer
        Tag10 = TextBox3.Text

    End Sub

    
End Class
