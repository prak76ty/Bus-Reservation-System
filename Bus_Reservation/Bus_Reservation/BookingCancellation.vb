Imports System.Data.SqlClient
Public Class BookingCancellation
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t, i, PK, FAD, ADA, Z As Integer
    Dim Rno, BNo2, SType, Sr, Pname, Pgender, Page, l, m, n, o As String

    Private Sub BookingCancellation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select max(CancellationNo) From Cancellation", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        CNumber.Text = t.ToString
        dr.Close()
    End Sub
    Private Sub BNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNo.Click
        clearall()
        Try
            If BNo.Text.Trim = "" Then
                MsgBox("Plz.. Enter Correct Booking No")
            Else
                info()
            End If
        Catch ex As Exception
            MsgBox("No Record Found")
        End Try
    End Sub
    Private Sub SNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNo.Click
        clearall()
        Try
            If SeatNo1.Text.Trim = "" Then
                MsgBox("Plz.. Enter Correct Seat No")
            ElseIf ST1.Text.Trim = "" And ST1.Text = "Select" Then
                MsgBox("Plz.. Enter Correct SeatType")
            Else
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("Select Distinct From PassengerDetails Where SeatNo='" & SeatNo1.Text & "' and SeatType='" & ST1.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                BookingNo.Text = dr.GetValue(0)
                BookingNo1.Text = dr.GetValue(0)
                dr.Close()
                info()
            End If
        Catch ex As Exception
            MsgBox("No Record Found")
        End Try
    End Sub
    Private Sub BName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BName.Click
        clearall()
        Try
            If BookedName1.Text.Trim = "" Then
                MsgBox("Plz.. Enter Correct Booking No")
            Else
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("Select * From PaymentPassenger Where PassengerName='" & BookedName1.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                BookingNo.Text = dr.GetValue(0)
                BookingNo1.Text = dr.GetValue(0)
                dr.Close()
                info()
            End If
        Catch ex As Exception
            MsgBox("No Record Found")
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        BookingNo1.Clear()
        ST1.Text = ""
        SeatNo1.Clear()
        BookedName1.Clear()
        BookingNo.Clear()
        S1.Clear()
        S2.Clear()
        BBName.Clear()
        PaymentBy.Text = ""
        Bcontact.Clear()
        BNumber2.Clear()
        BReservation.Clear()
    End Sub
    Sub info()
        PK = 4
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select * From PaymentPassenger Where BookingNo=" & BookingNo1.Text & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        BookingNo.Text = dr.GetValue(0)
        BDate.Value = dr.GetValue(2)
        BBName.Text = dr.GetValue(6)
        BookedName1.Text = dr.GetValue(6)
        Bcontact.Text = dr.GetValue(8)
        'BTime.Text = dr.GetValue(14)
        dr.Close()

        cmd = New SqlCommand("Select * From PassengerDetails Where BookingNo=" & BookingNo1.Text & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Rno = dr.GetValue(1)
        BNo2 = dr.GetValue(2)
        PaymentBy.Text = dr.GetValue(10)
        dr.Close()
        cmd = New SqlCommand("Select * From Route Where Rno=" & Rno & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        S1.Text = dr.GetValue(4)
        S2.Text = dr.GetValue(5)
        dr.Close()
        cmd = New SqlCommand("Select * From Bus Where BusSno=" & BNo2 & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        BNumber2.Text = dr.GetValue(1)
        BReservation.Text = dr.GetValue(4)
        dr.Close()
        checkvisibility()
        CheckSeats()
        con.Close()
    End Sub
    Sub CheckSeats()
        Dim check, SeatType As String
        SeatType = "L"
        If SeatType = "L" Then
            check = "1"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox1.Enabled = True
                CheckBox1.Checked = True
            End If
            dr.Close()
            check = "2"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox2.Enabled = True
                CheckBox2.Checked = True
            End If
            dr.Close()
            check = "3"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox3.Enabled = True
                CheckBox3.Checked = True
            End If
            dr.Close()
            check = "4"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox4.Enabled = True
                CheckBox4.Checked = True
            End If
            dr.Close()
            check = "5"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox5.Enabled = True
                CheckBox5.Checked = True
            End If
            dr.Close()
            check = "6"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox6.Enabled = True
                CheckBox6.Checked = True
            End If
            dr.Close()
            check = "7"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox7.Enabled = True
                CheckBox7.Checked = True
            End If
            dr.Close()
            check = "8"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox8.Enabled = True
                CheckBox8.Checked = True
            End If
            dr.Close()
            check = "9"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox9.Enabled = True
                CheckBox9.Checked = True
            End If
            dr.Close()
            check = "10"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox10.Enabled = True
                CheckBox10.Checked = True
            End If
            dr.Close()
            check = "11"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox11.Enabled = True
                CheckBox11.Checked = True
            End If
            dr.Close()
            check = "12"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox12.Enabled = True
                CheckBox12.Checked = True
            End If
            dr.Close()
            check = "13"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox13.Enabled = True
                CheckBox13.Checked = True
            End If
            dr.Close()
            check = "14"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox14.Enabled = True
                CheckBox14.Checked = True
            End If
            dr.Close()
            check = "15"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox15.Enabled = True
                CheckBox15.Checked = True
            End If
            dr.Close()
            check = "16"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox16.Enabled = True
                CheckBox16.Checked = True
            End If
            dr.Close()
            check = "17"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox17.Enabled = True
                CheckBox17.Checked = True
            End If
            dr.Close()
            check = "18"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox18.Enabled = True
                CheckBox18.Checked = True
            End If
            dr.Close()
            check = "19"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox19.Enabled = True
                CheckBox19.Checked = True
            End If
            dr.Close()
            check = "20"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox20.Enabled = True
                CheckBox20.Checked = True
            End If
            dr.Close()
            check = "21"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox21.Enabled = True
                CheckBox21.Checked = True
            End If
            dr.Close()
            check = "22"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox22.Enabled = True
                CheckBox22.Checked = True
            End If
            dr.Close()
            check = "23"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox23.Enabled = True
                CheckBox23.Checked = True
            End If
            dr.Close()
            check = "24"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox24.Enabled = True
                CheckBox24.Checked = True
            End If
            dr.Close()
            check = "25"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox25.Enabled = True
                CheckBox25.Checked = True
            End If
            dr.Close()
            check = "26"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox26.Enabled = True
                CheckBox26.Checked = True
            End If
            dr.Close()
            check = "27"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox27.Enabled = True
                CheckBox27.Checked = True
            End If
            dr.Close()
            check = "28"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox28.Enabled = True
                CheckBox28.Checked = True
            End If
            dr.Close()
            check = "29"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox29.Enabled = True
                CheckBox29.Checked = True
            End If
            dr.Close()
            check = "30"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox30.Enabled = True
                CheckBox30.Checked = True
            End If
            dr.Close()
            check = "31"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox31.Enabled = True
                CheckBox31.Checked = True
            End If
            dr.Close()
            check = "32"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox32.Enabled = True
                CheckBox32.Checked = True
            End If
            dr.Close()
            check = "33"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox33.Enabled = True
                CheckBox33.Checked = True
            End If
            dr.Close()
            check = "34"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox34.Enabled = True
                CheckBox34.Checked = True
            End If
            dr.Close()
            check = "35"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox35.Enabled = True
                CheckBox35.Checked = True
            End If
            dr.Close()
            check = "36"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox36.Enabled = True
                CheckBox36.Checked = True
            End If
            dr.Close()
            check = "37"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox37.Enabled = True
                CheckBox37.Checked = True
            End If
            dr.Close()
            check = "38"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox38.Enabled = True
                CheckBox38.Checked = True
            End If
            dr.Close()
            check = "39"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox39.Enabled = True
                CheckBox39.Checked = True
            End If
            dr.Close()
            check = "40"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox40.Enabled = True
                CheckBox40.Checked = True
            End If
            dr.Close()
        End If
        SeatType = "U"
        If SeatType = "U" Then
            check = "1"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox80.Enabled = True
                CheckBox80.Checked = True
            End If
            dr.Close()
            check = "2"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox79.Enabled = True
                CheckBox79.Checked = True
            End If
            dr.Close()
            check = "3"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox78.Enabled = True
                CheckBox78.Checked = True
            End If
            dr.Close()
            check = "4"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox77.Enabled = True
                CheckBox77.Checked = True
            End If
            dr.Close()
            check = "5"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox76.Enabled = True
                CheckBox76.Checked = True
            End If
            dr.Close()
            check = "6"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox75.Enabled = True
                CheckBox75.Checked = True
            End If
            dr.Close()
            check = "7"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox74.Enabled = True
                CheckBox74.Checked = True
            End If
            dr.Close()
            check = "8"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox73.Enabled = True
                CheckBox73.Checked = True
            End If
            dr.Close()
            check = "9"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox72.Enabled = True
                CheckBox72.Checked = True
            End If
            dr.Close()
            check = "10"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox71.Enabled = True
                CheckBox71.Checked = True
            End If
            dr.Close()
            check = "11"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox70.Enabled = True
                CheckBox70.Checked = True
            End If
            dr.Close()
            check = "12"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox69.Enabled = True
                CheckBox69.Checked = True
            End If
            dr.Close()
            check = "13"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox68.Enabled = True
                CheckBox68.Checked = True
            End If
            dr.Close()
            check = "14"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox67.Enabled = True
                CheckBox67.Checked = True
            End If
            dr.Close()
            check = "15"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox66.Enabled = True
                CheckBox66.Checked = True
            End If
            dr.Close()
            check = "16"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox65.Enabled = True
                CheckBox65.Checked = True
            End If
            dr.Close()
            check = "17"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox64.Enabled = True
                CheckBox64.Checked = True
            End If
            dr.Close()
            check = "18"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox63.Enabled = True
                CheckBox63.Checked = True
            End If
            dr.Close()
            check = "19"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox62.Enabled = True
                CheckBox62.Checked = True
            End If
            dr.Close()
            check = "20"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox61.Enabled = True
                CheckBox61.Checked = True
            End If
            dr.Close()
            check = "21"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox60.Enabled = True
                CheckBox60.Checked = True
            End If
            dr.Close()
            check = "22"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox59.Enabled = True
                CheckBox59.Checked = True
            End If
            dr.Close()
            check = "23"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox58.Enabled = True
                CheckBox58.Checked = True
            End If
            dr.Close()
            check = "24"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox57.Enabled = True
                CheckBox57.Checked = True
            End If
            dr.Close()
            check = "25"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox56.Enabled = True
                CheckBox56.Checked = True
            End If
            dr.Close()
            check = "26"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox55.Enabled = True
                CheckBox55.Checked = True
            End If
            dr.Close()
            check = "27"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox54.Enabled = True
                CheckBox54.Checked = True
            End If
            dr.Close()
            check = "28"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox53.Enabled = True
                CheckBox53.Checked = True
            End If
            dr.Close()
            check = "29"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox52.Enabled = True
                CheckBox52.Checked = True
            End If
            dr.Close()
            check = "30"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox51.Enabled = True
                CheckBox51.Checked = True
            End If
            dr.Close()
            check = "31"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox50.Enabled = True
                CheckBox50.Checked = True
            End If
            dr.Close()
            check = "32"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox49.Enabled = True
                CheckBox49.Checked = True
            End If
            dr.Close()
            check = "33"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox48.Enabled = True
                CheckBox48.Checked = True
            End If
            dr.Close()
            check = "34"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox47.Enabled = True
                CheckBox47.Checked = True
            End If
            dr.Close()
            check = "35"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox46.Enabled = True
                CheckBox46.Checked = True
            End If
            dr.Close()
            check = "36"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox45.Enabled = True
                CheckBox45.Checked = True
            End If
            dr.Close()
            check = "37"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox44.Enabled = True
                CheckBox44.Checked = True
            End If
            dr.Close()
            check = "38"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox43.Enabled = True
                CheckBox43.Checked = True
            End If
            dr.Close()
            check = "39"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox42.Enabled = True
                CheckBox42.Checked = True
            End If
            dr.Close()
            check = "40"
            cmd = New SqlCommand("Select BookingNo,SeatNo,SeatType From PassengerDetails where BookingNo=" & BookingNo1.Text & " and SeatNo='" & check & "' and SeatType='" & SeatType & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox41.Enabled = True
                CheckBox41.Checked = True
            End If
            dr.Close()
        End If
    End Sub
    Sub clearall()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False
        CheckBox30.Checked = False
        CheckBox31.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox36.Checked = False
        CheckBox37.Checked = False
        CheckBox38.Checked = False
        CheckBox39.Checked = False
        CheckBox40.Checked = False
        CheckBox41.Checked = False
        CheckBox42.Checked = False
        CheckBox43.Checked = False
        CheckBox44.Checked = False
        CheckBox45.Checked = False
        CheckBox46.Checked = False
        CheckBox47.Checked = False
        CheckBox48.Checked = False
        CheckBox49.Checked = False
        CheckBox50.Checked = False
        CheckBox51.Checked = False
        CheckBox52.Checked = False
        CheckBox53.Checked = False
        CheckBox54.Checked = False
        CheckBox55.Checked = False
        CheckBox56.Checked = False
        CheckBox57.Checked = False
        CheckBox58.Checked = False
        CheckBox59.Checked = False
        CheckBox60.Checked = False
        CheckBox61.Checked = False
        CheckBox62.Checked = False
        CheckBox63.Checked = False
        CheckBox64.Checked = False
        CheckBox65.Checked = False
        CheckBox66.Checked = False
        CheckBox67.Checked = False
        CheckBox68.Checked = False
        CheckBox69.Checked = False
        CheckBox70.Checked = False
        CheckBox71.Checked = False
        CheckBox72.Checked = False
        CheckBox73.Checked = False
        CheckBox74.Checked = False
        CheckBox75.Checked = False
        CheckBox76.Checked = False
        CheckBox77.Checked = False
        CheckBox78.Checked = False
        CheckBox79.Checked = False
        CheckBox80.Checked = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False
        CheckBox12.Enabled = False
        CheckBox13.Enabled = False
        CheckBox14.Enabled = False
        CheckBox15.Enabled = False
        CheckBox16.Enabled = False
        CheckBox17.Enabled = False
        CheckBox18.Enabled = False
        CheckBox19.Enabled = False
        CheckBox20.Enabled = False
        CheckBox21.Enabled = False
        CheckBox22.Enabled = False
        CheckBox23.Enabled = False
        CheckBox24.Enabled = False
        CheckBox25.Enabled = False
        CheckBox26.Enabled = False
        CheckBox27.Enabled = False
        CheckBox28.Enabled = False
        CheckBox29.Enabled = False
        CheckBox30.Enabled = False
        CheckBox31.Enabled = False
        CheckBox32.Enabled = False
        CheckBox33.Enabled = False
        CheckBox34.Enabled = False
        CheckBox35.Enabled = False
        CheckBox36.Enabled = False
        CheckBox37.Enabled = False
        CheckBox38.Enabled = False
        CheckBox39.Enabled = False
        CheckBox40.Enabled = False
        CheckBox41.Enabled = False
        CheckBox42.Enabled = False
        CheckBox43.Enabled = False
        CheckBox44.Enabled = False
        CheckBox45.Enabled = False
        CheckBox46.Enabled = False
        CheckBox47.Enabled = False
        CheckBox48.Enabled = False
        CheckBox49.Enabled = False
        CheckBox50.Enabled = False
        CheckBox51.Enabled = False
        CheckBox52.Enabled = False
        CheckBox53.Enabled = False
        CheckBox54.Enabled = False
        CheckBox55.Enabled = False
        CheckBox56.Enabled = False
        CheckBox57.Enabled = False
        CheckBox58.Enabled = False
        CheckBox59.Enabled = False
        CheckBox60.Enabled = False
        CheckBox61.Enabled = False
        CheckBox62.Enabled = False
        CheckBox63.Enabled = False
        CheckBox64.Enabled = False
        CheckBox65.Enabled = False
        CheckBox66.Enabled = False
        CheckBox67.Enabled = False
        CheckBox68.Enabled = False
        CheckBox69.Enabled = False
        CheckBox70.Enabled = False
        CheckBox71.Enabled = False
        CheckBox72.Enabled = False
        CheckBox73.Enabled = False
        CheckBox74.Enabled = False
        CheckBox75.Enabled = False
        CheckBox76.Enabled = False
        CheckBox77.Enabled = False
        CheckBox78.Enabled = False
        CheckBox79.Enabled = False
        CheckBox80.Enabled = False
    End Sub

    Private Sub CB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB.Click
        If BookingNo1.Text.Trim = "" Then
            MsgBox("Plz.. Enter Booking No..")
        ElseIf BookedName1.Text.Trim = "" Then
            MsgBox("Plz.. Enter Booked By Name..")
        ElseIf CCharges.Text.Trim = "" Then
            MsgBox("Plz.. Enter Cancellation Charges..")
        Else
            Z = 0
            Dim res As DialogResult = MessageBox.Show("Do U Want To Cancel Booking?", "Cancel Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If res = DialogResult.Yes Then
                If CheckBox1.Checked = True Then
                    InsertDB(1)
                End If
                If CheckBox2.Checked = True Then
                    InsertDB(2)
                End If
                If CheckBox3.Checked = True Then
                    InsertDB(3)
                End If
                If CheckBox4.Checked = True Then
                    InsertDB(4)
                End If
                If CheckBox5.Checked = True Then
                    InsertDB(5)
                End If
                If CheckBox6.Checked = True Then
                    InsertDB(6)
                End If
                If CheckBox7.Checked = True Then
                    InsertDB(7)
                End If
                If CheckBox8.Checked = True Then
                    InsertDB(8)
                End If
                If CheckBox9.Checked = True Then
                    InsertDB(9)
                End If
                If CheckBox10.Checked = True Then
                    InsertDB(10)
                End If
                If CheckBox11.Checked = True Then
                    InsertDB(11)
                End If
                If CheckBox12.Checked = True Then
                    InsertDB(12)
                End If
                If CheckBox13.Checked = True Then
                    InsertDB(13)
                End If
                If CheckBox14.Checked = True Then
                    InsertDB(14)
                End If
                If CheckBox15.Checked = True Then
                    InsertDB(15)
                End If
                If CheckBox16.Checked = True Then
                    InsertDB(16)
                End If
                If CheckBox17.Checked = True Then
                    InsertDB(17)
                End If
                If CheckBox18.Checked = True Then
                    InsertDB(18)
                End If
                If CheckBox19.Checked = True Then
                    InsertDB(19)
                End If
                If CheckBox20.Checked = True Then
                    InsertDB(20)
                End If
                If CheckBox21.Checked = True Then
                    InsertDB(21)
                End If
                If CheckBox22.Checked = True Then
                    InsertDB(22)
                End If
                If CheckBox23.Checked = True Then
                    InsertDB(23)
                End If
                If CheckBox24.Checked = True Then
                    InsertDB(24)
                End If
                If CheckBox25.Checked = True Then
                    InsertDB(25)
                End If
                If CheckBox26.Checked = True Then
                    InsertDB(26)
                End If
                If CheckBox27.Checked = True Then
                    InsertDB(27)
                End If
                If CheckBox28.Checked = True Then
                    InsertDB(28)
                End If
                If CheckBox29.Checked = True Then
                    InsertDB(29)
                End If
                If CheckBox30.Checked = True Then
                    InsertDB(30)
                End If
                If CheckBox31.Checked = True Then
                    InsertDB(31)
                End If
                If CheckBox32.Checked = True Then
                    InsertDB(32)
                End If
                If CheckBox33.Checked = True Then
                    InsertDB(33)
                End If
                If CheckBox34.Checked = True Then
                    InsertDB(34)
                End If
                If CheckBox35.Checked = True Then
                    InsertDB(35)
                End If
                If CheckBox36.Checked = True Then
                    InsertDB(36)
                End If
                If CheckBox37.Checked = True Then
                    InsertDB(37)
                End If
                If CheckBox38.Checked = True Then
                    InsertDB(38)
                End If
                If CheckBox39.Checked = True Then
                    InsertDB(39)
                End If
                If CheckBox40.Checked = True Then
                    InsertDB(40)
                End If
                If CheckBox41.Checked = True Then
                    InsertDB(40)
                End If
                If CheckBox42.Checked = True Then
                    InsertDB(39)
                End If
                If CheckBox43.Checked = True Then
                    InsertDB(38)
                End If
                If CheckBox44.Checked = True Then
                    InsertDB(37)
                End If
                If CheckBox45.Checked = True Then
                    InsertDB(36)
                End If
                If CheckBox46.Checked = True Then
                    InsertDB(35)
                End If
                If CheckBox47.Checked = True Then
                    InsertDB(34)
                End If
                If CheckBox48.Checked = True Then
                    InsertDB(33)
                End If
                If CheckBox49.Checked = True Then
                    InsertDB(32)
                End If
                If CheckBox50.Checked = True Then
                    InsertDB(31)
                End If
                If CheckBox51.Checked = True Then
                    InsertDB(30)
                End If
                If CheckBox52.Checked = True Then
                    InsertDB(29)
                End If
                If CheckBox53.Checked = True Then
                    InsertDB(28)
                End If
                If CheckBox54.Checked = True Then
                    InsertDB(27)
                End If
                If CheckBox55.Checked = True Then
                    InsertDB(26)
                End If
                If CheckBox56.Checked = True Then
                    InsertDB(25)
                End If
                If CheckBox57.Checked = True Then
                    InsertDB(24)
                End If
                If CheckBox58.Checked = True Then
                    InsertDB(23)
                End If
                If CheckBox59.Checked = True Then
                    InsertDB(22)
                End If
                If CheckBox60.Checked = True Then
                    InsertDB(21)
                End If
                If CheckBox61.Checked = True Then
                    InsertDB(20)
                End If
                If CheckBox62.Checked = True Then
                    InsertDB(19)
                End If
                If CheckBox63.Checked = True Then
                    InsertDB(18)
                End If
                If CheckBox64.Checked = True Then
                    InsertDB(17)
                End If
                If CheckBox65.Checked = True Then
                    InsertDB(16)
                End If
                If CheckBox66.Checked = True Then
                    InsertDB(15)
                End If
                If CheckBox67.Checked = True Then
                    InsertDB(14)
                End If
                If CheckBox68.Checked = True Then
                    InsertDB(13)
                End If
                If CheckBox69.Checked = True Then
                    InsertDB(12)
                End If
                If CheckBox70.Checked = True Then
                    InsertDB(11)
                End If
                If CheckBox71.Checked = True Then
                    InsertDB(10)
                End If
                If CheckBox72.Checked = True Then
                    InsertDB(9)
                End If
                If CheckBox73.Checked = True Then
                    InsertDB(8)
                End If
                If CheckBox74.Checked = True Then
                    InsertDB(7)
                End If
                If CheckBox75.Checked = True Then
                    InsertDB(6)
                End If
                If CheckBox76.Checked = True Then
                    InsertDB(5)
                End If
                If CheckBox77.Checked = True Then
                    InsertDB(4)
                End If
                If CheckBox78.Checked = True Then
                    InsertDB(3)
                End If
                If CheckBox79.Checked = True Then
                    InsertDB(2)
                End If
                If CheckBox80.Checked = True Then
                    InsertDB(1)
                End If
                Try
                    Dim BNO1 As String
                    con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                    con.Open()
                    cmd = New SqlCommand("Select * From PassengerDetails Where BookingNo=" & BookingNo1.Text & "", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    BNO1 = dr.GetValue(0)
                    dr.Close()
                    con.Close()
                    If Z <> 0 Then
                        MsgBox("Booked Seat Cancelled")
                    Else
                        MsgBox("No Seat Cancelled")
                    End If
                Catch ex As Exception
                    con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                    con.Open()
                    cmd = New SqlCommand("Delete From PaymentPassenger Where BookingNo=" & BookingNo1.Text & "", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Full Booking Cancelled")
                    con.Close()
                End Try
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("Select max(CancellationNo) From Cancellation", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If (dr.Item(0) IsNot DBNull.Value) Then
                    t = dr.Item(0) + 1
                Else
                    t = 1
                End If
                CNumber.Text = t.ToString
                dr.Close()
                con.Close()
                BookingNo1.Clear()
                ST1.Text = ""
                SeatNo1.Clear()
                BookedName1.Clear()
                BookingNo.Clear()
                S1.Clear()
                S2.Clear()
                BBName.Clear()
                PaymentBy.Text = ""
                Bcontact.Clear()
                BNumber2.Clear()
                BReservation.Clear()
                clearall()
            Else
                MsgBox("No Booking Cancelled")
            End If
        End If
    End Sub
    Sub checkvisibility()
        If BReservation.Text = "2x1" Then
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True
            CheckBox25.Visible = True
            CheckBox26.Visible = True
            CheckBox27.Visible = True
            CheckBox28.Visible = True
            CheckBox29.Visible = True
            CheckBox30.Visible = True
            CheckBox51.Visible = True
            CheckBox52.Visible = True
            CheckBox53.Visible = True
            CheckBox54.Visible = True
            CheckBox55.Visible = True
            CheckBox56.Visible = True
            CheckBox57.Visible = True
            CheckBox58.Visible = True
            CheckBox59.Visible = True
            CheckBox60.Visible = True
        End If
        If BReservation.Text = "2x2" Then
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True
            CheckBox25.Visible = True
            CheckBox26.Visible = True
            CheckBox27.Visible = True
            CheckBox28.Visible = True
            CheckBox29.Visible = True
            CheckBox30.Visible = True
            CheckBox51.Visible = True
            CheckBox52.Visible = True
            CheckBox53.Visible = True
            CheckBox54.Visible = True
            CheckBox55.Visible = True
            CheckBox56.Visible = True
            CheckBox57.Visible = True
            CheckBox58.Visible = True
            CheckBox59.Visible = True
            CheckBox60.Visible = True
            CheckBox31.Visible = True
            CheckBox32.Visible = True
            CheckBox33.Visible = True
            CheckBox34.Visible = True
            CheckBox35.Visible = True
            CheckBox36.Visible = True
            CheckBox37.Visible = True
            CheckBox38.Visible = True
            CheckBox39.Visible = True
            CheckBox40.Visible = True
            CheckBox41.Visible = True
            CheckBox42.Visible = True
            CheckBox43.Visible = True
            CheckBox44.Visible = True
            CheckBox45.Visible = True
            CheckBox46.Visible = True
            CheckBox47.Visible = True
            CheckBox48.Visible = True
            CheckBox49.Visible = True
            CheckBox50.Visible = True
        End If
    End Sub
    Public Sub InsertDB(ByVal SN As Integer)
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select * From PassengerDetails Where BookingNo=" & BookingNo1.Text & " and SeatNo='" & SN & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Rno = dr.GetValue(1)
        BNo2 = dr.GetValue(2)
        Sr = dr.GetValue(3)
        Pname = dr.GetValue(4)
        Pgender = dr.GetValue(5)
        Page = dr.GetValue(6)
        SType = dr.GetValue(8)
        FAD = dr.GetValue(9)
        dr.Close()
        ADA = FAD - Val(CCharges.Text)
        SB(PK)
        cmd = New SqlCommand("Insert Into CancellationPassenger Values(" & CNumber.Text & ",'" & BookingNo.Text & "','" & Rno & "','" & BNo2 & "','" & Sr & "','" & Pname & "','" & Pgender & "','" & Page & "','" & SN & "','" & SType & "','" & FAD & "','" & CCharges.Text & "','" & ADA & "','" & BDate.Value & "','" & PaymentBy.Text & "')", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Delete From PassengerDetails Where BookingNo=" & BookingNo.Text & " and SEATNO='" & SN & "' and SeatType='" & SType & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
        Z = Z + 1
    End Sub
    Sub SB(ByVal x As Integer)
        If x = 4 Then
            cmd = New SqlCommand("Select * From PaymentPassenger Where BookingNo=" & BookingNo1.Text & "", con)
            dr = cmd.ExecuteReader
            dr.Read()
            l = dr.GetValue(1)
            m = dr.GetValue(7)
            n = dr.GetValue(9)
            o = dr.GetValue(10)
            dr.Close()
            cmd = New SqlCommand("Insert Into Cancellation Values(" & CNumber.Text & ",'" & BookingNo.Text & "','" & l & "','" & BDate.Value & "','" & Format(CancDate.Value, "dd/MM/yyyy hh:mm:ss tt") & "','" & BBName.Text & "','" & m & "','" & Bcontact.Text & "','" & n & "','" & o & "')", con)
            cmd.ExecuteNonQuery()
            PK += 1
        End If
    End Sub
End Class