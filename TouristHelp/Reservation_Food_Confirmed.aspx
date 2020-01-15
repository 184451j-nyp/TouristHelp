<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Reservation_Food_Confirmed.aspx.cs" Inherits="TouristHelp.Reservation_Food_Confirmed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center">
        <br /><br /><br /><br /><br />
        <h1 style="color: green">Reservation Confirmed</h1>
        <br />
        <asp:Label runat="server" ID="lbName"></asp:Label>
        <p>At:
            <asp:Label runat="server" ID="lbPlace"></asp:Label></p>
        <asp:Label runat="server" ID="lbDateTime"></asp:Label>
        <br />
        <asp:Label runat="server" ID="lbPax"></asp:Label>
    </div>
</asp:Content>
