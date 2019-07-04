Imports System.Data.SqlClient

Public Class CancellationSB
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
            cmd = New SqlCommand("Select * From Cancellation Where BookingNo=" & BookingNo.Text & "", con)
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
                i += 1
            End While
            dr.Close()
            con.Close()

            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select * From CancellationPassenger Where BookingNo=" & BookingNo.Text & "", con)
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
                DGV2.Item(11, i).Value = dr.GetValue(11)
                DGV2.Item(12, i).Value = dr.GetValue(12)
                DGV2.Item(13, i).Value = dr.GetValue(14)
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
            cmd = New SqlCommand("Select * From Cancellation Where BookingDate='" & Format(CNDate.Value, "dd/MM/yyyy") & "'", con)
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
                i += 1
            End While
            dr.Close()
            cmd = New SqlCommand("Select * From CancellationPassenger Where BDate='" & Format(CNDate.Value, "dd/MM/yyyy") & "'", con)
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
                DGV2.Item(11, i).Value = dr.GetValue(11)
                DGV2.Item(12, i).Value = dr.GetValue(12)
                DGV2.Item(13, i).Value = dr.GetValue(14)
                i += 1
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("No Records Found")
        End Try
    End Sub
End Class