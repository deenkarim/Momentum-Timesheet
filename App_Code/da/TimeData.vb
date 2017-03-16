Imports System.Data.SqlClient


Namespace MSLTimesheet

Public Class TimeData
    Public Function GetTop5ByUserID(ByVal UserID As Integer) As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)

        Dim sSQL As String = "SELECT TOP 5 t.TSID, t.TSDate, t.StartTime, t.StartLunch, t.EndLunch, t.EndTime, t.Comments, t.TotalHours, u.UserID" & _
                                " FROM tblTimeSheet t " & _
                                    " INNER JOIN tblUsers as u ON t.UserID=u.UserID " & _
                                  " WHERE t.UserID = " & UserID.ToString & _
                                    " ORDER BY t.TSID DESC"

        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("TimeSheet")

        cn.Open()
        da.Fill(ds, "TimeSheet")
        cn.Close()

        Return ds
    End Function

    Public Function GetTop5() As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT TOP 5 t.TSID, t.TSDate, t.StartTime, t.StartLunch, t.EndLunch, t.EndTime, t.Comments, t.TotalHours, u.UserName" & _
                                " FROM tblTimeSheet t " & _
                                    " INNER JOIN tblUsers as u ON t.UserID=u.UserID " & _
                                   " ORDER t.TSID DESC"
        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("TimeSheet")

        cn.Open()
        da.Fill(ds, "TimeSheet")
        cn.Close()

        Return ds
    End Function

    Function GetAllDataByTSID(ByVal TSID As Integer) As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT * " & _
                                " FROM tblTimeSheet " & _
                                    " WHERE TSID = " & TSID.ToString


        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("TimeSheet")

        cn.Open()
        da.Fill(ds, "TimeSheet")
        cn.Close()

        Return ds
    End Function
    Public Function GetAlLTimeByID(ByVal UserID As Integer) As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT t.TSID, t.TSDate, t.StartTime, t.StartLunch, t.EndLunch, t.EndTime, t.Comments,t.TotalHours, u.UserID" & _
                                " FROM tblTimeSheet t " & _
                                    " INNER JOIN tblUsers as u ON t.UserID=u.UserID " & _
                                  " WHERE t.UserID = " & UserID.ToString & _
                                    " ORDER BY u.UserID, t.TSDate"

        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("TimeSheet")

        cn.Open()
        da.Fill(ds, "TimeSheet")
        cn.Close()

        Return ds
    End Function

    Public Function GetAllTime() As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT t.TSID, t.TSDate, t.StartTime, t.StartLunch, t.EndLunch, t.EndTime, t.Comments, t.TotalHours, u.UserName" & _
                                " FROM tblTimeSheet t " & _
                                    " INNER JOIN tblUsers as u ON t.UserID=u.UserID " & _
                                   " ORDER BY u.UserName, t.TSDate"
        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("TimeSheet")

        cn.Open()
        da.Fill(ds, "TimeSheet")
        cn.Close()

        Return ds
    End Function

    Function InsertTime(ByVal TSDate As String, _
                             ByVal StartTime As String, _
                             ByVal StartLunch As String, _
                             ByVal EndLunch As String, _
                             ByVal EndTime As String, _
                             ByVal UserID As Long, _
                             ByVal TotalHours As Decimal)

        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "INSERT INTO tblTimeSheet " & _
                                "(TSDate, StartTime, StartLunch, EndLunch, EndTime, UserID, TotalHours) " & _
                            "VALUES " & _
                             "('" & TSDate & "', '" & StartTime & " ', '" & StartLunch & "', '" & EndLunch & "', '" & EndTime & "', '" & UserID & " ', '" & TotalHours & " ')"

        Dim cmd As New SqlCommand(sSQL, cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Function

    Function UpdateTime(ByVal TSID As Long, _
                         ByVal TSDate As String, _
                         ByVal StartTime As String, _
                         ByVal StartLunch As String, _
                         ByVal EndLunch As String, _
                         ByVal EndTime As String, _
                         ByVal UserID As Long, _
                         ByVal TotalHours As Decimal)

        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)



        'Set SQL database string
        Dim ssql As String = "UPDATE tblTimeSheet " & _
                                "SET TSDate = '" & TSDate & "', " & _
                                    "StartTime = '" & StartTime & "', " & _
                                    "StartLunch = '" & StartLunch & "', " & _
                                    "EndLunch = '" & EndLunch & "', " & _
                                    "EndTime = '" & EndTime & "', " & _
                                    "UserID = '" & UserID & "', " & _
                                    "TotalHours = '" & TotalHours & "' " & _
                                    "WHERE TSID = " & TSID.ToString

        Dim cmd As New SqlCommand(ssql, cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Function

    Function DeleteTime(ByVal TSID As Long)
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim ssql As String = "DELETE FROM tblTimeSheet WHERE TSID= " & TSID.ToString
        Dim cmd As New SqlCommand(ssql, cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Function

End Class

End Namespace
