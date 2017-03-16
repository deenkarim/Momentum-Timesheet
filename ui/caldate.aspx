<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.CalDate" CodeFile="CalDate.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CalDate</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" id="control" runat="server" NAME="control">
			<asp:Calendar id="calDate1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="200px" Height="80px" BorderStyle="None" BorderColor="Transparent" Font-Names="Tahoma"
				Font-Size="11px" ShowGridLines="True">
				<DayStyle BackColor="GhostWhite"></DayStyle>
				<DayHeaderStyle Font-Bold="True" ForeColor="Black" BackColor="Gainsboro"></DayHeaderStyle>
				<SelectedDayStyle BackColor="Orange"></SelectedDayStyle>
				<TitleStyle Font-Bold="True" ForeColor="HighlightText" BackColor="LightSteelBlue"></TitleStyle>
			</asp:Calendar>
		</form>
	</body>
</HTML>
