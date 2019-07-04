Imports System.Data.SqlClient

Public Class WaitingList

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t, CN, a, b, c, d, seats As Integer
    Dim i As Integer
    Dim BR, RN, BN As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If BookingNo.Text.Trim = "" Then
                MsgBox("Booking No is Empty..")
            Else
                DGV.Rows.Clear()
                con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
                con.Open()
                cmd = New SqlCommand("Select * From APaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
                dr = cmd.ExecuteReader
                i = 0
                While dr.Read
                    DGV.Rows.Add()
                    DGV.Item(0, i).Value = dr.GetValue(0)
                    DGV.Item(1, i).Value = dr.GetValue(1)
                    DGV.Item(2, i).Value = dr.GetValue(2)
                    BookingDate.Value = dr.GetValue(2)
                    DGV.Item(3, i).Value = dr.GetValue(3)
                    DGV.Item(4, i).Value = dr.GetValue(4)
                    DGV.Item(5, i).Value = dr.GetValue(5)
                    DGV.Item(6, i).Value = dr.GetValue(6)
                    DGV.Item(7, i).Value = dr.GetValue(7)
                    DGV.Item(8, i).Value = dr.GetValue(8)
                    DGV.Item(9, i).Value = dr.GetValue(9)
                    i += 1
                End While
                dr.Close()
                RNo.Enabled = True
                BusSerialNo.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("No Records Found")
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RNo.Enabled = False
            BusSerialNo.Enabled = False
        End Try
    End Sub

    Private Sub Ending_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ending.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            DGV.Rows.Clear()
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select * From APaymentPassenger Where BookingDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "' and Not WaitingNo='" & "0" & "'", con)
            dr = cmd.ExecuteReader
            i = 0
            While dr.Read
                DGV.Rows.Add()
                DGV.Item(0, i).Value = dr.GetValue(0)
                DGV.Item(1, i).Value = dr.GetValue(1)
                DGV.Item(2, i).Value = dr.GetValue(2)
                DGV.Item(3, i).Value = dr.GetValue(3)
                DGV.Item(4, i).Value = dr.GetValue(4)
                DGV.Item(5, i).Value = dr.GetValue(5)
                DGV.Item(6, i).Value = dr.GetValue(6)
                DGV.Item(7, i).Value = dr.GetValue(7)
                DGV.Item(8, i).Value = dr.GetValue(8)
                DGV.Item(9, i).Value = dr.GetValue(9)
                i += 1
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("No Records Found")
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        SA()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        SA()
    End Sub
   
    Private Sub Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceed.Click
        Try
            CN = BookingNo.Text
            If BookingNo.Text.Trim = "" Then
                MsgBox("Plz.. Enter Booking No..")
            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Plz.. Select Seat Section..")
            Else
                Dim res As DialogResult = MessageBox.Show("Do U Want To Allocate Seat To Waiting Booking?", "Allocate Seat?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If res = DialogResult.Yes Then
                    RN = RNo.Text
                    BN = BusSerialNo.Text
                    Me.Hide()
                    If BusReservation.Text = "1x1" And RadioButton1.Checked = True Then
                        Dim SSL As New SeatSelectionLower("AB_UN", CN, RN, BN)
                        SSL.Show()
                    End If
                    If BusReservation.Text = "1x1" And RadioButton2.Checked = True Then
                        Dim SSU As New SeatSelectionUpper("AB_UN", CN, RN, BN)
                        SSU.Show()
                    End If
                    If BusReservation.Text = "2x1" And RadioButton1.Checked = True Then
                        Dim SSL1 As New SeatSelectionLower21("AB_UN", CN, RN, BN)
                        SSL1.Show()
                    End If
                    If BusReservation.Text = "2x1" And RadioButton2.Checked = True Then
                        Dim SSU1 As New SeatSelectionUpper21("AB_UN", CN, RN, BN)
                        SSU1.Show()
                    End If
                    If BusReservation.Text = "2x2" And RadioButton1.Checked = True Then
                        Dim SSL2 As New SeatSelectionLower22("AB_UN", CN, RN, BN)
                        SSL2.Show()
                    End If
                    If BusReservation.Text = "2x2" And RadioButton2.Checked = True Then
                        Dim SSU2 As New SeatSelectionUpper21("AB_UN", CN, RN, BN)
                        SSU2.Show()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Nothing Selected.. Plz Select Correct Booking No..")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DGV.Rows.Clear()
        SeatCapacity.Clear()
        BookingNo.Clear()
        SC2.Clear()
        SeatAvailability.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RNo.Text = "Select"
        BusSerialNo.Text = "Select"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim res As DialogResult = MessageBox.Show("Do U Want To Cancel Waiting Booking?", "Cancel Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If res = DialogResult.Yes Then
                If BookingNo.Text.Trim = "" Then
                    MsgBox("Give Booking No..")
                Else
                    Dim CN2 As String
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
                    CN2 = t.ToString
                    dr.Close()
                    cmd = New SqlCommand("Select * From APaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim a1, a2, a3, a4, a5, a6, a7 As String
                    a1 = dr.GetValue(0)
                    a2 = dr.GetValue(1)
                    a3 = dr.GetValue(2)
                    a4 = dr.GetValue(6)
                    a5 = dr.GetValue(7)
                    a6 = dr.GetValue(8)
                    a7 = dr.GetValue(9)
                    dr.Close()
                    cmd = New SqlCommand("Insert Into Cancellation Values(" & CN2 & ",'" & a1 & "','" & a2 & "','" & a3 & "','" & Today + " " + TimeOfDay & "','" & a4 & "','" & a5 & "','" & a6 & "','" & a7 & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd = New SqlCommand("Delete From APassengerDetails Where BookingNo=" & BookingNo.Text & "", con)
                    cmd.ExecuteNonQuery()
                    cmd = New SqlCommand("Delete From APaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Done")
                    con.Close()
                    DGV.Rows.Clear()
                    SeatCapacity.Clear()
                    BookingNo.Clear()
                    SC2.Clear()
                    SeatAvailability.Clear()
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                End If
            Else
                MsgBox("Not Cancelled")
            End If
        Catch ex As Exception
            MsgBox("Nothing Selected..!")
        End Try
    End Sub

    Private Sub WaitingList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = MDI.Size
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select Distinct(Rno) From Route", con)
        dr = cmd.ExecuteReader
        RNo.Items.Clear()
        While dr.Read
            RNo.Items.Add(dr.GetValue(0))
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
    End Sub

    Private Sub RNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNo.SelectedIndexChanged
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select Arrivaltime,Departuretime,Startingpoint,Destination From Route Where Rno=" & RNo.SelectedItem & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Arrivaltime.Text = dr.GetValue(0)
        Departuretime.Text = dr.GetValue(1)
        cmbstartpoint.Text = dr.GetValue(2)
        cmbdestination.Text = dr.GetValue(3)
        dr.Close()
        con.Close()
        SA()
    End Sub

    Private Sub BusSerialNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusSerialNo.SelectedIndexChanged
        If RNo.Text.Trim = "" Then
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
            con.Close()
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            SA()
        End If
    End Sub
    Public Sub SA()
        If RadioButton1.Checked = True Then
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            If Format(BookingDate.Value, "dd/MM/yyyy") = Today Then
                cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "L" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
            Else
                cmd = New SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" & "L" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "' and BDate=" & Format(BookingDate.Value, "dd/MM/yyyy") & "", con)
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            SeatAvailability.Text = dr.Item(0)
            Label16.Text = "Seat Booked From   20   Seats"
            dr.Close()
            SC2.Text = Val(SeatCapacity.Text) / 2
        Else
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            If Format(BookingDate.Value, "dd/MM/yyyy") = Today Then
                cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "U" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
            Else
                cmd = New SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" & "U" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "' and BDate=" & Format(BookingDate.Value, "dd/MM/yyyy") & "", con)
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            SeatAvailability.Text = dr.Item(0)
            Label16.Text = "Seat Booked From   20   Seats"
            dr.Close()
            con.Close()
            SC2.Text = Val(SeatCapacity.Text) / 2
        End If
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        If Format(BookingDate.Value, "dd/MM/yyyy") = Today Then
            cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "L" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
        Else
            cmd = New SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" & "L" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "' and BDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.GetValue(0)
        dr.Close()
        If Format(BookingDate.Value, "dd/MM/yyyy") = Today Then
            cmd = New SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" & "U" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "'", con)
        Else
            cmd = New SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" & "U" & "' and RouteNo='" & RNo.Text & "' and BusSno='" & BusSerialNo.Text & "' and BDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "'", con)
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        b = dr.GetValue(0)
        dr.Close()
        con.Close()
        seats = a + b
        If Val(SeatCapacity.Text) = seats Then
            Proceed.Enabled = False
        Else
            Proceed.Enabled = True
        End If
    End Sub
End Class