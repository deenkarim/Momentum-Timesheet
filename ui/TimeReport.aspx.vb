Namespace MSLTimesheet

Partial Class TimeReport
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
        If Not IsPostBack Then
            GetAll()
        End If
    End Sub


    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Response.Redirect("TimeSheet.aspx")
    End Sub

    Friend Function GetAll()
        Dim t As New TimeData
        Dim ds As DataSet
        Dim RowsFound As String

        Dim UserID As Integer = Session("UserID3")
        If UserID = 0 Then
            ds = t.GetAlLTime()
        Else
            ds = t.GetAlLTimeByID(UserID)
        End If

        dgTimeReport.DataSource = ds
        RowsFound = ds.Tables(0).Rows.Count.ToString
        dgTimeReport.Columns(1).FooterText = RowsFound & " record(s) found"
        dgTimeReport.DataBind()
    End Function

 
    Protected Sub dgTimeReport_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgTimeReport.ItemDataBound
        Dim da As New DataAccess
        Dim objItem As DataGridItem

        Dim DetailID As Integer

        For Each objItem In Me.dgTimeReport.Items

            ' Ignore invalid items
            If objItem.ItemType <> ListItemType.Header And _
                objItem.ItemType <> ListItemType.Footer And _
                objItem.ItemType <> ListItemType.Pager Then

                ' Retrieve the value of the check box
                Dim GetDay As String

                getday = CType(objItem.Cells(1).FindControl("lblDate2"), Label).Text

                If GetDay = "Sunday" Then
                    objItem.BackColor = System.Drawing.Color.CornflowerBlue
                    objItem.ForeColor = System.Drawing.Color.WhiteSmoke
                Else
                    objItem.ForeColor = System.Drawing.Color.DimGray
                End If
            End If
        Next
    End Sub
End Class

End Namespace
