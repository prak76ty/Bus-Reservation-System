Public Class PassengerMaster
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
        PassengerNo.Text = Master.Add("Pno", "Passenger")
        f = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If f = 0 Then
                If PassengerNo.Text.Trim = "" Or PassengerName.Text.Trim = "" Or PassengerAddress.Text.Trim = "" Or PassengerCity.Text.Trim = "" Or PassengerContact.Text.Trim = "" Then
                    MsgBox("Information is Missing.. !")
                Else
                    MsgBox(Master.Save(5))
                    FormControls("CLR")
                End If
            Else
                If PassengerNo.Text.Trim = "" Or PassengerName.Text.Trim = "" Or PassengerAddress.Text.Trim = "" Or PassengerCity.Text.Trim = "" Or PassengerContact.Text.Trim = "" Then
                    MsgBox("Information is Missing.. !")
                Else
                    MsgBox(Master.Update(5))
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
            f = 1
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            MsgBox(Master.Delete("Pno", "Passenger", PassengerNo.Text))
            FormControls("CLR")
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim id As Integer
            id = InputBox("Plz Enter Passenger No:")
            Master.Find("Pno", "Passenger", id, 5)
            MoveLR()
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            PassengerNo.ReadOnly = True
            PassengerName.Enabled = False
            PassengerAddress.Enabled = False
            PassengerCity.Enabled = False
            PassengerContact.Enabled = False
            Left1.Enabled = True
            Right1.Enabled = True
        Catch ex As Exception
            MsgBox("NO Record Found")
        End Try
    End Sub

    Private Sub PassengerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassengerName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PassengerContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassengerContact.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PassengerCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassengerCity.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Sub MoveLR()
        PassengerNo.Text = Master.FindMe(0)
        PassengerName.Text = Master.FindMe(1)
        PassengerAddress.Text = Master.FindMe(2)
        PassengerCity.Text = Master.FindMe(3)
        PassengerContact.Text = Master.FindMe(4)
    End Sub

    Private Sub Left1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left1.Click
        Try
            Master.Find("Pno", "Passenger", Val(PassengerNo.Text) - 1, 5)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub

    Private Sub Right1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right1.Click
        Try
            Master.Find("Pno", "Passenger", Val(PassengerNo.Text) + 1, 5)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub FormControls(ByVal CLR As String)
        If CLR = "CLR" Then
            PassengerNo.Clear()
            PassengerName.Clear()
            PassengerAddress.Clear()
            PassengerCity.Clear()
            PassengerContact.Clear()
            PassengerNo.Enabled = False
            PassengerName.Enabled = False
            PassengerAddress.Enabled = False
            PassengerCity.Enabled = False
            PassengerContact.Enabled = False
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
            PassengerName.Enabled = True
            PassengerAddress.Enabled = True
            PassengerCity.Enabled = True
            PassengerContact.Enabled = True
            PassengerName.Focus()
        End If
    End Sub
End Class