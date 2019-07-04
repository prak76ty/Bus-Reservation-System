<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatBooking
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
        Me.cmbdestination = New System.Windows.Forms.ComboBox
        Me.cmbstartpoint = New System.Windows.Forms.ComboBox
        Me.Departuretime = New System.Windows.Forms.DateTimePicker
        Me.Arrivaltime = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BusNumber = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BusType = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BusReservation = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.SeatCapacity = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Rno = New System.Windows.Forms.ComboBox
        Me.BookingNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.BusSerialNo = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.S2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.S1 = New System.Windows.Forms.TextBox
        Me.New2 = New System.Windows.Forms.Label
        Me.WNo = New System.Windows.Forms.TextBox
        Me.SeatAvailability = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.SC2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Insert = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.WaitingList = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbdestination
        '
        Me.cmbdestination.BackColor = System.Drawing.Color.LightCyan
        Me.cmbdestination.Enabled = False
        Me.cmbdestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdestination.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbdestination.FormattingEnabled = True
        Me.cmbdestination.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbdestination.Location = New System.Drawing.Point(783, 408)
        Me.cmbdestination.Name = "cmbdestination"
        Me.cmbdestination.Size = New System.Drawing.Size(190, 33)
        Me.cmbdestination.TabIndex = 29
        '
        'cmbstartpoint
        '
        Me.cmbstartpoint.BackColor = System.Drawing.Color.LightCyan
        Me.cmbstartpoint.Enabled = False
        Me.cmbstartpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstartpoint.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbstartpoint.FormattingEnabled = True
        Me.cmbstartpoint.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbstartpoint.Location = New System.Drawing.Point(307, 406)
        Me.cmbstartpoint.Name = "cmbstartpoint"
        Me.cmbstartpoint.Size = New System.Drawing.Size(188, 33)
        Me.cmbstartpoint.TabIndex = 28
        '
        'Departuretime
        '
        Me.Departuretime.Enabled = False
        Me.Departuretime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Departuretime.Location = New System.Drawing.Point(784, 331)
        Me.Departuretime.Name = "Departuretime"
        Me.Departuretime.Size = New System.Drawing.Size(190, 31)
        Me.Departuretime.TabIndex = 25
        '
        'Arrivaltime
        '
        Me.Arrivaltime.Enabled = False
        Me.Arrivaltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Arrivaltime.Location = New System.Drawing.Point(307, 334)
        Me.Arrivaltime.Name = "Arrivaltime"
        Me.Arrivaltime.Size = New System.Drawing.Size(186, 31)
        Me.Arrivaltime.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(577, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Departure Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Arrival Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Route No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(576, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Choose Destination"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Choose Starting Point"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Bus Serial No"
        '
        'BusNumber
        '
        Me.BusNumber.Enabled = False
        Me.BusNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusNumber.FormattingEnabled = True
        Me.BusNumber.Items.AddRange(New Object() {"Select", "MH 19 1020", "MH 19 3333", "MH 19 5747", "MH 19 57472", "MH-19  1000", "MH-19 2000"})
        Me.BusNumber.Location = New System.Drawing.Point(308, 467)
        Me.BusNumber.Name = "BusNumber"
        Me.BusNumber.Size = New System.Drawing.Size(185, 33)
        Me.BusNumber.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Bus Number"
        '
        'BusType
        '
        Me.BusType.Enabled = False
        Me.BusType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusType.FormattingEnabled = True
        Me.BusType.Items.AddRange(New Object() {"Select", "Seater", "Push Back", "Sleeper", "Semi Sleeper"})
        Me.BusType.Location = New System.Drawing.Point(784, 467)
        Me.BusType.Name = "BusType"
        Me.BusType.Size = New System.Drawing.Size(189, 33)
        Me.BusType.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(576, 467)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Bus Type"
        '
        'BusReservation
        '
        Me.BusReservation.Enabled = False
        Me.BusReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusReservation.FormattingEnabled = True
        Me.BusReservation.Items.AddRange(New Object() {"Select", "1x1", "2x1", "2x2"})
        Me.BusReservation.Location = New System.Drawing.Point(308, 539)
        Me.BusReservation.Name = "BusReservation"
        Me.BusReservation.Size = New System.Drawing.Size(187, 33)
        Me.BusReservation.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 539)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Reservation"
        '
        'SeatCapacity
        '
        Me.SeatCapacity.Enabled = False
        Me.SeatCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatCapacity.Location = New System.Drawing.Point(784, 542)
        Me.SeatCapacity.Name = "SeatCapacity"
        Me.SeatCapacity.Size = New System.Drawing.Size(186, 31)
        Me.SeatCapacity.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(576, 542)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 25)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Seat Capacity"
        '
        'Rno
        '
        Me.Rno.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Rno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rno.FormattingEnabled = True
        Me.Rno.Location = New System.Drawing.Point(309, 91)
        Me.Rno.Name = "Rno"
        Me.Rno.Size = New System.Drawing.Size(186, 33)
        Me.Rno.TabIndex = 1
        '
        'BookingNo
        '
        Me.BookingNo.Enabled = False
        Me.BookingNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingNo.Location = New System.Drawing.Point(310, 251)
        Me.BookingNo.Name = "BookingNo"
        Me.BookingNo.Size = New System.Drawing.Size(185, 31)
        Me.BookingNo.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(70, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 25)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Booking No"
        '
        'BusSerialNo
        '
        Me.BusSerialNo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BusSerialNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BusSerialNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusSerialNo.FormattingEnabled = True
        Me.BusSerialNo.Location = New System.Drawing.Point(310, 174)
        Me.BusSerialNo.Name = "BusSerialNo"
        Me.BusSerialNo.Size = New System.Drawing.Size(186, 33)
        Me.BusSerialNo.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(576, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(390, 26)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Choose Seat Selection Lower Or Upper"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(628, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 25)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Lower Section"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(797, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 25)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Upper Section"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(616, 215)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(784, 215)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label7.Location = New System.Drawing.Point(262, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(380, 37)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Route  And Bus Selection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.S2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.S1)
        Me.Panel1.Controls.Add(Me.New2)
        Me.Panel1.Controls.Add(Me.WNo)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(-11, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1381, 74)
        Me.Panel1.TabIndex = 125
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
        'WNo
        '
        Me.WNo.Location = New System.Drawing.Point(318, 25)
        Me.WNo.Name = "WNo"
        Me.WNo.Size = New System.Drawing.Size(100, 20)
        Me.WNo.TabIndex = 136
        '
        'SeatAvailability
        '
        Me.SeatAvailability.BackColor = System.Drawing.Color.MintCream
        Me.SeatAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SeatAvailability.Enabled = False
        Me.SeatAvailability.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatAvailability.Location = New System.Drawing.Point(590, 258)
        Me.SeatAvailability.Name = "SeatAvailability"
        Me.SeatAvailability.Size = New System.Drawing.Size(47, 24)
        Me.SeatAvailability.TabIndex = 127
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(633, 258)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(273, 26)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "Seat Booked From   20 Seats"
        '
        'SC2
        '
        Me.SC2.BackColor = System.Drawing.Color.MintCream
        Me.SC2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SC2.Enabled = False
        Me.SC2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SC2.Location = New System.Drawing.Point(808, 258)
        Me.SC2.Name = "SC2"
        Me.SC2.Size = New System.Drawing.Size(39, 24)
        Me.SC2.TabIndex = 129
        Me.SC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(76, 603)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CLOSE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.Color.PowderBlue
        Me.Insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Insert.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Image = Global.Bus_Reservation.My.Resources.Resources.arrow_48
        Me.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Insert.Location = New System.Drawing.Point(478, 603)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(276, 53)
        Me.Insert.TabIndex = 5
        Me.Insert.Text = "SAVE AND PROCEED"
        Me.Insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insert.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.PowderBlue
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = Global.Bus_Reservation.My.Resources.Resources.return_48
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(794, 603)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(180, 53)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "Clear Form "
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(672, 155)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(171, 26)
        Me.Label20.TabIndex = 174
        Me.Label20.Text = "Current Booking"
        '
        'WaitingList
        '
        Me.WaitingList.BackColor = System.Drawing.Color.PowderBlue
        Me.WaitingList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WaitingList.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.WaitingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WaitingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaitingList.Image = Global.Bus_Reservation.My.Resources.Resources.arrow_48
        Me.WaitingList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WaitingList.Location = New System.Drawing.Point(258, 603)
        Me.WaitingList.Name = "WaitingList"
        Me.WaitingList.Size = New System.Drawing.Size(201, 53)
        Me.WaitingList.TabIndex = 6
        Me.WaitingList.Text = "WAITING LIST"
        Me.WaitingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WaitingList.UseVisualStyleBackColor = False
        '
        'SeatBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 742)
        Me.Controls.Add(Me.WaitingList)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BusSerialNo)
        Me.Controls.Add(Me.BookingNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.btnclear)
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
        Me.Controls.Add(Me.SC2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SeatAvailability)
        Me.Name = "SeatBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SEAT BOOKING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstartpoint As System.Windows.Forms.ComboBox
    Friend WithEvents Departuretime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Arrivaltime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BusNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BusType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BusReservation As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SeatCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Rno As System.Windows.Forms.ComboBox
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents BookingNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BusSerialNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SeatAvailability As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents S2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents S1 As System.Windows.Forms.TextBox
    Friend WithEvents SC2 As System.Windows.Forms.TextBox
    Friend WithEvents New2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents WaitingList As System.Windows.Forms.Button
    Friend WithEvents WNo As System.Windows.Forms.TextBox
End Class
