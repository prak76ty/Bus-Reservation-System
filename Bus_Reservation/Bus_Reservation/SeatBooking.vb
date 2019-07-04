Imports System.Data.SqlClient

Public Class SeatBooking
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t, seats, a, b, c, d, k, l As Integer
    Dim br, new21, new22, RN, BN As String

    Public Sub btnclear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Rno.Text = "Select"
        cmbstartpoint.Text = ""
        cmbdestination.Text = ""
        BusSerialNo.Text = "Select"
        BusNumber.Text = "Select"
        BusType.Text = "Select"
        BusReservation.Text = "Select"
        Arrivaltime.Text = TimeOfDay
        Departuretime.Text = TimeOfDay
        SeatCapacity.Clear()
        S1.Clear()
        S2.Clear()
        SeatAvailability.Clear()
        SC2.Clear()
    End Sub

    Public Sub SeatBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rno.Text = "Select"
        cmbstartpoint.Text = "Select"
        cmbdestination.Text = "Select"
        BusSerialNo.Text = "Select"
        BusNumber.Text = "Select"
        BusType.Text = "Select"
        BusReservation.Text = "Select"
        SeatCapacity.Clear()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select Distinct(Rno) From Route", con)
        dr = cmd.ExecuteReader
        Rno.Items.Clear()
        While dr.Read
            Rno.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
        con.Close()

        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select Distinct(BusSno) From Bus", con)
        dr = cmd.ExecuteReader
        BusSerialNo.Items.Clear()
        While dr.Read
            BusSerialNo.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
        con.Close()

        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select max(BookingNo) From PaymentPassenger", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        c = t.ToString
        dr.Close()
        cmd = New SqlCommand("Select max(BookingNo) From APaymentPassenger", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        d = t.ToString
        dr.Close()
        cmd = New SqlCommand("Select max(BookingNo) From Cancellation", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        k = t.ToString
        dr.Close()
        cmd = New SqlCommand("Select max(BookingNo) From CompletedPP", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        l = t.ToString
        dr.Close()
        If c > d And c > k And c > l Then
            BookingNo.Text = c
        ElseIf d > c And d > k And d > l Then
            BookingNo.Text = d
        ElseIf k > c And k > d And k > l Then
            BookingNo.Text = k
        ElseIf l > c And l > d And l > k Then
            BookingNo.Text = l
        Else
            BookingNo.Text = 1
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub Rno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rno.SelectedIndexChanged, Rno.SelectedIndexChanged
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()

        cmd = New SqlCommand("Select Arrivaltime,Departuretime,Startingpoint,Destination From Route Where Rno=" & Rno.Text & "", con)
        dr = cmd.ExecuteReader

        dr.Read()
        Arrivaltime.Text = dr.GetValue(0)
        Departuretime.Text = dr.GetValue(1)
        cmbstartpoint.Text = dr.GetValue(2)
        cmbdestination.Text = dr.GetValue(3)
        dr.Close()
        cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "U" & "' and RouteNo='" & Rno.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.GetValue(0)
        dr.Close()
        cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "U" & "' and RouteNo='" & Rno.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        b = dr.GetValue(0)
        dr.Close()
        seats = a + b
        If Val(SeatCapacity.Text) = seats Then
            ' WaitingList.Enabled = True
            Insert.Enabled = False
        Else
            ' WaitingList.Enabled = False
            Insert.Enabled = True
        End If
        SA()
        con.Close()
        S1.Text = cmbstartpoint.Text
        S2.Text = cmbdestination.Text
    End Sub

    Public Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        If Rno.Text.Trim = "" Or Rno.Text.Trim = "Select" Then
            MsgBox("Plz.. Enter Correct Route No")
        ElseIf BusSerialNo.Text.Trim = "" Or BusSerialNo.Text.Trim = "Select" Then
            MsgBox("Plz Enter Bus Serial No and Press Find")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Plz.. Select Seat Type")
        Else

            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()

            cmd = New SqlCommand("Insert Into PaymentPassenger(BookingNo,RouteBus,BookingDate,WaitingNo,CurrentDate,ArrivalTime) Values(" & BookingNo.Text & ",'" & cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text & "','" & Format(Today, "dd/MM/yyyy") & "','" & "0" & "','" & Format(Today, "dd/MM/yyyy") & "','" & Format(Arrivaltime.Value, "hh:mm:ss tt") & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Success... Next...")
            con.Close()
            Me.Hide()
            If BusReservation.Text = "1x1" And RadioButton1.Checked = True Then
                Dim SSL0 As New SeatSelectionLower("NA", "SB", Rno.Text, BusSerialNo.Text)
                SSL0.Show()
            End If
            If BusReservation.Text = "1x1" And RadioButton2.Checked = True Then
                Dim SSL1 As New SeatSelectionUpper("NA", "SB", Rno.Text, BusSerialNo.Text)
                SSL1.Show()
            End If
            If BusReservation.Text = "2x1" And RadioButton1.Checked = True Then
                Dim SSL3 As New SeatSelectionLower21("NA", "SB", Rno.Text, BusSerialNo.Text)
                SSL3.Show()
            End If
            If BusReservation.Text = "2x1" And RadioButton2.Checked = True Then
                Dim SSL4 As New SeatSelectionUpper21("NA", "SB", Rno.Text, BusSerialNo.Text)
                SSL4.Show()
            End If
            If BusReservation.Text = "2x2" And RadioButton1.Checked = True Then
                Dim SSL5 As New SeatSelectionLower22("NA", "SB", Rno.Text, BusSerialNo.Text)
                SSL5.Show()
            End If
            If BusReservation.Text = "2x2" And RadioButton2.Checked = True Then
                Dim SSL6 As New SeatSelectionUpper22("NA", "SB", Rno.Text, BusSerialNo.Text)
                SSL6.Show()
            End If
        End If
    End Sub

    Private Sub BusSerialNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusSerialNo.SelectedIndexChanged
        If Rno.Text.Trim = "" Then
            MsgBox("Plz.. Enter Route No")
        Else
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()

            cmd = New SqlCommand("Select BusNo,Type,Reservation,SeatCapacity From Bus Where BusSno=" & BusSerialNo.SelectedItem & "", con)
            dr = cmd.ExecuteReader

            dr.Read()
            BusNumber.Text = dr.GetValue(0)
            BusType.Text = dr.GetValue(1)
            BusReservation.Text = dr.GetValue(2)
            SeatCapacity.Text = dr.GetValue(3)
            dr.Close()
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "L" & "' and RouteNo='" & Rno.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            a = dr.GetValue(0)
            dr.Close()
            cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "U" & "' and RouteNo='" & Rno.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            b = dr.GetValue(0)
            dr.Close()
            seats = a + b
            If Val(SeatCapacity.Text) = seats Then
                'WaitingList.Enabled = True
                Insert.Enabled = False
            Else
                ' WaitingList.Enabled = False
                Insert.Enabled = True
            End If
            SA()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        SA()
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        SA()
    End Sub
    Public Sub SA()
        If RadioButton1.Checked = True Then
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "L" & "' and RouteNo='" & Rno.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            SeatAvailability.Text = dr.Item(0)
            Label16.Text = "Seat Booked From   20   Seats"
            dr.Close()
            SC2.Text = Val(SeatCapacity.Text) / 2
        Else
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "U" & "' and RouteNo='" & Rno.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            SeatAvailability.Text = dr.Item(0)
            Label16.Text = "Seat Booked From   20   Seats"
            dr.Close()
            con.Close()
            SC2.Text = Val(SeatCapacity.Text) / 2
        End If
    End Sub

    Private Sub WaitingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitingList.Click
        If Rno.Text.Trim = "" Or Rno.Text.Trim = "Select" Then
            MsgBox("Plz.. Enter Correct Route No")
        ElseIf BusSerialNo.Text.Trim = "" Or BusSerialNo.Text.Trim = "Select" Then
            MsgBox("Plz Enter Bus Serial No and Press Find")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Plz.. Select Seat Type")
        Else
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select max(WaitingNo) From APaymentPassenger", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If (dr.Item(0) IsNot DBNull.Value) Then
                t = dr.Item(0) + 1
            Else
                t = 1
            End If
            WNo.Text = t.ToString
            dr.Close()
            cmd = New SqlCommand("Insert Into APaymentPassenger(BookingNo,RouteBus,BookingDate,WaitingNo,CurrentDate,ArrivalTime) Values(" & BookingNo.Text & ",'" & cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text & "','" & Format(Today, "dd/MM/yyyy") & "','" & WNo.Text & "','" & Format(Today, "dd/MM/yyyy") & "','" & Format(Arrivaltime.Value, "hh:mm:ss tt") & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Success... Next")
            con.Close()
            Me.Hide()
            Dim ABPassenger As New Booking_And_Passenger("AB_UN", "L/U", "WL")
            ABPassenger.Show()
        End If
    End Sub
End Class