Public Class OfficeMaster
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
        OfficeID.Text = Master.Add("Oid", "Office")
        O = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If O = 0 Then
                If OfficeID.Text.Trim = "" Or OWorkerName.Text.Trim = "" Or Officeaddress.Text.Trim = "" Or Officecity.Text.Trim = "" Or Officecontact.Text.Trim = "" Then
                    MsgBox("Plz.. Enter Office Information..")
                Else
                    MsgBox(Master.Save(4))
                    FormControls("CLR")
                End If
            Else
                If OfficeID.Text.Trim = "" Or OWorkerName.Text.Trim = "" Or Officeaddress.Text.Trim = "" Or Officecity.Text.Trim = "" Or Officecontact.Text.Trim = "" Then
                    MsgBox("Plz.. Enter Office Information..")
                Else
                    MsgBox(Master.Update(4))
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
            O = 1
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            MsgBox(Master.Delete("Oid", "Office", OfficeID.Text))
            FormControls("CLR")
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim id As Integer
            id = InputBox("Plz Enter Office ID:")
            Master.Find("Oid", "Office", id, 5)
            MoveLR()
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            OfficeID.ReadOnly = True
            OWorkerName.Enabled = False
            Officeaddress.Enabled = False
            Officecity.Enabled = False
            Officecontact.Enabled = False
            Left1.Enabled = True
            Right1.Enabled = True
        Catch ex As Exception
            MsgBox("NO Record Found")
        End Try
    End Sub

    Private Sub OWorkerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OWorkerName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Officecontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Officecontact.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Officecity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Officecity.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Sub MoveLR()
        OfficeID.Text = Master.FindMe(0)
        OWorkerName.Text = Master.FindMe(1)
        Officeaddress.Text = Master.FindMe(2)
        Officecity.Text = Master.FindMe(3)
        Officecontact.Text = Master.FindMe(4)
    End Sub

    Private Sub Left1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left1.Click
        Try
            Master.Find("Oid", "Office", Val(OfficeID.Text) - 1, 5)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub

    Private Sub Right1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right1.Click
        Try
            Master.Find("Oid", "Office", Val(OfficeID.Text) + 1, 5)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub FormControls(ByVal CLR As String)
        If CLR = "CLR" Then
            OfficeID.Clear()
            OWorkerName.Clear()
            Officeaddress.Clear()
            Officecity.Clear()
            Officecontact.Clear()
            OfficeID.Enabled = False
            OWorkerName.Enabled = False
            Officeaddress.Enabled = False
            Officecity.Enabled = False
            Officecontact.Enabled = False
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
            OWorkerName.Enabled = True
            Officeaddress.Enabled = True
            Officecity.Enabled = True
            Officecontact.Enabled = True
            OWorkerName.Focus()
        End If
    End Sub
End Class