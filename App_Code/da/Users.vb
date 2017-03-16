Imports System.Data.SqlClient


Namespace MSLTimesheet

Public Class Users
    Function ValidUser(ByVal UserName As String, _
                        ByVal Password As String, _
                           ByRef DeptID As String, _
                           ByRef UserFlag As Single, _
                           ByRef AdminFlag As Single, _
                           ByRef UserID As Single) As Boolean

        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT ISNULL(UserID, 0) as Authed, " & _
                                        "ISNULL(DeptID, 0) as CustomerID, " & _
                                        "ISNULL(UserFlag, 0) as UserFlag, " & _
                                        "ISNULL(AdminFlag, 0) as AdminFlag, " & _
                                        "ISNULL(UserID, 0) as UserID " & _
                                       "FROM tblUsers " & _
                                "WHERE UserName = '" & UserName & "' " & _
                                    " AND Password = '" & Password & "' "
        Dim dr As SqlDataReader
        Dim Result As Boolean
        Dim cmd As New SqlCommand(sSQL, cn)

        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read()
            Result = dr.GetValue(0)
            DeptID = dr.GetValue(1)
            UserFlag = dr.GetValue(2)
            AdminFlag = dr.GetValue(3)
            UserID = dr.GetValue(4)
        End While

        cn.Close()

        Return Result
    End Function

    Function GetUserDetails() As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT  u.UserID, u.UserName, u.FullName, u.JobTitle, u.Password, u.UserFlag, u.AdminFlag, d.DeptID, d.DeptName " & _
                             "FROM tblUsers u " & _
                                "INNER JOIN tblDepts as d ON u.DeptID = d.DeptID "


        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("UserDetails")

        cn.Open()
        da.Fill(ds, "UserDetails")
        cn.Close()

        Return ds
    End Function


    Function GetUserDetails(ByVal UserID As Long) As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT  u.UserID, u.UserName, u.FullName, u.JobTitle, u.Password, u.UserFlag, u.AdminFlag, d.DeptID, d.DeptName " & _
                             "FROM tblUsers u " & _
                                "INNER JOIN tblDepts as d ON u.DeptID = d.DeptID " & _
                             "WHERE UserID = " & UserID.ToString

        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("UserDetails")

        cn.Open()
        da.Fill(ds, "UserDetails")
        cn.Close()

        Return ds
    End Function

        Public Sub DeleteUser(ByVal UserID As Long)
            DeleteTimesheets(UserID)
            Dim db As New DataAccess
            Dim cn As New SqlConnection(db.ConnectStr)
            Dim ssql As String = "DELETE FROM tblUsers WHERE UserID= " & UserID.ToString
            Dim cmd As New SqlCommand(ssql, cn)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Sub
        Public Sub DeleteTimesheets(ByVal UserID As Long)
            Dim db As New DataAccess
            Dim cn As New SqlConnection(db.ConnectStr)
            Dim ssql As String = "DELETE FROM tblTimeSheet WHERE UserID= " & UserID.ToString
            Dim cmd As New SqlCommand(ssql, cn)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Sub

    Public Function InsertUser(ByVal UserName As String, _
                            ByVal FullName As String, _
                            ByVal JobTitle As String, _
                            ByVal Password As String, _
                            ByVal UserFlag As Single, _
                            ByVal AdminFlag As Single, _
                            ByVal DeptID As Integer)
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)


        'Deal with potential SQL aproshophere problem
        UserName = Replace(UserName, "'", "''")
        FullName = Replace(FullName, "'", "''")
        JobTitle = Replace(JobTitle, "'", "''")
        Password = Replace(Password, "'", "''")

        Dim sSQL As String = "INSERT INTO tblUsers " & _
                                "(UserName,FullName, JobTitle, Password, UserFlag, AdminFlag, DeptID) " & _
                            "VALUES " & _
                             "('" & UserName & "', '" & FullName & " ', '" & JobTitle & "', '" & Password & "', '" & UserFlag & "', '" & AdminFlag & " ', '" & DeptID & " ')"


        Dim cmd As New SqlCommand(sSQL, cn)

        Dim UserID As Integer
        cn.Open()
        cmd.ExecuteNonQuery()
        sSQL = "SELECT MAX(UserID) From tblUsers"
        cmd.CommandText = sSQL
        UserID = cmd.ExecuteScalar()
        cn.Close()

        Return UserID
    End Function

    Function UpdateUser(ByVal UserID As Long, ByVal UserName As String, _
                                  ByVal FullName As String, _
                                  ByVal JobTitle As String, _
                                  ByVal Password As String, _
                                  ByVal UserFlag As Single, _
                                  ByVal AdminFlag As Single, _
                                  ByVal DeptID As Integer)


        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)

        'Deal with potential SQL aproshophere problem
        UserName = Replace(UserName, "'", "''")
        FullName = Replace(FullName, "'", "''")
        JobTitle = Replace(JobTitle, "'", "''")
        Password = Replace(Password, "'", "''")

        'Set SQL database string
        Dim ssql As String = "UPDATE tblUsers " & _
                                "SET UserName = '" & UserName & "', " & _
                                    "FullName = '" & FullName & "', " & _
                                    "JobTitle = '" & JobTitle & "', " & _
                                    "Password = '" & Password & "', " & _
                                    "UserFlag = '" & UserFlag & "', " & _
                                    "AdminFlag = '" & AdminFlag & "', " & _
                                    "DeptID = '" & DeptID & "' " & _
                                "WHERE UserID = " & UserID.ToString

        Dim cmd As New SqlCommand(ssql, cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Function

End Class

End Namespace
