Namespace MSLTimesheet

Partial Class CalDate
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
        control.Value = Request.QueryString("textbox").ToString()
    End Sub

    Private Sub calDate1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDate1.SelectionChanged
        Dim strScript As String = "<script>window.opener.document.forms(0)." + control.Value + ".value = '"
        strScript += calDate1.SelectedDate.ToString("dd/MM/yyyy")
        strScript += "';self.close()"
        strScript += "</" + "script>"
        RegisterClientScriptBlock("anything", strScript)
    End Sub

    Private Sub calDate1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles calDate1.DayRender
        If e.Day.Date = DateTime.Now.ToString("d") Then
            e.Cell.BackColor = System.Drawing.Color.LightGray
        End If
    End Sub
End Class

End Namespace
