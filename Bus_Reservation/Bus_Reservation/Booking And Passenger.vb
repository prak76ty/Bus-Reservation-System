Imports System.Data.SqlClient

Public Class Booking_And_Passenger
    Inherits System.Windows.Forms.Form
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t, f As Integer
    Dim checkm, stype, BR, RNO, BNO, Scapacity, WL As String

    Public Sub New(ByVal msgreceived, ByVal seattype, ByVal WN)
        MyBase.New()
        InitializeComponent()
        checkm = msgreceived
        stype = seattype
        WL = WN
    End Sub
    Private Sub Booking_And_Passenger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If WL = "WL" Then
            WLF.Enabled = True
            Insert.Enabled = False
        End If
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        If checkm = "NA" Then
            cmd = New SqlCommand("Select max(BookingNo) From PaymentPassenger", con)
        Else
            cmd = New SqlCommand("Select max(BookingNo) From APaymentPassenger", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        BookingNo.Text = t.ToString
        If BookingNo.Text <> 1 Then
            BookingNo.Text = Val(BookingNo.Text) - 1
        End If
        dr.Close()
        If checkm = "AB_UN" Then
            cmd = New SqlCommand("Select BookingDate From APaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
            dr = cmd.ExecuteReader
            dr.Read()
            BookingDate.Value = dr.GetValue(0)
            dr.Close()
        End If
        con.Close()
        BR = AdvanceSeatBooking.BusReservation.Text
    End Sub

    Private Sub btnpassengerfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassengerfind.Click
        Try
            If PassengerNo.Text.Trim = "" Then
                MsgBox("Plz.. Enter Valid Passenger No")
            Else
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("Select * From Passenger Where Pno=" & PassengerNo.Text & "", con)
                dr = cmd.ExecuteReader
                dr.Read()
                PassengerNo.Text = dr.GetValue(0)
                PassengerName.Text = dr.GetValue(1)
                PassengerAddress.Text = dr.GetValue(2)
                PassengerCity.Text = dr.GetValue(3)
                PassengerContact.Text = dr.GetValue(4)
                dr.Close()
                con.Close()
                f = 1
                btnsave.Enabled = True
                btndelete.Enabled = True
                PassengerNo.Enabled = True
                PassengerName.Enabled = True
                PassengerAddress.Enabled = True
                PassengerCity.Enabled = True
                PassengerContact.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("No Record Found")
        End Try
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear()
        PassengerNo.Enabled = True
        PassengerName.Enabled = True
        PassengerAddress.Enabled = True
        PassengerCity.Enabled = True
        PassengerContact.Enabled = True
        PassengerName.Focus()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select max(Pno) From Passenger", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        PassengerNo.Text = t.ToString
        dr.Close()
        con.Close()
        btnsave.Enabled = True
        btnpassengerfind.Enabled = False
        btnnew.Enabled = False
        f = 5
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        PassengerSU()
        btnsave.Enabled = False
        btnpassengerfind.Enabled = True
        btnnew.Enabled = True
        btndelete.Enabled = False
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If res = DialogResult.Yes Then
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Delete From Passenger Where Pno=" & PassengerNo.Text & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted !")
            clear()
            btnsave.Enabled = False
            btnnew.Enabled = True
            btnpassengerfind.Enabled = True
            con.Close()
        End If
    End Sub
    Sub clear()
        PassengerNo.Clear()
        PassengerName.Clear()
        PassengerAddress.Clear()
        PassengerCity.Clear()
        PassengerContact.Clear()
        PassengerNo.Enabled = True
        PassengerName.Enabled = False
        PassengerAddress.Enabled = False
        PassengerCity.Enabled = False
        PassengerContact.Enabled = False
    End Sub
    Private Sub PassengerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassengerName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PassengerContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassengerContact.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PassengerCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassengerCity.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        If PassengerNo.Text.Trim = "" Then
            MsgBox("Plz.. Enter Passenger No..")
        Else
            If checkm = "NA" Then
                RNO = SeatBooking.Rno.Text
                BNO = SeatBooking.BusSerialNo.Text
                Scapacity = SeatBooking.SeatCapacity.Text
                BR = SeatBooking.BusReservation.Text
            Else
                RNO = AdvanceSeatBooking.Rno.Text
                BNO = AdvanceSeatBooking.BusSerialNo.Text
                Scapacity = AdvanceSeatBooking.SeatCapacity.Text
                BR = AdvanceSeatBooking.BusReservation.Text
            End If
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            If checkm = "NA" Then
                cmd = New SqlCommand("Update PaymentPassenger Set BookingDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "',PassengerNo='" & PassengerNo.Text & "',PassengerName='" & PassengerName.Text & "',PassengerCity='" & PassengerCity.Text & "',PassengerContact='" & PassengerContact.Text & "',PassengerAddress='" & PassengerAddress.Text & "'Where BookingNo=" & BookingNo.Text & "", con)
            Else
                cmd = New SqlCommand("Update APaymentPassenger Set BookingDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "',PassengerNo='" & PassengerNo.Text & "',PassengerName='" & PassengerName.Text & "',PassengerCity='" & PassengerCity.Text & "',PassengerContact='" & PassengerContact.Text & "',PassengerAddress='" & PassengerAddress.Text & "'Where BookingNo=" & BookingNo.Text & "", con)
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            '  PassengerSU()
            MsgBox("Success... Next")
            If checkm = "NA" Then
                Dim s1 As New Seat_Booking_Details("NA", BookingNo.Text)
                s1.Show()
                s1.BringToFront()
            Else
                If BR = "1x1" And stype = "L" Then
                    Dim SSL As New SeatSelectionLower("AB_UN", BookingNo.Text, RNO, BNO)
                    SSL.Show()
                End If
                If BR = "1x1" And stype = "U" Then
                    Dim SSU As New SeatSelectionUpper("AB_UN", BookingNo.Text, RNO, BNO)
                    SSU.Show()
                End If
                If BR = "2x1" And stype = "L" Then
                    Dim SSL1 As New SeatSelectionLower21("AB_UN", BookingNo.Text, RNO, BNO)
                    SSL1.Show()
                End If
                If BR = "2x1" And stype = "U" Then
                    Dim SSU1 As New SeatSelectionUpper21("AB_UN", BookingNo.Text, RNO, BNO)
                    SSU1.Show()
                End If
                If BR = "2x2" And stype = "L" Then
                    Dim SSL2 As New SeatSelectionLower22("AB_UN", BookingNo.Text, RNO, BNO)
                    SSL2.Show()
                End If
                If BR = "2x2" And stype = "U" Then
                    Dim SSU2 As New SeatSelectionUpper21("AB_UN", BookingNo.Text, RNO, BNO)
                    SSU2.Show()
                End If
            End If
            Me.Hide()
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim SSL0 As New SeatSelectionLower("NA", "NA", RNO, BNO)
        SSL0.BringToFront()
        SSL0.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SSL1 As New SeatSelectionUpper("NA", "NA", RNO, BNO)
        SSL1.BringToFront()
        SSL1.Show()
    End Sub

    Private Sub WLF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WLF.Click
        If PassengerNo.Text.Trim = "" Then
            MsgBox("Plz.. Enter Passenger No..")
        Else
            If checkm = "NA" Then
                RNO = SeatBooking.Rno.Text
                BNO = SeatBooking.BusSerialNo.Text
                Scapacity = SeatBooking.SeatCapacity.Text
                BR = SeatBooking.BusReservation.Text
            Else
                RNO = AdvanceSeatBooking.Rno.Text
                BNO = AdvanceSeatBooking.BusSerialNo.Text
                Scapacity = AdvanceSeatBooking.SeatCapacity.Text
                BR = AdvanceSeatBooking.BusReservation.Text
            End If
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Update APaymentPassenger Set BookingDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "',PassengerNo='" & PassengerNo.Text & "',PassengerName='" & PassengerName.Text & "',PassengerCity='" & PassengerCity.Text & "',PassengerContact='" & PassengerContact.Text & "',PassengerAddress='" & PassengerAddress.Text & "'Where BookingNo=" & BookingNo.Text & "", con)
            cmd.ExecuteNonQuery()
            con.Close()
            'PassengerSU()
            MsgBox("Finished...")
            Me.Close()
            SeatBooking.Close()
            AdvanceSeatBooking.Close()
        End If
    End Sub
    Sub PassengerSU()
        If f = 5 Then
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Insert Into Passenger Values(" & PassengerNo.Text & ",'" & PassengerName.Text & "','" & PassengerAddress.Text & "','" & PassengerCity.Text & "','" & PassengerContact.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Success... Next !")
            con.Close()
        Else
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Update Passenger Set Pname='" & PassengerName.Text & "',Paddress='" & PassengerAddress.Text & "',Pcity='" & PassengerCity.Text & "',Pcontact='" & PassengerContact.Text & "' Where Pno=" & PassengerNo.Text & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record is Updated !")
        End If
    End Sub
End Class