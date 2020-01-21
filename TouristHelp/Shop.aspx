﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="TouristHelp.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <!-- breadcrumb start-->
    <section class="breadcrumb breadcrumb_bg align-items-center">
        <div class="container">
            <div class="row align-items-center justify-content-between">
                <div class="col-sm-6">
                    <div class="breadcrumb_tittle text-left">
                        <h2>Shop</h2>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="breadcrumb_content text-right">
                        <p>Reward<span>/</span>Shop</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- breadcrumb start-->

            <asp:Label ID="LblMsg" CssClass="lblMsgCss" runat="server" Text="Text"></asp:Label>





  <form id="frm" runat="server">
                <div>
                <div class="row">
                <asp:Label ID="creditBalanceTB" CssClass="col-2" runat="server" Text="Your Credit Balance:"></asp:Label>
                <asp:TextBox id="creditBalance" CssClass="col-2" runat="server" Enabled="False" ></asp:TextBox>


                    
               <asp:Label ID="loginCountTB" CssClass="col-2" runat="server" Text="Total Days Login:"></asp:Label>

               <asp:TextBox id="loginCount" CssClass="col-2" runat="server" Enabled="False"></asp:TextBox>

                 <asp:Button ID="addCreditBtn" CssClass="buttonPosition" runat="server" Text="Add Credits" OnClick="addCreditBtn_Click" />

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


                    
                                                     <div class="row">
                                                        <asp:Label ID="loyaltyTierLabel" CssClass="col-2" runat="server" Text="Loyalty Tier: "></asp:Label>

                                                        <asp:TextBox ID="loyaltyTier" runat="server" CssClass="col-2" Enabled="False"></asp:TextBox>





                                                                                        </div>

                  

                  



                    </div>









    <section>



        <span class="menu">
        <ul>
          <li class="active"><a href="RewardPage.aspx">How It Works</a></li>
          <li><a href="Shop.aspx">Shop</a></li>
          <li><a href="TransactionPage.aspx">My Transaction</a></li>
        </ul>



                    
      </span>
    </section>


    <section class="ftco-section">
      <div class="container">
        <div class="row">
        	<div class="col-lg-3 sidebar order-md-last ftco-animate">
        		<div class="sidebar-wrap ftco-animate">
        			<h3 class="heading mb-4">Filter</h3>
        			<form action="#">
        				<div class="fields">
		              <div class="form-group">
		                <input type="text" class="form-control" placeholder="Search for specific item">
		              </div>
		              <div class="form-group">
		                <div class="select-wrap one-third">
	                    <div class="icon"><span class="ion-ios-arrow-down"></span></div>
	                    <select name="" id="" class="form-control" >
	                      <option value="">Search By Category</option>
	                      <option value="">Popular</option>
	                      <option value="">Newest</option>
	                      <option value="">Low Price</option>
	                      <option value="">High Price</option>
	                    </select>
	                  </div>
		              </div>
		             
		              <div class="form-group">
		                <input type="submit" value="Search" class="btn btn-primary py-3 px-5">
		              </div>
		            </div>
	            </form>
        		</div>
        		<div class="sidebar-wrap ftco-animate">
        			<form method="post" class="star-rating">

							</form>
        		</div>
          </div><!-- END-->




























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





















          <div class="col-lg-9">
          	<div class="row">
          		<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(../Images/silverMember.png);">



                                    
		    						<div class="icon d-flex justify-content-center align-items-center">
		    							<span class="icon-link"></span>
		    						</div>
		    					</a>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    					
				    				<h3> <asp:Label ID="voucherName" runat="server"></asp:Label> </h3>
			    						</div>
			    						<div class="two">
			    							<asp:Label class="price" runat="server" ID="voucherCost"></asp:Label>
                                            <asp:Label ID="creditLabel" runat="server" Text="Credits"></asp:Label>
		    							</div>
		    						</div>
                                  <asp:Label ID="voucherDesc" runat="server"></asp:Label> 
		    						<p class="days" id="voucherWarning"><span></span></p>
		    						<hr>
		    						
                                    	<p class="bottom-area d-flex">

                                            <asp:Button ID="BtnSubmit"  CssClass="ml-auto" runat="server" Text="Purchase" OnClick="BtnSubmit_Click" />

		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/);">

		    						<div class="icon d-flex justify-content-center align-items-center">
		    							<span class="icon-link"></span>
		    						</div>
		    					</a>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<h3><a href="#"></a></h3>
				    					
			    						</div>
			    						<div class="two">



		    							</div>
		    						</div>
		    						<p>Far far away, behind the word mountains, far from the countries</p>
		    						<hr>
		    						<p class="bottom-area d-flex">



		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/);">
		    						<div class="icon d-flex justify-content-center align-items-center">
		    							<span class="icon-link"></span>
		    						</div>
		    					</a>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<h3><a href="#"></a></h3>
				    						
			    						</div>
			    						<div class="two">


		    							</div>
		    						</div>
		    						<p>Far far away, behind the word mountains, far from the countries</p>


		    						<hr>
		    						<p class="bottom-area d-flex">



		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/);">
		    						<div class="icon d-flex justify-content-center align-items-center">
		    							<span class="icon-link"></span>
		    						</div>
		    					</a>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<h3><a href="#"></a></h3>
				    					


			    						</div>
			    						<div class="two">
			    							<span class="price"></span>
		    							</div>
		    						</div>
		    						<p>Far far away, behind the word mountains, far from the countries</p>


		    						<hr>
		    						<p class="bottom-area d-flex">


		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/);">
		    						<div class="icon d-flex justify-content-center align-items-center">
		    							<span class="icon-link"></span>
		    						</div>
		    					</a>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<h3><a href="#"></a></h3>
				    					


			    						</div>
			    						<div class="two">
			    							<span class="price"></span>
		    							</div>
		    						</div>
		    						<p>Far far away, behind the word mountains, far from the countries</p>




		    						<hr>
		    						<p class="bottom-area d-flex">



		    						</p>
		    					</div>
		    				</div>
		    			</div>
		    			<div class="col-sm col-md-6 col-lg-4 ftco-animate">
		    				<div class="destination">
		    					<a href="#" class="img img-2 d-flex justify-content-center align-items-center" style="background-image: url(images/);">
		    						<div class="icon d-flex justify-content-center align-items-center">
		    							<span class="icon-link"></span>
		    						</div>
		    					</a>
		    					<div class="text p-3">
		    						<div class="d-flex">
		    							<div class="one">
				    						<h3><a href="#"></a></h3>
                                           <%-- <p class="rate">
                                                <i class="icon-star"></i>
                                                <i class="icon-star"></i>
                                                <i class="icon-star"></i>
                                                <i class="icon-star"></i>
                                                <i class="icon-star-o"></i>
                                                <span>8 Rating</span>
                                            </p>--%>
			    						</div>
			    						<div class="two">
			    							<span class="price"></span>
		    							</div>
		    						</div>
		    						<p>Far far away, behind the word mountains, far from the countries</p>


		    						<hr>
		    						<p class="bottom-area d-flex">


		    						</p>
		    					</div>
		    				</div>
		    			</div>
          	</div>
        



          </div> <!-- .col-md-8 -->
        </div>
      </div>
    </section> <!-- .section -->

	

                  </form>




    
   <style>
    span.menu ul li {
  display: inline-block;
  height:100%;
  padding: 0 1rem;
  margin-left:300px;
  text-align: center;
  margin-top:200px;


}

span.menu a {
  text-decoration: none;
  position: relative;
  top: 50%;
  text-align:center;
  transform: translateY(-50%);
  display: inline-block;
  vertical-align: middle;
  line-height: normal;

}

div.row {

    margin-top:30px;
}

#creditLabel{

    margin-left:40px;
}

.lblMsgCss
{
    font-size:20px;
    text-align: center;

}

.buttonPosition{

    margin-left:100px;
}

       </style>
</asp:Content>
