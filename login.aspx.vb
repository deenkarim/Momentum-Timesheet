Imports System.Web.Security


Namespace MSLTimesheet

Partial Class login
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
        'Sets Path to Web Folder
        SetWebFolder()
    End Sub
    Private Sub SetWebFolder()
        Dim data As New DataAccess
        ' Set path of Webfolder
        data.WebFolder = Server.MapPath("")
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim u As New Users
        Dim Authed As Boolean
        Dim UserID As Integer
        Dim DeptID As Integer
        Dim TSID As Integer
        Dim UserFlag As Boolean
        Dim AdminFlag As Boolean
        Dim ds As New DataSet

        'Authenticate User Login
        Authed = u.ValidUser(Me.txtUserName.Text, _
                                Me.txtPassword.Text, _
                                DeptID, _
                                UserFlag, _
                                AdminFlag, _
                                UserID)

        If Authed Then
            'Set Variables if Login has been Authenticated
            Session("UserID") = UserID
            Session("DeptID") = DeptID
            Session("UserFlag") = UserFlag
            Session("AdminFlag") = AdminFlag

            FormsAuthentication.SetAuthCookie(txtUserName.Text, False)
            'Redirect to TimeSheet.aspx if Login Successful
            Response.Redirect("ui/TimeSheet.aspx")
        Else
            SetWebFolder()
            'Return Error Messgae if Login Unsucessful
            Me.lblLoginMessage.Text = "Invalid user name and password, please try again"
        End If
    End Sub
End Class

End Namespace
