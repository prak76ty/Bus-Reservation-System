<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceSeatBooking
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
        Me.S2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.SC3 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.SeatAvailability2 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.S1 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.New2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.WNo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.BusSerialNo = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.BookingNo = New System.Windows.Forms.TextBox
        Me.SeatCapacity = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.BusReservation = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.BusType = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BusNumber = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbdestination = New System.Windows.Forms.ComboBox
        Me.cmbstartpoint = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Departuretime = New System.Windows.Forms.DateTimePicker
        Me.Arrivaltime = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Rno = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.AB = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.BookingDate = New System.Windows.Forms.DateTimePicker
        Me.WaitingList = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'S2
        '
        Me.S2.Enabled = False
        Me.S2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S2.Location = New System.Drawing.Point(891, 39)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(94, 31)
        Me.S2.TabIndex = 130
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCyan
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label7.Location = New System.Drawing.Point(260, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(394, 37)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Route And Bus Selection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(614, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(284, 26)
        Me.Label20.TabIndex = 173
        Me.Label20.Text = "AND Advance Booking Date"
        '
        'SC3
        '
        Me.SC3.BackColor = System.Drawing.Color.MintCream
        Me.SC3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SC3.Enabled = False
        Me.SC3.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SC3.Location = New System.Drawing.Point(810, 278)
        Me.SC3.Name = "SC3"
        Me.SC3.Size = New System.Drawing.Size(39, 24)
        Me.SC3.TabIndex = 172
        Me.SC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Crimson
        Me.Label18.Location = New System.Drawing.Point(851, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 24)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "TO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(635, 277)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(273, 26)
        Me.Label19.TabIndex = 171
        Me.Label19.Text = "Seat Booked From   20 Seats"
        '
        'SeatAvailability2
        '
        Me.SeatAvailability2.BackColor = System.Drawing.Color.MintCream
        Me.SeatAvailability2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SeatAvailability2.Enabled = False
        Me.SeatAvailability2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatAvailability2.Location = New System.Drawing.Point(593, 279)
        Me.SeatAvailability2.Name = "SeatAvailability2"
        Me.SeatAvailability2.Size = New System.Drawing.Size(47, 24)
        Me.SeatAvailability2.TabIndex = 170
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Crimson
        Me.Label17.Location = New System.Drawing.Point(684, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 24)
        Me.Label17.TabIndex = 125
        Me.Label17.Text = "FROM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'S1
        '
        Me.S1.Enabled = False
        Me.S1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.Location = New System.Drawing.Point(753, 39)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(90, 31)
        Me.S1.TabIndex = 128
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.S2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.S1)
        Me.Panel1.Controls.Add(Me.New2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.WNo)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1381, 74)
        Me.Panel1.TabIndex = 164
        '
        'New2
        '
        Me.New2.AutoSize = True
        Me.New2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New2.Location = New System.Drawing.Point(772, 43)
        Me.New2.Name = "New2"
        Me.New2.Size = New System.Drawing.Size(54, 25)
        Me.New2.TabIndex = 135
        Me.New2.Text = "New"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(321, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 136
        '
        'WNo
        '
        Me.WNo.Location = New System.Drawing.Point(366, 24)
        Me.WNo.Name = "WNo"
        Me.WNo.Size = New System.Drawing.Size(100, 20)
        Me.WNo.TabIndex = 137
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(769, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 25)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Upper Section"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(600, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 25)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "Lower Section"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(562, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(390, 26)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "Choose Seat Selection Lower Or Upper"
        '
        'BusSerialNo
        '
        Me.BusSerialNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BusSerialNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BusSerialNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusSerialNo.FormattingEnabled = True
        Me.BusSerialNo.Location = New System.Drawing.Point(321, 175)
        Me.BusSerialNo.Name = "BusSerialNo"
        Me.BusSerialNo.Size = New System.Drawing.Size(186, 33)
        Me.BusSerialNo.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(81, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 25)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Booking No"
        '
        'BookingNo
        '
        Me.BookingNo.Enabled = False
        Me.BookingNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingNo.Location = New System.Drawing.Point(321, 252)
        Me.BookingNo.Name = "BookingNo"
        Me.BookingNo.Size = New System.Drawing.Size(185, 31)
        Me.BookingNo.TabIndex = 157
        '
        'SeatCapacity
        '
        Me.SeatCapacity.Enabled = False
        Me.SeatCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatCapacity.Location = New System.Drawing.Point(795, 543)
        Me.SeatCapacity.Name = "SeatCapacity"
        Me.SeatCapacity.Size = New System.Drawing.Size(186, 31)
        Me.SeatCapacity.TabIndex = 152
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(587, 543)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 25)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Seat Capacity"
        '
        'BusReservation
        '
        Me.BusReservation.Enabled = False
        Me.BusReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusReservation.FormattingEnabled = True
        Me.BusReservation.Items.AddRange(New Object() {"Select", "1x1", "2x1", "2x2"})
        Me.BusReservation.Location = New System.Drawing.Point(319, 540)
        Me.BusReservation.Name = "BusReservation"
        Me.BusReservation.Size = New System.Drawing.Size(187, 33)
        Me.BusReservation.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(82, 540)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 25)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Reservation"
        '
        'BusType
        '
        Me.BusType.Enabled = False
        Me.BusType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusType.FormattingEnabled = True
        Me.BusType.Items.AddRange(New Object() {"Select", "Seater", "Push Back", "Sleeper", "Semi Sleeper"})
        Me.BusType.Location = New System.Drawing.Point(795, 468)
        Me.BusType.Name = "BusType"
        Me.BusType.Size = New System.Drawing.Size(189, 33)
        Me.BusType.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(587, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Bus Type"
        '
        'BusNumber
        '
        Me.BusNumber.Enabled = False
        Me.BusNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusNumber.FormattingEnabled = True
        Me.BusNumber.Items.AddRange(New Object() {"Select", "MH 19 1020", "MH 19 3333", "MH 19 5747", "MH 19 57472", "MH-19  1000", "MH-19 2000"})
        Me.BusNumber.Location = New System.Drawing.Point(319, 468)
        Me.BusNumber.Name = "BusNumber"
        Me.BusNumber.Size = New System.Drawing.Size(185, 33)
        Me.BusNumber.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Bus Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 25)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Bus Serial No"
        '
        'cmbdestination
        '
        Me.cmbdestination.BackColor = System.Drawing.Color.LightCyan
        Me.cmbdestination.Enabled = False
        Me.cmbdestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdestination.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbdestination.FormattingEnabled = True
        Me.cmbdestination.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbdestination.Location = New System.Drawing.Point(794, 409)
        Me.cmbdestination.Name = "cmbdestination"
        Me.cmbdestination.Size = New System.Drawing.Size(190, 33)
        Me.cmbdestination.TabIndex = 143
        '
        'cmbstartpoint
        '
        Me.cmbstartpoint.BackColor = System.Drawing.Color.LightCyan
        Me.cmbstartpoint.Enabled = False
        Me.cmbstartpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstartpoint.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbstartpoint.FormattingEnabled = True
        Me.cmbstartpoint.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbstartpoint.Location = New System.Drawing.Point(318, 407)
        Me.cmbstartpoint.Name = "cmbstartpoint"
        Me.cmbstartpoint.Size = New System.Drawing.Size(188, 33)
        Me.cmbstartpoint.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(587, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 25)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Choose Destination"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 25)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Choose Starting Point"
        '
        'Departuretime
        '
        Me.Departuretime.Enabled = False
        Me.Departuretime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Departuretime.Location = New System.Drawing.Point(795, 332)
        Me.Departuretime.Name = "Departuretime"
        Me.Departuretime.Size = New System.Drawing.Size(190, 31)
        Me.Departuretime.TabIndex = 139
        '
        'Arrivaltime
        '
        Me.Arrivaltime.Enabled = False
        Me.Arrivaltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Arrivaltime.Location = New System.Drawing.Point(318, 335)
        Me.Arrivaltime.Name = "Arrivaltime"
        Me.Arrivaltime.Size = New System.Drawing.Size(186, 31)
        Me.Arrivaltime.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(588, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 25)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Departure Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 25)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Arrival Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Route No"
        '
        'Rno
        '
        Me.Rno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Rno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rno.FormattingEnabled = True
        Me.Rno.Location = New System.Drawing.Point(320, 92)
        Me.Rno.Name = "Rno"
        Me.Rno.Size = New System.Drawing.Size(186, 33)
        Me.Rno.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(588, 239)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "L"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(756, 239)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(33, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "U"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'AB
        '
        Me.AB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AB.FlatAppearance.BorderSize = 2
        Me.AB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AB.Image = Global.Bus_Reservation.My.Resources.Resources.advance_48
        Me.AB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AB.Location = New System.Drawing.Point(469, 604)
        Me.AB.Name = "AB"
        Me.AB.Size = New System.Drawing.Size(280, 66)
        Me.AB.TabIndex = 6
        Me.AB.Text = "ADVANCE BOOKING"
        Me.AB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AB.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(44, 604)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 66)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CLOSE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclear.FlatAppearance.BorderSize = 2
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = Global.Bus_Reservation.My.Resources.Resources.return_48
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(808, 604)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(177, 66)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "Clear Form "
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'BookingDate
        '
        Me.BookingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BookingDate.Location = New System.Drawing.Point(667, 177)
        Me.BookingDate.Name = "BookingDate"
        Me.BookingDate.Size = New System.Drawing.Size(176, 31)
        Me.BookingDate.TabIndex = 3
        '
        'WaitingList
        '
        Me.WaitingList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WaitingList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WaitingList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WaitingList.FlatAppearance.BorderSize = 2
        Me.WaitingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WaitingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaitingList.Image = Global.Bus_Reservation.My.Resources.Resources.arrow_48
        Me.WaitingList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WaitingList.Location = New System.Drawing.Point(226, 604)
        Me.WaitingList.Name = "WaitingList"
        Me.WaitingList.Size = New System.Drawing.Size(201, 66)
        Me.WaitingList.TabIndex = 7
        Me.WaitingList.Text = "WAITING LIST"
        Me.WaitingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WaitingList.UseVisualStyleBackColor = False
        '
        'AdvanceSeatBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.WaitingList)
        Me.Controls.Add(Me.BookingDate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.SC3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SeatAvailability2)
        Me.Controls.Add(Me.AB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BusSerialNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.BookingNo)
        Me.Controls.Add(Me.SeatCapacity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BusReservation)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BusType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BusNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbdestination)
        Me.Controls.Add(Me.cmbstartpoint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Departuretime)
        Me.Controls.Add(Me.Arrivaltime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Rno)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Name = "AdvanceSeatBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AdvanceSeatBooking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SC3 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SeatAvailability2 As System.Windows.Forms.TextBox
    Friend WithEvents AB As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents S1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents New2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BusSerialNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents BookingNo As System.Windows.Forms.TextBox
    Friend WithEvents SeatCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BusReservation As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BusType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BusNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstartpoint As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Departuretime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Arrivaltime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Rno As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents BookingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents WaitingList As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents WNo As System.Windows.Forms.TextBox
End Class
