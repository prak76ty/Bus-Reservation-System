<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusMaster
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
        Me.BusReservation = New System.Windows.Forms.ComboBox
        Me.BusType = New System.Windows.Forms.ComboBox
        Me.BusRoute = New System.Windows.Forms.ComboBox
        Me.BusNumber = New System.Windows.Forms.ComboBox
        Me.SeatCapacity = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BusSerialNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.mainlabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(-14, 74)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Cyan
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.BusReservation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BusType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BusRoute)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BusNumber)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SeatCapacity)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BusSerialNo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1394, 703)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 5
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexit.FlatAppearance.BorderSize = 2
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexit.Location = New System.Drawing.Point(16, 510)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(150, 75)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = "EXIT FORM"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnfind
        '
        Me.btnfind.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnfind.FlatAppearance.BorderSize = 2
        Me.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfind.Image = Global.Bus_Reservation.My.Resources.Resources.search_property_48
        Me.btnfind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnfind.Location = New System.Drawing.Point(16, 429)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(150, 75)
        Me.btnfind.TabIndex = 11
        Me.btnfind.Text = "FIND"
        Me.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfind.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndelete.FlatAppearance.BorderSize = 2
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Bus_Reservation.My.Resources.Resources.delete_property_48
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndelete.Location = New System.Drawing.Point(16, 348)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(150, 75)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "DELETE"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnedit.FlatAppearance.BorderSize = 2
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Image = Global.Bus_Reservation.My.Resources.Resources.edit_property_48
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnedit.Location = New System.Drawing.Point(16, 267)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(150, 75)
        Me.btnedit.TabIndex = 9
        Me.btnedit.Text = "EDIT"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.FlatAppearance.BorderSize = 2
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Bus_Reservation.My.Resources.Resources.save_48
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsave.Location = New System.Drawing.Point(16, 186)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(150, 75)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnadd.FlatAppearance.BorderSize = 2
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Bus_Reservation.My.Resources.Resources.add_property_48
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnadd.Location = New System.Drawing.Point(16, 105)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(150, 75)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnmain
        '
        Me.btnmain.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnmain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmain.FlatAppearance.BorderSize = 2
        Me.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmain.ForeColor = System.Drawing.Color.Black
        Me.btnmain.Image = Global.Bus_Reservation.My.Resources.Resources.xbox_menu_48
        Me.btnmain.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmain.Location = New System.Drawing.Point(16, 24)
        Me.btnmain.Name = "btnmain"
        Me.btnmain.Size = New System.Drawing.Size(150, 75)
        Me.btnmain.TabIndex = 6
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
        Me.Right1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Right1.Image = Global.Bus_Reservation.My.Resources.Resources.chevron_right_round_48
        Me.Right1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Right1.Location = New System.Drawing.Point(611, 9)
        Me.Right1.Name = "Right1"
        Me.Right1.Size = New System.Drawing.Size(89, 58)
        Me.Right1.TabIndex = 35
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
        Me.Left1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Left1.Image = Global.Bus_Reservation.My.Resources.Resources.chevron_left_round_48
        Me.Left1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Left1.Location = New System.Drawing.Point(202, 9)
        Me.Left1.Name = "Left1"
        Me.Left1.Size = New System.Drawing.Size(89, 58)
        Me.Left1.TabIndex = 34
        Me.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Left1.UseVisualStyleBackColor = False
        '
        'BusReservation
        '
        Me.BusReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BusReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusReservation.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusReservation.FormattingEnabled = True
        Me.BusReservation.Items.AddRange(New Object() {"1x1", "2x1", "2x2"})
        Me.BusReservation.Location = New System.Drawing.Point(497, 430)
        Me.BusReservation.Name = "BusReservation"
        Me.BusReservation.Size = New System.Drawing.Size(264, 34)
        Me.BusReservation.TabIndex = 4
        '
        'BusType
        '
        Me.BusType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BusType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusType.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusType.FormattingEnabled = True
        Me.BusType.Items.AddRange(New Object() {"Seater", "Push Back", "Sleeper", "Semi Sleeper"})
        Me.BusType.Location = New System.Drawing.Point(497, 349)
        Me.BusType.Name = "BusType"
        Me.BusType.Size = New System.Drawing.Size(264, 34)
        Me.BusType.TabIndex = 3
        '
        'BusRoute
        '
        Me.BusRoute.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BusRoute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusRoute.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusRoute.FormattingEnabled = True
        Me.BusRoute.Items.AddRange(New Object() {"Pachora To Pune", "Pachora To Mumbai", "Pachora To Surat", "Pune To Pachora", "Mumbai To Pachora", "Surat To Pachora"})
        Me.BusRoute.Location = New System.Drawing.Point(497, 267)
        Me.BusRoute.Name = "BusRoute"
        Me.BusRoute.Size = New System.Drawing.Size(264, 34)
        Me.BusRoute.TabIndex = 2
        '
        'BusNumber
        '
        Me.BusNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BusNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusNumber.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusNumber.FormattingEnabled = True
        Me.BusNumber.Items.AddRange(New Object() {"MH 19 1020", "MH 19 3333", "MH 19 5747", "MH 19 57472", "MH-19  1000", "MH-19 2000"})
        Me.BusNumber.Location = New System.Drawing.Point(497, 186)
        Me.BusNumber.Name = "BusNumber"
        Me.BusNumber.Size = New System.Drawing.Size(264, 34)
        Me.BusNumber.TabIndex = 1
        '
        'SeatCapacity
        '
        Me.SeatCapacity.Enabled = False
        Me.SeatCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatCapacity.Location = New System.Drawing.Point(497, 508)
        Me.SeatCapacity.Name = "SeatCapacity"
        Me.SeatCapacity.Size = New System.Drawing.Size(264, 38)
        Me.SeatCapacity.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(170, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 31)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Seat Capacity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(170, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 31)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Reservation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(170, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Bus Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Route"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 31)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Bus Number"
        '
        'BusSerialNo
        '
        Me.BusSerialNo.BackColor = System.Drawing.Color.White
        Me.BusSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusSerialNo.Location = New System.Drawing.Point(497, 101)
        Me.BusSerialNo.Name = "BusSerialNo"
        Me.BusSerialNo.ReadOnly = True
        Me.BusSerialNo.Size = New System.Drawing.Size(264, 38)
        Me.BusSerialNo.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 31)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Bus Serial No"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.mainlabel)
        Me.Panel1.Location = New System.Drawing.Point(-14, -31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 108)
        Me.Panel1.TabIndex = 4
        '
        'mainlabel
        '
        Me.mainlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlabel.Location = New System.Drawing.Point(171, 28)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(506, 62)
        Me.mainlabel.TabIndex = 1
        Me.mainlabel.Text = "BUS MASTER "
        '
        'BusMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 742)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BusMaster"
        Me.Text = "Bus Master"
        Me.TransparencyKey = System.Drawing.Color.White
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
    Friend WithEvents btnmain As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SeatCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BusSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BusRoute As System.Windows.Forms.ComboBox
    Friend WithEvents BusNumber As System.Windows.Forms.ComboBox
    Friend WithEvents BusReservation As System.Windows.Forms.ComboBox
    Friend WithEvents BusType As System.Windows.Forms.ComboBox
    Friend WithEvents mainlabel As System.Windows.Forms.Label
    Friend WithEvents Right1 As System.Windows.Forms.Button
    Friend WithEvents Left1 As System.Windows.Forms.Button
End Class
