<%@ Page Title="Available Slips" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvailableSlips.aspx.cs" Inherits="Marina.Ass1.App.About" %>

<%@ Register Src="~/Controls/SlipSelector.ascx" TagPrefix="uc1" TagName="SlipSelector" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--<h2><%: Title %>.</h2>--%>
    <br />
    <h3>List of Available Slips for Lease by Dock</h3>
    <p>Select a dock in the dropdown menu to view slips</p>
    <uc1:SlipSelector runat="server" id="SlipSelector" />
    <br />
    <asp:Button ID="uxLeaseASlip" runat="server" OnClick="uxLeaseASlip_Click" Text="Lease A Slip" />
</asp:Content>
