'===========================================================================
' This file was modified as part of an ASP.NET 2.0 Web project conversion.
' The class name was changed and the class modified to inherit from the abstract base class 
' in file 'App_Code\Migrated\ui\Stub_notes_aspx_vb.vb'.
' During runtime, this allows other classes in your web application to bind and access 
' the code-behind page using the abstract base class.
' The associated content page 'ui\notes.aspx' was also modified to refer to the new class name.
' For more information on this code pattern, please refer to http://go.microsoft.com/fwlink/?LinkId=46995 
'===========================================================================
Namespace MSLTimesheet

'Partial Class Notes
Partial Class Migrated_Notes

Inherits Notes

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub


    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            LoadSubjects()
            LoadDate()
            LoadNotes()
        End If
    End Sub
    Overrides Sub LoadSubjects()
        Dim n As New NoteData
        Dim ds As DataSet

        ds = n.GetNoteSubjects
        With ddlNoteSubject
            .DataSource = ds
            .DataValueField = "SubjectID"
            .DataTextField = "NoteSubject"
        End With
        ddlNoteSubject.DataBind()

    End Sub
    Overrides Sub LoadDate()
        Session("TSID") = Request.QueryString("id")
        Dim n As New NoteData
        Dim TSDate As Date

        ' Populate controls and session variables
        TSDate = n.GetDate(Session("TSID"))
        lblDate.Text = TSDate

    End Sub
    Overrides Sub LoadNotes()
        Session("TSID") = Request.QueryString("id")
        Dim n As New NoteData
        Dim ds As DataSet
        ' Populate controls and session variables
        ds = n.GetNotes(Session("TSID"))
        dgNotes.DataSource = ds
        dgNotes.DataBind()
        ds = Nothing
    End Sub
    Overrides Sub OKtoSave()
        If Me.lblDate.Text.Length = 0 Then
            Me.lblRequired.Visible = True
        Else
            Me.lblRequired.Visible = False
        End If
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        OKtoSave()
        Dim n As New NoteData
        Dim NoteDate As DateTime
        Dim SubjectID As String
        NoteDate = lblDate.Text

        SubjectID = ddlNoteSubject.SelectedValue

        n.InsertNotes(Session("TSID"), SubjectID, txtNotes.Text, Format(NoteDate, "Long Date"))
        LoadNotes()
        txtNotes.Text = ""
    End Sub
End Class

End Namespace
