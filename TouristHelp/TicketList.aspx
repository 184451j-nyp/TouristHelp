<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicketList.aspx.cs" Inherits="TouristHelp.TicketList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero-wrap js-fullheight" style="background-image: url('images/bg_1.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center" data-scrollax-parent="true">
          <div class="col-md-9 text-center ftco-animate" data-scrollax=" properties: { translateY: '70%' }">
            <p class="breadcrumbs" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }"><span class="mr-2"><a href="Main.aspx">Home</a></span> <span>Tickets</span></p>
            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }">Your Redeemable Tickets</h1>
          </div>
        </div>
      </div>
    </div>

    <form runat="server">
       <section class="ftco-section">
           <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
           <ItemTemplate>
         <div class="container">
             <div class="row">
                 <div class="col-lg-2">
                     <img style="width: 150px; height: 150px;" src="Images/uss.jpg" />
                 </div>
                 <div class="col-lg-8">
                     <div class="row">
                         <div class="col-lg-12">
                             <%--<h2>Ticket Name</h2>--%>
                             <asp:Label ID="lbTixName" runat="server" Font-Bold="True" Text='<%#Eval("attractionName") %>'></asp:Label>
                              <asp:Label ID="lbTixId" runat="server" Visible ="false" Text='<%#Eval("ticketId") %>'></asp:Label>
                         </div>
                         <div class="col-lg-12">
                             <%--<h4>Ticket Desc</h4>--%>
                             <asp:Label ID="lbTixDesc" runat="server" Text='<%#Eval("attractionDesc") %>'></asp:Label>
                         </div>
                         <div class="col-lg-12">
                             <h4>Expiry Date:</h4>
                             <asp:Label ID="lbTixExp" runat="server" Text='<%#Eval("dateExpire") %>'></asp:Label>
                         </div>
                     </div>
                 </div>
                 <div class="col-lg-2">
                     <a href="Main.aspx">Link here :D</a>
                     <%--send them to the QR code or ticket code here--%>
                     <%--<asp:HyperLink--%>
                 </div>
             </div>
         </div>
               </ItemTemplate>
             </asp:Repeater>
       </section>
    </form>
</asp:Content>
