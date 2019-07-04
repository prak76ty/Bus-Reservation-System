Imports System.Data.SqlClient

Public Class Newuser
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtfullname.Clear()
        txtAK.Clear()
        txtmobile.Clear()
        txtpassword.Clear()
        txtusername.Clear()
        txtfullname.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtfullname.Text.Trim = "" Then
            MsgBox("Plz.. Enter Full Name..")
        ElseIf txtmobile.Text.Trim = "" Then
            MsgBox("Plz.. Enter Mobile Number..")
        ElseIf txtusername.Text.Trim = "" Then
            MsgBox("Plz.. Enter Username..")
        ElseIf txtpassword.Text.Trim = "" Then
            MsgBox("Plz.. Enter Password..")
        ElseIf txtAK.Text.Trim = "" Then
            MsgBox("Plz.. Enter Access Key..")
        Else
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from  AKPrivate where KeyIMP='" & txtAK.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                cmd = New SqlCommand("Select max(ID) From Newuser", con)
                dr = cmd.ExecuteReader

                dr.Read()
                If (dr.Item(0) IsNot DBNull.Value) Then
                    t = dr.Item(0) + 1
                Else
                    t = 1
                End If
                txtID.Text = t.ToString
                dr.Close()
                cmd = New SqlCommand("Insert Into Newuser values(" & txtID.Text & ",'" & txtfullname.Text & "','" & txtmobile.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Congratulations.. Successfully Registered")
                con.Close()
                txtID.Text = Master.Add("ID", "Newuser")
                Me.Hide()
                Login.BringToFront()
            Else
                MsgBox("Wrong Access Key.. Try Again")
            End If
        End If
    End Sub

    Private Sub Newuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select max(ID) From Newuser", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        txtID.Text = t.ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If UName.Text.Trim = "" Then
                MsgBox("Plz.. Enter UserName..")
            ElseIf OPassword.Text.Trim = "" Then
                MsgBox("Plz.. Enter Old Password..")
            ElseIf NPassword.Text.Trim = "" Or OPassword.Text.Trim = "" Then
                MsgBox("Plz.. Enter New Password and Confirm it..")
            ElseIf NPassword.Text <> CPassword.Text Then
                MsgBox("Plz.. Password You Typed Did Not Match .. Plz Enter New Password Both Boxes..")
            ElseIf AK.Text.Trim = "" Then
                MsgBox("Plz.. Enter Access Key..")
            Else
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("select username,password from Newuser where username='" & UName.Text & "' and password='" & OPassword.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    dr.Close()
                    cmd = New SqlCommand("select * from  AKPrivate where KeyIMP='" & AK.Text & "'", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        dr.Close()
                        cmd = New SqlCommand("Update Newuser Set password='" & NPassword.Text & "' Where username='" & UName.Text & "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Password Changed Successfully..!")
                        AK.Clear()
                        NPassword.Clear()
                        CPassword.Clear()
                        OPassword.Clear()
                        UName.Clear()
                    Else
                        MsgBox("Wrong Access Key..!")
                    End If
                Else
                    MsgBox("Wrong Username and Password..!")
                End If
                dr.Close()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Sorry.. Something Went Wrong..!")
        End Try
    End Sub
End Class