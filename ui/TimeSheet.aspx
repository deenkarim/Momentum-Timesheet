<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.TimeSheet" CodeFile="TimeSheet.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>TimeSheet</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	
</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="lblUserName" style="Z-INDEX: 100; LEFT: 72px; POSITION: absolute; TOP: 8px"
				runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:label>
			<asp:label id="lblError2" style="Z-INDEX: 128; LEFT: 8px; POSITION: absolute; TOP: 352px" runat="server"
				Font-Size="14px" Font-Names="Tahoma" Width="304px" ForeColor="Red" Height="8px"></asp:label><asp:regularexpressionvalidator id="REVEndTime2" style="Z-INDEX: 124; LEFT: 464px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtEndTime" ValidationExpression="\S{0,5}" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="REVEndLunch2" style="Z-INDEX: 123; LEFT: 352px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtEndLunch" ValidationExpression="\S{0,5}" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="REVStartLunch2" style="Z-INDEX: 122; LEFT: 240px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtStartLunch" ValidationExpression="\S{0,5}" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="REVStartTime2" style="Z-INDEX: 121; LEFT: 133px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtStartTime" ValidationExpression="\S{0,5}" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="REVEndTime" style="Z-INDEX: 120; LEFT: 464px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtEndTime" ValidationExpression="^(([0-9])|([0-1][0-9])|([2][0-3])):(([0-9])|([0-5][0-9]))$" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="REVEndLunch" style="Z-INDEX: 119; LEFT: 352px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtEndLunch" ValidationExpression="^(([0-9])|([0-1][0-9])|([2][0-3])):(([0-9])|([0-5][0-9]))$" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="REVStartLunch" style="Z-INDEX: 118; LEFT: 240px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtStartLunch" ValidationExpression="^(([0-9])|([0-1][0-9])|([2][0-3])):(([0-9])|([0-5][0-9]))$" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><asp:button id="btnEdit" style="Z-INDEX: 116; LEFT: 508px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="Edit"></asp:button><asp:button id="btnDelete" style="Z-INDEX: 115; LEFT: 456px; POSITION: absolute; TOP: 184px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="Delete"></asp:button><asp:button id="btnUsers" style="Z-INDEX: 114; LEFT: 507px; POSITION: absolute; TOP: 32px" runat="server"
				Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="Users"></asp:button><asp:button id="btnViewAll" style="Z-INDEX: 113; LEFT: 404px; POSITION: absolute; TOP: 184px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="View All"></asp:button><asp:button id="btnClear" style="Z-INDEX: 112; LEFT: 509px; POSITION: absolute; TOP: 152px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="Clear"></asp:button><asp:label id="lblTimeGrid" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 184px"
				runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" Width="96px" Font-Underline="True" Height="16px">Last 5 entries:</asp:label>
			<TABLE id="Table1" style="Z-INDEX: 109; LEFT: 8px; WIDTH: 550px; POSITION: absolute; TOP: 96px; HEIGHT: 38px"
				cellSpacing="0" cellPadding="0" width="544" border="0">
				<TBODY>
					<TR>
						<TD style="FONT-SIZE: 11px; WIDTH: 110px; COLOR: buttontext; FONT-FAMILY: Tahoma; HEIGHT: 2px"
							align="center" bgColor="lightsteelblue" colSpan="1" rowSpan="1">Date</TD>
						<TD style="FONT-SIZE: 11px; WIDTH: 110px; COLOR: buttontext; FONT-FAMILY: Tahoma; HEIGHT: 2px"
							align="center" bgColor="lightsteelblue" colSpan="1" rowSpan="1">Start Time 
							(hh:mm)</TD>
						<TD style="FONT-SIZE: 11px; WIDTH: 110px; COLOR: buttontext; FONT-FAMILY: Tahoma; HEIGHT: 2px"
							align="center" bgColor="lightsteelblue" colSpan="1" rowSpan="1">Lunch (hh:mm)</TD>
						<TD style="FONT-SIZE: 11px; WIDTH: 110px; COLOR: buttontext; FONT-FAMILY: Tahoma; HEIGHT: 2px"
							align="center" bgColor="lightsteelblue" colSpan="1" rowSpan="1">End Lunch 
							(hh:mm)</TD>
						<TD style="FONT-SIZE: 11px; WIDTH: 110px; COLOR: buttontext; FONT-FAMILY: Tahoma; HEIGHT: 2px"
							align="center" bgColor="lightsteelblue" colSpan="1" rowSpan="1">End Time 
							(hh:mm)</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 110px" align="center" bgColor="ghostwhite"><asp:textbox id="txtDate" runat="server" Font-Names="Tahoma" Font-Size="11px" Width="80px"></asp:textbox>&nbsp;
						<A onclick="window.open('CalDate.aspx?textbox=txtDate','cal','width=215,height=160,left=150,top=150, toolbar=no, scrollbars=no')"
								href="javascript:;"><IMG src="datesmall.gif" border="0" id="IMG1" onclick="return IMG1_onclick()"></A>
						<TD style="WIDTH: 110px" align="center" bgColor="ghostwhite"><asp:textbox id="txtStartTime" runat="server" Font-Names="Tahoma" Font-Size="11px" Width="80px"></asp:textbox></TD>
						<TD style="WIDTH: 110px" align="center" bgColor="ghostwhite"><asp:textbox id="txtStartLunch" runat="server" Font-Names="Tahoma" Font-Size="11px" Width="80px"></asp:textbox></TD>
						<TD style="WIDTH: 110px" align="center" bgColor="ghostwhite"><asp:textbox id="txtEndLunch" runat="server" Font-Names="Tahoma" Font-Size="11px" Width="80px"></asp:textbox></TD>
						<TD style="WIDTH: 110px" align="center" bgColor="ghostwhite"><asp:textbox id="txtEndTime" runat="server" Font-Names="Tahoma" Font-Size="11px" Width="80px"></asp:textbox></TD>
					</TR>
				</TBODY>
			</TABLE>
			<asp:label id="Label2" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Names="Tahoma" Font-Size="11px">Job Title:</asp:label><asp:label id="Label1" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 24px" runat="server"
				Font-Names="Tahoma" Font-Size="11px">Department:</asp:label><asp:datagrid id="dgTimesheet" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 208px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" BackColor="WhiteSmoke" ForeColor="DimGray" Width="550px" Height="16px" GridLines="Horizontal" AutoGenerateColumns="False"
				OnItemDataBound="dgTimesheet_ItemDataBound">
				<HeaderStyle ForeColor="ControlText" BackColor="LightSteelBlue"></HeaderStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="TSID" HeaderText="TS ID"></asp:BoundColumn>
					<asp:TemplateColumn>
						<ItemTemplate>
							<asp:CheckBox id="chkSelect" runat="server"></asp:CheckBox>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Day">
						<ItemStyle Font-Bold="True"></ItemStyle>
						<ItemTemplate>
							<asp:Label id=lblDate2 runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TSDate", "{0:dddd}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Date">
						<ItemTemplate>
							<asp:Label id=lblDate runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TSDate", "{0:dd/MM/yyyy}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Start Time">
						<ItemTemplate>
							<asp:Label id=lblStartTime runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "StartTime", "{0:HH:mm}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Lunch">
						<ItemTemplate>
							<asp:Label id=lblStartLunch runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "StartLunch", "{0:HH:mm}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="End Lunch">
						<ItemTemplate>
							<asp:Label id=lblEndLunch runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EndLunch", "{0:HH:mm}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="End Time">
						<ItemTemplate>
							<asp:Label id=lblEndTime runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EndTime", "{0:HH:mm}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Total Hours">
						<ItemStyle Font-Italic="True" Font-Bold="True" ForeColor="Black" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<asp:Label id=lblTotalTime runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TotalHours") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:HyperLinkColumn Text="Notes" DataNavigateUrlField="TSID" DataNavigateUrlFormatString="javascript:var w =window.open('notes.aspx?id={0}',null,'width=350,height=400,top=150 left=150 scrollbars=yes location=no')"
						SortExpression="Comment" HeaderText="Notes"></asp:HyperLinkColumn>
				</Columns>
			</asp:datagrid><asp:label id="lblJobTitle" style="Z-INDEX: 102; LEFT: 72px; POSITION: absolute; TOP: 40px"
				runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:label><asp:label id="lblDept" style="Z-INDEX: 101; LEFT: 72px; POSITION: absolute; TOP: 24px" runat="server"
				Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:label><asp:button id="btnSignOut" style="Z-INDEX: 103; LEFT: 496px; POSITION: absolute; TOP: 8px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" BackColor="MediumSlateBlue" ForeColor="White" Text="Sign Out"></asp:button><asp:label id="lblUserWelcome" style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 8px"
				runat="server" Font-Names="Tahoma" Font-Size="11px">Welcome:</asp:label><asp:label id="lblAddDate" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" Width="144px" Font-Underline="True" Height="16px">Add Date:</asp:label><asp:button id="btnAdd" style="Z-INDEX: 111; LEFT: 456px; POSITION: absolute; TOP: 152px" runat="server"
				Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="Add"></asp:button><asp:regularexpressionvalidator id="REVStartTime" style="Z-INDEX: 117; LEFT: 133px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" ControlToValidate="txtStartTime" ValidationExpression="^(([0-9])|([0-1][0-9])|([2][0-3])):(([0-9])|([0-5][0-9]))$" ErrorMessage="Invalid Time Format"></asp:regularexpressionvalidator><A onclick="window.open('Help.aspx','Help','width=160,height=200,left=400,top=100, toolbar=no, scrollbars=no')"
				href="javascript:;"><IMG style="Z-INDEX: 125; LEFT: 563px; POSITION: absolute; TOP: 114px" alt="" src="help.gif"
					border="0"></A>
			<asp:label id="lblError" style="Z-INDEX: 126; LEFT: 16px; POSITION: absolute; TOP: 136px" runat="server"
				Font-Names="Tahoma" Font-Size="11px" ForeColor="Red" Width="56px" Height="8px"></asp:label></form>
	</body>
</HTML>
