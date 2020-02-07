<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPageHotel.aspx.cs" Inherits="TouristHelp.AdminPageHotel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <form id="form1" runat="server">
    <div style="background-color: lightcyan">
        <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }" style="text-align: center; transform: translateZ(0px) translateY(10.929%);">Guidebook</h1>
    </div>
    <div>
        <asp:Button ID="ButtonAdd" runat="server" Text="Add Hotel" Width="124px" OnClick="ButtonAdd_Click" />
        <br />
        <br />
        <asp:Repeater ID="repeatHotel" runat="server">
            <ItemTemplate>
                <div class="col-sm col-md-6 col-lg-12" style="border-style: solid; border-width: 1px; margin-bottom: 10px">
                    <%-- Proto Box --%>

                    <a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/destination-3.jpg);">
                        <div class="icon d-flex justify-content-center align-items-center">
                            <span class="icon-link"></span>
                        </div>
                    </a>
                    <asp:HiddenField ID="hotelId" Value='<%#Eval("hotelId") %>' runat="server"></asp:HiddenField>

                    <div class="text p-3">
                        <asp:Label ID="hotelPriceLbl" runat="server" Visible="false" Text='<%#Eval("hotelPrice") %>'></asp:Label> <%--to put id for db retrieval--%>
                        <div class="one">
                            <h3 id="hotelNameLbl"><%#Eval("hotelName") %></h3>
                        </div>
                    
                        <h4 id="hotelImage"><%#Eval("hotelImage") %></h4>
                        <hr>
                       
                        <asp:Button ID="ButtonSelect" runat="server"  CssClass="btn btn-default" Text="More info" Style="float:right;" />
                        <br />
                        <br />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    </form>
</asp:Content>
