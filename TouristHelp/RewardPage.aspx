<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RewardPage.aspx.cs" Inherits="TouristHelp.RewardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


   
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        
      

            <form id="frm" runat="server">
                <div>
                <div class="row">
                <asp:Label ID="creditBalanceTB" CssClass="col-2" runat="server" Text="Your Credit Balance:"></asp:Label>
                <asp:TextBox id="creditBalance" CssClass="col-2" runat="server" Enabled="False" ></asp:TextBox>


                    
               <asp:Label ID="loginCountTB" CssClass="col-2" runat="server" Text="Total Days Login:"></asp:Label>

               <asp:TextBox id="loginCount" CssClass="col-2" runat="server" Enabled="False"></asp:TextBox>

                    </div>



                                    <div class="row">
                                        <asp:Label ID="membershipTierTB" CssClass="col-2" runat="server" Text="Membership Type:"></asp:Label>
                                        <asp:TextBox ID="membershipTier" CssClass="col-2" runat="server" Enabled="False">Membership: </asp:TextBox>


                                        <asp:Label ID="loginStreakTB" CssClass="col-2" runat="server" Text="Login Streak:"></asp:Label>

                                        <asp:TextBox ID="loginStreak" CssClass="col-2" runat="server" Enabled="False"></asp:TextBox>
              
                                                            </div>

              
                                                    <div class="row">
                                                        <asp:Label ID="totalDiscountTB" CssClass="col-2" runat="server" Text="Total Discount:  "></asp:Label>

                                                        <asp:TextBox ID="totalDiscount" runat="server" CssClass="col-2" Enabled="False"></asp:TextBox>





                                                        <asp:Label ID="remainBonusDaysTB" CssClass="col-2" runat="server" Text="Days before Credit Bonus:"></asp:Label>

                                                        <asp:TextBox ID="remainBonusDays" CssClass="col-2" runat="server" Enabled="False" Width="100"></asp:TextBox>

                                                        
                                                       <asp:Label ID="bonusCreditsTB" CssClass="col-1" runat="server" Text="Bonus Credits:"></asp:Label>

                                                        <asp:TextBox ID="bonusCredits" CssClass="col-2" runat="server" Enabled="False"></asp:TextBox>






                                                      

                                                                                        </div>



                  


                    </div>







            </form>

               

            <div class="menu">
        <ul>
          <li class="active"><a href="RewardPage.aspx">How It Works</a></li>
          <li><a href="Shop.aspx">Shop</a></li>
          <li><a href="TransactionPage.aspx">My Transaction</a></li>
        </ul>



                    
      </div>


      <div class="row">
          <div class="col-lg-12">
          	<div class="row">
          		<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
                                <img class="img img-2 d-flex justify-content-center align-items-center" style="height:300px; width:350px;" src="Images/iconicFood.jpg"/>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<asp:Label ID="IntFood" Text="Food" ForeColor="Black" runat="server"></asp:Label>
			    						</div>
		    						</div>
		    						<p>Find out what local cuisines are left to be discovered, waiting to be savoured.</p>
		    						<hr>
		    						<p class="bottom-area d-flex">
		    							<asp:Button ID="BtnAddFood" runat="server" class="ml-auto" Text="Add" OnClick="Btn_AddInt" />
                                        <asp:Button ID="BtnRemFood" runat="server" class="ml-auto" Text="Remove" OnClick="Btn_RemoveInt" Visible="False" />
		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
                                <img class="img img-2 d-flex justify-content-center align-items-center" style="height:300px; width:350px;" src="Images/gbtb.jpg" />
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<asp:Label ID="IntNature" Text="Nature" ForeColor="Black" runat="server"></asp:Label>
			    						</div>
		    						</div>
		    						<p>Experience the greenery and have a refreshing take on Singapore.</p>
		    						<hr>
		    						<p class="bottom-area d-flex">
		    							<asp:Button ID="BtnAddNature" runat="server" class="ml-auto" Text="Add" OnClick="Btn_AddInt" />
                                        <asp:Button ID="BtnRemNature" runat="server" class="ml-auto" Text="Remove" OnClick="Btn_RemoveInt" Visible="False" />
		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<img class="img img-2 d-flex justify-content-center align-items-center" style="height:300px; width:350px;" src="Images/uss.jpg" />
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<asp:Label ID="IntAmusementPark" Text="Amusement Parks" ForeColor="Black" runat="server"></asp:Label>
			    						</div>
		    						</div>
		    						<p>Rediscover the definition of fun and thrill in our iconic amusement parks.</p>
		    						<hr>
		    						<p class="bottom-area d-flex">
		    							<asp:Button ID="BtnAddAP" runat="server" class="ml-auto" Text="Add" OnClick="Btn_AddInt" BackColor="Green" />
                                        <asp:Button ID="BtnRemAP" runat="server" class="ml-auto" Text="Remove" OnClick="Btn_RemoveInt" BackColor="Red" Visible="False" />
		    						    `</p>
		    					</div>
		    				</div>
		    			</div>
          	</div>
          </div> <!-- .col-md-8 -->
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
