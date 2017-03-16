Namespace MSLTimesheet

Partial Class TimeSheetCRV
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
            LoadRPT()
        End If
    End Sub
    Sub LoadRPT()
        Try
            Dim rpt As New mslts_rpt

            Dim logon As New CrystalDecisions.Shared.TableLogOnInfo
            Dim i As Integer
            Dim da As New DataAccess
            Dim sTemp As String = da.ConnectStr()

            For i = 0 To rpt.Database.Tables.Count - 1
                logon.ConnectionInfo.ServerName = da.Server
                logon.ConnectionInfo.DatabaseName = da.Database
                logon.ConnectionInfo.UserID = da.Username
                logon.ConnectionInfo.Password = da.Password
                rpt.Database.Tables.Item(i).ApplyLogOnInfo(logon)
            Next i

            Me.CRV.ReportSource = rpt
            Me.DataBind()


        Catch ex As Exception

        End Try
    End Sub
End Class

End Namespace
