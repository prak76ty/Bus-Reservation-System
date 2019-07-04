Imports System.Data.SqlClient

Public Class Login
    Public a As Integer
    Public LIDT, LIDT2 As String

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Connection
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True"
        con.Open()

        'command
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select username,password from Newuser where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"

        'data reader
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        dr.Read()

        If txtusername.Text.Trim = "" And txtpassword.Text.Trim = "" Then
            MsgBox("Plz Enter Username and Password.. Press OK")
            txtpassword.Clear()
            txtusername.Clear()
            txtusername.Focus()
        ElseIf dr.HasRows Then
            dr.Close()
            cmd = New SqlCommand("select ID from Newuser where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            a = dr.GetValue(0)
            dr.Close()
            Master.LI()
            MsgBox("You Are Connecting To Bus Reservation System... Press OK")
            Me.Hide()
            MDI.Show()
        Else
            MsgBox("Wrong User.. Plz Enter Valid Username and Password Again.. Press OK")
            txtpassword.Clear()
            txtusername.Clear()
            txtusername.Focus()
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim a As New Newuser
        a.Show()
    End Sub
End Class
