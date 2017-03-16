<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.EditDept" CodeFile="EditDept.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>EditDept</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Button id="btnAdd" style="Z-INDEX: 125; LEFT: 128px; POSITION: absolute; TOP: 80px" tabIndex="7"
				runat="server" Font-Size="11px" Font-Names="Tahoma" Text="OK" ForeColor="Black" Width="72px"
				BackColor="LightSteelBlue"></asp:Button>
			<asp:Button id="btnCancel" style="Z-INDEX: 122; LEFT: 208px; POSITION: absolute; TOP: 80px"
				tabIndex="8" runat="server" Font-Size="11px" Font-Names="Tahoma" Text="Cancel" ForeColor="Black"
				Width="50px" BackColor="LightSteelBlue"></asp:Button>
			<asp:textbox id="txtDept" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 56px" tabIndex="1"
				runat="server" Font-Size="8pt" Font-Names="Tahoma" Width="144px" DESIGNTIMEDRAGDROP="76"></asp:textbox>
			<asp:label id="lblRequired" style="Z-INDEX: 111; LEFT: 288px; POSITION: absolute; TOP: 56px"
				runat="server" Font-Size="8pt" Font-Names="Tahoma" ForeColor="Red" Visible="False">Required</asp:label>
			<asp:label id="Label4" style="Z-INDEX: 110; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server"
				Font-Size="8pt" Font-Names="Tahoma" Width="136px" Font-Bold="True" Font-Underline="True">Edit Department</asp:label>
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 32px; POSITION: absolute; TOP: 56px" runat="server"
				Font-Size="8pt" Font-Names="Tahoma">Department:</asp:label>
		</form>
	</body>
</HTML>
