﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuideRequestsPage.aspx.cs" Inherits="TouristHelp.TourGuideRequestsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <div>
            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }" style="text-align: center; transform: translateZ(0px) translateY(10.929%);">Your Tourist Bookings</h1>
        </div>
        <br />
        <br />

        <asp:Repeater ID="RepeaterBookings" runat="server" OnItemCommand="RepeaterBookings_ItemCommand">
            <ItemTemplate>
                <div class="col-sm col-md-6 col-lg-12" style="border-style: solid; border-width: 1px; margin-bottom: 10px">
                    <%-- Proto Box --%>

                    <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                        <div class="icon d-flex justify-content-center align-items-center">
                            <span class="icon-link"></span>
                        </div>
                    </a>
                    <div class="one">
                        <asp:Label ID="tourguideid" runat="server" Font-Size="15" Text='<%#Eval("TourGuideId") %>'></asp:Label>
                    </div>
                    <div class="two">
                        <span class="tgname" id="tourguidename">Tour Guide Name: <%#Eval("Name") %></span>
                    </div>
                    <div class="three">
                        <span class="tourtitle" id="TourTitle">Tour Title: <%#Eval("TourTitle") %></span>
                    </div>

                    <div class="four">
                        <span class="tourtiming" id="TourTiming">Tour Date: <%#Eval("Timing") %></span>
                    </div>

                    <div class="five">
                        <span class="tourstatus" id="TourStatus">Tour Status: <%#Eval("Status") %></span>
                    </div>
                    <div class="six">
                        <span class="touristid" id="TouristId">Tourist Id: <%#Eval("TouristId") %></span>
                    </div>

                    <div class="seven">
                        <asp:Label ID="Label1" runat="server" Font-Size="15" Text='<%#Eval("TourId") %>'></asp:Label>

                    </div>

                    <hr>
                    <td>
                        <asp:LinkButton ID="RejectButton" runat="server" Font-Size="15">Reject Request</asp:LinkButton>

                    </td>
                </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </form>
</asp:Content>
