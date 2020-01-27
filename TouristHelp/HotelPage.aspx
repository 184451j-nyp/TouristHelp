<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HotelPage.aspx.cs" Inherits="TouristHelp.Hotel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <!-- breadcrumb start-->
    <section class="breadcrumb breadcrumb_bg align-items-center">
        <div class="container">
            <div class="row align-items-center justify-content-between">
                <div class="col-sm-6">
                    <div class="breadcrumb_tittle text-left">
                        <h2>Hotel</h2>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="breadcrumb_content text-right">
                        <p>Hotel</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- breadcrumb start-->





        <form id="frm" runat="server">

          <asp:Label ID="hotelAddedLbl" runat="server" visible="false" Text="Label"></asp:Label>

















    <td style="width: 1000px">

            <table>
                <section class="ftco-section">
                    <div class="container">


                        <div class="col-lg-12">
                            <%--start the repeater here--%>

                            <style>

                                 .size1of3 { float: left; width: 30%; }
                                </style>

                            <div>

                                <asp:Repeater ID="RepeatHotel" runat="server" OnItemCommand="RepeatHotel_ItemCommand" >

                                    <ItemTemplate>

                                        <div class="size1of3">

                                            <span class="col-sm col-md-6 col-lg-4 ftco-animate">
                                                





                                                <asp:Image ID="hotelImage" class="img img-2 d-flex justify-content-center align-items-center" Style="height: 300px; width: 350px;"
                                                    ImageUrl='<%# Eval("hotelImage")%>'
                                                    runat="server" />

                                                <asp:HiddenField runat="server" ID="hotelId" Value='<%#Eval("hotelId") %>' />


                                                <div class="text p-3">
                                                    <div class="d-flex">
                                                        <div class="one">
                                                            <h3>
                                                                <asp:Label ID="hotelName" runat="server" Text='<%#Eval("hotelName") %>'></asp:Label>
                                                            </h3>
                                                            <asp:Label ID="priceLabel" runat="server" Text="$"></asp:Label>
                                                            <asp:Label ID="hotelPrice" runat="server" Style="margin-left: 10px;" ForeColor="BlueViolet" Text='<%#Eval("hotelPrice") %>'></asp:Label>
                                                        </div>
                                                    </div>
                                                  
                                                    <hr>
                                                    <p class="bottom-area d-flex">

                                                        <asp:Label ID="roomQtyLbl" runat="server" Text="Rooms"></asp:Label>

                                                        <asp:DropDownList ID="roomQty" runat="server" AutoPostBack="True">
                                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                            <asp:ListItem>9</asp:ListItem>
                                                            <asp:ListItem>10</asp:ListItem>

                                                        </asp:DropDownList>
                         <asp:Button ID="BtnBuy" runat="server" Text="Add to Shopping Cart" style="float:right" OnClick="BtnBuy_Click"/>

                                                </div></p>
                                        </div>



                                    </ItemTemplate>
                                    <HeaderTemplate>

           

		
                          
                                    </HeaderTemplate>
                                    <SeparatorTemplate>   </SeparatorTemplate>
                                    <FooterTemplate></FooterTemplate>
                                </asp:Repeater>


                                


            <%-- <asp:ScriptManager ID="ScriptManager69" runat="server">
                 </asp:ScriptManager>


                                         <section class="ftco-section">
      <div class="container">
        <div class="row">
        	<div class="col-lg-12 sidebar order-md-last ftco-animate">
        		<div class="sidebar-wrap ftco-animate">
        			<h3 class="heading mb-4">Find City</h3>
        			<form action="#">
        				<div class="fields">
		                   <div class="form-group">
		                <div class="select-wrap one-third">
	                    <div class="icon"><span class="ion-ios-arrow-down"></span></div>
	                    <select name="" id="" class="form-control" placeholder="Region">
	                      <option value="">Region</option>
	                      <option value="">North</option>
	                      <option value="">South</option>
	                      <option value="">East</option>
	                      <option value="">West</option>
	                    </select>
	                  </div>
		              </div>
		              <div class="form-group">
		                <div class="select-wrap one-third">
	                    <div class="icon"><span class="ion-ios-arrow-down"></span></div>
	                    <select name="" id="" class="form-control" placeholder="Keyword search">
	                      <option value="">Select Location</option>
	                      <option value="">Ang Mo Kio</option>
	                      <option value="">Bishan</option>
	                      <option value="">Khatib</option>
	                      <option value="">Sembawang</option>
                          <option value="">Yishun</option>

	                    </select>
	                  </div>
		              </div>


                        <span>
		              <span class="form-group">
                         <asp:TextBox ID="checkInTB" runat="server">Check In</asp:TextBox>

                          
                          <ajaxToolkit:PopupControlExtender ID="checkIn_PopupControlExtender"  BehaviorID="checkIn_PopupControlExtender"   PopupControlID="CheckInPanel" Position="Bottom" TargetControlID="checkInTB" runat="server"></ajaxToolkit:PopupControlExtender>

                          <br />

                            <asp:Panel ID="CheckInPanel" style="background-color:white;" runat="server">
                             <asp:UpdatePanel ID="updateCheckinPanel"  runat="server">
                                 <ContentTemplate>


                                     <asp:Calendar ID="checkInCalender" runat="server" OnSelectionChanged="checkInCalender_SelectionChanged"></asp:Calendar>
                            
                                    

                                 </ContentTemplate>

                             </asp:UpdatePanel>
                                </asp:Panel>

		              </span>

                           




                            
		              <span class="form-group">

                         <asp:TextBox ID="checkOutTB" runat="server">Check Out</asp:TextBox>

                          
                          <ajaxToolkit:PopupControlExtender ID="checkOut_PopupControlExtender"  BehaviorID="checkOut_PopupControlExtender"  PopupControlID="checkOutPanel" Position="Bottom" TargetControlID="checkOutTB" runat="server"></ajaxToolkit:PopupControlExtender>

                          <br />

                            <asp:Panel ID="checkOutPanel" style="background-color:white;" runat="server">
                             <asp:UpdatePanel ID="updateCheckOutPanel" runat="server">
                                 <ContentTemplate>
                                     <asp:Calendar ID="checkOutCalendar" runat="server" OnSelectionChanged="checkOutCalendar_SelectionChanged"></asp:Calendar>
                                 </ContentTemplate>

                             </asp:UpdatePanel>
                                </asp:Panel>

		              </span>

                            </span>


		          
		              <div class="form-group">
		              	<div class="range-slider">
		              		<span>
										    <input type="number" value="25000" min="0" max="120000"/>	-
										    <input type="number" value="50000" min="0" max="120000"/>
										  </span>
										  <input value="1000" min="0" max="120000" step="500" type="range"/>
										  <input value="50000" min="0" max="120000" step="500" type="range"/>
										  </svg>
										</div>
		              </div>
		              <div class="form-group">
		                <input type="submit" value="Search" class="btn btn-primary py-3 px-5">
		              </div>
		            </div>




                        <style>
                            

                              button, input, optgroup, select, textarea {
    font-family: -webkit-pictograph;
   
}
                          </style>


                       
	            </form>
        		</div>
        	


          </div><!-- END-->









        
          
          </div> <!-- .col-md-8 -->
        </div>
    </section> <!-- .section -->--%>

                                <br style="clear: left;" />
                            </div>


                        </div>
                        <!-- .col-md-8 -->
                    </div>
                </section>
                <!-- .section -->

            </table>
        </td>



            </form>
    
		
   

</asp:Content>
