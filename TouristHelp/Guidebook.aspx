<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Guidebook.aspx.cs" Inherits="TouristHelp.Guidebook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:lightcyan">
        <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }" style="text-align: center; transform: translateZ(0px) translateY(10.929%);">Guidebook</h1>
    </div>

    <form runat="server">

        <div class="col-sm col-md-6 col-lg-4 ftco-animate fadeInUp ftco-animated" style="border-style: solid; border-width: 1px; margin-bottom: 10px">
            <%-- Proto Box --%>

            <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                <div class="icon d-flex justify-content-center align-items-center">
                    <span class="icon-link"></span>
                </div>
            </a>
            <div class="text p-3">

                <div class="one">
                    <h3><a href="#">Ding Tai Fung</a></h3>
                </div>
                <div class="two">
                    <span class="price">$31.20</span>
                </div>
                <div class="days"><span>No time limit</span></div>
                <h4>Enjoy good Chinese food like our award winning fried rice</h4>
                <hr>
                <p class="bottom-area d-flex">
                    <span><i class="icon-map-o"></i>Various outlets</span>
                    <asp:Button ID="Button2" runat="server" CssClass="btn btn-default" Text="More info" Style="float: right" OnClick="BtnAction_Click" />
                    <%-- temporary button rename later --%>
                </p>
            </div>

        </div>

        <div class="col-sm col-md-6 col-lg-4 ftco-animate fadeInUp ftco-animated" style="border-style: solid; border-width: 1px; margin-bottom: 10px">
            <div class="destination">
                <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                    <div class="icon d-flex justify-content-center align-items-center">
                        <span class="icon-link"></span>
                    </div>
                </a>
                <div class="text p-3">
                    <div class="d-flex">
                        <h3><a href="#">Singapore Zoo</a></h3>
                        <div class="two">
                            <p class="price">$31.20</p>
                        </div>
                    </div>
                    <p>Discover the world's best rainforest zoo</p>
                    <p class="days"><span></span></p>
                    <hr>
                    <p class="bottom-area d-flex">
                        <span><i class="icon-map-o"></i>80 Mandai Lake Rd</span>
                        <asp:Button ID="BtnAction" runat="server" CssClass="btn btn-default" Text="More info" OnClick="BtnAction_Click" />
                        <%-- temporary button rename later --%>
                    </p>
                </div>
            </div>
        </div>

        <div class="col-sm col-md-6 col-lg-4 ftco-animate fadeInUp ftco-animated" style="border-style: solid; border-width: 1px; margin-bottom: 10px">
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
                            <span class="price">$31.20</span>
                        </div>
                    </div>
                    <p>Enjoy good Chinese food like our award winning fried rice</p>
                    <p class="days"><span>forever</span></p>
                    <hr>
                    <p class="bottom-area d-flex">
                        <span><i class="icon-map-o"></i>Various outlets</span>
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="More info" OnClick="BtnAction_Click" />
                        <%-- temporary button rename later --%>
                    </p>
                </div>
            </div>
        </div>



    </form>
</asp:Content>
