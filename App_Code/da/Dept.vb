Imports System.Data.SqlClient


Namespace MSLTimesheet

Public Class Dept
    Function GetAllDepartments() As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim da As New SqlDataAdapter("SELECT * FROM tblDepts ORDER BY DeptName", cn)
        Dim ds As New DataSet("Dept")

        cn.Open()
        da.Fill(ds, "Dept")
        cn.Close()

        Return ds
    End Function

    Public Function GetAllDepartmentsByID(ByVal DeptID As String) As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT  DeptID, DeptName " & _
                             "FROM tblDepts " & _
                                "WHERE DeptID = " & DeptID.ToString

        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("Dept")

        cn.Open()
        da.Fill(ds, "Dept")
        cn.Close()

        Return ds
    End Function

    Function InsertDept(ByVal DeptName As String) As Integer
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim ssql As String = "INSERT INTO tblDepts (DeptName) VALUES ('" & DeptName & "') "
        Dim cmd As New SqlCommand(ssql, cn)
        Dim DeptID As Integer

        cn.Open()
        cmd.ExecuteNonQuery()
        ssql = "SELECT MAX(DeptID) From tblDepts"
        cmd.CommandText = ssql
        DeptID = cmd.ExecuteScalar()
        cn.Close()

        Return DeptID
    End Function

    Function UpdateDept(ByVal DeptID As Long, ByVal DeptName As String)
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        'Deal with potential SQL aproshophere problem
        DeptName = Replace(DeptName, "'", "''")
        'Set SQL database string
        Dim ssql As String = "UPDATE tblDepts " & _
                                "SET DeptName = '" & DeptName & "' " & _
                                      "WHERE DeptID = " & DeptID.ToString

        Dim cmd As New SqlCommand(ssql, cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Function
End Class

End Namespace
