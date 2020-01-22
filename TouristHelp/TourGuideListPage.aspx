<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuideListPage.aspx.cs" Inherits="TouristHelp.TourGuideListPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />


    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
            <div class="col-sm col-md-6 col-lg-12 ftco-animate fadeInUp ftco-animated">
                <div class="destination">
                    <a>
                        <img border="0" width="160" height="150" alt="Private tour guide Walter" class="lazy" src="https://www.toursbylocals.com/images/guides/7/7385/2013094184902530.jpg" style="display: block;">
                    </a>
                    <div class="text p-3">
                        <div class="d-flex">
                            <div class="one">
                                <td>
                                    <asp:Label ID="LbName" runat="server" Text='<%#Eval("Name") %>'></asp:Label></td>

                            </div>

                        </div>
                        <td>
                            <asp:Label ID="LbEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label></td>
                        <hr>
                        <p class="bottom-area d-flex">
                            <td>
                                <asp:Label ID="LbPassword" runat="server" Text='<%#Eval("Password") %>'></asp:Label></td>
                            <span class="ml-auto"><a href="TourGuideDetails.aspx">Learn More</a></span>
                        </p>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
