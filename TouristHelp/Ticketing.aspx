<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ticketing.aspx.cs" Inherits="TouristHelp.Ticketing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero-wrap js-fullheight" style="background-image: url('images/bg_1.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center" data-scrollax-parent="true">
          <div class="col-md-9 text-center ftco-animate" data-scrollax=" properties: { translateY: '70%' }">
            <p class="breadcrumbs" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }"><span class="mr-2"><a href="Main.aspx">Home</a></span> <span>Tickets</span></p>
            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }">Tickets</h1>
          </div>
        </div>
      </div>
    </div>
    <form runat="server">
       <section class="ftco-section">
         <div class="container">
           <div class="row">
               <div class="col-lg-12">
                   <div class="col-lg-12 ftco-animate">
                       <h1>1-Day package</h1>
                       <h3>Select Ticket Type:</h3>
                       <asp:Button ID="BtnType" runat="server" class="ml-auto" Text="Sentosa Package" OnClick="Btn_TypeSel" />
                       <h3>Pick a date:</h3>
                       <asp:TextBox ID="TbDate" runat="server" CssClass="form-control" Text="Click to pick a date"></asp:TextBox>
                       <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                       <h3>Select Quantity</h3>
                       <div class="row">
                           <div class="col-lg-6">
                               <h4>Adult</h4>
                           </div>
                           <div class="col-lg-6">
                               <asp:Button ID="BtnDec" runat="server" class="ml-auto" Text="-" OnClick="Btn_DecreaseQ" />
                               <asp:TextBox ID="tbQuantityAdult" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                               <asp:Button ID="BtnInc" runat="server" class="ml-auto" Text="+" OnClick="Btn_IncreaseQ" />
                           </div>
                       </div>
                        <asp:Button ID="Button1" runat="server" class="ml-auto" Text="Buy Now" OnClick="Btn_Buy" />
                   </div>
               </div>
         </div>
             </div>
       </section>
    </form>
</asp:Content>
