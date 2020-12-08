<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SelectASlip.ascx.cs" Inherits="Marina.Ass1.App.Controls.SelectASlip" %>
<asp:DropDownList ID="uxDocks" runat="server" AutoPostBack="True" Height="50px" Width="300px" OnSelectedIndexChanged="uxDocks_SelectedIndexChanged"></asp:DropDownList>
<br />
<br />

<asp:GridView ID="uxAvailableSlips" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="630px"
    OnSelectedIndexChanged="uxAvailableSlips_SelectedIndexChanged" ShowHeaderWhenEmpty="True"  >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
<p>Click on the submit button to lease selected slip</p>
<asp:Button ID="uxSubmit" runat="server" Text="Submit" OnClick="uxSubmit_Click" />
<br />
<br />
     <h3>Leased Slips</h3>
    <p>These are your leased slips</p>
    
<asp:GridView ID="uxLeasedSlips" runat="server" CellPadding="4" Enabled="False" ForeColor="#333333" 
    GridLines="None" Width="630px" ShowHeaderWhenEmpty="True" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
       
    

 