﻿Imports System.Data.SqlClient

Public Class CurrentSB
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t As Integer
    Dim i As Integer
    Private Sub Ending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ending.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            DGV.Rows.Clear()
            DGV2.Rows.Clear()
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            If Format(Today, "dd/MM/yyyy") = Format(BookingDate.Value, "dd/MM/yyyy") Then
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

            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            If Format(Today, "dd/MM/yyyy") = Format(BookingDate.Value, "dd/MM/yyyy") Then
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
                i += 1
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("No Records Found")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            DGV.Rows.Clear()
            DGV2.Rows.Clear()
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            If Format(Today, "dd/MM/yyyy") = Format(BookingDate.Value, "dd/MM/yyyy") Then
                cmd = New SqlCommand("Select * From PaymentPassenger Where BookingDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "'", con)
            Else
                cmd = New SqlCommand("Select * From APaymentPassenger Where BookingDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "'", con)
            End If
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
            If Format(Today, "dd/MM/yyyy") = Format(BookingDate.Value, "dd/MM/yyyy") Then
                cmd = New SqlCommand("Select * From PassengerDetails Where BDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "'", con)
            Else
                cmd = New SqlCommand("Select * From APassengerDetails Where BDate='" & Format(BookingDate.Value, "dd/MM/yyyy") & "'", con)
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
                i += 1
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("No Records Found")
        End Try
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

End Class