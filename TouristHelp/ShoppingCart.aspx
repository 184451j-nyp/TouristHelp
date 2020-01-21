<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="TouristHelp.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            
        }
        .auto-style2 {
            width: 420px;
        }
        .auto-style4 {
            width: 181px;
        }
        .auto-style5 {
            width: 180px;
        }
        .auto-style6 {
            width: 177px;
        }
        .auto-style7 {
            width: 150px;
            height: 23px;
        }
        .auto-style8 {
            width: 420px;
            
            height: 23px;
        }
        .auto-style9 {
            width: 177px;
            height: 23px;
        }
        .auto-style10 {
            width: 181px;
            height: 23px;
        }
        .auto-style11 {
            width: 180px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
        .header{
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <section class="ftco-section">
      <div class="container">

          <table class="w-100">
              <tr>
                  <td class="auto-style7 header"></td>
                  <td class="auto-style8 header">Product</td>
                  <td class="auto-style9 header">Item Price</td>
                  <td class="auto-style10 header">Quantity</td>
                  <td class="auto-style11 header">Total Price</td>
                  <td class="auto-style12 header">Action</td>
              </tr>
              <tr>
                  <td class="auto-style1">&nbsp;</td>
                  <td class="auto-style2">
                      <div>
                          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                      </div>
                      <div>

                          <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

                      </div>
                  </td>
                  <td class="auto-style6">&nbsp;</td>
                  <td class="auto-style4">&nbsp;</td>
                  <td class="auto-style5">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
          </table>

      </div>
    </section>
    </form>
</asp:Content>
