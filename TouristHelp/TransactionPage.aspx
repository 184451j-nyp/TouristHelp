<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="TouristHelp.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

         <div class="hero-wrap js-fullheight" style="background-image: url('images/bg_1.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center" data-scrollax-parent="true">
          <div class="col-md-9 text-center ftco-animate" data-scrollax=" properties: { translateY: '50%' }">

            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }">Transaction</h1>
          </div>
        </div>
      </div>
    </div>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    
            <div class="menu">
        <ul>
          <li class="active"><a href="RewardPage.aspx">How It Works</a></li>
          <li><a href="Shop.aspx">Shop</a></li>
          <li><a href="TransactionPage.aspx">My Transaction</a></li>
        </ul>



                    
      </div>


      <form id="frm" runat="server">
                <div>
                <asp:Label ID="transactionLabel"  runat="server" Text="Your Transaction History"></asp:Label>

                            <div class="select-wrap one-third">
	                    <select name="" id="" class="form-control" >
	                      <option value="">Search By Category</option>
	                      <option value="">Newest</option>
	                      <option value="">Oldest</option>
	                    </select>
	                  </div>
                                        </div>






                                    <div class="row">
                                        <asp:Label ID="voucherNameLabel" CssClass="col-2" runat="server" Text="Product Name:"></asp:Label>


                                        <asp:Label ID="voucherQuantityLabel" CssClass="col-2" runat="server" Text="Quantity:"></asp:Label>

                                        <asp:Label ID="dateLabel" CssClass="col-2" runat="server" Text="Date:"></asp:Label>

                                      <asp:Label ID="expiryDateLabel" CssClass="col-2" runat="server" Text="Expiry Date"></asp:Label>

                              <asp:Label ID="shopPriceLabel" CssClass="col-1" runat="server" Text="Price(Cost)"></asp:Label>


                                         <asp:Label ID="voucherStatusLabel" CssClass="col-1" runat="server" Text="Status"></asp:Label>


                               <asp:Label ID="confirmCodeLabel" CssClass="col-2" runat="server" Text="Code Verification"></asp:Label>



              
                                                            </div>

              
                                                    <div class="row">
                                                     

                                                           <asp:Label ID="voucherName" CssClass="col-2" runat="server" Text="Product Name:"></asp:Label>


                                        <asp:Label ID="voucherQty" CssClass="col-2" runat="server" Text="Quantity:"></asp:Label>

                                        <asp:Label ID="voucherDate" CssClass="col-2" runat="server" Text="Date:"></asp:Label>

                                      <asp:Label ID="voucherExpiry" CssClass="col-2" runat="server" Text="Expiry Date"></asp:Label>

                              <asp:Label ID="voucherTotalCost" CssClass="col-1" runat="server" Text="Price(Cost)"></asp:Label>


                                         <asp:Label ID="voucherStats" CssClass="col-1" runat="server" Text="Status"></asp:Label>


                               <asp:Label ID="confirmCode" CssClass="col-2" runat="server" Text="Code Verification"></asp:Label>



                                                      

                                                                                        </div>



                  









            </form>
       <style>
    div.menu ul li {
  display: inline-block;
  height:100%;
  padding: 0 1rem;
  text-align: center;

}

div.menu a {
  text-decoration: none;
  position: relative;
  top: 50%;
  margin-top:100px;
  transform: translateY(-50%);
  display: inline-block;
  vertical-align: middle;
  line-height: normal;

}




div.position{

    width:200px;
    text-align:right;
}

.form-group{
   display: inline-block;
   margin-right: 10px;
   float:left;
}

.form-group label{
   display: block;
}


div.row {

    margin-top:30px;
}


       </style>


</asp:Content>
