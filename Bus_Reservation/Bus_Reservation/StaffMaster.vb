Public Class StaffMaster
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub btnmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmain.Click
        FormControls("CLR")
    End Sub

    Private Sub StaffMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormControls("CLR")
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        FormControls("Save")
        StaffID.Text = Master.Add("Sid", "Staff")
        S = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If S = 0 Then
                If StaffType.Text = "Select" Then
                    MsgBox("Select an Valid Catagory")
                ElseIf StaffName.Text.Trim = "" Or StaffAddress.Text.Trim = "" Or StaffCity.Text.Trim = "" Or StaffContact.Text.Trim = "" Or StaffID.Text.Trim = "" Then
                    MsgBox("Information is Missing..!")
                Else
                    MsgBox(Master.Save(6))
                    FormControls("CLR")
                End If
            Else
                If StaffType.Text = "Select" Then
                    MsgBox("Select an Valid Catagory")
                ElseIf StaffName.Text.Trim = "" Or StaffAddress.Text.Trim = "" Or StaffCity.Text.Trim = "" Or StaffContact.Text.Trim = "" Or StaffID.Text.Trim = "" Then
                    MsgBox("Information is Missing..!")
                Else
                    MsgBox(Master.Update(6))
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
            S = 1
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            MsgBox(Master.Delete("Sid", "Staff", StaffID.Text))
            FormControls("CLR")
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim id As Integer
            id = InputBox("Plz Enter Staff ID:")
            Master.Find("Sid", "Staff", id, 6)
            MoveLR()
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            StaffID.ReadOnly = True
            StaffName.Enabled = False
            StaffType.Enabled = False
            StaffAddress.Enabled = False
            StaffCity.Enabled = False
            StaffContact.Enabled = False
            Left1.Enabled = True
            Right1.Enabled = True
        Catch ex As Exception
            MsgBox("NO Record Found")
        End Try
    End Sub

    Private Sub StaffName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StaffName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub StaffContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StaffContact.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub StaffCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StaffCity.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Sub MoveLR()
        StaffID.Text = Master.FindMe(0)
        StaffName.Text = Master.FindMe(1)
        StaffType.Text = Master.FindMe(2)
        StaffAddress.Text = Master.FindMe(3)
        StaffCity.Text = Master.FindMe(4)
        StaffContact.Text = Master.FindMe(5)
    End Sub

    Private Sub Left1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left1.Click
        Try
            Master.Find("Sid", "Staff", Val(StaffID.Text) - 1, 6)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub

    Private Sub Right1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right1.Click
        Try
            Master.Find("Sid", "Staff", Val(StaffID.Text) + 1, 6)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub FormControls(ByVal CLR As String)
        If CLR = "CLR" Then
            StaffID.Clear()
            StaffName.Clear()
            StaffType.Text = "Select"
            StaffAddress.Clear()
            StaffCity.Clear()
            StaffContact.Clear()
            StaffID.Enabled = False
            StaffName.Enabled = False
            StaffType.Enabled = False
            StaffAddress.Enabled = False
            StaffCity.Enabled = False
            StaffContact.Enabled = False
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
            StaffName.Enabled = True
            StaffType.Enabled = True
            StaffAddress.Enabled = True
            StaffCity.Enabled = True
            StaffContact.Enabled = True
            StaffName.Focus()
        End If
    End Sub
End Class