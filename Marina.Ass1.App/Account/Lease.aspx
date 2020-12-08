<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lease.aspx.cs" Inherits="Marina.Ass1.App.Account.Enroll" %>

<%@ Register Src="~/Controls/SelectASlip.ascx" TagPrefix="uc1" TagName="SelectASlip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Lease a Slip</h3>
    <p>Select A Dock in the dropdown menu to see available slips for lease</p>
    <uc1:SelectASlip runat="server" ID="SelectASlip" />
</asp:Content>
