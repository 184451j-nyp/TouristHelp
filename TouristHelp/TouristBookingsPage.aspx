<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TouristBookingsPage.aspx.cs" Inherits="TouristHelp.TouristBookingsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <div>
            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }" style="text-align: center; transform: translateZ(0px) translateY(10.929%);">Your Tour Guide Bookings</h1>
        </div>
        <br />
        <br />

        <asp:Repeater ID="RepeaterBookings" runat="server">
            <ItemTemplate>
                <div class="col-sm col-md-6 col-lg-12" style="border-style: solid; border-width: 1px; margin-bottom: 10px">
                    <%-- Proto Box --%>

                    <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                        <div class="icon d-flex justify-content-center align-items-center">
                            <span class="icon-link"></span>
                        </div>
                    </a>
                    <div class="text p-3">
                        <h3 id="TouristId"><%#Eval("TouristId") %></h3>
                        <div class="one">
                        </div>
                        <div class="two">
                        </div>
                        <hr>
                        <%--<asp:Button ID="ButtonSelect" runat="server" CssClass="btn btn-default" Text="More info" Style="float: right" />--%>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </form>
</asp:Content>
