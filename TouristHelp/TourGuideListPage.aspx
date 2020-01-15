<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TourGuideListPage.aspx.cs" Inherits="TouristHelp.TourGuideListPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    
    <div class="col-sm col-md-6 col-lg-12 ftco-animate fadeInUp ftco-animated">
        <div class="destination">
            <a>
                <img border="0" width="160" height="150" alt="Private tour guide Walter" class="lazy" src="https://www.toursbylocals.com/images/guides/7/7385/2013094184902530.jpg" style="display: block;">
            </a>
            <div class="text p-3">
                <div class="d-flex">
                    <div class="one">
                        <h3><a href="#">Jonathan Chew</a></h3>
                        <p class="rate">
                            <i class="icon-star"></i>
                            <i class="icon-star"></i>
                            <i class="icon-star"></i>
                            <i class="icon-star"></i>
                            <i class="icon-star-o"></i>
                            <span>87 Rating</span>
                        </p>
                    </div>
                    
                </div>
                <p>Languages: English (Fluent), Chinese (Fluent)</p>
                <hr>
                <p class="bottom-area d-flex">
                    <span><i class="icon-map-o"></i>Singapore, Pasir Ris</span>
                    <span class="ml-auto"><a href="TourGuideDetails.aspx">Learn More</a></span>
                </p>
            </div>
        </div>
    </div>
    <div class="col-sm col-md-6 col-lg-12 ftco-animate fadeInUp ftco-animated">
        <div class="destination">
            <a>
              <img border="0" width="160" height="150" alt="Private tour guide Chintana" class="lazy" src="https://www.toursbylocals.com/images/guides/5/5360/2019156012901578.jpg" style="display: block;">
            </a>
            <div class="text p-3">
                <div class="d-flex">
                    <div class="one">
                        <h3><a href="#">Stephanie Song</a></h3>
                        <p class="rate">
                            <i class="icon-star"></i>
                            <i class="icon-star"></i>
                            <i class="icon-star"></i>
                            <i class="icon-star-o"></i>
                            <i class="icon-star-o"></i>
                            <span>15 Rating</span>
                        </p>
                    </div>
                    
                </div>
                <p>Languages: English (Fluent), Chinese (Conversational)</p>
                <hr>
                <p class="bottom-area d-flex">
                    <span><i class="icon-map-o"></i>Singapore, Punggol</span>
                    <span class="ml-auto"><a href="#">Learn More</a></span>
                </p>
            </div>
        </div>
    </div>
</asp:Content>