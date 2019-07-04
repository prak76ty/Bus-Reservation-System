Imports System.Data.SqlClient
Public Class CLEAR
    Dim GiveKey As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Sub New(ByVal Key As String)
        MyBase.New()
        InitializeComponent()
        GiveKey = Key
    End Sub

    Private Sub CLEAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GiveKey = "C" Then
            Label1.Text = "Clearing Records Of Current Booking"
        ElseIf GiveKey = "A" Then
            Label1.Text = "Clearing Records Of Advance Booking"
        ElseIf GiveKey = "Canc" Then
            Label1.Text = "Clearing Records Of Cancellation Booking"
        ElseIf GiveKey = "Comp" Then
            Label1.Text = "Clearing Records Of Completed Booking"
        ElseIf GiveKey = "MF" Then
            Label1.Text = "Clearing Records Of Master Data"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GiveKey = "C" Then
            Master.clear("PassengerDetails", "PaymentPassenger")
            ProgressBar1.Value = 100
            MsgBox("Current Booking Cleared..!")
        ElseIf GiveKey = "A" Then
            Master.clear("APassengerDetails", "APaymentPassenger")
            ProgressBar1.Value = 100
            MsgBox("Advance Booking Cleared..!")
        ElseIf GiveKey = "Canc" Then
            Master.clear("CancellationPassenger", "Cancellation")
            ProgressBar1.Value = 100
            MsgBox("Cancellation Booking Cleared..!")
        ElseIf GiveKey = "Comp" Then
            Master.clear("CompletedPassenger", "CompletedPP")
            ProgressBar1.Value = 100
            MsgBox("Completed Booking Cleared..!")
        ElseIf GiveKey = "MF" Then
            Master.clear("Route", "Bus")
            ProgressBar1.Value = 33
            Master.clear("Driver", "Staff")
            ProgressBar1.Value = 66
            Master.clear("Passenger", "Office")
            ProgressBar1.Value = 100
            MsgBox("Master Data Cleared..!")
        ElseIf GiveKey = "All" Then
            Master.clear("PassengerDetails", "PaymentPassenger")
            ProgressBar1.Value = 25
            Master.clear("APassengerDetails", "APaymentPassenger")
            ProgressBar1.Value = 50
            Master.clear("CancellationPassenger", "Cancellation")
            ProgressBar1.Value = 75
            Master.clear("CompletedPassenger", "CompletedPP")
            ProgressBar1.Value = 100
            MsgBox("All Booking Cleared..!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class