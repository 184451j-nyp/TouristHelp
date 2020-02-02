﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuideListPage.aspx.cs" Inherits="TouristHelp.TourGuideListPage" %>

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
                                        <label></label>
                                        <asp:Label ID="LbName" runat="server" Font-Size="15" Text='<%#Eval("Name") %>'></asp:Label></td>
                                    <asp:Label ID="LbEmail" runat="server" Visible="false" Text='<%#Eval("Email") %>'></asp:Label></td>
                                           <asp:Label ID="LbuserId" runat="server" Visible="false" Text='<%#Eval("UserId") %>'></asp:Label></td>
                                         <asp:Label ID="LbtourguideId" runat="server" Visible="false" Text='<%#Eval("TourGuideId") %>'></asp:Label></td>

                                </div>
                                <td>
                                    <asp:Label ID="LbCredentials" runat="server" Font-Size="15" Visible="false" Text='<%#Eval("Credentials") %>'></asp:Label></td>




                            </div>
                            <td>
                                <asp:Label ID="LbPassword" runat="server" Visible="false" Text='<%#Eval("Password") %>'></asp:Label></td>

                            <asp:Label ID="LbDescription" runat="server" Font-Size="15" Text='<%#Eval("Description") %>'></asp:Label></td>
                                                        <p class="bottom-area d-flex">

                                                            <td>
                                                                <asp:Label ID="LbLanguages" runat="server" Font-Size="15" Text='<%#Eval("Languages") %>'></asp:Label></td>

                                                        </p>

                            <td>
                                <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="15">Learn More</asp:LinkButton>
                            </td>
                            <hr>

                            <td></td>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</asp:Content>

