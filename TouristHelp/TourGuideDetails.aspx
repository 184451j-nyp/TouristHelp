<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuideDetails.aspx.cs" Inherits="TouristHelp.TourGuideDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form" runat="server">





        <div class="row">
            <asp:Label ID="tourguidenameLabel" CssClass="col-1" runat="server" Text="Name:"></asp:Label>
            <asp:Label ID="tourguidenameLabel2" CssClass="col-1" runat="server"></asp:Label>

            <asp:Label ID="tourguidedescriptionLabel" CssClass="col-1" runat="server" Text="Description:"></asp:Label>
            <asp:Label ID="tourguidedescriptionLabel2" CssClass="col-1" runat="server"></asp:Label>

            <asp:Label ID="tourguidelanguagesLabel" CssClass="col-1" runat="server" Text="Languages:"></asp:Label>
            <asp:Label ID="tourguidelanguagesLabel2" CssClass="col-1" runat="server"></asp:Label>








        </div>

        <asp:Button ID="ButtonRedirect"
            Text="View Tours"
            OnClick="RedirectBtn_Click"
            runat="server" />
    </form>

    <style>
        div.menu ul li {
            display: inline-block;
            height: 100%;
            padding: 0 1rem;
            text-align: center;
        }

        div.menu a {
            text-decoration: none;
            position: relative;
            top: 50%;
            margin-top: 100px;
            transform: translateY(-50%);
            display: inline-block;
            vertical-align: middle;
            line-height: normal;
        }




        div.position {
            width: 200px;
            text-align: right;
        }

        .form-group {
            display: inline-block;
            margin-right: 10px;
            float: left;
        }

            .form-group label {
                display: block;
            }


        div.row {
            margin-top: 30px;
        }
    </style>


</asp:Content>
