<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="Marina.Ass1.App.Controls.Registration" %>
<br />
<h3>Registration </h3>
<p>&nbsp;</p>

 <table class="table">
   <tr>
      <td style="width:150px"> First Name</td>
        <td>
            <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
             ErrorMessage="First name is required" ForeColor="Red" ControlToValidate="uxFirstName">
             *</asp:RequiredFieldValidator>
        </td>
   </tr>

    <tr>
        <td> Last Name</td>
        <td>
            <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
             ErrorMessage="Last name is required" ForeColor="Red" ControlToValidate="uxLastName">
             *</asp:RequiredFieldValidator>
        </td>
   </tr>

   <tr>
      <td>Phone</td>
      <td>
          <asp:TextBox ID="uxPhone" runat="server"></asp:TextBox>
      </td>
      <td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
           ErrorMessage="Phone number is required" ForeColor="Red" ControlToValidate="uxPhone">
           *</asp:RequiredFieldValidator>
      </td>
  </tr>
  <tr>
      <td>City</td>
      <td>
          <asp:TextBox ID="uxCity" runat="server"></asp:TextBox>
      </td>
      <td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
           ErrorMessage="City is required" ForeColor="Red" ControlToValidate="uxCity">
           *</asp:RequiredFieldValidator>
      </td>
  </tr>

  <tr>
      <td  colspan ="2"> 
         <asp:Button ID="uxSubmit" runat="server" Text="Submit" OnClick="uxSubmit_Click" />
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
      </td>
  </tr>
</table>
        
                
   