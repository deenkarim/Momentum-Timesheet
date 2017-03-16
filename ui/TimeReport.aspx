<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.TimeReport" CodeFile="TimeReport.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>TimeReport</title>
		<meta content="True" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="dgTimeReport" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 32px"
				runat="server" Font-Names="Tahoma" Font-Size="11px" BackColor="WhiteSmoke" Width="550px" Height="16px"
				GridLines="Horizontal" AutoGenerateColumns="False" ShowFooter="True" OnItemDataBound="dgTimeReport_ItemDataBound"
				PageSize="2">
				<HeaderStyle ForeColor="ControlText" BackColor="LightSteelBlue"></HeaderStyle>
				<FooterStyle Font-Bold="True" HorizontalAlign="Left" ForeColor="Black" VerticalAlign="Middle"
					BackColor="Gainsboro"></FooterStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="TSID" HeaderText="TS ID"></asp:BoundColumn>
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
					<asp:HyperLinkColumn Text="Notes" DataNavigateUrlField="TSID" DataNavigateUrlFormatString="javascript:var w =window.open('notes.aspx?id={0}',null,'width=300,height=300,top=150 left=150 scrollbars=yes location=no')"
						SortExpression="Comment" HeaderText="Notes"></asp:HyperLinkColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:datagrid>
			<asp:label id="lblTimeGrid" style="Z-INDEX: 103; LEFT: 10px; POSITION: absolute; TOP: 8px"
				runat="server" Height="16px" Width="96px" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True"
				Font-Underline="True">All entries:</asp:label><asp:button id="cmdBack" style="Z-INDEX: 102; LEFT: 508px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Names="Tahoma" Font-Size="11px" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Text="Back"></asp:button></form>
	</body>
</HTML>
