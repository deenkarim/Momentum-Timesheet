<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.login" CodeFile="login.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>login</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="txtUserName" style="Z-INDEX: 104; LEFT: 264px; POSITION: absolute; TOP: 64px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" EnableViewState="False"></asp:textbox><asp:textbox id="txtPassword" style="Z-INDEX: 106; LEFT: 264px; POSITION: absolute; TOP: 96px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" EnableViewState="False" TextMode="Password"></asp:textbox><asp:label id="lblPass" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Names="Tahoma" Font-Size="11px">Password:</asp:label><asp:button id="btnLogin" style="Z-INDEX: 102; LEFT: 264px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ForeColor="Black" BackColor="LightSteelBlue" Text="Login" Font-Bold="True"></asp:button><asp:label id="lblUser" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 64px" runat="server"
				Font-Names="Tahoma" Font-Size="11px">User Name:</asp:label><asp:label id="lblLoginMessage" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 168px"
				runat="server" Font-Names="Tahoma" Font-Size="8pt" Height="24px" Width="288px" EnableViewState="False" ForeColor="Red"></asp:label><IMG style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 24px" alt="" src="ui/MSL.jpg"
				width="120" height="148">
			<asp:Label id="Label1" style="Z-INDEX: 108; LEFT: 176px; POSITION: absolute; TOP: 16px" runat="server"
				Width="344px" Height="24px" Font-Size="20px" Font-Names="Tahoma">Momentum Services Ltd - Time Sheet</asp:Label></form>
	</body>
</HTML>
