<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="AdminPageAddAttraction_2.aspx.cs" Inherits="TouristHelp.AdminPageAddAttraction_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <table class="table">
            <tr>
                <td class="auto-style1">
                    <p>
                        Attraction Name: 
                            <asp:TextBox ID="TbName" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        Attraction Description:
                            <asp:TextBox ID="TbDesc" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        Attraction Price:
                            <asp:TextBox ID="TbPrice" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        Attraction Location:
                        <asp:TextBox ID="TbLocation" runat="server"></asp:TextBox>
                    </p>
                    <p>
                       Attraction Date:
                            <asp:TextBox ID="TbDate" runat="server"></asp:TextBox>
                    </p>
                    <p>
                       Attraction Latitude:
                            <asp:TextBox ID="TbLat" runat="server"></asp:TextBox>
                    </p>
                    <p>
                       Attraction Longitude:
                            <asp:TextBox ID="TbLong" runat="server"></asp:TextBox>
                    </p>
                    <p>
                       Attraction Interest:
                            <asp:TextBox ID="TbInterest" runat="server"></asp:TextBox>
                    </p>
                    <p>
                       Attraction Type:
                            <asp:TextBox ID="TbType" runat="server"></asp:TextBox>
                    </p>
                    <asp:Button ID="BtnAdd" runat="server" CssClass="btn btn-default" Style="float: right" Text="Add Attraction" OnClick="BtnAdd_Click" />
                    <asp:Button ID="BtnCancel" runat="server" CssClass="btn btn-default" Style="float: right; margin-right:20px" Text="Go back" OnClick="BtnBack_Click" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
