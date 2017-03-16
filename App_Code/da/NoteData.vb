Imports System.Data.SqlClient


Namespace MSLTimesheet

Public Class NoteData
    Function GetNotes(ByVal TSID As Long) As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT t.TSID, t.TSDate, " & _
                             "n.NoteID, ns.NoteSubject, n.Notes, n.NoteDate " & _
                             " FROM tblTimeSheet t " & _
                                    "INNER JOIN tblNotes as n ON t.TSID=n.TSID " & _
                                    "INNER JOIN tblNoteSubjects as ns ON n.SubjectID=ns.SubjectID " & _
                                    "WHERE t.TSID = " & TSID.ToString & _
                                     "ORDER BY n.NoteDate, n.NoteID DESC"

        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("Notes")

        cn.Open()
        da.Fill(ds, "Notes")
        cn.Close()

        Return (ds)

    End Function
    Function GetDate(ByVal TSID As Long) As Date
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT TSDate FROM tblTimeSheet " & _
                                    "WHERE TSID = " & TSID
        Dim dr As SqlDataReader
        Dim TSdate As Date
        Dim cmd As New SqlCommand(sSQL, cn)
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            TSdate = dr.GetValue(0)
        End While
        cn.Close()
        Return TSdate
    End Function
    Function GetNoteSubjects() As DataSet
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT SubjectID, NoteSubject FROM tblNoteSubjects ORDER BY NoteSubject ASC"

        Dim da As New SqlDataAdapter(sSQL, cn)
        Dim ds As New DataSet("NoteSubjects")

        cn.Open()
        da.Fill(ds, "NoteSubjects")
        cn.Close()

        Return ds

    End Function
    Function GetNoteSubjectByID(ByVal SubjectID As String) As String

        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)
        Dim sSQL As String = "SELECT NoteSubject FROM tblNoteSubjects WHERE SubjectID=" & SubjectID.ToString

        Dim dr As SqlDataReader
        Dim NoteSubject As String
        Dim cmd As New SqlCommand(sSQL, cn)
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            NoteSubject = dr.GetValue(0)
        End While
        cn.Close()
        Return NoteSubject
    End Function

    Function InsertNotes(ByVal TSID As Long, ByVal SubjectID As String, ByVal Notes As String, ByVal NoteDate As String)
        Dim db As New DataAccess
        Dim cn As New SqlConnection(db.ConnectStr)

        Dim sSQL As String = "INSERT INTO tblNotes " & _
                                       "(TSID, SubjectID, Notes, NoteDate) " & _
                                   "VALUES " & _
                                       "('" & TSID & "', '" & SubjectID & "', '" & Notes & "','" & NoteDate & "')"

        Dim cmd As New SqlCommand(sSQL, cn)

        Dim NoteID As Integer
        cn.Open()
        cmd.ExecuteNonQuery()
        sSQL = "SELECT MAX(NoteID) From tblNotes"
        cmd.CommandText = sSQL
        NoteID = cmd.ExecuteScalar()
        cn.Close()

        Return NoteID
    End Function
End Class

End Namespace
