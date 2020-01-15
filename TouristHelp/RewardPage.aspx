<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RewardPage.aspx.cs" Inherits="TouristHelp.RewardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


       <div class="hero-wrap js-fullheight" style="background-image: url('images/bg_1.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-center justify-content-center" data-scrollax-parent="true">
          <div class="col-md-9 text-center ftco-animate" data-scrollax=" properties: { translateY: '50%' }">

            <h1 class="mb-3 bread" data-scrollax="properties: { translateY: '30%', opacity: 1.6 }">Reward</h1>
          </div>
        </div>
      </div>
    </div>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
        
                


            <form id="frm" runat="server">

                <span>
                <asp:Label ID="creditBalanceTB" runat="server" Text="Your Credit Balance:"></asp:Label>
                <asp:TextBox id="creditBalance" runat="server" Enabled="False" ></asp:TextBox>


                    
               <asp:Label ID="loginCountTB" runat="server" Text="Total Days Login:"></asp:Label>

               <asp:TextBox id="loginCount" runat="server" Enabled="False"></asp:TextBox>

               <asp:Label ID="loginStreakTB" runat="server" Text="Login Streak:"></asp:Label>

               <asp:TextBox id="loginStreak" runat="server" Enabled="False"></asp:TextBox>
                                        </span>

              

                       <div>

                            <asp:Label ID="remainBonusDaysTB" runat="server" Text="Next Login Day Credit Bonus:"></asp:Label>

                        <asp:TextBox ID="remainBonusDays" runat="server" Enabled="False" Width="100"></asp:TextBox>




                        <asp:TextBox ID="bonusCredits" runat="server" Width="50" Enabled="False"></asp:TextBox>
                            

                         <asp:Label ID="bonusCreditsTB" runat="server" Text="Credits"></asp:Label>

                       </div>

                     <div class="position">

                 <asp:Label ID="membershipTierTB" runat="server" Text="Membership Type:"></asp:Label>
                <asp:TextBox id="membershipTier" runat="server" Enabled="False">Membership: </asp:TextBox>


                <asp:Label ID="totalDiscountTB" runat="server" Text="Total Discount:  "></asp:Label>

                <asp:TextBox id="totalDiscount" runat="server" Enabled="False"></asp:TextBox>

                       </div>



                       

                                
            </form>

               

            <div class="menu">
        <ul>
          <li class="active"><a href="index.html">How It Works</a></li>
          <li><a href="Shop.aspx">Shop</a></li>
          <li><a href="Transaction.aspx">My Transaction</a></li>
        </ul>



                    
      </div>

<table>
               <section class="ftco-section services-section bg-light">
      <div class="container">
        <div class="row d-flex">
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block">
              <div class="icon"><span class="flaticon-yatch"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Be Active!</h3>
                <p>Credits can be earned via daily logins, booking hottels and joining activities and attractions</p>
              </div>
            </div>      
          </div>
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block">
              <div class="icon"><span class="flaticon-around"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Get rewarded</h3>
                <p>Credits can be used to bouchers and membership to get special offers and discounts</p>
              </div>
            </div>    
          </div>
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block">
              <div class="icon"><span class="flaticon-compass"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Loyalty pays!</h3>
                <p>Get PERMANANT discount by simply logging in everyday to reach higher loyalty tier</p>
              </div>
            </div>      
          </div>
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
                
          </div>
        </div>
      </div>


    </section>
                  


    </table>

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
  transform: translateY(-50%);
  display: inline-block;
  vertical-align: middle;
  line-height: normal;

}


span {

width:200px;

text-align:right;
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
       </style>


</asp:Content>
