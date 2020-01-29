<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourDetailsPage.aspx.cs" Inherits="TouristHelp.TourDetailsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <style>
            .button {
                background-color: #4CAF50; /* Green */
                border: none;
                color: white;
                padding: 15px 32px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 16px;
            }
        </style>
    </header>
    <form id="form1" runat="server">

        <div class="col-lg-12">
            <h2>Tours Title</h2>
            <asp:Label Font-Size="15" ID="tourguidetitleLabel" CssClass="col-2" runat="server" Text="Title:"></asp:Label>
            <asp:Label ID="tourguideidLabel" Visible="false" CssClass="col-2" runat="server" Text="Tour Guide Id:"></asp:Label>
            <asp:Label ID="useridLabel" Visible="false" CssClass="col-2" runat="server" Text="User Id:"></asp:Label>
            <br />
            <br />
            <br />
            <h2>Tour Description</h2>
            <asp:Label Font-Size="12" ID="tourdescriptionLabel" CssClass="col-2" runat="server" Text=""></asp:Label>

        </div>
        <br />
        <br />
        <br />

        <div class="col-lg-12">
            <h2>Tour Details</h2>

            <asp:Label Font-Size="12" ID="tourdetailsLabel" CssClass="col-2" runat="server" Text=""></asp:Label>

        </div>

        <br />
        <br />
        <br />
        <div class="col-lg-12">

            <h2>Book this tour</h2>
        </div>

        <div class="col-lg-12">
            <b>Tour Price</b>

            <asp:Label Font-Size="12" ID="tourpriceLabel" CssClass="col-2" runat="server" Text=""></asp:Label>



        </div>
        <asp:Button ID="BtnConfirm" runat="server" CssClass="btn btn-default" Style="float: right" Text="Confirm Booking" OnClick="BtnConfirm_Click" />
    </form>

</asp:Content>
