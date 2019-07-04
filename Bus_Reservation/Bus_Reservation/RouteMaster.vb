Public Class RouteMaster
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub

    Private Sub RouteMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormControls("CLR")
    End Sub

    Private Sub btnmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmain.Click
        FormControls("CLR")
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        FormControls("Save")
        Rno.Text = Master.Add("Rno", "Route")
        R = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If R = 0 Then
                If cmbdestination.Text = "Select" Or cmbstartpoint.Text = "Select" Then
                    MsgBox("Select an Valid Starting Point OR Destination")
                ElseIf cmbstartpoint.Text = "Pachora" And cmbdestination.Text = "Pachora" Or cmbstartpoint.Text = "Pune" And cmbdestination.Text = "Pune" Or cmbstartpoint.Text = "Mumbai" And cmbdestination.Text = "Mumbai" Or cmbstartpoint.Text = "Surat" And cmbdestination.Text = "Surat" Then
                    MsgBox("!!!!!!!Starting Point and Destination is Same.. Select Again!!!!!!!")
                ElseIf FAmount.Text.Trim = "" Then
                    MsgBox("Plz.. Enter Fare Amount..")
                ElseIf TTime.Text.Trim = "" Or TDistance.Text.Trim = "" Then
                    MsgBox("Plz.. Generate Your Route")
                Else
                    MsgBox(Master.Save(1))
                    FormControls("CLR")
                End If
            Else
                If cmbdestination.Text = "Select" Or cmbstartpoint.Text = "Select" Then
                    MsgBox("Select an Valid Starting Point OR Destination")
                ElseIf cmbstartpoint.Text = "Pachora" And cmbdestination.Text = "Pachora" Or cmbstartpoint.Text = "Pune" And cmbdestination.Text = "Pune" Or cmbstartpoint.Text = "Mumbai" And cmbdestination.Text = "Mumbai" Or cmbstartpoint.Text = "Surat" And cmbdestination.Text = "Surat" Then
                    MsgBox("!!!!!!!Starting Point and Destination is Same.. Select Again!!!!!!!")
                ElseIf FAmount.Text.Trim = "" Then
                    MsgBox("Plz.. Enter Fare Amount..")
                ElseIf TTime.Text.Trim = "" Or TDistance.Text.Trim = "" Then
                    MsgBox("Plz.. Generate Your Route")
                Else
                    MsgBox(Master.Update(1))
                    FormControls("CLR")
                End If
            End If
        Catch ex As Exception
            MsgBox("Sorry.. Something Went Wrong..!")
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Edit Record?", "UPdate Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            FormControls("Save")
            R = 1
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As DialogResult = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            MsgBox(Master.Delete("Rno", "Route", Rno.Text))
           FormControls("CLR")
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim id As Integer
            id = InputBox("Plz Enter Route No:")
            Master.Find("Rno", "Route", id, 9)
            MoveLR()
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            Rno.ReadOnly = True
            RouteName.Enabled = False
            Arrivaltime.Enabled = False
            Departuretime.Enabled = False
            cmbstartpoint.Enabled = False
            cmbdestination.Enabled = False
            FAmount.Enabled = False
            Left1.Enabled = True
            Right1.Enabled = True
        Catch ex As Exception
            MsgBox("NO Record Found????")
        End Try
    End Sub

    Private Sub btngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerate.Click
        Dim interval As New TimeSpan(7, 0, 0)
        Dim interval2 As New TimeSpan(6, 30, 0)
        Dim interval3 As New TimeSpan(6, 0, 0)
        If cmbstartpoint.Text = "Pachora" And cmbdestination.Text = "Pune" Or cmbstartpoint.Text = "Pune" And cmbdestination.Text = "Pachora" Then
            TDistance.Text = "347km"
            TTime.Text = "07:00"
            Departuretime.Value = Arrivaltime.Value + interval
        ElseIf cmbstartpoint.Text = "Pachora" And cmbdestination.Text = "Mumbai" Or cmbstartpoint.Text = "Mumbai" And cmbdestination.Text = "Pachora" Then
            TDistance.Text = "325km"
            TTime.Text = "06:30"
            Departuretime.Value = Arrivaltime.Value + interval2
        ElseIf cmbstartpoint.Text = "Pachora" And cmbdestination.Text = "Surat" Or cmbstartpoint.Text = "Surat" And cmbdestination.Text = "Pachora" Then
            TDistance.Text = "305km"
            TTime.Text = "06:00"
            Departuretime.Value = Arrivaltime.Value + interval3
        ElseIf cmbstartpoint.Text = "Pachora" And cmbdestination.Text = "Pachora" Or cmbstartpoint.Text = "Pune" And cmbdestination.Text = "Pune" Or cmbstartpoint.Text = "Mumbai" And cmbdestination.Text = "Mumbai" Or cmbstartpoint.Text = "Surat" And cmbdestination.Text = "Surat" Then
            MsgBox("!!!!!!!Starting Point and Destination is Same.. Select Again!!!!!!!")
        ElseIf cmbdestination.Text = "Select" Or cmbstartpoint.Text = "Select" Then
            MsgBox("Select an Valid Category")
        End If
    End Sub

    Private Sub Rname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RouteName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Left1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left1.Click
        Try
            Master.Find("Rno", "Route", Val(Rno.Text) - 1, 9)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub MoveLR()
        Rno.Text = Master.FindMe(0)
        RouteName.Text = Master.FindMe(1)
        Arrivaltime.Text = Master.FindMe(2)
        Departuretime.Text = Master.FindMe(3)
        cmbstartpoint.Text = Master.FindMe(4)
        cmbdestination.Text = Master.FindMe(5)
        FAmount.Text = Master.FindMe(6)
        TTime.Text = Master.FindMe(7)
        TDistance.Text = Master.FindMe(8)
    End Sub

    Private Sub Right1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right1.Click
        Try
            Master.Find("Rno", "Route", Val(Rno.Text) + 1, 9)
            MoveLR()
        Catch ex As Exception
            MsgBox("No Records..")
        End Try
    End Sub
    Sub FormControls(ByVal CLR As String)
        If CLR = "CLR" Then
            Rno.Clear()
            RouteName.Clear()
            FAmount.Clear()
            cmbdestination.Text = "Select"
            cmbstartpoint.Text = "Select"
            TTime.Clear()
            TDistance.Clear()
            Arrivaltime.Text = TimeOfDay
            Departuretime.Text = TimeOfDay
            Rno.Enabled = False
            RouteName.Enabled = False
            FAmount.Enabled = False
            cmbdestination.Enabled = False
            cmbstartpoint.Enabled = False
            Arrivaltime.Enabled = False
            Departuretime.Enabled = False
            btnsave.Enabled = False
            btnedit.Enabled = False
            btndelete.Enabled = False
            btnadd.Enabled = True
            btnfind.Enabled = True
            btngenerate.Enabled = False
            Left1.Enabled = False
            Right1.Enabled = False
        End If
        If CLR = "Save" Then
            RouteName.Enabled = True
            FAmount.Enabled = True
            cmbdestination.Enabled = True
            cmbstartpoint.Enabled = True
            Arrivaltime.Enabled = True
            Departuretime.Enabled = False
            RouteName.Focus()
            btnsave.Enabled = True
            btnadd.Enabled = False
            btnfind.Enabled = False
            btndelete.Enabled = False
            btnedit.Enabled = False
            btngenerate.Enabled = True
        End If
    End Sub
End Class