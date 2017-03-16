<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.Users1" CodeFile="Users.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Users</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="dgUsers" style="Z-INDEX: 100; LEFT: 8px; POSITION: absolute; TOP: 32px" runat="server"
				AutoGenerateColumns="False" GridLines="Horizontal" Height="16px" BackColor="White" ForeColor="DimGray"
				Width="544px" Font-Size="11px" Font-Names="Tahoma">
				<HeaderStyle ForeColor="ControlText" BackColor="LightSteelBlue"></HeaderStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="UserID" HeaderText="UserID"></asp:BoundColumn>
					<asp:TemplateColumn>
						<ItemTemplate>
							<asp:CheckBox id="chkSelect" tabIndex="5" runat="server"></asp:CheckBox>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="User Name">
						<ItemTemplate>
							<asp:Label id=lblUserName runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "UserName") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Full Name">
						<ItemTemplate>
							<asp:Label id=lblFullName runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FullName") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Job Title">
						<ItemTemplate>
							<asp:Label id=lblJobTitle runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "JobTitle") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="User">
						<ItemTemplate>
							<asp:CheckBox id=chkUser runat="server" Checked='<%# DataBinder.Eval(Container.DataItem, "UserFlag") %>' Enabled="False">
							</asp:CheckBox>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Admin">
						<ItemTemplate>
							<asp:CheckBox id=chkAdmin runat="server" Checked='<%# DataBinder.Eval(Container.DataItem, "AdminFlag") %>' Enabled="False">
							</asp:CheckBox>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Department">
						<ItemTemplate>
							<asp:Label id="lblDept" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "DeptName") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:datagrid><asp:button id="btnAdd" style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 8px" tabIndex="1"
				runat="server" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Font-Size="11px" Font-Names="Tahoma"
				Text="Add"></asp:button><asp:button id="btnDelete" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 8px" tabIndex="3"
				runat="server" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Font-Size="11px" Font-Names="Tahoma" Text="Delete"></asp:button><asp:button id="btnEdit" style="Z-INDEX: 102; LEFT: 60px; POSITION: absolute; TOP: 8px" tabIndex="2"
				runat="server" BackColor="LightSteelBlue" ForeColor="Black" Width="50px" Font-Size="11px" Font-Names="Tahoma" Text="Edit"></asp:button><asp:button id="btnBack" style="Z-INDEX: 101; LEFT: 504px; POSITION: absolute; TOP: 8px" tabIndex="4"
				runat="server" Font-Names="Tahoma" Font-Size="11px" Width="50px" ForeColor="Black" BackColor="LightSteelBlue" Text="Back"></asp:button></form>
	</body>
</HTML>
