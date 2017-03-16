Namespace MSLTimesheet

Partial Class AddDept
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
        'Put user code to initialize the page here
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.txtDept.Text.Length = 0 Then
            Me.lblRequired.Visible = True
            Exit Sub
        Else
            Me.lblRequired.Visible = False
        End If
        Dim d As New Dept
        Session("DeptID") = d.InsertDept(txtDept.Text)
        GetRedirect()
    End Sub
End Class

End Namespace
