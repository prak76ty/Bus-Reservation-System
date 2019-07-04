Public Class DriverMaster
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
        DriverID.Text = Master.Add("Did", "Driver")
        D = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If D = 0 Then
                If DriverID.Text.Trim = "" Or DriverName.Text.Trim = "" Or DriverAddress.Text.Trim = "" Or Drivercity.Text.Trim = "" Or DriverAge.Text.Trim = "" Or DriverContact.Text.Trim = "" Or DriverLicense.Text.Trim = "" Or DriverSalary.Text.Trim = "" Or DriverQualification.Text.Trim = "" Or DriverReference.Text.Trim = "" Or DriverConctact2.Text.Trim = "" Then
                    MsgBox("Information is Missing..")
                Else
                    MsgBox(Master.Save(3))
                    FormControls("CLR")
                End If
            Else
                If DriverID.Text.Trim = "" Or DriverName.Text.Trim = "" Or DriverAddress.Text.Trim = "" Or Drivercity.Text.Trim = "" Or DriverAge.Text.Trim = "" Or DriverContact.Text.Trim = "" Or DriverLicense.Text.Trim = "" Or DriverSalary.Text.Trim = "" Or DriverQualification.Text.Trim = "" Or DriverReference.Text.Trim = "" Or DriverConctact2.Text.Trim = "" Then
                    MsgBox("Information is Missing..")
                Else
                    MsgBox(Master.Update(3))
                    FormControls("CLR")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Edit Record?", "UPdate Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            FormControls("Save")
            D = 1
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then   
            MsgBox(Master.Delete("Did", "Driver", DriverID.Text))
            FormControls("CLR")
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim id As Integer
            id = InputBox("Plz Enter Driver ID:")
            Master.Find("Did", "Driver", id, 12)
            MoveLR()
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            DriverID.ReadOnly = True
            DriverName.Enabled = False
            DriverAddress.Enabled = False
            Drivercity.Enabled = False
            DriverContact.Enabled = False
            DriverAge.Enabled = False
            DriverLicense.Enabled = False
            DateJoining.Enabled = False
            DriverSalary.Enabled = False
            DriverQualification.Enabled = False
            DriverReference.Enabled = False
            DriverConctact2.Enabled = False
            Left1.Enabled = True
            Right1.Enabled = True
        Catch ex As Exception
            MsgBox("NO Record Found")
        End Try
    End Sub

    Private Sub DriverName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DriverName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DriverContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DriverContact.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DriverConctact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DriverConctact2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Drivercity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Drivercity.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Sub MoveLR()
        DriverID.Text = Master.FindMe(0)
        DriverName.Text = Master.FindMe(1)
        DriverAddress.Text = Master.FindMe(2)
        Drivercity.Text = Master.FindMe(3)
        DriverAge.Text = Master.FindMe(4)
        DriverContact.Text = Master.FindMe(5)
        DriverLicense.Text = Master.FindMe(6)
        DateJoining.Text = Master.FindMe(7)
        DriverSalary.Text = Master.FindMe(8)
        DriverQualification.Text = Master.FindMe(9)
        DriverReference.Text = Master.FindMe(10)
        DriverConctact2.Text = Master.FindMe(11)
    End Sub

    Private Sub Left1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left1.Click
        Try
            Master.Find("Did", "Driver", Val(DriverID.Text) - 1, 12)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub

    Private Sub Right1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right1.Click
        Try
            Master.Find("Did", "Driver", Val(DriverID.Text) + 1, 12)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub FormControls(ByVal CLR As String)
        If CLR = "CLR" Then
            DriverID.Enabled = False
            DriverName.Enabled = False
            DriverAddress.Enabled = False
            Drivercity.Enabled = False
            DriverContact.Enabled = False
            DriverAge.Enabled = False
            DriverLicense.Enabled = False
            DateJoining.Enabled = False
            DriverSalary.Enabled = False
            DriverQualification.Enabled = False
            DriverReference.Enabled = False
            DriverConctact2.Enabled = False
            DriverID.Clear()
            DriverName.Clear()
            DriverAddress.Clear()
            Drivercity.Clear()
            DriverAge.Clear()
            DriverContact.Clear()
            DriverLicense.Clear()
            DriverSalary.Clear()
            DriverQualification.Clear()
            DriverReference.Clear()
            DriverConctact2.Clear()
            DateJoining.Text = TimeOfDay
            btnsave.Enabled = False
            btnedit.Enabled = False
            btndelete.Enabled = False
            btnadd.Enabled = True
            btnfind.Enabled = True
            Left1.Enabled = False
            Right1.Enabled = False
        End If
        If CLR = "Save" Then
            DriverName.Enabled = True
            DriverAddress.Enabled = True
            Drivercity.Enabled = True
            DriverContact.Enabled = True
            DriverAge.Enabled = True
            DriverLicense.Enabled = True
            DateJoining.Enabled = True
            DriverSalary.Enabled = True
            DriverQualification.Enabled = True
            DriverReference.Enabled = True
            DriverConctact2.Enabled = True
            btnsave.Enabled = True
            btnadd.Enabled = False
            btnfind.Enabled = False
            btndelete.Enabled = False
            btnedit.Enabled = False
        End If
    End Sub
End Class