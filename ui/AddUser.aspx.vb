Namespace MSLTimesheet

Partial Class AddUser
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
        If Not IsPostBack Then GetDepartmentList()
        GetDBInfo()
    End Sub
    Private Sub GetDBInfo()
        Dim data As New DataAccess
        data.WebFolder = Server.MapPath("")
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Response.Redirect("Users.aspx")
    End Sub

    Private Sub btnAddDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDept.Click
        Session("DeptRedirectID") = 1
        Response.Redirect("AddDept.aspx")
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Session("DeptRedirectID") = 1
        Session("DeptID") = ddlDept.SelectedValue
        Response.Redirect("EditDept.aspx")
    End Sub

    Sub GetDepartmentList()
        Dim d As New Dept
        Dim ds As DataSet

        'Populate department drop down list
        ds = d.GetAllDepartments()
        With ddlDept
            .DataSource = ds
            .DataValueField = "DeptID"
            .DataTextField = "DeptName"
            If Session("DeptID") > 0 Then .SelectedValue = Session("DeptID")
        End With
        ds = Nothing

        Me.DataBind()
    End Sub

    Private Function OKToSave() As Boolean
        Dim Result As Boolean = True

        If Me.txtUserName.Text.Length = 0 Then
            Me.lblRequiredUserName.Visible = True
            Exit Function
        Else
            Me.lblRequiredUserName.Visible = False
        End If

        If Me.txtFullName.Text.Length = 0 Then
            Me.lblRequiredFullName.Visible = True
            Exit Function
        Else
            Me.lblRequiredFullName.Visible = False
        End If

        If Me.txtPassword.Text.Length = 0 Then
            Me.lblRequiredPassword.Visible = True
            Exit Function
        Else
            Me.lblRequiredPassword.Visible = False
        End If
        Return Result
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Adminchk As Single
        Dim Userchk As Single

        If Not OKToSave() Then Exit Sub

        If chkAdmin.Checked = True Then
            Adminchk = 1
        Else
            Adminchk = 0
        End If

        Userchk = 1

        If txtPassword.Text = txtVerifyPass.Text Then
            Dim u As New Users
            u.InsertUser(txtUserName.Text, txtFullName.Text, txtJobTitle.Text, txtPassword.Text, Userchk, Adminchk, ddlDept.SelectedValue)
        Else
        End If
        Response.Redirect("Users.aspx")
    End Sub
End Class

End Namespace
