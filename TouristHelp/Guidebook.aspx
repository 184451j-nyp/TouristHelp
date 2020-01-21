﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Guidebook.aspx.cs" Inherits="TouristHelp.Guidebook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero-wrap js-fullheight" style="background-image: url(&quot;images/bg_1.jpg&quot;); height: 549px;">
        <div class="overlay"></div>
        <div class="container">
            <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center" data-scrollax-parent="true" style="height: 549px;">
                <div class="col-md-9 text-center ftco-animate fadeInUp ftco-animated" data-scrollax=" properties: { translateY: '70%' }" style="transform: translateZ(0px) translateY(25.5009%);">
                    <p class="breadcrumbs" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }" style="opacity: 0.417122; transform: translateZ(0px) translateY(10.929%);"><span class="mr-2"><a href="Main.html">Home</a></span> <span>Places</span></p>
                    <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }" style="opacity: 0.417122; transform: translateZ(0px) translateY(10.929%);">Guidebook</h1>
                </div>
            </div>
        </div>
    </div>
    <form runat="server">
        <div class="col-sm col-md-6 col-lg-4 ftco-animate fadeInUp ftco-animated">
            <div class="destination">
                <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                    <div class="icon d-flex justify-content-center align-items-center">
                        <span class="icon-link"></span>
                    </div>
                </a>
                <div class="text p-3">
                    <div class="d-flex">
                        <div class="one">
                            <h3><a href="#">Singapore Zoo</a></h3>
                        </div>
                        <div class="two">
                            <div class="price">$31.20</div>
                        </div>
                    </div>
                    <p>Discover the world's best rainforest zoo</p>
                    <p class="days"><span></span></p>
                    <hr>
                    <p class="bottom-area d-flex">
                        <span><i class="icon-map-o"></i>80 Mandai Lake Rd</span>
                        <asp:Button ID="BtnAction" runat="server" CssClass="btn btn-default" Text="More info" OnClick="BtnAction_Click" /> <%-- temporary button rename later --%>
                    </p>
                </div>
            </div>
        </div>

        <div class="col-sm col-md-6 col-lg-4 ftco-animate fadeInUp ftco-animated">
            <div class="destination">
                <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                    <div class="icon d-flex justify-content-center align-items-center">
                        <span class="icon-link"></span>
                    </div>
                </a>
                <div class="text p-3">
                    <div class="d-flex">
                        <div class="one">
                            <h3><a href="#">Ding Tai Fung</a></h3>
                        </div>
                        <div class="two">
                            <div class="price">$31.20</div>
                        </div>
                    </div>
                    <p>Enjoy good Chinese food like our award winning fried rice</p>
                    <p class="days"><span>forever</span></p>
                    <hr>
                    <p class="bottom-area d-flex">
                        <span><i class="icon-map-o"></i>Various outlets</span>
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="More info" OnClick="BtnAction_Click" /> <%-- temporary button rename later --%>
                    </p>
                </div>
            </div>
        </div>

    </form>
</asp:Content>
