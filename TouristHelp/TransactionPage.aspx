<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="TouristHelp.Transaction" %>
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
                        <p>Reward<span>/</span>Transaction</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- breadcrumb start-->




    
     

        <section>



            <span class="menu">
                <ul>
                    <li class="active"><a href="RewardPage.aspx">How It Works</a></li>
                    <li class="style1"><a href="Shop.aspx">Shop</a></li>
                    <li class="style2"><a href="TransactionPage.aspx">My Transaction</a></li>
                </ul>




            </span>
        </section>





      <form id="frm" runat="server">
                <span>

                            <span class="select-wrap one-third">
               <asp:Label ID="transactionLabel"   runat="server" Text="Your Transaction History"></asp:Label>
                                
	                    <select name="" id="" style="width:unset;" class="form-control" >
	                      <option value="">Search By Category</option>
	                      <option value="">Newest</option>
	                      <option value="">Oldest</option>
	                    </select>
	                  </span>
                                        </span>



          <style>             
              span#ContentPlaceHolder1_transactionLabel{
                  font-size:30px;
                  color:cornflowerblue;


              }
          </style>



          







      <table>
<tr>
<td>
    <asp:GridView ID="GvEmployee"  ShowHeader="True" 
        GridLines="None" AutoGenerateColumns="false"
        runat="server">


        <Columns>


            <asp:TemplateField>

               
                <ItemTemplate>
                    
                                       <div class="row">
                                                     

                                     <asp:Label ID="voucherGen_id" CssClass="col-2" runat="server" Text='<%#Eval("voucherGen_id") %>'></asp:Label>


                                          <asp:Label ID="voucherName" CssClass="col-2" runat="server" Text='<%#Eval("voucherName") %>'></asp:Label>


                                        <asp:Label ID="voucherQuantity" CssClass="col-1" runat="server" Text='<%#Eval("voucherQuantity") %>'></asp:Label>

                                        <asp:Label ID="voucherDate" CssClass="col-2" runat="server" Text='<%#Eval("voucherDate") %>'></asp:Label>

                                      <asp:Label ID="voucherExpiry" CssClass="col-2" runat="server" Text='<%#Eval("voucherExpiry") %>'></asp:Label>

                              <asp:Label ID="voucherTotalCost" CssClass="col-1" runat="server" Text='<%#Eval("voucherTotalCost") %>'></asp:Label>


                                         <asp:Label ID="voucherStats" CssClass="col-1" runat="server" Text='<%#Eval("voucherStats") %>'></asp:Label>


                               <asp:Label ID="confirmCode" CssClass="col-1" runat="server" Text='<%#Eval("confirmCode") %>'></asp:Label>



                         
                </ItemTemplate>



                 <HeaderTemplate>    
                    <div class="row">

                                     <asp:Label ID="voucherIdLabel" CssClass="col-2" runat="server" Text="Product Id:"></asp:Label>

                                        <asp:Label ID="voucherNameLabel" CssClass="col-2" runat="server" Text="Product Name:"></asp:Label>


                                        <asp:Label ID="voucherQuantityLabel" CssClass="col-1" runat="server" Text="Quantity:"></asp:Label>

                                        <asp:Label ID="dateLabel" CssClass="col-2" runat="server" Text="Date:"></asp:Label>

                                      <asp:Label ID="expiryDateLabel" CssClass="col-2" runat="server" Text="Expiry Date"></asp:Label>

                              <asp:Label ID="shopPriceLabel" CssClass="col-1" runat="server" Text="Total Cost"></asp:Label>


                                         <asp:Label ID="voucherStatusLabel" CssClass="col-1" runat="server" Text="Status"></asp:Label>


                               <asp:Label ID="confirmCodeLabel" CssClass="col-1" runat="server" Text="Code Verification"></asp:Label>



              
                                                            </div></HeaderTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</td>


<td>
    <asp:Repeater ID="Repeater1"  runat="server">
        <ItemTemplate>
            
           
                                    
                                                      

                                                                                        </div>


        </ItemTemplate>
        <SeparatorTemplate>
        

        </SeparatorTemplate>
    </asp:Repeater>
</td>
</tr>
</table>










<%--                                    <div class="row">

                                     <asp:Label ID="voucherIdLabel" CssClass="col-2" runat="server" Text="Product Id:"></asp:Label>

                                        <asp:Label ID="voucherNameLabel" CssClass="col-2" runat="server" Text="Product Name:"></asp:Label>


                                        <asp:Label ID="voucherQuantityLabel" CssClass="col-1" runat="server" Text="Quantity:"></asp:Label>

                                        <asp:Label ID="dateLabel" CssClass="col-2" runat="server" Text="Date:"></asp:Label>

                                      <asp:Label ID="expiryDateLabel" CssClass="col-2" runat="server" Text="Expiry Date"></asp:Label>

                              <asp:Label ID="shopPriceLabel" CssClass="col-1" runat="server" Text="Price(Cost)"></asp:Label>


                                         <asp:Label ID="voucherStatusLabel" CssClass="col-1" runat="server" Text="Status"></asp:Label>


                               <asp:Label ID="confirmCodeLabel" CssClass="col-1" runat="server" Text="Code Verification"></asp:Label>



              
                                                            </div>

              
                                                    <div class="row">
                                                     

                                     <asp:Label ID="voucherGen_id" CssClass="col-2" runat="server" Text=""></asp:Label>


                                          <asp:Label ID="voucherName" CssClass="col-2" runat="server" Text=""></asp:Label>


                                        <asp:Label ID="voucherQty" CssClass="col-1" runat="server" Text=""></asp:Label>

                                        <asp:Label ID="voucherDate" CssClass="col-2" runat="server" Text=""></asp:Label>

                                      <asp:Label ID="voucherExpiry" CssClass="col-2" runat="server" Text=""></asp:Label>

                              <asp:Label ID="voucherTotalCost" CssClass="col-1" runat="server" Text=""></asp:Label>


                                         <asp:Label ID="voucherStats" CssClass="col-1" runat="server" Text=""></asp:Label>


                               <asp:Label ID="confirmCode" CssClass="col-1" runat="server" Text=""></asp:Label>



                                                      

                                                                                        </div>--%>



                  

            


                  







            </form>
       <style>
    span.menu ul li  {
            display: inline-block;
            height: 100%;
            padding: 0 1rem;
            text-align: center;
            font-size:25px;
            padding-left:230px;
            margin-top: 200px;
        }

span.menu a {
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

form#frm
{
    text-align:center;
    margin-left:30%;
}


ul{



}

 li.active {
            margin-left:20%;
        }

       </style>


</asp:Content>
