Imports System.Web.Security


Namespace MSLTimesheet

Partial Class TimeSheet
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
            btnSignOut.Attributes.Add("onclick", "return confirm('Are you sure you want to Logout?');")
            btnDelete.Attributes.Add("onclick", "return confirm('Are you sure you want to delete?');")
            LoadUserDetail()
            CheckAdmin()
            GetTop5()
        End If
        SetWebFolder()
    End Sub
    Sub SetWebFolder()
        Dim data As New DataAccess
        ' Set path of Webfolder
        data.WebFolder = Server.MapPath("")
    End Sub
    Sub CheckAdmin()
        'Check if user has Admin rights
        If Session("AdminFlag") = "1" Then
            ButtonsVisible(True)
        Else
            ButtonsVisible(False)
        End If
    End Sub
    Sub ButtonsVisible(ByVal Flag As Boolean)
        'Make buttons visable if user has Admin rights
        Me.btnUsers.Visible = Flag
    End Sub
    Sub LoadUserDetail()
        'Get UserDetails and populate controls on form
        Dim U As New Users
        Dim dsUserDetails As DataSet
        'Populate controls and session variables

        dsUserDetails = U.GetUserDetails(Session("UserID"))
        With dsUserDetails.Tables(0).Rows(0)
            lblUserName.Text = .Item("UserName")
            lblDept.Text = .Item("DeptName")
            lblJobTitle.Text = .Item("JobTitle")
        End With
        dsUserDetails = Nothing
    End Sub

    Sub GetTop5()
        'Populate TimeSheet DataGrid With Users Timedata
        Dim t As New TimeData
        Dim dsTime As DataSet
        Dim RowsFound As String

        Dim UserID As Integer = Session("UserID")
        If UserID = 0 Then
            dsTime = t.GetTop5()
        Else
            dsTime = t.GetTop5ByUserID(UserID)
        End If

        dgTimesheet.DataSource = dsTime
        dgTimesheet.DataBind()
    End Sub
    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        'Log out of user session

        FormsAuthentication.SignOut()
        Response.Redirect("ui/TimeSheet.aspx")
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clears all the input boxes
        txtDate.Text = ""
        txtStartTime.Text = ""
        txtStartLunch.Text = ""
        txtEndLunch.Text = ""
        txtEndTime.Text = ""
        If btnAdd.Text = "Update" Then
            lblAddDate.Text = "Add Date:"
            btnAdd.Text = "Add"
        End If
    End Sub
    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        'Go to Users page
        Response.Redirect("Users.aspx")
    End Sub
    Private Sub btnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAll.Click
        'Go to Time Report page
        Response.Redirect("TimeReport.aspx")
    End Sub

    Sub dgTimesheet_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgTimesheet.ItemDataBound
        Dim da As New DataAccess
        Dim objItem As DataGridItem

        Dim DetailID As Integer

        For Each objItem In Me.dgTimesheet.Items

            ' Ignore invalid items
            If objItem.ItemType <> ListItemType.Header And _
                objItem.ItemType <> ListItemType.Footer And _
                objItem.ItemType <> ListItemType.Pager Then

                ' Retrieve the value of the check box
                Dim GetDay As String

                GetDay = CType(objItem.Cells(1).FindControl("lblDate2"), Label).Text
                'Sets colours if Sunday exists
                If GetDay = "Sunday" Then
                    objItem.BackColor = System.Drawing.Color.CornflowerBlue
                    objItem.ForeColor = System.Drawing.Color.WhiteSmoke
                Else
                    objItem.ForeColor = System.Drawing.Color.DimGray
                End If
            End If
        Next
    End Sub

    Function TotalHours() As Decimal
        'Declares variables to be calculated
        Dim StartTime As DateTime = CType(txtStartTime.Text, DateTime).ToString("HH:mm")
        Dim EndTime As DateTime = CType(txtEndTime.Text, DateTime).ToString("HH:mm")
        Dim GetTotalDifference As TimeSpan = EndTime.Subtract(StartTime)
        Dim Total As Decimal = GetTotalDifference.TotalHours

        'Declaures variables which will be subtracted
        Dim StartLunch As DateTime = CType(txtStartLunch.Text, DateTime).ToString("HH:mm")
        Dim EndLunch As DateTime = CType(txtEndLunch.Text, DateTime).ToString("HH:mm")
        Dim GetTotalLunchDifference As TimeSpan = EndLunch.Subtract(StartLunch)
        Dim TotalLunch As Decimal = GetTotalLunchDifference.TotalHours

        'Calculates TotalHours
        Dim CompleteTotal As Decimal = Total - TotalLunch
        Return CompleteTotal
    End Function
    Function CheckTimes() As Boolean
        If txtStartTime.Text = txtEndTime.Text Then
            CheckTimes = True
        Else
            CheckTimes = False
        End If
        Return CheckTimes
    End Function
    Function NoTimes() As Boolean
        If txtStartTime.Text.Length = 0 Then
            NoTimes = True
        Else
            NoTimes = False
        End If
        Return NoTimes
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If NoTimes() = True Then
            Response.Redirect("TimeSheet.aspx")
        End If

        If CheckTimes() = True Then
            Response.Redirect("TimeSheet.aspx")
        End If

        'Checks whether To insert Time or Update a time
        Try
            If btnAdd.Text = "Add" Then
                TimeDataInsert()
                lblAddDate.Text = "Add Date:"
            ElseIf btnAdd.Text = "Update" Then
                TimeDataUpdate()
                lblAddDate.Text = "Update Date:"
            End If
        Catch ex As SqlClient.SqlException
            If ex.Number = 242 Then
                lblError2.Text = "Error: 242  = Invalid Date"
            End If
        End Try
    End Sub

    Sub TimeDataInsert()
        'Inserts Time into tblTimeSheet
        Dim t As New TimeData
        t.InsertTime(Format(txtDate.Text, "Long Date"), txtStartTime.Text, txtStartLunch.Text, txtEndLunch.Text, txtEndTime.Text, Session("UserID"), TotalHours)
        Response.Redirect("TimeSheet.aspx")
    End Sub
    Sub TimeDataUpdate()
        'Updates a Time from tblTimeSheet
        Dim t As New TimeData
        t.UpdateTime(Session("TSID"), Format(txtDate.Text, "Long Date"), txtStartTime.Text, txtStartLunch.Text, txtEndLunch.Text, txtEndTime.Text, Session("UserID"), TotalHours)
        Response.Redirect("TimeSheet.aspx")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim t As New TimeData
        Dim objItem As DataGridItem
        Dim TSID As Integer

        For Each objItem In Me.dgTimesheet.Items

            ' Ignore invalid items
            If objItem.ItemType <> ListItemType.Header And _
                objItem.ItemType <> ListItemType.Footer And _
                objItem.ItemType <> ListItemType.Pager Then

                ' Retrieve the value of the check box
                Dim blnDelete As Boolean

                blnDelete = CType(objItem.Cells(1).FindControl("chkSelect"), CheckBox).Checked

                If blnDelete = True Then
                    TSID = objItem.Cells(0).Text
                    'Delets Selected TimeData
                    t.DeleteTime(TSID)
                End If
            End If
        Next

        GetTop5()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim da As New DataAccess
        Dim objItem As DataGridItem
        Dim DetailID As Integer

        For Each objItem In Me.dgTimesheet.Items

            ' Ignore invalid items
            If objItem.ItemType <> ListItemType.Header And _
                objItem.ItemType <> ListItemType.Footer And _
                objItem.ItemType <> ListItemType.Pager Then

                ' Retrieve the value of the check box
                Dim blnEdit As Boolean

                blnEdit = CType(objItem.Cells(1).FindControl("chkSelect"), CheckBox).Checked

                If blnEdit = True Then
                    Session("TSID") = objItem.Cells(0).Text
                    PopulateEditFields()
                    If Session("TSID") > 0 Then
                        btnAdd.Text = "Update"
                        lblAddDate.Text = "Update Date:"
                    Else
                    End If
                End If
            End If
        Next
    End Sub
    Sub PopulateEditFields()
        Dim t As New TimeData
        Dim ds As DataSet

        'Populate controls and session variables
        ds = t.GetAllDataByTSID(Session("TSID"))
        Me.txtDate.Text = ds.Tables(0).Rows(0).Item(1)
        Me.txtStartTime.Text = CType(ds.Tables(0).Rows(0).Item(2), DateTime).ToString("HH:mm")
        Me.txtStartLunch.Text = CType(ds.Tables(0).Rows(0).Item(3), DateTime).ToString("HH:mm")
        Me.txtEndLunch.Text = CType(ds.Tables(0).Rows(0).Item(4), DateTime).ToString("HH:mm")
        Me.txtEndTime.Text = CType(ds.Tables(0).Rows(0).Item(5), DateTime).ToString("HH:mm")
        ds = Nothing
    End Sub

End Class

End Namespace
