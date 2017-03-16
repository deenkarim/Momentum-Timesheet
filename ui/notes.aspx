<%@ Page Language="vb" AutoEventWireup="false" Inherits="MSLTimesheet.Migrated_Notes" CodeFile="Notes.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Notes</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="dgNotes" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 200px" runat="server"
				AutoGenerateColumns="False" ShowHeader="False" ForeColor="Navy" BackColor="Beige" Font-Size="11px"
				Font-Names="Verdana" GridLines="Horizontal" Width="260px">
				<ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
				<FooterStyle HorizontalAlign="Center" VerticalAlign="Top"></FooterStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="TSID" ReadOnly="True"></asp:BoundColumn>
					<asp:TemplateColumn>
						<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<asp:Label id=Label2 runat="server" Width="80px" text='<%# DataBinder.Eval(Container.DataItem, "NoteDate", "{0:d}") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn>
						<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<asp:Label id="lblSubject" runat="server" text='<%#Container.DataItem("NoteSubject")%>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn>
						<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<TABLE width="40%">
								<TR>
									<TD>
										<asp:textbox id=txtNote runat="server" BackColor="FloralWhite" Font-Size="11px" Font-Names="Tahoma" TextMode="MultiLine" Height="30px" text='<%#Container.DataItem("Notes")%>'>
										</asp:textbox></TD>
								</TR>
							</TABLE>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:datagrid><asp:dropdownlist id="ddlNoteSubject" style="Z-INDEX: 109; LEFT: 104px; POSITION: absolute; TOP: 40px"
				tabIndex="1" runat="server" Font-Size="8pt" Font-Names="Tahoma" Width="184px"></asp:dropdownlist><asp:label id="Label3" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Size="11px" Font-Names="Verdana" Width="96px">Note Subject:</asp:label><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Size="11px" Font-Names="Verdana" Width="40px">Date:</asp:label><asp:button id="cmdAdd" style="Z-INDEX: 101; LEFT: 248px; POSITION: absolute; TOP: 160px" tabIndex="3"
				runat="server" Font-Size="11px" Font-Names="Verdana" Width="41px" Text="Add"></asp:button><asp:textbox id="txtNotes" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Font-Size="11px" Font-Names="Verdana" Width="280px" TextMode="MultiLine" Height="64px"></asp:textbox><asp:label id="lblComment" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Size="11px" Font-Names="Verdana" Width="128px">Add Note:</asp:label><asp:label id="lblRequired" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 160px"
				runat="server" ForeColor="Red" Font-Size="11px" Font-Names="Verdana" Width="144px"></asp:label><asp:label id="lblDate" style="Z-INDEX: 107; LEFT: 48px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Size="11px" Font-Names="Tahoma"></asp:label></form>
	</body>
</HTML>
