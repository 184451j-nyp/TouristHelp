<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Reservation_Food.aspx.cs" Inherits="TouristHelp.Reservation_Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" Visible="false" runat="server" Text=""></asp:Label>
    <form runat="server">
        <table class="table">
            <tr>
                <td class="auto-style1">
                    <p>
                        Make Reservation: 
                        <asp:Label runat="server" ID="lbName"></asp:Label>
                    </p>
                    <p>
                        <asp:Label runat="server" ID="lbDesc"></asp:Label>
                    </p>
                    <div class="one-half img" style="background-image: url(images/about.jpg);"></div>
                    <div>
                        <div>At: <asp:Label runat="server" ID="lbPlace"></asp:Label></div>
                        <div>
                            Time:
                            <asp:TextBox ID="TbTime" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            Pax:
                            <asp:TextBox ID="TbPax" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button ID="BtnConfirm" runat="server" CssClass="btn btn-default" Style="float: right" Text="Confirm Reservation" OnClick="BtnConfirm_Click" />
                        <%-- temporary button rename later --%>
                    </div>
                </td>
                <td>
                    <asp:Label ID="LblCustId" runat="server">test</asp:Label>
                    <p style="font-size: 20px; font-weight: bold">How to use:</p>
                    <p>- A Confirmation Code will be sent to your phone number </p>
                    <p>- Present the Conformation Code to the restraunt staff to be seated</p>
                </td>
            </tr>
            <tr style="border-top-style: solid">
                <td>
                    <p style="font-size: 20px; font-weight: bold">Terms and conditions:</p>
                    <p>- Restraunt reserves the right to revoke reservations</p>
                    <p>- Reservation availability may vary</p>
                </td>
            </tr>
        </table>

    </form>
</asp:Content>
