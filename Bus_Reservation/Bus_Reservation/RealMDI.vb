Imports System.Data.SqlClient
Public Class RealMDI
    Public id, Uname As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub RealMDI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        LoadData()
    End Sub

    Private Sub RealMDI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub RealMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To LOG OFF?", "LOG OFF?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Master.LR()
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub
    Sub LoadData()
        Me.Size = MDI.Size
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        id = Login.a
        If id = 0 Then
            id = 1
        End If
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("Select Fullname From Newuser where ID='" & id & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Label2.Text = dr.GetValue(0)
        dr.Close()
        Route.Text = Master.AddCount("Rno", "Route")
        Bus.Text = Master.AddCount("BusSno", "Bus")
        Passenger.Text = Master.AddCount("Pno", "Passenger")
        Driver.Text = Master.AddCount("Did", "Driver")
        Staff.Text = Master.AddCount("Sid", "Staff")
        Office.Text = Master.AddCount("Oid", "Office")
        Current.Text = Master.AddCount("BookingNo", "PaymentPassenger")
        Cancellation.Text = Master.AddCount("BookingNo", "Cancellation")
        Completed.Text = Master.AddCount("BookingNo", "CompletedPP")
        Advance.Text = Master.AddCount("BookingNo", "APaymentPassenger", "WaitingNo", "0")
        Waiting.Text = Master.AddCount("BookingNo", "APaymentPassenger", "Not WaitingNo", "0")
    End Sub
End Class