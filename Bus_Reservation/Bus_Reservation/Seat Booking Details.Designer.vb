<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seat_Booking_Details
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
        Me.Label12 = New System.Windows.Forms.Label
        Me.BookingDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.PN = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PaymentBy = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.DGV2 = New System.Windows.Forms.DataGridView
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Ending = New System.Windows.Forms.Button
        Me.Bno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PContact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookingNo
        '
        Me.BookingNo.Enabled = False
        Me.BookingNo.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingNo.Location = New System.Drawing.Point(237, 53)
        Me.BookingNo.Name = "BookingNo"
        Me.BookingNo.Size = New System.Drawing.Size(253, 27)
        Me.BookingNo.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(79, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 21)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Booking No"
        '
        'BookingDate
        '
        Me.BookingDate.Enabled = False
        Me.BookingDate.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingDate.Location = New System.Drawing.Point(692, 53)
        Me.BookingDate.Name = "BookingDate"
        Me.BookingDate.Size = New System.Drawing.Size(306, 27)
        Me.BookingDate.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(549, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Booking Date:"
        '
        'PN
        '
        Me.PN.Enabled = False
        Me.PN.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PN.Location = New System.Drawing.Point(237, 103)
        Me.PN.Name = "PN"
        Me.PN.Size = New System.Drawing.Size(253, 27)
        Me.PN.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Booked By Name"
        '
        'PaymentBy
        '
        Me.PaymentBy.Enabled = False
        Me.PaymentBy.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentBy.FormattingEnabled = True
        Me.PaymentBy.Items.AddRange(New Object() {"Cash", "Some Cash", "Cash Later"})
        Me.PaymentBy.Location = New System.Drawing.Point(692, 101)
        Me.PaymentBy.Name = "PaymentBy"
        Me.PaymentBy.Size = New System.Drawing.Size(250, 29)
        Me.PaymentBy.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(549, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Payment By"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bno, Me.Column1, Me.BDate, Me.Column2, Me.Column3, Me.Pno, Me.Pname, Me.PCity, Me.PContact, Me.Column8})
        Me.DGV.Location = New System.Drawing.Point(38, 196)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(960, 162)
        Me.DGV.TabIndex = 185
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column4, Me.Column5, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.C18, Me.Column6, Me.Column7})
        Me.DGV2.Location = New System.Drawing.Point(38, 412)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(960, 182)
        Me.DGV2.TabIndex = 187
        '
        'Column12
        '
        Me.Column12.HeaderText = "Booking No"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "RouteNo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "BusSno"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "Sr. No"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Passenger Name"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Passenger Gender"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "Passenger Age"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "Seat No"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'C18
        '
        Me.C18.HeaderText = "SeatType"
        Me.C18.Name = "C18"
        Me.C18.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fare Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Payment"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1295, 45)
        Me.Panel1.TabIndex = 189
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(330, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(402, 30)
        Me.Label10.TabIndex = 257
        Me.Label10.Text = "ALL DETAILS OF YOUR SEAT BOOKING"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(-4, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1295, 35)
        Me.Panel3.TabIndex = 191
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(740, 30)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "BOOKING DETAILS AND PERSON OR PASSENGER BOOKED BY DETAILS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(-4, 374)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1295, 35)
        Me.Panel4.TabIndex = 192
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(658, 30)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "ALL PASSENGERS DETAILS, SEAT DETAILS AND FARE AMOUNT"
        '
        'Ending
        '
        Me.Ending.BackColor = System.Drawing.Color.PowderBlue
        Me.Ending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ending.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Ending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ending.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ending.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.Ending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ending.Location = New System.Drawing.Point(739, 600)
        Me.Ending.Name = "Ending"
        Me.Ending.Size = New System.Drawing.Size(259, 47)
        Me.Ending.TabIndex = 1
        Me.Ending.Text = "Back To Main Form"
        Me.Ending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ending.UseVisualStyleBackColor = False
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
        'Column8
        '
        Me.Column8.HeaderText = "Address"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Seat_Booking_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1286, 742)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Ending)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.PaymentBy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BookingDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BookingNo)
        Me.Controls.Add(Me.Label12)
        Me.Name = "Seat_Booking_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seat Booking Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookingNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BookingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PaymentBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Ending As System.Windows.Forms.Button
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PContact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
