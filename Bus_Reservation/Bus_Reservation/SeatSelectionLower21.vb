Imports System.Data.SqlClient

Public Class SeatSelectionLower21
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t, i, k As Integer
    Public checkm, ST, PN, PassengerN, Pcity, Pcontact, BR, BNO4, RN, BN0 As String
    Public Sub New(ByVal msgreceived, ByVal BN, ByVal R, ByVal B)
        MyBase.New()
        InitializeComponent()
        checkm = msgreceived
        BNO4 = BN
        RN = R
        BN0 = B
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK1()
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK2()
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK3()
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK4()
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK5()
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK6()
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK7()
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK8()
        End If
    End Sub
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK9()
        End If
    End Sub
    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK10()
        End If
    End Sub
    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK11()
        End If
    End Sub
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK12()
        End If
    End Sub
    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK13()
        End If
    End Sub
    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK14()
        End If
    End Sub
    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK15()
        End If
    End Sub
    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK16()
        End If
    End Sub
    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK17()
        End If
    End Sub
    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK18()
        End If
    End Sub
    Private Sub CheckBox19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox19.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK19()
        End If
    End Sub
    Private Sub CheckBox20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox20.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK20()
        End If
    End Sub
    Private Sub CheckBox21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox21.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK21()
        End If
    End Sub
    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK22()
        End If
    End Sub
    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK23()
        End If
    End Sub
    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK24()
        End If
    End Sub
    Private Sub CheckBox25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK25()
        End If
    End Sub
    Private Sub CheckBox26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK26()
        End If
    End Sub
    Private Sub CheckBox27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK27()
        End If
    End Sub
    Private Sub CheckBox28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK28()
        End If
    End Sub
    Private Sub CheckBox29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox29.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK29()
        End If
    End Sub
    Private Sub CheckBox30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox30.CheckedChanged
        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Or i = 15 Or i = 16 Or i = 17 Or i = 18 Or i = 19 Then
            CHK30()
        End If
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If checkm = "NA" Then
            Dim SSU0 As New SeatSelectionUpper21("NA", "NA", RNO.Text, BNO.Text)
            SSU0.BringToFront()
            SSU0.Show()
        Else
            Dim SSU1 As New SeatSelectionUpper21("AB_UN", BookingNo.Text, RNO.Text, BNO.Text)
            SSU1.BringToFront()
            SSU1.Show()
        End If
    End Sub
    Private Sub SeatSelectionLower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PaymentBy.Text = "Select"
        If checkm = "NA" Then
            BookingNo.Text = SeatBooking.BookingNo.Text
        Else
            BookingNo.Text = BNO4
        End If
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        If checkm = "NA" Then
            RNO.Text = RN
            BNO.Text = BN0
        Else
            cmd = New SqlCommand("Select BookingDate From APaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
            dr = cmd.ExecuteReader
            dr.Read()
            DateTimePicker1.Value = dr.GetValue(0)
            RNO.Text = RN
            BNO.Text = BN0
            dr.Close()
        End If
        cmd = New SqlCommand("Select SeatCapacity From Bus Where BusSno=" & BN0 & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        SCapacity.Text = dr.GetValue(0)
        dr.Close()
        If DateTimePicker1.Text = Today And checkm = "AB_UN" And BNO4 <> "SB" Then
            checkm = "NA"
            k = 95
        End If
        Dim check As String
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        check = "1"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox1.Enabled = False
            CheckBox1.BringToFront()
            CheckBox1.BackColor = Color.Red
            CheckBox1.Text = "01 Booked"
        End If
        dr.Close()
        check = "2"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox2.Enabled = False
            CheckBox2.BringToFront()
            CheckBox2.BackColor = Color.Red
            CheckBox2.Text = "02 Booked"
        End If
        dr.Close()
        check = "3"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox3.Enabled = False
            CheckBox3.BringToFront()
            CheckBox3.BackColor = Color.Red
            CheckBox3.Text = "03 Booked"
        End If
        dr.Close()
        check = "4"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox4.Enabled = False
            CheckBox4.BringToFront()
            CheckBox4.BackColor = Color.Red
            CheckBox4.Text = "04 Booked"
        End If
        dr.Close()
        check = "5"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox5.Enabled = False
            CheckBox5.BringToFront()
            CheckBox5.BackColor = Color.Red
            CheckBox5.Text = "05 Booked"
        End If
        dr.Close()
        check = "6"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox6.Enabled = False
            CheckBox6.BringToFront()
            CheckBox6.BackColor = Color.Red
            CheckBox6.Text = "06 Booked"
        End If
        dr.Close()
        check = "7"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox7.Enabled = False
            CheckBox7.BringToFront()
            CheckBox7.BackColor = Color.Red
            CheckBox7.Text = "07 Booked"
        End If
        dr.Close()
        check = "8"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox8.Enabled = False
            CheckBox8.BringToFront()
            CheckBox8.BackColor = Color.Red
            CheckBox8.Text = "08 Booked"
        End If
        dr.Close()
        check = "9"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox9.Enabled = False
            CheckBox9.BringToFront()
            CheckBox9.BackColor = Color.Red
            CheckBox9.Text = "09 Booked"
        End If
        dr.Close()
        check = "10"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox10.Enabled = False
            CheckBox10.BringToFront()
            CheckBox10.BackColor = Color.Red
            CheckBox10.Text = "10 Booked"
        End If
        dr.Close()
        check = "11"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox11.Enabled = False
            CheckBox11.BringToFront()
            CheckBox11.BackColor = Color.Red
            CheckBox11.Text = "11 Booked"
        End If
        dr.Close()
        check = "12"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox12.Enabled = False
            CheckBox12.BringToFront()
            CheckBox12.BackColor = Color.Red
            CheckBox12.Text = "12 Booked"
        End If
        dr.Close()
        check = "13"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox13.Enabled = False
            CheckBox13.BringToFront()
            CheckBox13.BackColor = Color.Red
            CheckBox13.Text = "13 Booked"
        End If
        dr.Close()
        check = "14"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox14.Enabled = False
            CheckBox14.BringToFront()
            CheckBox14.BackColor = Color.Red
            CheckBox14.Text = "14 Booked"
        End If
        dr.Close()
        check = "15"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox15.Enabled = False
            CheckBox15.BringToFront()
            CheckBox15.BackColor = Color.Red
            CheckBox15.Text = "15 Booked"
        End If
        dr.Close()
        check = "16"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox16.Enabled = False
            CheckBox16.BringToFront()
            CheckBox16.BackColor = Color.Red
            CheckBox16.Text = "16 Booked"
        End If
        dr.Close()
        check = "17"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox17.Enabled = False
            CheckBox17.BringToFront()
            CheckBox17.BackColor = Color.Red
            CheckBox17.Text = "17 Booked"
        End If
        dr.Close()
        check = "18"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox18.Enabled = False
            CheckBox18.BringToFront()
            CheckBox18.BackColor = Color.Red
            CheckBox18.Text = "18 Booked"
        End If
        dr.Close()
        check = "19"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox19.Enabled = False
            CheckBox19.BringToFront()
            CheckBox19.BackColor = Color.Red
            CheckBox19.Text = "19 Booked"
        End If
        dr.Close()
        check = "20"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox20.Enabled = False
            CheckBox20.BringToFront()
            CheckBox20.BackColor = Color.Red
            CheckBox20.Text = "20 Booked"
        End If
        dr.Close()
        check = "21"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox21.Enabled = False
            CheckBox21.BringToFront()
            CheckBox21.BackColor = Color.Red
            CheckBox21.Text = "21 Booked"
        End If
        dr.Close()
        check = "22"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox22.Enabled = False
            CheckBox22.BringToFront()
            CheckBox22.BackColor = Color.Red
            CheckBox22.Text = "22 Booked"
        End If
        dr.Close()
        check = "23"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox23.Enabled = False
            CheckBox23.BringToFront()
            CheckBox23.BackColor = Color.Red
            CheckBox23.Text = "23 Booked"
        End If
        dr.Close()
        check = "24"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox24.Enabled = False
            CheckBox24.BringToFront()
            CheckBox24.BackColor = Color.Red
            CheckBox24.Text = "24 Booked"
        End If
        dr.Close()
        check = "25"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox25.Enabled = False
            CheckBox25.BringToFront()
            CheckBox25.BackColor = Color.Red
            CheckBox25.Text = "25 Booked"
        End If
        dr.Close()
        check = "26"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox26.Enabled = False
            CheckBox26.BringToFront()
            CheckBox26.BackColor = Color.Red
            CheckBox26.Text = "26 Booked"
        End If
        dr.Close()
        check = "27"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox27.Enabled = False
            CheckBox27.BringToFront()
            CheckBox27.BackColor = Color.Red
            CheckBox27.Text = "27 Booked"
        End If
        dr.Close()
        check = "28"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox28.Enabled = False
            CheckBox28.BringToFront()
            CheckBox28.BackColor = Color.Red
            CheckBox28.Text = "28 Booked"
        End If
        dr.Close()
        check = "29"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox29.Enabled = False
            CheckBox29.BringToFront()
            CheckBox29.BackColor = Color.Red
            CheckBox29.Text = "29 Booked"
        End If
        dr.Close()
        check = "30"
        If checkm = "NA" Then
            cmd = New SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        Else
            cmd = New SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' and SeatNo='" & check & "' and SeatType='" & SType.Text & "' and BusSno='" & BNO.Text & "' and RouteNo='" & RNO.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CheckBox30.Enabled = False
            CheckBox30.BringToFront()
            CheckBox30.BackColor = Color.Red
            CheckBox30.Text = "30 Booked"
        End If
        dr.Close()
        con.Close()
        If k = 95 Then
            checkm = "AB_UN"
        End If
    End Sub
    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        If PaymentBy.Text = "Select" Then
            MsgBox("Plz.. Select Payment Method")
        Else
            If PaymentBy.Text = "Cash" Then
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()

                cmd = New SqlCommand("Select FareAmt From Route Where Rno=" & RNO.Text & "", con)
                dr = cmd.ExecuteReader
                dr.Read()
                FareAmount.Text = dr.GetValue(0)
                dr.Close()
                con.Close()
                If CheckBox1.Checked = True Then
                    SeatNo.Text = "1"
                    InsertDB()
                End If
                If CheckBox2.Checked = True Then
                    SeatNo.Text = "2"
                    InsertDB()
                End If
                If CheckBox3.Checked = True Then
                    SeatNo.Text = "3"
                    InsertDB()
                End If
                If CheckBox4.Checked = True Then
                    SeatNo.Text = "4"
                    InsertDB()
                End If
                If CheckBox5.Checked = True Then
                    SeatNo.Text = "5"
                    InsertDB()
                End If
                If CheckBox6.Checked = True Then
                    SeatNo.Text = "6"
                    InsertDB()
                End If
                If CheckBox7.Checked = True Then
                    SeatNo.Text = "7"
                    InsertDB()
                End If
                If CheckBox8.Checked = True Then
                    SeatNo.Text = "8"
                    InsertDB()
                End If
                If CheckBox9.Checked = True Then
                    SeatNo.Text = "9"
                    InsertDB()
                End If
                If CheckBox10.Checked = True Then
                    SeatNo.Text = "10"
                    InsertDB()
                End If
                If CheckBox11.Checked = True Then
                    SeatNo.Text = "11"
                    InsertDB()
                End If
                If CheckBox12.Checked = True Then
                    SeatNo.Text = "12"
                    InsertDB()
                End If
                If CheckBox13.Checked = True Then
                    SeatNo.Text = "13"
                    InsertDB()
                End If
                If CheckBox14.Checked = True Then
                    SeatNo.Text = "14"
                    InsertDB()
                End If
                If CheckBox15.Checked = True Then
                    SeatNo.Text = "15"
                    InsertDB()
                End If
                If CheckBox16.Checked = True Then
                    SeatNo.Text = "16"
                    InsertDB()
                End If
                If CheckBox17.Checked = True Then
                    SeatNo.Text = "17"
                    InsertDB()
                End If
                If CheckBox18.Checked = True Then
                    SeatNo.Text = "18"
                    InsertDB()
                End If
                If CheckBox19.Checked = True Then
                    SeatNo.Text = "19"
                    InsertDB()
                End If
                If CheckBox20.Checked = True Then
                    SeatNo.Text = "20"
                    InsertDB()
                End If
                If CheckBox21.Checked = True Then
                    SeatNo.Text = "21"
                    InsertDB()
                End If
                If CheckBox22.Checked = True Then
                    SeatNo.Text = "22"
                    InsertDB()
                End If
                If CheckBox23.Checked = True Then
                    SeatNo.Text = "23"
                    InsertDB()
                End If
                If CheckBox24.Checked = True Then
                    SeatNo.Text = "24"
                    InsertDB()
                End If
                If CheckBox25.Checked = True Then
                    SeatNo.Text = "25"
                    InsertDB()
                End If
                If CheckBox26.Checked = True Then
                    SeatNo.Text = "26"
                    InsertDB()
                End If
                If CheckBox27.Checked = True Then
                    SeatNo.Text = "27"
                    InsertDB()
                End If
                If CheckBox28.Checked = True Then
                    SeatNo.Text = "28"
                    InsertDB()
                End If
                If CheckBox29.Checked = True Then
                    SeatNo.Text = "29"
                    InsertDB()
                End If
                If CheckBox30.Checked = True Then
                    SeatNo.Text = "30"
                    InsertDB()
                End If
            ElseIf PaymentBy.Text = "Cash Later" Then
                FareAmount.Text = "0"
                If CheckBox1.Checked = True Then
                    SeatNo.Text = "1"
                    InsertDB()
                End If
                If CheckBox2.Checked = True Then
                    SeatNo.Text = "2"
                    InsertDB()
                End If
                If CheckBox3.Checked = True Then
                    SeatNo.Text = "3"
                    InsertDB()
                End If
                If CheckBox4.Checked = True Then
                    SeatNo.Text = "4"
                    InsertDB()
                End If
                If CheckBox5.Checked = True Then
                    SeatNo.Text = "5"
                    InsertDB()
                End If
                If CheckBox6.Checked = True Then
                    SeatNo.Text = "6"
                    InsertDB()
                End If
                If CheckBox7.Checked = True Then
                    SeatNo.Text = "7"
                    InsertDB()
                End If
                If CheckBox8.Checked = True Then
                    SeatNo.Text = "8"
                    InsertDB()
                End If
                If CheckBox9.Checked = True Then
                    SeatNo.Text = "9"
                    InsertDB()
                End If
                If CheckBox10.Checked = True Then
                    SeatNo.Text = "10"
                    InsertDB()
                End If
                If CheckBox11.Checked = True Then
                    SeatNo.Text = "11"
                    InsertDB()
                End If
                If CheckBox12.Checked = True Then
                    SeatNo.Text = "12"
                    InsertDB()
                End If
                If CheckBox13.Checked = True Then
                    SeatNo.Text = "13"
                    InsertDB()
                End If
                If CheckBox14.Checked = True Then
                    SeatNo.Text = "14"
                    InsertDB()
                End If
                If CheckBox15.Checked = True Then
                    SeatNo.Text = "15"
                    InsertDB()
                End If
                If CheckBox16.Checked = True Then
                    SeatNo.Text = "16"
                    InsertDB()
                End If
                If CheckBox17.Checked = True Then
                    SeatNo.Text = "17"
                    InsertDB()
                End If
                If CheckBox18.Checked = True Then
                    SeatNo.Text = "18"
                    InsertDB()
                End If
                If CheckBox19.Checked = True Then
                    SeatNo.Text = "19"
                    InsertDB()
                End If
                If CheckBox20.Checked = True Then
                    SeatNo.Text = "20"
                    InsertDB()
                End If
                If CheckBox21.Checked = True Then
                    SeatNo.Text = "21"
                    InsertDB()
                End If
                If CheckBox22.Checked = True Then
                    SeatNo.Text = "22"
                    InsertDB()
                End If
                If CheckBox23.Checked = True Then
                    SeatNo.Text = "23"
                    InsertDB()
                End If
                If CheckBox24.Checked = True Then
                    SeatNo.Text = "24"
                    InsertDB()
                End If
                If CheckBox25.Checked = True Then
                    SeatNo.Text = "25"
                    InsertDB()
                End If
                If CheckBox26.Checked = True Then
                    SeatNo.Text = "26"
                    InsertDB()
                End If
                If CheckBox27.Checked = True Then
                    SeatNo.Text = "27"
                    InsertDB()
                End If
                If CheckBox28.Checked = True Then
                    SeatNo.Text = "28"
                    InsertDB()
                End If
                If CheckBox29.Checked = True Then
                    SeatNo.Text = "29"
                    InsertDB()
                End If
                If CheckBox30.Checked = True Then
                    SeatNo.Text = "30"
                    InsertDB()
                End If
            ElseIf PaymentBy.Text = "Some Cash" Then
                If CheckBox1.Checked = True Then
                    SeatNo.Text = "1"
                    FareAmount.Text = Val(TextBox1.Text)
                    InsertDB()
                End If
                If CheckBox2.Checked = True Then
                    SeatNo.Text = "2"
                    FareAmount.Text = Val(TextBox2.Text)
                    InsertDB()
                End If
                If CheckBox3.Checked = True Then
                    SeatNo.Text = "3"
                    FareAmount.Text = Val(TextBox3.Text)
                    InsertDB()
                End If
                If CheckBox4.Checked = True Then
                    SeatNo.Text = "4"
                    FareAmount.Text = Val(TextBox4.Text)
                    InsertDB()
                End If
                If CheckBox5.Checked = True Then
                    SeatNo.Text = "5"
                    FareAmount.Text = Val(TextBox5.Text)
                    InsertDB()
                End If
                If CheckBox6.Checked = True Then
                    SeatNo.Text = "6"
                    FareAmount.Text = Val(TextBox6.Text)
                    InsertDB()
                End If
                If CheckBox7.Checked = True Then
                    SeatNo.Text = "7"
                    FareAmount.Text = Val(TextBox7.Text)
                    InsertDB()
                End If
                If CheckBox8.Checked = True Then
                    SeatNo.Text = "8"
                    FareAmount.Text = Val(TextBox8.Text)
                    InsertDB()
                End If
                If CheckBox9.Checked = True Then
                    SeatNo.Text = "9"
                    FareAmount.Text = Val(TextBox9.Text)
                    InsertDB()
                End If
                If CheckBox10.Checked = True Then
                    SeatNo.Text = "10"
                    FareAmount.Text = Val(TextBox10.Text)
                    InsertDB()
                End If
                If CheckBox11.Checked = True Then
                    SeatNo.Text = "11"
                    FareAmount.Text = Val(TextBox11.Text)
                    InsertDB()
                End If
                If CheckBox12.Checked = True Then
                    SeatNo.Text = "12"
                    FareAmount.Text = Val(TextBox12.Text)
                    InsertDB()
                End If
                If CheckBox13.Checked = True Then
                    SeatNo.Text = "13"
                    FareAmount.Text = Val(TextBox13.Text)
                    InsertDB()
                End If
                If CheckBox14.Checked = True Then
                    SeatNo.Text = "14"
                    FareAmount.Text = Val(TextBox14.Text)
                    InsertDB()
                End If
                If CheckBox15.Checked = True Then
                    SeatNo.Text = "15"
                    FareAmount.Text = Val(TextBox15.Text)
                    InsertDB()
                End If
                If CheckBox16.Checked = True Then
                    SeatNo.Text = "16"
                    FareAmount.Text = Val(TextBox16.Text)
                    InsertDB()
                End If
                If CheckBox17.Checked = True Then
                    SeatNo.Text = "17"
                    FareAmount.Text = Val(TextBox17.Text)
                    InsertDB()
                End If
                If CheckBox18.Checked = True Then
                    SeatNo.Text = "18"
                    FareAmount.Text = Val(TextBox18.Text)
                    InsertDB()
                End If
                If CheckBox19.Checked = True Then
                    SeatNo.Text = "19"
                    FareAmount.Text = Val(TextBox19.Text)
                    InsertDB()
                End If
                If CheckBox20.Checked = True Then
                    SeatNo.Text = "20"
                    FareAmount.Text = Val(TextBox20.Text)
                    InsertDB()
                End If
                If CheckBox21.Checked = True Then
                    SeatNo.Text = "21"
                    FareAmount.Text = Val(TextBox21.Text)
                    InsertDB()
                End If
                If CheckBox22.Checked = True Then
                    SeatNo.Text = "22"
                    FareAmount.Text = Val(TextBox22.Text)
                    InsertDB()
                End If
                If CheckBox23.Checked = True Then
                    SeatNo.Text = "23"
                    FareAmount.Text = Val(TextBox23.Text)
                    InsertDB()
                End If
                If CheckBox24.Checked = True Then
                    SeatNo.Text = "24"
                    FareAmount.Text = Val(TextBox24.Text)
                    InsertDB()
                End If
                If CheckBox25.Checked = True Then
                    SeatNo.Text = "25"
                    FareAmount.Text = Val(TextBox25.Text)
                    InsertDB()
                End If
                If CheckBox26.Checked = True Then
                    SeatNo.Text = "26"
                    FareAmount.Text = Val(TextBox26.Text)
                    InsertDB()
                End If
                If CheckBox27.Checked = True Then
                    SeatNo.Text = "27"
                    FareAmount.Text = Val(TextBox27.Text)
                    InsertDB()
                End If
                If CheckBox28.Checked = True Then
                    SeatNo.Text = "28"
                    FareAmount.Text = Val(TextBox28.Text)
                    InsertDB()
                End If
                If CheckBox29.Checked = True Then
                    SeatNo.Text = "29"
                    FareAmount.Text = Val(TextBox29.Text)
                    InsertDB()
                End If
                If CheckBox30.Checked = True Then
                    SeatNo.Text = "30"
                    FareAmount.Text = Val(TextBox30.Text)
                    InsertDB()
                End If
            End If
            MsgBox("DONE.. !!!")
            SeatNo.Text = ""
            If checkm = "NA" Then
                Dim a1 As New Booking_And_Passenger("NA", "NA", "0")
                a1.Show()
            Else
                Dim s1 As New Seat_Booking_Details("AB_UN", BNO4)
                s1.Show()
            End If
            Me.Close()
        End If
    End Sub
    Public Sub InsertDB()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        If checkm = "NA" Then
            cmd = New SqlCommand("Update PassengerDetails Set RouteNo='" & RNO.Text & "',BusSno='" & BNO.Text & "',FareAmount='" & FareAmount.Text & "',Payment='" & PaymentBy.Text & "',BDate='" & Format(Today, "dd/MM/yyyy") & "' where BookingNo=" & BookingNo.Text & "", con)
        Else
            cmd = New SqlCommand("Update APassengerDetails Set RouteNo='" & RNO.Text & "',BusSno='" & BNO.Text & "',FareAmount='" & FareAmount.Text & "',Payment='" & PaymentBy.Text & "',BDate='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "' where BookingNo=" & BookingNo.Text & "", con)
        End If
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub PaymentBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentBy.SelectedIndexChanged
        If PaymentBy.Text = "Some Cash" Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = True
            TextBox26.Visible = True
            TextBox27.Visible = True
            TextBox28.Visible = True
            TextBox29.Visible = True
            TextBox30.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
        ElseIf PaymentBy.Text = "Cash" Then
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            TextBox18.Visible = False
            TextBox19.Visible = False
            TextBox20.Visible = False
            TextBox21.Visible = False
            TextBox22.Visible = False
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            TextBox26.Visible = False
            TextBox27.Visible = False
            TextBox28.Visible = False
            TextBox29.Visible = False
            TextBox30.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False
            TextBox9.Visible = False
        ElseIf PaymentBy.Text = "Cash Later" Then
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            TextBox18.Visible = False
            TextBox19.Visible = False
            TextBox20.Visible = False
            TextBox21.Visible = False
            TextBox22.Visible = False
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            TextBox26.Visible = False
            TextBox27.Visible = False
            TextBox28.Visible = False
            TextBox29.Visible = False
            TextBox30.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False
            TextBox9.Visible = False
        End If
    End Sub

    Private Sub InsertP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertP.Click
        Try
            If PaymentBy.Text.Trim = "" Then
                MsgBox("Plz.. Select Payment Option")
            ElseIf DGV.Rows(i).Cells(1).Value = "" Then
                MsgBox("Plz.. Type Passenger Name")
            ElseIf DGV.Rows(i).Cells(2).Value = "" Then
                MsgBox("Plz.. Select Passenger Gender")
            ElseIf DGV.Rows(i).Cells(3).Value = "" Then
                MsgBox("Plz.. Type Passenger Age")
            Else
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                If checkm = "NA" Then
                    cmd = New SqlCommand("Insert Into PassengerDetails(BookingNo,SrNo,PNAME,PGENDER,PassengerAGE,SeatNo,SeatType) Values(" & BookingNo.Text & ",'" & DGV.Rows(i).Cells(0).Value & "','" & DGV.Rows(i).Cells(1).Value & "','" & DGV.Rows(i).Cells(2).Value & "','" & DGV.Rows(i).Cells(3).Value & "','" & DGV.Rows(i).Cells(4).Value & "','" & SType.Text & "')", con)
                Else
                    cmd = New SqlCommand("Insert Into APassengerDetails(BookingNo,SrNo,PNAME,PGENDER,PassengerAGE,SeatNo,SeatType) Values(" & BookingNo.Text & ",'" & DGV.Rows(i).Cells(0).Value & "','" & DGV.Rows(i).Cells(1).Value & "','" & DGV.Rows(i).Cells(2).Value & "','" & DGV.Rows(i).Cells(3).Value & "','" & DGV.Rows(i).Cells(4).Value & "','" & SType.Text & "')", con)
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Success...")
                If DGV.Rows(i).Cells(4).Value = 1 Then
                    CheckBox1.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 2 Then
                    CheckBox2.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 3 Then
                    CheckBox3.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 4 Then
                    CheckBox4.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 5 Then
                    CheckBox5.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 6 Then
                    CheckBox6.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 7 Then
                    CheckBox7.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 8 Then
                    CheckBox8.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 9 Then
                    CheckBox9.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 10 Then
                    CheckBox10.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 11 Then
                    CheckBox11.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 12 Then
                    CheckBox12.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 13 Then
                    CheckBox13.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 14 Then
                    CheckBox14.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 15 Then
                    CheckBox15.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 16 Then
                    CheckBox16.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 17 Then
                    CheckBox17.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 18 Then
                    CheckBox18.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 19 Then
                    CheckBox19.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 20 Then
                    CheckBox20.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 21 Then
                    CheckBox21.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 22 Then
                    CheckBox22.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 23 Then
                    CheckBox23.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 24 Then
                    CheckBox24.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 25 Then
                    CheckBox25.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 26 Then
                    CheckBox26.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 27 Then
                    CheckBox27.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 28 Then
                    CheckBox28.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 29 Then
                    CheckBox29.Enabled = False
                ElseIf DGV.Rows(i).Cells(4).Value = 30 Then
                    CheckBox30.Enabled = False
                End If
                i += 1
                Insert.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Passenger Insertion Failed")
        End Try
    End Sub
    Public Sub CHK1()
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "01 Booked"
            DGV.Item(4, i).Value() = "1"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox1.Text = "01"
        End If
    End Sub
    Public Sub CHK2()
        If CheckBox2.Checked = True Then
            CheckBox2.Text = "02 Booked"
            DGV.Item(4, i).Value() = "2"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox2.Text = "02"
        End If
    End Sub
    Public Sub CHK3()
        If CheckBox3.Checked = True Then
            CheckBox3.Text = "03 Booked"
            DGV.Item(4, i).Value() = "3"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox3.Text = "03"
        End If
    End Sub
    Public Sub CHK4()
        If CheckBox4.Checked = True Then
            CheckBox4.Text = "04 Booked"
            DGV.Item(4, i).Value() = "4"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox4.Text = "04"
        End If
    End Sub
    Public Sub CHK5()
        If CheckBox5.Checked = True Then
            CheckBox5.Text = "05 Booked"
            DGV.Item(4, i).Value() = "5"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox5.Text = "05"
        End If
    End Sub
    Public Sub CHK6()
        If CheckBox6.Checked = True Then
            CheckBox6.Text = "06 Booked"
            DGV.Item(4, i).Value() = "6"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox6.Text = "06"
        End If
    End Sub
    Public Sub CHK7()
        If CheckBox7.Checked = True Then
            CheckBox7.Text = "07 Booked"
            DGV.Item(4, i).Value() = "7"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox7.Text = "07"
        End If
    End Sub
    Public Sub CHK8()
        If CheckBox8.Checked = True Then
            CheckBox8.Text = "08 Booked"
            DGV.Item(4, i).Value() = "8"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox8.Text = "08"
        End If
    End Sub
    Public Sub CHK9()
        If CheckBox9.Checked = True Then
            CheckBox9.Text = "09 Booked"
            DGV.Item(4, i).Value() = "9"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox9.Text = "09"
        End If
    End Sub
    Public Sub CHK10()
        If CheckBox10.Checked = True Then
            CheckBox10.Text = "10 Booked"
            DGV.Item(4, i).Value() = "10"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox10.Text = "10"
        End If
    End Sub
    Public Sub CHK11()
        If CheckBox11.Checked = True Then
            CheckBox11.Text = "11 Booked"
            DGV.Item(4, i).Value() = "11"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox11.Text = "11"
        End If
    End Sub
    Public Sub CHK12()
        If CheckBox12.Checked = True Then
            CheckBox12.Text = "12 Booked"
            DGV.Item(4, i).Value() = "12"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox12.Text = "12"
        End If
    End Sub
    Public Sub CHK13()
        If CheckBox13.Checked = True Then
            CheckBox13.Text = "13 Booked"
            DGV.Item(4, i).Value() = "13"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox13.Text = "13"
        End If
    End Sub
    Public Sub CHK14()
        If CheckBox14.Checked = True Then
            CheckBox14.Text = "14 Booked"
            DGV.Item(4, i).Value() = "14"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox14.Text = "14"
        End If
    End Sub
    Public Sub CHK15()
        If CheckBox15.Checked = True Then
            CheckBox15.Text = "15 Booked"
            DGV.Item(4, i).Value() = "15"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox15.Text = "15"
        End If
    End Sub
    Public Sub CHK16()
        If CheckBox16.Checked = True Then
            CheckBox16.Text = "16 Booked"
            DGV.Item(0, i).Value() = i + 1
            DGV.Item(4, i).Value() = "16"

        Else
            DGV.Item(0, i).Value = ""
            DGV.Item(4, i).Value = ""
            CheckBox16.Text = "16"
        End If
    End Sub
    Public Sub CHK17()
        If CheckBox17.Checked = True Then
            CheckBox17.Text = "17 Booked"
            DGV.Item(4, i).Value() = "17"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox17.Text = "17"
        End If
    End Sub
    Public Sub CHK18()
        If CheckBox18.Checked = True Then
            CheckBox18.Text = "18 Booked"
            DGV.Item(4, i).Value() = "18"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox18.Text = "18"
        End If
    End Sub
    Public Sub CHK19()
        If CheckBox19.Checked = True Then
            CheckBox19.Text = "19 Booked"
            DGV.Item(4, i).Value() = "19"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox19.Text = "19"
        End If
    End Sub
    Public Sub CHK20()
        If CheckBox20.Checked = True Then
            CheckBox20.Text = "20 Booked"
            DGV.Item(4, i).Value() = "20"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox20.Text = "20"
        End If
    End Sub
    Public Sub CHK21()
        If CheckBox21.Checked = True Then
            CheckBox21.Text = "21 Booked"
            DGV.Item(4, i).Value() = "21"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox21.Text = "21"
        End If
    End Sub
    Public Sub CHK22()
        If CheckBox22.Checked = True Then
            CheckBox22.Text = "22 Booked"
            DGV.Item(4, i).Value() = "22"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox22.Text = "22"
        End If
    End Sub
    Public Sub CHK23()
        If CheckBox23.Checked = True Then
            CheckBox23.Text = "23 Booked"
            DGV.Item(4, i).Value() = "23"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox23.Text = "23"
        End If
    End Sub
    Public Sub CHK24()
        If CheckBox24.Checked = True Then
            CheckBox24.Text = "24 Booked"
            DGV.Item(4, i).Value() = "24"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox24.Text = "24"
        End If
    End Sub
    Public Sub CHK25()
        If CheckBox25.Checked = True Then
            CheckBox25.Text = "25 Booked"
            DGV.Item(4, i).Value() = "25"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox25.Text = "25"
        End If
    End Sub
    Public Sub CHK26()
        If CheckBox26.Checked = True Then
            CheckBox26.Text = "26 Booked"
            DGV.Item(0, i).Value() = i + 1
            DGV.Item(4, i).Value() = "26"

        Else
            DGV.Item(0, i).Value = ""
            DGV.Item(4, i).Value = ""
            CheckBox26.Text = "26"
        End If
    End Sub
    Public Sub CHK27()
        If CheckBox27.Checked = True Then
            CheckBox27.Text = "27 Booked"
            DGV.Item(4, i).Value() = "27"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox27.Text = "27"
        End If
    End Sub
    Public Sub CHK28()
        If CheckBox28.Checked = True Then
            CheckBox28.Text = "28 Booked"
            DGV.Item(4, i).Value() = "28"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox28.Text = "28"
        End If
    End Sub
    Public Sub CHK29()
        If CheckBox29.Checked = True Then
            CheckBox29.Text = "29 Booked"
            DGV.Item(4, i).Value() = "29"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox29.Text = "29"
        End If
    End Sub
    Public Sub CHK30()
        If CheckBox30.Checked = True Then
            CheckBox30.Text = "30 Booked"
            DGV.Item(4, i).Value() = "30"
            DGV.Item(0, i).Value() = i + 1
        Else
            DGV.Item(4, i).Value = ""
            DGV.Item(0, i).Value = ""
            CheckBox30.Text = "30"
        End If
    End Sub
End Class