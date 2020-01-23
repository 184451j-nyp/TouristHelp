<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuideListPage.aspx.cs" Inherits="TouristHelp.TourGuideListPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />


    <form id="form1" runat="server">
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
                                    <asp:Label ID="LbEmail" runat="server" Visible="false" Text='<%#Eval("Email") %>'></asp:Label></td>
                                           <asp:Label ID="LbuserId" runat="server" Visible="false" Text='<%#Eval("UserId") %>'></asp:Label></td>
                                         <asp:Label ID="LbtourguideId" runat="server" Visible="false" Text='<%#Eval("TourGuideId") %>'></asp:Label></td>

                                </div>

                            </div>
                            <td>
                                <asp:Label ID="LbPassword" runat="server" Visible="false" Text='<%#Eval("Password") %>'></asp:Label></td>

                            <asp:Label ID="LbTours" runat="server" Visible="false" Text='<%#Eval("Tours") %>'></asp:Label></td>
                            <asp:Label ID="LbDescription" runat="server" Text='<%#Eval("Description") %>'></asp:Label></td>

                            <hr>
                            <p class="bottom-area d-flex">
                                <td>
                                    <asp:Label ID="LbLanguages" runat="server" Text='<%#Eval("Languages") %>'></asp:Label></td>
                                <asp:Label ID="LbCredentials" runat="server" Text='<%#Eval("Credentials") %>'></asp:Label></td>

                            </p>
                            <td>
                                <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                            </td>
                            <td></td>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</asp:Content>

