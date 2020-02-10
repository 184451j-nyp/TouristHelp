<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TouristHelp.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #welcomeBanner {
            height: 60vh;
            background-image: url('Images/splash.jpg');
            background-repeat: no-repeat;
            background-size: cover;
            background-position: center;
        }

        #welcomeText{
            color: black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="welcomeBanner" class="my-3">
        <p id="welcomeText" class="text-center pt-5 display-2">Welcome back,
            <asp:Label ID="LblName" runat="server" Text=""></asp:Label></p>
    </div>

    <div class="container">

    </div>
</asp:Content>