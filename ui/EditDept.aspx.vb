Namespace MSLTimesheet

Partial Class EditDept
    Inherits System.Web.UI.Page

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
            If Session("DeptID") = 0 Then GetRedirect()
            PopulateForEdit()
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GetRedirect()
    End Sub
    Sub GetRedirect()
        If Session("DeptRedirectID") = 1 Then
            Response.Redirect("AddUser.aspx")
        ElseIf Session("DeptRedirectID") = 2 Then
            Response.Redirect("EditUser.aspx")
        End If
    End Sub
    Sub PopulateForEdit()
        Dim D As New Dept
        Dim ds As DataSet
        'Populate controls and session variables
        ds = D.GetAllDepartmentsByID(Session("DeptID"))
        Me.txtDept.Text = ds.Tables(0).Rows(0).Item(1)
        ds = Nothing
    End Sub
    Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.txtDept.Text.Length = 0 Then
            Me.lblRequired.Visible = True
            Exit Sub
        Else
            Me.lblRequired.Visible = False
        End If

        Dim D As New Dept
        D.UpdateDept(Session("DeptID"), txtDept.Text)
        GetRedirect()
    End Sub

End Class

End Namespace
