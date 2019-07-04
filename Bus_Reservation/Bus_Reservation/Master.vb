Imports System.Data.SqlClient
Module Master
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Public t, ID, CID, f, R, D, O, P, S As Integer
    Public FindMe(15), LIDT As String
    Public CS As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True"

    Function Add(ByVal MAX As String, ByVal Table As String) As String
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Select max(" + MAX + ") From " + Table, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If (dr.Item(0) IsNot DBNull.Value) Then
            t = dr.Item(0) + 1
        Else
            t = 1
        End If
        ID = t.ToString
        dr.Close()
        con.Close()
        Return ID
    End Function

    Function Delete(ByVal MAX As String, ByVal Table As String, ByVal Key As String) As String
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Delete From " + Table + " Where " + MAX + "=" & Key & "", con)
        cmd.ExecuteNonQuery()
        con.Close()
        Return "Record Deleted !"
    End Function

    Sub Find(ByVal MAX As String, ByVal Table As String, ByVal Key As Integer, ByVal Size As Integer)
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Select * From " + Table + " Where " + MAX + "=" & Key & "", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Size >= 5 Then
            FindMe(0) = dr.GetValue(0)
            FindMe(1) = dr.GetValue(1)
            FindMe(2) = dr.GetValue(2)
            FindMe(3) = dr.GetValue(3)
            FindMe(4) = dr.GetValue(4)
        End If
        If Size >= 6 Then
            FindMe(5) = dr.GetValue(5)
        End If
        If Size >= 9 Then
            FindMe(6) = dr.GetValue(6)
            FindMe(7) = dr.GetValue(7)
            FindMe(8) = dr.GetValue(8)
        End If
        If Size >= 12 Then
            FindMe(9) = dr.GetValue(9)
            FindMe(10) = dr.GetValue(10)
            FindMe(11) = dr.GetValue(11)
        End If
        dr.Close()
        con.Close()
    End Sub

    Function Save(ByVal Key As Integer) As String
        con = New SqlConnection(CS)
        con.Open()
        If Key = 1 Then
            cmd = New SqlCommand("Insert Into Route Values(" & RouteMaster.Rno.Text & ",'" & RouteMaster.RouteName.Text & "','" & Format(RouteMaster.Arrivaltime.Value, "hh:mm:ss tt") & "','" & Format(RouteMaster.Departuretime.Value, "hh:mm:ss tt") & "','" & RouteMaster.cmbstartpoint.Text & "','" & RouteMaster.cmbdestination.Text & "','" & RouteMaster.FAmount.Text & "','" & RouteMaster.TTime.Text & "','" & RouteMaster.TDistance.Text & "')", con)
        ElseIf Key = 2 Then
            cmd = New SqlCommand("Insert Into Bus Values(" & BusMaster.BusSerialNo.Text & ",'" & BusMaster.BusNumber.Text & "','" & BusMaster.BusRoute.Text & "','" & BusMaster.BusType.Text & "','" & BusMaster.BusReservation.Text & "','" & BusMaster.SeatCapacity.Text & "')", con)
        ElseIf Key = 3 Then
            cmd = New SqlCommand("Insert Into Driver Values(" & DriverMaster.DriverID.Text & ",'" & DriverMaster.DriverName.Text & "','" & DriverMaster.DriverAddress.Text & "','" & DriverMaster.Drivercity.Text & "','" & DriverMaster.DriverAge.Text & "','" & DriverMaster.DriverContact.Text & "','" & DriverMaster.DriverLicense.Text & "','" & DriverMaster.DateJoining.Value & "','" & DriverMaster.DriverSalary.Text & "','" & DriverMaster.DriverQualification.Text & "','" & DriverMaster.DriverReference.Text & "','" & DriverMaster.DriverConctact2.Text & "')", con)
        ElseIf Key = 4 Then
            cmd = New SqlCommand("Insert Into Office Values(" & OfficeMaster.OfficeID.Text & ",'" & OfficeMaster.OWorkerName.Text & "','" & OfficeMaster.Officeaddress.Text & "','" & OfficeMaster.Officecity.Text & "','" & OfficeMaster.Officecontact.Text & "')", con)
        ElseIf Key = 5 Then
            cmd = New SqlCommand("Insert Into Passenger Values(" & PassengerMaster.PassengerNo.Text & ",'" & PassengerMaster.PassengerName.Text & "','" & PassengerMaster.PassengerAddress.Text & "','" & PassengerMaster.PassengerCity.Text & "','" & PassengerMaster.PassengerContact.Text & "')", con)
        ElseIf Key = 6 Then
            cmd = New SqlCommand("Insert Into Staff Values(" & StaffMaster.StaffID.Text & ",'" & StaffMaster.StaffName.Text & "','" & StaffMaster.StaffType.Text & "','" & StaffMaster.StaffAddress.Text & "','" & StaffMaster.StaffCity.Text & "','" & StaffMaster.StaffContact.Text & "')", con)
        End If
        cmd.ExecuteNonQuery()
        Return "Success... !"
    End Function

    Function Update(ByVal Key As Integer) As String
        con = New SqlConnection(CS)
        con.Open()
        If Key = 1 Then
            cmd = New SqlCommand("Update Route Set Rname='" & RouteMaster.RouteName.Text & "',Arrivaltime='" & Format(RouteMaster.Arrivaltime.Value, "hh:mm tt") & "',Departuretime='" & Format(RouteMaster.Departuretime.Value, "hh:mm tt") & "',Startingpoint='" & RouteMaster.cmbstartpoint.Text & "',Destination='" & RouteMaster.cmbdestination.Text & "',FareAmt='" & RouteMaster.FAmount.Text & "',TotalTime='" & RouteMaster.TTime.Text & "',TotalDistance='" & RouteMaster.TDistance.Text & "' Where Rno=" & RouteMaster.Rno.Text & "", con)
        ElseIf Key = 2 Then
            cmd = New SqlCommand("Update Bus Set BusNo='" & BusMaster.BusNumber.Text & "',Route='" & BusMaster.BusRoute.Text & "',Type='" & BusMaster.BusType.Text & "',Reservation='" & BusMaster.BusReservation.Text & "',SeatCapacity='" & BusMaster.SeatCapacity.Text & "' Where BusSno=" & BusMaster.BusSerialNo.Text & "", con)
        ElseIf Key = 3 Then
            cmd = New SqlCommand("Update Driver Set Dname='" & DriverMaster.DriverName.Text & "',Daddress='" & DriverMaster.DriverAddress.Text & "',Dcity='" & DriverMaster.Drivercity.Text & "',Dage='" & DriverMaster.DriverAge.Text & "',Dcontact='" & DriverMaster.DriverContact.Text & "',Dlicense='" & DriverMaster.DriverLicense.Text & "',Djoiningdate='" & DriverMaster.DateJoining.Value & "',Dsalary='" & DriverMaster.DriverSalary.Text & "',Dqualification='" & DriverMaster.DriverQualification.Text & "',Dreference='" & DriverMaster.DriverReference.Text & "',Dcontact2='" & DriverMaster.DriverConctact2.Text & "' Where Did=" & DriverMaster.DriverID.Text & "", con)
        ElseIf Key = 4 Then
            cmd = New SqlCommand("Update Office Set OWname='" & OfficeMaster.OWorkerName.Text & "',Oaddress='" & OfficeMaster.Officeaddress.Text & "',Ocity='" & OfficeMaster.Officecity.Text & "',Ocontact='" & OfficeMaster.Officecontact.Text & "' Where Oid=" & OfficeMaster.OfficeID.Text & "", con)
        ElseIf Key = 5 Then
            cmd = New SqlCommand("Update Passenger Set Pname='" & PassengerMaster.PassengerName.Text & "',Paddress='" & PassengerMaster.PassengerAddress.Text & "',Pcity='" & PassengerMaster.PassengerCity.Text & "',Pcontact='" & PassengerMaster.PassengerContact.Text & "' Where Pno=" & PassengerMaster.PassengerNo.Text & "", con)
        ElseIf Key = 6 Then
            cmd = New SqlCommand("Update Staff Set Sname='" & StaffMaster.StaffName.Text & "',Stype='" & StaffMaster.StaffType.Text & "',Saddress='" & StaffMaster.StaffAddress.Text & "',Scity='" & StaffMaster.StaffCity.Text & "',Scontact='" & StaffMaster.StaffContact.Text & "' Where Sid=" & StaffMaster.StaffID.Text & "", con)
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        Return "Record is Updated !"
    End Function
    Sub Completed()
        Dim BD, BD2 As Date
        Dim Bno As Integer
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Select Distinct BookingDate,BookingNo From APaymentPassenger Where WaitingNo=" & "0" & "", con)
        dr = cmd.ExecuteReader
        While dr.Read()
            BD2 = dr.GetValue(0)
            Bno = dr.GetValue(1)
            If Format(Today, "MM/dd/yyyy") >= Format(BD2, "MM/dd/yyyy") Then
                dr.Close()
                cmd = New SqlCommand("Insert Into PaymentPassenger Select * From APaymentPassenger Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Insert Into PassengerDetails Select * From APassengerDetails Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Delete From APassengerDetails Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Delete From APaymentPassenger Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Select Distinct BookingDate,BookingNo From APaymentPassenger Where WaitingNo=" & "0" & "", con)
                dr = cmd.ExecuteReader
            End If
        End While
        dr.Close()

        cmd = New SqlCommand("Select Distinct BookingDate,BookingNo From PaymentPassenger", con)
        dr = cmd.ExecuteReader
        While dr.Read()
            BD = dr.GetValue(0)
            Bno = dr.GetValue(1)
            If Format(Today, "MM/dd/yyyy") > Format(BD, "MM/dd/yyyy") Then
                dr.Close()
                cmd = New SqlCommand("Insert Into CompletedPP Select * From PaymentPassenger Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Insert Into CompletedPassenger Select * From PassengerDetails Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Delete From PassengerDetails Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Delete From PaymentPassenger Where BookingNo=" & Bno & "", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("Select Distinct BookingDate,BookingNo From PaymentPassenger", con)
                dr = cmd.ExecuteReader
            End If
        End While
        dr.Close()
        con.Close()
    End Sub
    Sub clear(ByVal PP As String, ByVal PD As String)
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("delete from " + PP + "", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("delete from " + PD + "", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Function AddCount(ByVal MAX As String, ByVal Table As String) As String
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Select COUNT(" + MAX + ") From " + Table, con)
        dr = cmd.ExecuteReader
        dr.Read()
        CID = dr.GetValue(0)
        dr.Close()
        con.Close()
        Return CID
    End Function
    Function AddCount(ByVal MAX As String, ByVal Table As String, ByVal Condition As String, ByVal Value As String) As String
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Select COUNT(" + MAX + ") From " + Table + " Where " + Condition + "='" & Value & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        CID = dr.GetValue(0)
        dr.Close()
        con.Close()
        Return CID
    End Function
    Sub LR()
        con = New SqlConnection(CS)
        con.Open()
        cmd = New SqlCommand("Update LoginRecords Set LogoutDateTime='" & Today + " " + TimeOfDay & "' Where LogInDateTime='" & LIDT & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub LI()
        con = New SqlConnection(CS)
        con.Open()
        LIDT = Today + " " + TimeOfDay
        cmd = New SqlCommand("Insert Into LoginRecords(ID,LogInDateTime) Values(" & Login.a & ",'" & LIDT & "')", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Module
