<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_And_Passenger
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
        Me.BookingNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BookingDate = New System.Windows.Forms.DateTimePicker
        Me.PassengerNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PassengerAddress = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PassengerName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PassengerContact = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PassengerCity = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Insert = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnpassengerfind = New System.Windows.Forms.Button
        Me.WLF = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookingNo
        '
        Me.BookingNo.Enabled = False
        Me.BookingNo.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingNo.Location = New System.Drawing.Point(226, 94)
        Me.BookingNo.Name = "BookingNo"
        Me.BookingNo.Size = New System.Drawing.Size(218, 35)
        Me.BookingNo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Booking No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(476, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Booking Date:"
        '
        'BookingDate
        '
        Me.BookingDate.Enabled = False
        Me.BookingDate.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingDate.Location = New System.Drawing.Point(648, 99)
        Me.BookingDate.Name = "BookingDate"
        Me.BookingDate.Size = New System.Drawing.Size(352, 31)
        Me.BookingDate.TabIndex = 25
        '
        'PassengerNo
        '
        Me.PassengerNo.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerNo.Location = New System.Drawing.Point(226, 268)
        Me.PassengerNo.Name = "PassengerNo"
        Me.PassengerNo.Size = New System.Drawing.Size(218, 35)
        Me.PassengerNo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 30)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Passenger No"
        '
        'PassengerAddress
        '
        Me.PassengerAddress.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerAddress.Location = New System.Drawing.Point(226, 408)
        Me.PassengerAddress.Multiline = True
        Me.PassengerAddress.Name = "PassengerAddress"
        Me.PassengerAddress.Size = New System.Drawing.Size(218, 69)
        Me.PassengerAddress.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 30)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Passenger Address"
        '
        'PassengerName
        '
        Me.PassengerName.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerName.Location = New System.Drawing.Point(226, 341)
        Me.PassengerName.Name = "PassengerName"
        Me.PassengerName.Size = New System.Drawing.Size(218, 35)
        Me.PassengerName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 30)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Passenger Name"
        '
        'PassengerContact
        '
        Me.PassengerContact.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerContact.Location = New System.Drawing.Point(648, 415)
        Me.PassengerContact.Name = "PassengerContact"
        Me.PassengerContact.Size = New System.Drawing.Size(264, 35)
        Me.PassengerContact.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(476, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 30)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Contact No."
        '
        'PassengerCity
        '
        Me.PassengerCity.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerCity.Location = New System.Drawing.Point(648, 348)
        Me.PassengerCity.Name = "PassengerCity"
        Me.PassengerCity.Size = New System.Drawing.Size(264, 35)
        Me.PassengerCity.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 30)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Passenger City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label9.Location = New System.Drawing.Point(534, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(429, 26)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "FIND OR CREATE NEW ONE SAVE AND DELETE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 30)
        Me.Label2.TabIndex = 255
        Me.Label2.Text = "Seat Booked By Passenger Or Person Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(228, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 30)
        Me.Label10.TabIndex = 256
        Me.Label10.Text = "Booking Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-7, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1393, 52)
        Me.Panel1.TabIndex = 257
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(-7, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1393, 52)
        Me.Panel2.TabIndex = 258
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bus_Reservation.My.Resources.Resources.stairs_up_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 49)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Go To Upper Section"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Image = Global.Bus_Reservation.My.Resources.Resources.stairs_down_48
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button22.Location = New System.Drawing.Point(289, 534)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(268, 49)
        Me.Button22.TabIndex = 11
        Me.Button22.Text = "Go To Lower Section"
        Me.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.Color.PeachPuff
        Me.Insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Image = Global.Bus_Reservation.My.Resources.Resources.end_48
        Me.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Insert.Location = New System.Drawing.Point(844, 534)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(128, 49)
        Me.Insert.TabIndex = 9
        Me.Insert.Text = "Finish" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insert.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightSalmon
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Enabled = False
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.Bus_Reservation.My.Resources.Resources.delete_property_48
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(844, 257)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(146, 58)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "DELETE"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSalmon
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Enabled = False
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Bus_Reservation.My.Resources.Resources.save_48
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(721, 257)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(117, 58)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.LightSalmon
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Image = Global.Bus_Reservation.My.Resources.Resources.add_property_48
        Me.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.Location = New System.Drawing.Point(596, 257)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(119, 58)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "NEW"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnpassengerfind
        '
        Me.btnpassengerfind.BackColor = System.Drawing.Color.LightSalmon
        Me.btnpassengerfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpassengerfind.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon
        Me.btnpassengerfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpassengerfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpassengerfind.Image = Global.Bus_Reservation.My.Resources.Resources.search_property_48
        Me.btnpassengerfind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpassengerfind.Location = New System.Drawing.Point(481, 257)
        Me.btnpassengerfind.Name = "btnpassengerfind"
        Me.btnpassengerfind.Size = New System.Drawing.Size(109, 58)
        Me.btnpassengerfind.TabIndex = 2
        Me.btnpassengerfind.Text = "FIND"
        Me.btnpassengerfind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpassengerfind.UseVisualStyleBackColor = False
        '
        'WLF
        '
        Me.WLF.BackColor = System.Drawing.Color.PeachPuff
        Me.WLF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WLF.Enabled = False
        Me.WLF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLF.Image = Global.Bus_Reservation.My.Resources.Resources.end_48
        Me.WLF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WLF.Location = New System.Drawing.Point(596, 534)
        Me.WLF.Name = "WLF"
        Me.WLF.Size = New System.Drawing.Size(242, 49)
        Me.WLF.TabIndex = 10
        Me.WLF.Text = "Waiting List Finish" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.WLF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WLF.UseVisualStyleBackColor = False
        '
        'Booking_And_Passenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.WLF)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnpassengerfind)
        Me.Controls.Add(Me.PassengerContact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PassengerCity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PassengerAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PassengerName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PassengerNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BookingDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BookingNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking_And_Passenger"
        Me.Text = "Booking And Passenger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookingNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BookingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PassengerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PassengerAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PassengerName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PassengerContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PassengerCity As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnpassengerfind As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WLF As System.Windows.Forms.Button
End Class
