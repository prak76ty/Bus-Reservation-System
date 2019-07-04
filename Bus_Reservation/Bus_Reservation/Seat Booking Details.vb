Imports System.Data.SqlClient
Public Class Seat_Booking_Details

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t As Integer
    Dim i, BNO4 As Integer
    Dim checkm As String
    Public Sub New(ByVal msgreceived, ByVal BN)
        MyBase.New()
        InitializeComponent()
        checkm = msgreceived
        BNO4 = Val(BN)
    End Sub

    Private Sub Seat_Booking_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        BookingNo.Text = BNO4
        BookingNo.Text = BNO4
        If checkm = "NA" Then
            cmd = New SqlCommand("Select * From PaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
        Else
            cmd = New SqlCommand("Select * From APaymentPassenger Where BookingNo=" & BookingNo.Text & "", con)
        End If
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
            PN.Text = dr.GetValue(6)
            DGV.Item(7, i).Value = dr.GetValue(7)
            DGV.Item(8, i).Value = dr.GetValue(8)
            DGV.Item(9, i).Value = dr.GetValue(9)
            i += 1
        End While
        dr.Close()
        If checkm = "NA" Then
            cmd = New SqlCommand("Select * From PassengerDetails Where BookingNo=" & BookingNo.Text & "", con)
        Else
            cmd = New SqlCommand("Select * From APassengerDetails Where BookingNo=" & BookingNo.Text & "", con)
        End If
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read
            DGV2.Rows.Add()
            DGV2.Item(0, i).Value = dr.GetValue(0)
            DGV2.Item(1, i).Value = dr.GetValue(1)
            DGV2.Item(2, i).Value = dr.GetValue(2)
            DGV2.Item(3, i).Value = dr.GetValue(3)
            DGV2.Item(4, i).Value = dr.GetValue(4)
            DGV2.Item(5, i).Value = dr.GetValue(5)
            DGV2.Item(6, i).Value = dr.GetValue(6)
            DGV2.Item(7, i).Value = dr.GetValue(7)
            DGV2.Item(8, i).Value = dr.GetValue(8)
            DGV2.Item(9, i).Value = dr.GetValue(9)
            DGV2.Item(10, i).Value = dr.GetValue(10)
            PaymentBy.Text = dr.GetValue(10)
            i += 1
        End While
        dr.Close()
        If checkm = "NA" Then
            cmd = New SqlCommand("Update PaymentPassenger Set WaitingNo=" & "0" & " Where BookingNo=" & BookingNo.Text & "", con)
        Else
            cmd = New SqlCommand("Update APaymentPassenger Set WaitingNo=" & "0" & " Where BookingNo=" & BookingNo.Text & "", con)
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        Master.Completed()
    End Sub

    Private Sub Ending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ending.Click
        Try
            SeatBooking.Close()
            Me.Close()
            AdvanceSeatBooking.Close()
            Master.Completed()
            WaitingList.Close()
        Catch ex As Exception
            MsgBox("Something Went Wrong..! Manually Close Application..")
        End Try
    End Sub
End Class