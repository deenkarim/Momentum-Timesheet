Namespace MSLTimesheet

Partial Class EditUser
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
            If Session("UserIDEdit") = 0 Then Response.Redirect("Users.aspx")
            PopulateForEdit()
            GetDepartmentList()
        End If
        GetDBInfo()

    End Sub

    Private Sub GetDBInfo()
        Dim data As New DataAccess
        data.WebFolder = Server.MapPath("")
    End Sub
    Sub PopulateForEdit()
        Dim U As New Users
        Dim ds As DataSet

        'Populate controls and session variables
        ds = U.GetUserDetails(Session("UserIDEdit"))
        Me.txtUserName.Text = ds.Tables(0).Rows(0).Item(1)
        Me.txtFullName.Text = ds.Tables(0).Rows(0).Item(2)
        Me.txtJobTitle.Text = ds.Tables(0).Rows(0).Item(3)
        Me.txtPassword.Text = ds.Tables(0).Rows(0).Item(4)
        Me.txtVerifyPass.Text = ds.Tables(0).Rows(0).Item(4)
        Me.chkAdmin.Checked = ds.Tables(0).Rows(0).Item(6)
        Session("DeptID") = ds.Tables(0).Rows(0).Item(7)
        ds = Nothing
    End Sub
    Sub GetDepartmentList()
        Dim d As New Dept
        Dim ds As DataSet

        'Populate customer drop down list
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Response.Redirect("Users.aspx")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Adminchk As Single
        Dim Userchk As Single
        Dim DeptID As String

        If Me.txtUserName.Text.Length = 0 Then
            Me.lblRequiredUserName.Visible = True
            Exit Sub
        Else
            Me.lblRequiredUserName.Visible = False
        End If

        If chkAdmin.Checked = True Then
            Adminchk = 1
        Else
            Adminchk = 0
        End If

        Userchk = 1


        DeptID = ddlDept.SelectedValue

        Dim U As New Users
        U.UpdateUser(Session("UserIDEdit"), txtUserName.Text, txtFullName.Text, txtJobTitle.Text, txtPassword.Text, Userchk, Adminchk, DeptID)
        Response.Redirect("Users.aspx")
    End Sub

    Private Sub btnAddDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDept.Click
        Session("DeptRedirectID") = 2
        Response.Redirect("AddDept.aspx")
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Session("DeptRedirectID") = 2
        Session("DeptID") = ddlDept.SelectedValue
        Response.Redirect("EditDept.aspx")
    End Sub
End Class

End Namespace
