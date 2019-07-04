<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealMDI
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Insert = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Route = New System.Windows.Forms.TextBox
        Me.Bus = New System.Windows.Forms.TextBox
        Me.Driver = New System.Windows.Forms.TextBox
        Me.Passenger = New System.Windows.Forms.TextBox
        Me.Office = New System.Windows.Forms.TextBox
        Me.Staff = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Waiting = New System.Windows.Forms.TextBox
        Me.Completed = New System.Windows.Forms.TextBox
        Me.Cancellation = New System.Windows.Forms.TextBox
        Me.Advance = New System.Windows.Forms.TextBox
        Me.Current = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(226, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(715, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WEL-COME TO BUS RESERVATION SYSTEM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Bus_Reservation.My.Resources.Resources.travel_bus
        Me.PictureBox1.Location = New System.Drawing.Point(34, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(407, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Welcome "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(506, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "----------"
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Insert.Location = New System.Drawing.Point(780, 116)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(161, 49)
        Me.Insert.TabIndex = 61
        Me.Insert.Text = "LOG OFF"
        Me.Insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insert.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 30)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "MASTER INFORMATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 24)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Total Route's in System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 24)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Total Bus in System"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 515)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 24)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Total Office in System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 24)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Total Staff's in System"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 24)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Total Driver in System"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(280, 24)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Total Passenger Saved in System"
        '
        'Route
        '
        Me.Route.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Route.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Route.Location = New System.Drawing.Point(330, 253)
        Me.Route.Name = "Route"
        Me.Route.ReadOnly = True
        Me.Route.Size = New System.Drawing.Size(60, 26)
        Me.Route.TabIndex = 69
        Me.Route.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bus
        '
        Me.Bus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bus.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bus.Location = New System.Drawing.Point(330, 303)
        Me.Bus.Name = "Bus"
        Me.Bus.ReadOnly = True
        Me.Bus.Size = New System.Drawing.Size(60, 26)
        Me.Bus.TabIndex = 70
        Me.Bus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Driver
        '
        Me.Driver.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Driver.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver.Location = New System.Drawing.Point(330, 409)
        Me.Driver.Name = "Driver"
        Me.Driver.ReadOnly = True
        Me.Driver.Size = New System.Drawing.Size(60, 26)
        Me.Driver.TabIndex = 72
        Me.Driver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Passenger
        '
        Me.Passenger.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Passenger.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passenger.Location = New System.Drawing.Point(330, 358)
        Me.Passenger.Name = "Passenger"
        Me.Passenger.ReadOnly = True
        Me.Passenger.Size = New System.Drawing.Size(60, 26)
        Me.Passenger.TabIndex = 71
        Me.Passenger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Office
        '
        Me.Office.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Office.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office.Location = New System.Drawing.Point(330, 514)
        Me.Office.Name = "Office"
        Me.Office.ReadOnly = True
        Me.Office.Size = New System.Drawing.Size(60, 26)
        Me.Office.TabIndex = 74
        Me.Office.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Staff
        '
        Me.Staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Staff.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff.Location = New System.Drawing.Point(330, 463)
        Me.Staff.Name = "Staff"
        Me.Staff.ReadOnly = True
        Me.Staff.Size = New System.Drawing.Size(60, 26)
        Me.Staff.TabIndex = 73
        Me.Staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 587)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(355, 24)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Master Form Are For Primary Information.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(461, 587)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(550, 24)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Transaction Are For All Types Of Booking.. Based On Master Forms"
        '
        'Waiting
        '
        Me.Waiting.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Waiting.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waiting.Location = New System.Drawing.Point(881, 462)
        Me.Waiting.Name = "Waiting"
        Me.Waiting.ReadOnly = True
        Me.Waiting.Size = New System.Drawing.Size(60, 26)
        Me.Waiting.TabIndex = 87
        Me.Waiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Completed
        '
        Me.Completed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Completed.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Completed.Location = New System.Drawing.Point(881, 408)
        Me.Completed.Name = "Completed"
        Me.Completed.ReadOnly = True
        Me.Completed.Size = New System.Drawing.Size(60, 26)
        Me.Completed.TabIndex = 86
        Me.Completed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cancellation
        '
        Me.Cancellation.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancellation.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancellation.Location = New System.Drawing.Point(881, 357)
        Me.Cancellation.Name = "Cancellation"
        Me.Cancellation.ReadOnly = True
        Me.Cancellation.Size = New System.Drawing.Size(60, 26)
        Me.Cancellation.TabIndex = 85
        Me.Cancellation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Advance
        '
        Me.Advance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Advance.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Advance.Location = New System.Drawing.Point(881, 302)
        Me.Advance.Name = "Advance"
        Me.Advance.ReadOnly = True
        Me.Advance.Size = New System.Drawing.Size(60, 26)
        Me.Advance.TabIndex = 84
        Me.Advance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Current
        '
        Me.Current.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Current.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current.Location = New System.Drawing.Point(881, 252)
        Me.Current.Name = "Current"
        Me.Current.ReadOnly = True
        Me.Current.Size = New System.Drawing.Size(60, 26)
        Me.Current.TabIndex = 83
        Me.Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(461, 410)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(391, 24)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Total of All Completed Seat Booking in System"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(461, 359)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(403, 24)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Total of All Cancellation Seat Booking in System"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(461, 464)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(365, 24)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Total of All Waiting Seat Booking in System"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(461, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(370, 24)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Total of All Advance Seat Booking in System"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(461, 253)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(361, 24)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Total of All Current Seat Booking in System"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(569, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(313, 30)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "TRANSACTION INFORMATION"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(461, 515)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(372, 24)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Note :- ""To Refresh Click Anywhere On Form"""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(366, 62)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 91
        '
        'RealMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Waiting)
        Me.Controls.Add(Me.Completed)
        Me.Controls.Add(Me.Cancellation)
        Me.Controls.Add(Me.Advance)
        Me.Controls.Add(Me.Current)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Office)
        Me.Controls.Add(Me.Staff)
        Me.Controls.Add(Me.Driver)
        Me.Controls.Add(Me.Passenger)
        Me.Controls.Add(Me.Bus)
        Me.Controls.Add(Me.Route)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Route As System.Windows.Forms.TextBox
    Friend WithEvents Bus As System.Windows.Forms.TextBox
    Friend WithEvents Driver As System.Windows.Forms.TextBox
    Friend WithEvents Passenger As System.Windows.Forms.TextBox
    Friend WithEvents Office As System.Windows.Forms.TextBox
    Friend WithEvents Staff As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Waiting As System.Windows.Forms.TextBox
    Friend WithEvents Completed As System.Windows.Forms.TextBox
    Friend WithEvents Cancellation As System.Windows.Forms.TextBox
    Friend WithEvents Advance As System.Windows.Forms.TextBox
    Friend WithEvents Current As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
