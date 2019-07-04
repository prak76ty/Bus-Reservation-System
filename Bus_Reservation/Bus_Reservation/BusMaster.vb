Public Class BusMaster
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub PassengerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormControls("CLR")
    End Sub

    Private Sub btnmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmain.Click
        FormControls("CLR")
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        FormControls("Save")
        BusSerialNo.Text = Master.Add("BusSno", "Bus")
        f = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If f = 0 Then
            If BusNumber.Text = "Select" Then
                MsgBox("Select an Valid Catagory")
            ElseIf BusRoute.Text = "Select" Then
                MsgBox("Select an Valid Type")
            ElseIf BusType.Text = "Select" Then
                MsgBox("Select an Valid Size")
            ElseIf BusReservation.Text = "Select" Then
                MsgBox("Select an Valid Company")
            Else
                MsgBox(Master.Save(2))
                FormControls("CLR")
            End If
        Else
            If BusNumber.Text = "Select" Then
                MsgBox("Select an Valid Catagory")
            ElseIf BusRoute.Text = "Select" Then
                MsgBox("Select an Valid Type")
            ElseIf BusType.Text = "Select" Then
                MsgBox("Select an Valid Size")
            ElseIf BusReservation.Text = "Select" Then
                MsgBox("Select an Valid Company")
            Else
                MsgBox(Master.Update(2))
                FormControls("CLR")
            End If
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Edit Record?", "UPdate Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            FormControls("Save")
            f = 1
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            MsgBox(Master.Delete("BusSno", "Bus", BusSerialNo.Text))
            FormControls("CLR")
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim id As Integer
            id = InputBox("Plz Enter Bus Serial No:")
            Master.Find("BusSno", "Bus", id, 6)
            MoveLR()
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            BusSerialNo.ReadOnly = True
            BusNumber.Enabled = False
            BusRoute.Enabled = False
            BusType.Enabled = False
            BusReservation.Enabled = False
            Left1.Enabled = True
            Right1.Enabled = True
        Catch ex As Exception
            MsgBox("NO Record Found")
        End Try
    End Sub
    Private Sub BusReservation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusReservation.SelectedIndexChanged
        If BusReservation.Text = "1x1" Then
            SeatCapacity.Text = "40"
        End If
        If BusReservation.Text = "2x1" Then
            SeatCapacity.Text = "60"
        End If
        If BusReservation.Text = "2x2" Then
            SeatCapacity.Text = "80"
        End If
    End Sub
    Sub MoveLR()
        BusSerialNo.Text = Master.FindMe(0)
        BusNumber.Text = Master.FindMe(1)
        BusRoute.Text = Master.FindMe(2)
        BusType.Text = Master.FindMe(3)
        BusReservation.Text = Master.FindMe(4)
        SeatCapacity.Text = Master.FindMe(5)
    End Sub

    Private Sub Left1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left1.Click
        Try
            Master.Find("BusSno", "Bus", Val(BusSerialNo.Text) - 1, 6)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub

    Private Sub Right1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right1.Click
        Try
            Master.Find("BusSno", "Bus", Val(BusSerialNo.Text) + 1, 6)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub FormControls(ByVal CLR As String)
        If CLR = "CLR" Then
            BusSerialNo.Clear()
            BusNumber.Text = "Select"
            BusRoute.Text = "Select"
            BusType.Text = "Select"
            BusReservation.Text = "Select"
            BusSerialNo.Enabled = False
            BusNumber.Enabled = False
            BusRoute.Enabled = False
            BusType.Enabled = False
            BusReservation.Enabled = False
            SeatCapacity.Clear()
            btnsave.Enabled = False
            btnedit.Enabled = False
            btndelete.Enabled = False
            btnadd.Enabled = True
            btnfind.Enabled = True
            Left1.Enabled = False
            Right1.Enabled = False
        End If
        If CLR = "Save" Then
            btnsave.Enabled = True
            btnadd.Enabled = False
            btnfind.Enabled = False
            btndelete.Enabled = False
            btnedit.Enabled = False
            BusNumber.Enabled = True
            BusRoute.Enabled = True
            BusType.Enabled = True
            BusReservation.Enabled = True
            BusNumber.Focus()
        End If
    End Sub
End Class