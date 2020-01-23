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
            width: 130px;
        }
        .auto-style6 {
            width: 94px;
        }
        .auto-style12 {
            height: 23px;
        }
        .header{
            text-align: center;
        }
        .auto-style13 {
            height: 23px;
            width: 123px;
        }
        .auto-style14 {
            width: 123px;
        }
    .auto-style15 {
        height: 23px;
        width: 130px;
    }
    .auto-style16 {
        height: 23px;
        width: 94px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <section class="ftco-section">
      <div class="container">
          
          <table class="w-100">
              <tr>
                  <td class="auto-style12"></td>
                  <td class="auto-style12">Product</td>
                  <td class="auto-style16">Item Price</td>
                  <td class="auto-style15">Quantity</td>
                  <td class="auto-style13">Total Price</td>
                  <td class="auto-style12">Action</td>
              </tr>
              <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
           <ItemTemplate>
                  <tr>
                      <td class="auto-style1">&nbsp;</td>
                      <td class="auto-style2">
                          <div>
                              <asp:Label ID="lbProdName" runat="server" Font-Bold="True" Text='<%#Eval("productName") %>'></asp:Label>
                          </div>
                          <div>

                              <asp:Label ID="lbProdDesc" runat="server" Text='<%#Eval("productDesc") %>'></asp:Label>

                          </div>
                      </td>
                      <td class="auto-style6">
                          <asp:Label ID="lbPrice" runat="server" Text='<%#Eval("productPrice") %>'></asp:Label>
                      </td>
                      <td class="auto-style4">
                          <asp:TextBox ID="tbQuantity" runat="server" Height="22px" Width="57px" Text='<%#Eval("productQuantity") %>'></asp:TextBox>
                      </td>
                      <td class="auto-style14">
                          <asp:Label ID="lbTotalPrice" runat="server" Text='<%#Eval("productTotalPrice") %>'></asp:Label>
                      </td>
                      <td>
                          <asp:Button ID="btnDel" runat="server" Text="Delete" />
                      </td>
                  </tr>
                </ItemTemplate>
             </asp:Repeater>
          </table>
          <asp:Button ID="btnEdit" runat="server" Text="Edit" style="float:right"/>
        
      </div>
    </section>
    </form>
</asp:Content>
