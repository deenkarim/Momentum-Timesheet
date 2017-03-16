<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.AddUser" CodeFile="AddUser.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>AddUser</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:button id="btnAdd" style="Z-INDEX: 121; LEFT: 128px; POSITION: absolute; TOP: 272px" tabIndex="7"
				runat="server" BackColor="LightSteelBlue" Width="72px" ForeColor="Black" Text="OK" Font-Names="Tahoma"
				Font-Size="11px"></asp:button><asp:button id="btnEdit" style="Z-INDEX: 126; LEFT: 320px; POSITION: absolute; TOP: 176px" tabIndex="8"
				runat="server" BackColor="LightSteelBlue" Width="50px" ForeColor="Black" Text="Edit" Font-Names="Tahoma" Font-Size="11px"></asp:button><asp:label id="lblError" style="Z-INDEX: 125; LEFT: 378px; POSITION: absolute; TOP: 180px"
				runat="server" ForeColor="Red" Font-Names="Tahoma" Font-Size="8pt"></asp:label><asp:button id="btnAddDept" style="Z-INDEX: 123; LEFT: 264px; POSITION: absolute; TOP: 176px"
				tabIndex="8" runat="server" BackColor="LightSteelBlue" Width="50px" ForeColor="Black" Text="Add" Font-Names="Tahoma" Font-Size="11px"></asp:button><asp:button id="btnCancel" style="Z-INDEX: 122; LEFT: 208px; POSITION: absolute; TOP: 272px"
				tabIndex="8" runat="server" BackColor="LightSteelBlue" Width="50px" ForeColor="Black" Text="Cancel" Font-Names="Tahoma" Font-Size="11px"></asp:button><asp:label id="lblPassword" style="Z-INDEX: 120; LEFT: 296px; POSITION: absolute; TOP: 152px"
				runat="server" ForeColor="Red" Font-Names="Tahoma" Font-Size="8pt" Visible="False">Password does not match</asp:label><asp:label id="Label3" style="Z-INDEX: 118; LEFT: 32px; POSITION: absolute; TOP: 176px" runat="server"
				Font-Names="Tahoma" Font-Size="8pt">Department:</asp:label><asp:checkbox id="chkAdmin" style="Z-INDEX: 116; LEFT: 128px; POSITION: absolute; TOP: 240px"
				tabIndex="6" runat="server" Text="Administrator" Font-Names="Tahoma" Font-Size="8pt"></asp:checkbox><asp:label id="lblRequiredVerifyPassword" style="Z-INDEX: 114; LEFT: 296px; POSITION: absolute; TOP: 152px"
				runat="server" ForeColor="Red" Font-Names="Tahoma" Font-Size="8pt" Visible="False">Required</asp:label><asp:label id="Label9" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 128px" runat="server"
				Font-Names="Tahoma" Font-Size="8pt">Password:</asp:label><asp:textbox id="txtPassword" style="Z-INDEX: 108; LEFT: 128px; POSITION: absolute; TOP: 128px"
				tabIndex="4" runat="server" Width="128px" Font-Names="Tahoma" Font-Size="8pt" TextMode="Password"></asp:textbox><asp:label id="lblRequiredPassword" style="Z-INDEX: 113; LEFT: 296px; POSITION: absolute; TOP: 128px"
				runat="server" ForeColor="Red" Font-Names="Tahoma" Font-Size="8pt" Visible="False">Required</asp:label><asp:label id="Label7" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 104px" runat="server"
				Font-Names="Tahoma" Font-Size="8pt">Job Title:</asp:label><asp:textbox id="txtJobTitle" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 104px"
				tabIndex="3" runat="server" Width="160px" Font-Names="Tahoma" Font-Size="8pt"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 152px" runat="server"
				Font-Names="Tahoma" Font-Size="8pt">Verify Password:</asp:label><asp:textbox id="txtFullName" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 80px"
				tabIndex="2" runat="server" Width="160px" Font-Names="Tahoma" Font-Size="8pt"></asp:textbox><asp:label id="lblRequiredFullName" style="Z-INDEX: 112; LEFT: 296px; POSITION: absolute; TOP: 80px"
				runat="server" ForeColor="Red" Font-Names="Tahoma" Font-Size="8pt" Visible="False">Required</asp:label><asp:textbox id="txtUserName" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 56px"
				tabIndex="1" runat="server" Width="160px" Font-Names="Tahoma" Font-Size="8pt" DESIGNTIMEDRAGDROP="76"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Names="Tahoma" Font-Size="8pt">Full Name:</asp:label><asp:label id="lblRequiredUserName" style="Z-INDEX: 111; LEFT: 296px; POSITION: absolute; TOP: 56px"
				runat="server" ForeColor="Red" Font-Names="Tahoma" Font-Size="8pt" Visible="False">Required</asp:label><asp:label id="Label4" style="Z-INDEX: 110; LEFT: 16px; POSITION: absolute; TOP: 24px" runat="server"
				Width="88px" Font-Names="Tahoma" Font-Size="8pt" Font-Underline="True" Font-Bold="True">Add User</asp:label><asp:textbox id="txtVerifyPass" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 152px"
				tabIndex="5" runat="server" Width="128px" Font-Names="Tahoma" Font-Size="8pt" TextMode="Password"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 100; LEFT: 32px; POSITION: absolute; TOP: 56px" runat="server"
				Font-Names="Tahoma" Font-Size="8pt">User Name:</asp:label><asp:checkbox id="chkUser" style="Z-INDEX: 115; LEFT: 128px; POSITION: absolute; TOP: 208px" tabIndex="7"
				runat="server" Text="User" Font-Names="Tahoma" Font-Size="8pt" Enabled="False" Checked="True"></asp:checkbox><asp:dropdownlist id="ddlDept" style="Z-INDEX: 117; LEFT: 128px; POSITION: absolute; TOP: 176px" runat="server"
				Width="128px" Font-Names="Tahoma" Font-Size="8pt"></asp:dropdownlist>
			<asp:CompareValidator id="ComparePass" style="Z-INDEX: 119; LEFT: 296px; POSITION: absolute; TOP: 152px"
				runat="server" Font-Names="Tahoma" Font-Size="8pt" ErrorMessage="Password does not match" ControlToCompare="txtPassword"
				ControlToValidate="txtVerifyPass"></asp:CompareValidator></form>
	</body>
</HTML>
