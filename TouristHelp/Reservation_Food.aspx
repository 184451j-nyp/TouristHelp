<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Reservation_Food.aspx.cs" Inherits="TouristHelp.Reservation_Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <table class="table">
            <tr>
                <td class="auto-style1">
                    <p>Make Reservation:
                        <asp:Label runat="server" ID="lbName"></asp:Label></p>
                    <div class="one-half img" style="background-image: url(images/about.jpg);"></div>
                    <div>
                        <div>At: Place</div>
                        <div>Time: 9pm : 18/1/2020</div>
                        <div>Pax: 4</div>
                        <asp:Button ID="BtnConfirm" runat="server" CssClass="btn btn-default" Text="Confirm Reservation" OnClick="BtnConfirm_Click" /> <%-- temporary button rename later --%>
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
