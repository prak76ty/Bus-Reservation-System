<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitingList
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
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.BookingNo = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.BookingDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.SC2 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.SeatAvailability = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Proceed = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Ending = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.RNo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BusSerialNo = New System.Windows.Forms.ComboBox
        Me.Departuretime = New System.Windows.Forms.DateTimePicker
        Me.Arrivaltime = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbdestination = New System.Windows.Forms.ComboBox
        Me.cmbstartpoint = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.SeatCapacity = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.BusReservation = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.BusType = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.BusNumber = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Bno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PContact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(265, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(469, 30)
        Me.Label10.TabIndex = 257
        Me.Label10.Text = "ALLOCATE SEATS TO WAITING PASSENGERS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(740, 30)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "BOOKING DETAILS AND PERSON OR PASSENGER BOOKED BY DETAILS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 341)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1302, 45)
        Me.Panel3.TabIndex = 242
        '
        'BookingNo
        '
        Me.BookingNo.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingNo.Location = New System.Drawing.Point(672, 106)
        Me.BookingNo.Name = "BookingNo"
        Me.BookingNo.Size = New System.Drawing.Size(163, 27)
        Me.BookingNo.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1302, 40)
        Me.Panel1.TabIndex = 240
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 264
        '
        'BookingDate
        '
        Me.BookingDate.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BookingDate.Location = New System.Drawing.Point(157, 97)
        Me.BookingDate.Name = "BookingDate"
        Me.BookingDate.Size = New System.Drawing.Size(163, 31)
        Me.BookingDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Booking Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(532, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 26)
        Me.Label12.TabIndex = 233
        Me.Label12.Text = "Booking No"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(670, 276)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 25)
        Me.Label15.TabIndex = 249
        Me.Label15.Text = "Upper Section"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(501, 276)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 25)
        Me.Label14.TabIndex = 248
        Me.Label14.Text = "Lower Section"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(152, 276)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(312, 26)
        Me.Label13.TabIndex = 247
        Me.Label13.Text = "Seat Selection Lower Or Upper"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(489, 283)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "L"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(657, 283)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(33, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "U"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'SC2
        '
        Me.SC2.BackColor = System.Drawing.Color.MintCream
        Me.SC2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SC2.Enabled = False
        Me.SC2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SC2.Location = New System.Drawing.Point(690, 310)
        Me.SC2.Name = "SC2"
        Me.SC2.Size = New System.Drawing.Size(39, 24)
        Me.SC2.TabIndex = 255
        Me.SC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(515, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(273, 26)
        Me.Label19.TabIndex = 254
        Me.Label19.Text = "Seat Booked From   20 Seats"
        '
        'SeatAvailability
        '
        Me.SeatAvailability.BackColor = System.Drawing.Color.MintCream
        Me.SeatAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SeatAvailability.Enabled = False
        Me.SeatAvailability.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatAvailability.Location = New System.Drawing.Point(473, 311)
        Me.SeatAvailability.Name = "SeatAvailability"
        Me.SeatAvailability.Size = New System.Drawing.Size(47, 24)
        Me.SeatAvailability.TabIndex = 253
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(40, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 26)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "Search By  Booking Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(585, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 26)
        Me.Label5.TabIndex = 258
        Me.Label5.Text = "Give Booking No of Waiting Lst"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Turquoise
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Bus_Reservation.My.Resources.Resources.search_property_48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(346, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SEARCH"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Proceed
        '
        Me.Proceed.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Proceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Proceed.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Proceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proceed.Image = Global.Bus_Reservation.My.Resources.Resources.checklist_48
        Me.Proceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Proceed.Location = New System.Drawing.Point(537, 593)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(235, 65)
        Me.Proceed.TabIndex = 7
        Me.Proceed.Text = "Choose Seat    "
        Me.Proceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Proceed.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Turquoise
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bus_Reservation.My.Resources.Resources.search_property_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(856, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 56)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SEARCH"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Ending
        '
        Me.Ending.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Ending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ending.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Ending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ending.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ending.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.Ending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ending.Location = New System.Drawing.Point(899, 593)
        Me.Ending.Name = "Ending"
        Me.Ending.Size = New System.Drawing.Size(122, 65)
        Me.Ending.TabIndex = 9
        Me.Ending.Text = "Close"
        Me.Ending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ending.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Bus_Reservation.My.Resources.Resources.cancelled_logo
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(274, 593)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 65)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cancell Seat   "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Bus_Reservation.My.Resources.Resources.return_48
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(11, 593)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 65)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Clear"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bno, Me.Column1, Me.BDate, Me.Column2, Me.Column3, Me.Pno, Me.Pname, Me.PCity, Me.PContact, Me.Column4})
        Me.DGV.Location = New System.Drawing.Point(45, 392)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(944, 195)
        Me.DGV.TabIndex = 262
        '
        'RNo
        '
        Me.RNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RNo.Enabled = False
        Me.RNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RNo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RNo.FormattingEnabled = True
        Me.RNo.Location = New System.Drawing.Point(114, 157)
        Me.RNo.Name = "RNo"
        Me.RNo.Size = New System.Drawing.Size(83, 29)
        Me.RNo.TabIndex = 263
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "Route No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 25)
        Me.Label7.TabIndex = 266
        Me.Label7.Text = "Bus No"
        '
        'BusSerialNo
        '
        Me.BusSerialNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BusSerialNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BusSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BusSerialNo.Enabled = False
        Me.BusSerialNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusSerialNo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusSerialNo.FormattingEnabled = True
        Me.BusSerialNo.Location = New System.Drawing.Point(114, 218)
        Me.BusSerialNo.Name = "BusSerialNo"
        Me.BusSerialNo.Size = New System.Drawing.Size(83, 29)
        Me.BusSerialNo.TabIndex = 265
        '
        'Departuretime
        '
        Me.Departuretime.Enabled = False
        Me.Departuretime.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Departuretime.Location = New System.Drawing.Point(470, 155)
        Me.Departuretime.Name = "Departuretime"
        Me.Departuretime.Size = New System.Drawing.Size(124, 26)
        Me.Departuretime.TabIndex = 270
        '
        'Arrivaltime
        '
        Me.Arrivaltime.Enabled = False
        Me.Arrivaltime.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Arrivaltime.Location = New System.Drawing.Point(268, 155)
        Me.Arrivaltime.Name = "Arrivaltime"
        Me.Arrivaltime.Size = New System.Drawing.Size(113, 26)
        Me.Arrivaltime.TabIndex = 269
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(387, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 21)
        Me.Label8.TabIndex = 268
        Me.Label8.Text = "Departure"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(210, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 21)
        Me.Label9.TabIndex = 267
        Me.Label9.Text = "Arrival"
        '
        'cmbdestination
        '
        Me.cmbdestination.BackColor = System.Drawing.Color.LightCyan
        Me.cmbdestination.Enabled = False
        Me.cmbdestination.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdestination.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbdestination.FormattingEnabled = True
        Me.cmbdestination.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbdestination.Location = New System.Drawing.Point(890, 157)
        Me.cmbdestination.Name = "cmbdestination"
        Me.cmbdestination.Size = New System.Drawing.Size(131, 29)
        Me.cmbdestination.TabIndex = 274
        '
        'cmbstartpoint
        '
        Me.cmbstartpoint.BackColor = System.Drawing.Color.LightCyan
        Me.cmbstartpoint.Enabled = False
        Me.cmbstartpoint.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstartpoint.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbstartpoint.FormattingEnabled = True
        Me.cmbstartpoint.Items.AddRange(New Object() {"Pachora", "Pune", "Mumbai", "Surat"})
        Me.cmbstartpoint.Location = New System.Drawing.Point(669, 157)
        Me.cmbstartpoint.Name = "cmbstartpoint"
        Me.cmbstartpoint.Size = New System.Drawing.Size(122, 29)
        Me.cmbstartpoint.TabIndex = 273
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(797, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 21)
        Me.Label11.TabIndex = 272
        Me.Label11.Text = "Destination"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(600, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 21)
        Me.Label16.TabIndex = 271
        Me.Label16.Text = "Starting"
        '
        'SeatCapacity
        '
        Me.SeatCapacity.Enabled = False
        Me.SeatCapacity.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatCapacity.Location = New System.Drawing.Point(890, 218)
        Me.SeatCapacity.Name = "SeatCapacity"
        Me.SeatCapacity.Size = New System.Drawing.Size(131, 26)
        Me.SeatCapacity.TabIndex = 282
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(791, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 21)
        Me.Label17.TabIndex = 281
        Me.Label17.Text = "Seat Capacity"
        '
        'BusReservation
        '
        Me.BusReservation.Enabled = False
        Me.BusReservation.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusReservation.FormattingEnabled = True
        Me.BusReservation.Items.AddRange(New Object() {"Select", "1x1", "2x1", "2x2"})
        Me.BusReservation.Location = New System.Drawing.Point(690, 218)
        Me.BusReservation.Name = "BusReservation"
        Me.BusReservation.Size = New System.Drawing.Size(98, 29)
        Me.BusReservation.TabIndex = 280
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(603, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 21)
        Me.Label18.TabIndex = 279
        Me.Label18.Text = "Reservation"
        '
        'BusType
        '
        Me.BusType.Enabled = False
        Me.BusType.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusType.FormattingEnabled = True
        Me.BusType.Items.AddRange(New Object() {"Select", "Seater", "Push Back", "Sleeper", "Semi Sleeper"})
        Me.BusType.Location = New System.Drawing.Point(489, 218)
        Me.BusType.Name = "BusType"
        Me.BusType.Size = New System.Drawing.Size(108, 29)
        Me.BusType.TabIndex = 278
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(417, 221)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 21)
        Me.Label20.TabIndex = 277
        Me.Label20.Text = "Bus Type"
        '
        'BusNumber
        '
        Me.BusNumber.Enabled = False
        Me.BusNumber.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusNumber.FormattingEnabled = True
        Me.BusNumber.Items.AddRange(New Object() {"Select", "MH 19 1020", "MH 19 3333", "MH 19 5747", "MH 19 57472", "MH-19  1000", "MH-19 2000"})
        Me.BusNumber.Location = New System.Drawing.Point(304, 218)
        Me.BusNumber.Name = "BusNumber"
        Me.BusNumber.Size = New System.Drawing.Size(100, 29)
        Me.BusNumber.TabIndex = 276
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(203, 221)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 21)
        Me.Label21.TabIndex = 275
        Me.Label21.Text = "Bus Number"
        '
        'Bno
        '
        Me.Bno.HeaderText = "Booking No"
        Me.Bno.Name = "Bno"
        Me.Bno.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Route & Bus"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'BDate
        '
        Me.BDate.HeaderText = "Booking Date"
        Me.BDate.Name = "BDate"
        Me.BDate.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Waiting No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Current Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Pno
        '
        Me.Pno.HeaderText = "Passenger No"
        Me.Pno.Name = "Pno"
        Me.Pno.ReadOnly = True
        '
        'Pname
        '
        Me.Pname.HeaderText = "Name"
        Me.Pname.Name = "Pname"
        Me.Pname.ReadOnly = True
        '
        'PCity
        '
        Me.PCity.HeaderText = "City"
        Me.PCity.Name = "PCity"
        Me.PCity.ReadOnly = True
        '
        'PContact
        '
        Me.PContact.HeaderText = "Contact"
        Me.PContact.Name = "PContact"
        Me.PContact.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Address"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'WaitingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 742)
        Me.Controls.Add(Me.SeatCapacity)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BusReservation)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BusType)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.BusNumber)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmbdestination)
        Me.Controls.Add(Me.cmbstartpoint)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Departuretime)
        Me.Controls.Add(Me.Arrivaltime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BusSerialNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RNo)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Ending)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SC2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SeatAvailability)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Proceed)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BookingNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BookingDate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Name = "WaitingList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Allocate Seat To Waiting Passenger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Proceed As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BookingNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BookingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents SC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SeatAvailability As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ending As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents RNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BusSerialNo As System.Windows.Forms.ComboBox
    Friend WithEvents Departuretime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Arrivaltime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstartpoint As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SeatCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BusReservation As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BusType As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BusNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Bno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PContact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
