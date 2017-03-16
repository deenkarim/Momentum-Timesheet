Namespace MSLTimesheet

Partial Class Users1
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
            btnDelete.Attributes.Add("onclick", "return confirm('Are you sure you want to delete?');")
            LoadUserGrid()
        End If
        GetDBInfo()
    End Sub
    Private Sub GetDBInfo()
        Dim data As New DataAccess
        data.WebFolder = Server.MapPath("")
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("TimeSheet.aspx")
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Response.Redirect("AddUser.aspx")
    End Sub

    Sub LoadUserGrid()
        Dim U As New Users
        Dim dsUsers As DataSet
        Dim RowsFound As String

        dsUsers = U.GetUserDetails
        dgUsers.DataSource = dsUsers
        dgUsers.DataBind()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim u As New Users
        Dim objItem As DataGridItem
        Dim UserID As Integer

        For Each objItem In Me.dgUsers.Items

            ' Ignore invalid items
            If objItem.ItemType <> ListItemType.Header And _
                objItem.ItemType <> ListItemType.Footer And _
                objItem.ItemType <> ListItemType.Pager Then

                ' Retrieve the value of the check box
                Dim blnDelete As Boolean

                blnDelete = CType(objItem.Cells(1).FindControl("chkSelect"), CheckBox).Checked

                If blnDelete = True Then
                    UserID = objItem.Cells(0).Text
                    u.DeleteUser(UserID)
                End If
            End If
        Next
        LoadUserGrid()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim da As New DataAccess
        Dim objItem As DataGridItem
        Dim UserID As Integer

        For Each objItem In Me.dgUsers.Items

            ' Ignore invalid items
            If objItem.ItemType <> ListItemType.Header And _
                objItem.ItemType <> ListItemType.Footer And _
                objItem.ItemType <> ListItemType.Pager Then

                ' Retrieve the value of the check box
                Dim blnEdit As Boolean

                blnEdit = CType(objItem.Cells(1).FindControl("chkSelect"), CheckBox).Checked

                If blnEdit = True Then
                    Session("UserIDEdit") = objItem.Cells(0).Text
                    Response.Redirect("EditUser.aspx")
                End If

            End If
        Next
    End Sub
End Class

End Namespace
