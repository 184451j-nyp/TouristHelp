<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SendMailToTourGuide.aspx.cs" Inherits="TouristHelp.SendMailToTourGuide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form" runat="server">
        <asp:Label runat="server">Send To:</asp:Label>
        <asp:TextBox ID="txtTo" runat="server" CssClass="col-1"></asp:TextBox>

        <asp:Label runat="server">Subject:</asp:Label>
        <asp:TextBox ID="txtSub" runat="server" CssClass="col-1"></asp:TextBox>

        <asp:Label runat="server">Body:</asp:Label>
        <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" CssClass="col-1"></asp:TextBox>


        <asp:Button ID="Sendbtn" runat="server" CssClass="col-1" Text="Send Mail" OnClick="Sendbtn_Click" />
    </form>
</asp:Content>

