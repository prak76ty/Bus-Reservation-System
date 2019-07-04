Imports System.Data.SqlClient

Public Class MDI
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim t As Integer = 0
    Dim AN As Integer

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To LOG OFF?", "LOG OFF?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Master.LR()
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ROUTEMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROUTEMASTERToolStripMenuItem.Click
        RouteMaster.MdiParent = Me
        RouteMaster.Show()
        RouteMaster.BringToFront()
    End Sub

    Private Sub PASSENGERMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASSENGERMASTERToolStripMenuItem.Click
        PassengerMaster.MdiParent = Me
        PassengerMaster.Show()
        PassengerMaster.BringToFront()
    End Sub

    Private Sub STAFFMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFFMASTERToolStripMenuItem.Click
        StaffMaster.MdiParent = Me
        StaffMaster.Show()
        StaffMaster.BringToFront()
    End Sub

    Private Sub BUSMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUSMASTERToolStripMenuItem.Click
        BusMaster.MdiParent = Me
        BusMaster.Show()
        BusMaster.BringToFront()
    End Sub

    Private Sub OFFCEMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFCEMASTERToolStripMenuItem.Click
        OfficeMaster.MdiParent = Me
        OfficeMaster.Show()
        OfficeMaster.BringToFront()
    End Sub

    Private Sub DRIVERMASTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DRIVERMASTEToolStripMenuItem.Click
        DriverMaster.MdiParent = Me
        DriverMaster.Show()
        DriverMaster.BringToFront()
    End Sub

    Private Sub SEATBOOKINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEATBOOKINGToolStripMenuItem.Click
        Master.Completed()
        SeatBooking.MdiParent = Me
        SeatBooking.Show()
        SeatBooking.BringToFront()
    End Sub

    Private Sub BOOKINGCANCELLATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKINGCANCELLATIONToolStripMenuItem.Click
        Master.Completed()
        BookingCancellation.MdiParent = Me
        BookingCancellation.Show()
        BookingCancellation.BringToFront()
    End Sub
    

    Private Sub CurrentBookedSeatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentBookedSeatToolStripMenuItem.Click
        Master.Completed()
        CurrentSB.MdiParent = Me
        CurrentSB.Show()
        CurrentSB.BringToFront()
    End Sub

    Private Sub CancelledSeatsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelledSeatsToolStripMenuItem.Click
        Master.Completed()
        CancellationSB.MdiParent = Me
        CancellationSB.Show()
        CancellationSB.BringToFront()
    End Sub

    Private Sub CompletedBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletedBookingToolStripMenuItem.Click
        Master.Completed()
        CompletedSB.MdiParent = Me
        CompletedSB.Show()
        CompletedSB.BringToFront()
    End Sub

    Private Sub ADVANCEBOOKINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADVANCEBOOKINGToolStripMenuItem.Click
        Master.Completed()
        AdvanceSeatBooking.MdiParent = Me
        AdvanceSeatBooking.Show()
        AdvanceSeatBooking.BringToFront()
    End Sub

    Private Sub ADVANCEBOOKINGCANCELLATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADVANCEBOOKINGCANCELLATIONToolStripMenuItem.Click
        Master.Completed()
        AdvanceBookingCancellation.MdiParent = Me
        AdvanceBookingCancellation.Show()
        AdvanceBookingCancellation.BringToFront()
    End Sub

    Private Sub ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem.Click
        Master.Completed()
        WaitingList.MdiParent = Me
        WaitingList.Show()
        WaitingList.BringToFront()
    End Sub

    Private Sub MDI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Master.LR()
        Application.Exit()
    End Sub
    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Master.Completed()
        RealMDI.MdiParent = Me
        RealMDI.Show()
    End Sub

    Private Sub CLEARCURRENTBOOKINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARCURRENTBOOKINGToolStripMenuItem.Click
        Dim Current As New CLEAR("C")
        Current.Show()
        Current.BringToFront()
    End Sub

    Private Sub CLEARADVANCEBOOKINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARADVANCEBOOKINGToolStripMenuItem.Click
        Dim Advance As New CLEAR("A")
        Advance.Show()
        Advance.BringToFront()
    End Sub

    Private Sub CLEARCANCELLATIONBOOKINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARCANCELLATIONBOOKINGToolStripMenuItem.Click
        Dim CancellationB As New CLEAR("Canc")
        CancellationB.Show()
        CancellationB.BringToFront()
    End Sub

    Private Sub CLEARCOMPLETEDBOOKINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARCOMPLETEDBOOKINGSToolStripMenuItem.Click
        Dim CompletedB As New CLEAR("Comp")
        CompletedB.Show()
        CompletedB.BringToFront()
    End Sub

    Private Sub CLEARALLBOOKINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARALLBOOKINGSToolStripMenuItem.Click
        Dim All As New CLEAR("All")
        All.Show()
        All.BringToFront()
    End Sub

    Private Sub ROUTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROUTEToolStripMenuItem.Click
        ReportsRouteMaster.MdiParent = Me
        ReportsRouteMaster.Show()
        ReportsRouteMaster.BringToFront()
    End Sub

    Private Sub BUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUSToolStripMenuItem.Click
        ReportsBusMaster.MdiParent = Me
        ReportsBusMaster.Show()
        ReportsBusMaster.BringToFront()
    End Sub

    Private Sub PASSENGERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASSENGERToolStripMenuItem.Click
        ReportsPassengerMaster.MdiParent = Me
        ReportsPassengerMaster.Show()
        ReportsPassengerMaster.BringToFront()
    End Sub

    Private Sub DRIVERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DRIVERToolStripMenuItem.Click
        ReportsDriverMaster.MdiParent = Me
        ReportsDriverMaster.Show()
        ReportsDriverMaster.BringToFront()
    End Sub

    Private Sub STAFFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFFToolStripMenuItem.Click
        ReportsStaffMaster.MdiParent = Me
        ReportsStaffMaster.Show()
        ReportsStaffMaster.BringToFront()
    End Sub

    Private Sub OFFICEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFICEToolStripMenuItem.Click
        ReportsOfficeMaster.MdiParent = Me
        ReportsOfficeMaster.Show()
        ReportsOfficeMaster.BringToFront()
    End Sub

    Private Sub CLEARALLMASTERDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARALLMASTERDATAToolStripMenuItem.Click
        Dim MF As New CLEAR("MF")
        MF.Show()
        MF.BringToFront()
    End Sub

    Private Sub LOGINRECORDSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINRECORDSToolStripMenuItem.Click
        ReportsLoginRecords.MdiParent = Me
        ReportsLoginRecords.Show()
        ReportsLoginRecords.BringToFront()
    End Sub

    Private Sub CURRENTBOOKINGREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTBOOKINGREPORTToolStripMenuItem.Click
        ReportCurrentBooking.MdiParent = Me
        ReportCurrentBooking.Show()
        ReportCurrentBooking.BringToFront()
    End Sub

    Private Sub ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem.Click
        ReportAdvanceWaiting.MdiParent = Me
        ReportAdvanceWaiting.Show()
        ReportAdvanceWaiting.BringToFront()
    End Sub

    Private Sub COMPLETEDBOOKINGREPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLETEDBOOKINGREPORTSToolStripMenuItem.Click
        ReportCompleted.MdiParent = Me
        ReportCompleted.Show()
        ReportCompleted.BringToFront()
    End Sub

    Private Sub CANCELLATIONBOOKINGREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELLATIONBOOKINGREPORTToolStripMenuItem.Click
        ReportCancellation.MdiParent = Me
        ReportCancellation.Show()
        ReportCancellation.BringToFront()
    End Sub
End Class