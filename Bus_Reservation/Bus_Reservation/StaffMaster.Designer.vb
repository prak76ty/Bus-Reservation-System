<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMaster
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
        Me.StaffType = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.StaffContact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.StaffCity = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.StaffAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.StaffName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.StaffID = New System.Windows.Forms.TextBox
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.PaleGreen
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffContact)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffCity)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffAddress)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1394, 703)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 5
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnexit.FlatAppearance.BorderSize = 2
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.Bus_Reservation.My.Resources.Resources.shutdown_48
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexit.Location = New System.Drawing.Point(16, 510)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(150, 75)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "EXIT FORM"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnfind
        '
        Me.btnfind.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnfind.FlatAppearance.BorderSize = 2
        Me.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btndelete.FlatAppearance.BorderSize = 2
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnedit.FlatAppearance.BorderSize = 2
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderSize = 2
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnadd.FlatAppearance.BorderSize = 2
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnmain.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnmain.FlatAppearance.BorderSize = 2
        Me.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Right1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Right1.Image = Global.Bus_Reservation.My.Resources.Resources.chevron_right_round_48
        Me.Right1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Right1.Location = New System.Drawing.Point(650, 9)
        Me.Right1.Name = "Right1"
        Me.Right1.Size = New System.Drawing.Size(89, 58)
        Me.Right1.TabIndex = 46
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
        Me.Left1.Location = New System.Drawing.Point(237, 9)
        Me.Left1.Name = "Left1"
        Me.Left1.Size = New System.Drawing.Size(89, 58)
        Me.Left1.TabIndex = 45
        Me.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Left1.UseVisualStyleBackColor = False
        '
        'StaffType
        '
        Me.StaffType.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffType.FormattingEnabled = True
        Me.StaffType.Items.AddRange(New Object() {"Select", "Office boy", "Cleaner", "Conductor"})
        Me.StaffType.Location = New System.Drawing.Point(527, 241)
        Me.StaffType.Name = "StaffType"
        Me.StaffType.Size = New System.Drawing.Size(264, 39)
        Me.StaffType.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 31)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Staff Type"
        '
        'StaffContact
        '
        Me.StaffContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffContact.Location = New System.Drawing.Point(527, 533)
        Me.StaffContact.Name = "StaffContact"
        Me.StaffContact.Size = New System.Drawing.Size(264, 38)
        Me.StaffContact.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 537)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 31)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Staff Contact No."
        '
        'StaffCity
        '
        Me.StaffCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffCity.Location = New System.Drawing.Point(527, 452)
        Me.StaffCity.Name = "StaffCity"
        Me.StaffCity.Size = New System.Drawing.Size(264, 38)
        Me.StaffCity.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Staff City"
        '
        'StaffAddress
        '
        Me.StaffAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffAddress.Location = New System.Drawing.Point(527, 321)
        Me.StaffAddress.Multiline = True
        Me.StaffAddress.Name = "StaffAddress"
        Me.StaffAddress.Size = New System.Drawing.Size(264, 92)
        Me.StaffAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Staff Address"
        '
        'StaffName
        '
        Me.StaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffName.Location = New System.Drawing.Point(527, 159)
        Me.StaffName.Name = "StaffName"
        Me.StaffName.Size = New System.Drawing.Size(264, 38)
        Me.StaffName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Staff Name"
        '
        'StaffID
        '
        Me.StaffID.BackColor = System.Drawing.Color.White
        Me.StaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffID.Location = New System.Drawing.Point(527, 78)
        Me.StaffID.Name = "StaffID"
        Me.StaffID.ReadOnly = True
        Me.StaffID.Size = New System.Drawing.Size(264, 38)
        Me.StaffID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 31)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Staff ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.mainlabel)
        Me.Panel1.Location = New System.Drawing.Point(-14, -31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 108)
        Me.Panel1.TabIndex = 4
        '
        'mainlabel
        '
        Me.mainlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlabel.Location = New System.Drawing.Point(172, 30)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(506, 62)
        Me.mainlabel.TabIndex = 1
        Me.mainlabel.Text = "STAFF MASTER "
        '
        'StaffMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 742)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffMaster"
        Me.Text = "Staff Master"
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
    Friend WithEvents StaffContact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StaffCity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StaffAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StaffName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StaffID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StaffType As System.Windows.Forms.ComboBox
    Friend WithEvents mainlabel As System.Windows.Forms.Label
    Friend WithEvents Right1 As System.Windows.Forms.Button
    Friend WithEvents Left1 As System.Windows.Forms.Button
End Class
