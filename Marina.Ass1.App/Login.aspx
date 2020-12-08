<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Marina.Ass1.App.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h3>Login</h3>
    <div class="col-md-4">
        <table class="table">

            <tr>
                <td style="width:150px">FirstName</td>
                <td>
                    <asp:TextBox ID="uxFirstname" runat="server"></asp:TextBox></td>
                <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="First name is required" ForeColor="Red" ControlToValidate="uxFirstName">
                        *</asp:RequiredFieldValidator>
               </td>
            </tr>

            <tr>
                <td>LastName</td>
                <td>
                    <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox></td>
                <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ErrorMessage="Last name is required" ForeColor="Red" ControlToValidate="uxLastName">
                            *</asp:RequiredFieldValidator>
               </td>
            </tr>  
            
            <tr>                
                <td class="2" >
                    <asp:Button ID="UxAuthenticate" runat="server" Text="Login" OnClick="UxAuthenticate_Click" /> </td>
            </tr>
            <tr>                
                <td colspan="2">
                    <asp:Label ID="uxError" runat="server" Text=""></asp:Label></td>
            </tr>

        </table>
    </div>

    <div>
        <h5>Not Registered yet? Click here</h5>
        <asp:Button ID="uxNotRegistered" runat="server" Text="Register" OnClick="uxNotRegistered_Click" />
    </div>
</asp:Content>
