<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RouteMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainlabel = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnfind = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnmain = New System.Windows.Forms.Button
        Me.Right1 = New System.Windows.Forms.Button
        Me.Left1 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TDistance = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TTime = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.FAmount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btngenerate = New System.Windows.Forms.Button
        Me.cmbdestination = New System.Windows.Forms.ComboBox
        Me.cmbstartpoint = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Departuretime = New System.Windows.Forms.DateTimePicker
        Me.Arrivaltime = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.RouteName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Rno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainlabel
        '
        Me.mainlabel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlabel.Location = New System.Drawing.Point(173, 29)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(506, 62)
        Me.mainlabel.TabIndex = 0
        Me.mainlabel.Text = "ROUTE MASTER "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(-14, 74)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnexit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnfind)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btndelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnedit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnsave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnadd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.Right1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Left1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TDistance)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TTime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FAmount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btngenerate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbdestination)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbstartpoint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Departuretime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Arrivaltime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RouteName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Rno)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1394, 703)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 3
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btnexit.FlatAppearance.BorderSize = 2
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexit.Location = New System.Drawing.Point(16, 510)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(150, 75)
        Me.btnexit.TabIndex = 14
        Me.btnexit.Text = "EXIT FORM"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnfind
        '
        Me.btnfind.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btnfind.FlatAppearance.BorderSize = 2
        Me.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfind.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfind.Image = Global.Bus_Reservation.My.Resources.Resources.search_property_48
        Me.btnfind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnfind.Location = New System.Drawing.Point(16, 429)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(150, 75)
        Me.btnfind.TabIndex = 12
        Me.btnfind.Text = "FIND"
        Me.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfind.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btndelete.FlatAppearance.BorderSize = 2
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Bus_Reservation.My.Resources.Resources.delete_property_48
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndelete.Location = New System.Drawing.Point(16, 348)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(150, 75)
        Me.btndelete.TabIndex = 11
        Me.btndelete.Text = "DELETE"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btnedit.FlatAppearance.BorderSize = 2
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Image = Global.Bus_Reservation.My.Resources.Resources.edit_property_48
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnedit.Location = New System.Drawing.Point(16, 267)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(150, 75)
        Me.btnedit.TabIndex = 10
        Me.btnedit.Text = "EDIT"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btnsave.FlatAppearance.BorderSize = 2
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Bus_Reservation.My.Resources.Resources.save_48
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsave.Location = New System.Drawing.Point(16, 186)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(150, 75)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btnadd.FlatAppearance.BorderSize = 2
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Bus_Reservation.My.Resources.Resources.add_property_48
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnadd.Location = New System.Drawing.Point(16, 105)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(150, 75)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnmain
        '
        Me.btnmain.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnmain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmain.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.btnmain.FlatAppearance.BorderSize = 2
        Me.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmain.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmain.Image = Global.Bus_Reservation.My.Resources.Resources.xbox_menu_48
        Me.btnmain.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmain.Location = New System.Drawing.Point(16, 24)
        Me.btnmain.Name = "btnmain"
        Me.btnmain.Size = New System.Drawing.Size(150, 75)
        Me.btnmain.TabIndex = 7
        Me.btnmain.Text = "MAIN PAGE"
        Me.btnmain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmain.UseVisualStyleBackColor = False
        '
        'Right1
        '
        Me.Right1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Right1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Right1.Enabled = False
        Me.Right1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.Right1.FlatAppearance.BorderSize = 2
        Me.Right1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Right1.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Right1.Image = Global.Bus_Reservation.My.Resources.Resources.chevron_right_round_48
        Me.Right1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Right1.Location = New System.Drawing.Point(668, 4)
        Me.Right1.Name = "Right1"
        Me.Right1.Size = New System.Drawing.Size(89, 58)
        Me.Right1.TabIndex = 33
        Me.Right1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Right1.UseVisualStyleBackColor = False
        '
        'Left1
        '
        Me.Left1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Left1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Left1.Enabled = False
        Me.Left1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.Left1.FlatAppearance.BorderSize = 2
        Me.Left1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Left1.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Left1.Image = Global.Bus_Reservation.My.Resources.Resources.chevron_left_round_48
        Me.Left1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Left1.Location = New System.Drawing.Point(259, 4)
        Me.Left1.Name = "Left1"
        Me.Left1.Size = New System.Drawing.Size(89, 58)
        Me.Left1.TabIndex = 32
        Me.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Left1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Orange
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(63, 533)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 52)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Press Here - ->>"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TDistance
        '
        Me.TDistance.Enabled = False
        Me.TDistance.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDistance.Location = New System.Drawing.Point(668, 533)
        Me.TDistance.Name = "TDistance"
        Me.TDistance.Size = New System.Drawing.Size(175, 31)
        Me.TDistance.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(472, 533)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 26)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Distance"
        '
        'TTime
        '
        Me.TTime.Enabled = False
        Me.TTime.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTime.Location = New System.Drawing.Point(668, 433)
        Me.TTime.Name = "TTime"
        Me.TTime.Size = New System.Drawing.Size(175, 31)
        Me.TTime.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(472, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 26)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Total Time"
        '
        'FAmount
        '
        Me.FAmount.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAmount.Location = New System.Drawing.Point(668, 284)
        Me.FAmount.Name = "FAmount"
        Me.FAmount.Size = New System.Drawing.Size(124, 31)
        Me.FAmount.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(472, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 26)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Fare Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(616, 26)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Note : Below Part Is Automated. Press Generate Your Route Button."
        '
        'btngenerate
        '
        Me.btngenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btngenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngenerate.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerate.Image = Global.Bus_Reservation.My.Resources.Resources.process_48
        Me.btngenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngenerate.Location = New System.Drawing.Point(259, 498)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(164, 108)
        Me.btngenerate.TabIndex = 7
        Me.btngenerate.Text = "Generate Your Route"
        Me.btngenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngenerate.UseVisualStyleBackColor = False
        '
        'cmbdestination
        '
        Me.cmbdestination.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdestination.FormattingEnabled = True
        Me.cmbdestination.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbdestination.Location = New System.Drawing.Point(668, 184)
        Me.cmbdestination.Name = "cmbdestination"
        Me.cmbdestination.Size = New System.Drawing.Size(175, 34)
        Me.cmbdestination.TabIndex = 4
        '
        'cmbstartpoint
        '
        Me.cmbstartpoint.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstartpoint.FormattingEnabled = True
        Me.cmbstartpoint.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbstartpoint.Location = New System.Drawing.Point(259, 184)
        Me.cmbstartpoint.Name = "cmbstartpoint"
        Me.cmbstartpoint.Size = New System.Drawing.Size(164, 34)
        Me.cmbstartpoint.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(472, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Choose Destination"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 26)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Choose Starting Point"
        '
        'Departuretime
        '
        Me.Departuretime.Enabled = False
        Me.Departuretime.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Departuretime.Location = New System.Drawing.Point(259, 429)
        Me.Departuretime.Name = "Departuretime"
        Me.Departuretime.Size = New System.Drawing.Size(164, 31)
        Me.Departuretime.TabIndex = 15
        '
        'Arrivaltime
        '
        Me.Arrivaltime.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Arrivaltime.Location = New System.Drawing.Point(259, 279)
        Me.Arrivaltime.Name = "Arrivaltime"
        Me.Arrivaltime.Size = New System.Drawing.Size(164, 31)
        Me.Arrivaltime.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Departure Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Arrival Time"
        '
        'RouteName
        '
        Me.RouteName.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RouteName.Location = New System.Drawing.Point(668, 94)
        Me.RouteName.Name = "RouteName"
        Me.RouteName.Size = New System.Drawing.Size(175, 31)
        Me.RouteName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Route Name"
        '
        'Rno
        '
        Me.Rno.BackColor = System.Drawing.Color.White
        Me.Rno.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rno.Location = New System.Drawing.Point(259, 94)
        Me.Rno.Name = "Rno"
        Me.Rno.ReadOnly = True
        Me.Rno.Size = New System.Drawing.Size(164, 31)
        Me.Rno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Route No"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.mainlabel)
        Me.Panel1.Location = New System.Drawing.Point(-14, -31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 108)
        Me.Panel1.TabIndex = 2
        '
        'RouteMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RouteMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ROUTE MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents mainlabel As System.Windows.Forms.Label
    Friend WithEvents btnmain As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RouteName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Rno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Departuretime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Arrivaltime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstartpoint As System.Windows.Forms.ComboBox
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TTime As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Left1 As System.Windows.Forms.Button
    Friend WithEvents Right1 As System.Windows.Forms.Button
End Class
