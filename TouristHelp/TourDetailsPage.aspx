<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourDetailsPage.aspx.cs" Inherits="TouristHelp.TourDetailsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <style>
            .button {
                background-color: #4CAF50; /* Green */
                border: none;
                color: white;
                padding: 15px 32px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 16px;
            }
        </style>
    </header>
    <form id="form1" runat="server">

        <div class="col-lg-6">
            <h6 class="text-uppercase">Tours Information</h6>
            <asp:Label ID="tourguidetitleLabel" CssClass="col-1" runat="server" Text="Title:"></asp:Label>
            <p>
                This is a 3 hour city tour that provides an overview of Singapore popular sites, cultures, history and economy.<br>
                <br>
                As this is a private tour, I can customize it according to your needs.<br>
                <br>
                This tour will use an air-conditioned car that can carry up to 4 travelers without luggage. If your group size is more than 4 please message me.<br>
                <br>
                The location for pickup/dropoff can be anywhere in town, airport or cruise centre, which makes this a great choice for shore excursion.<br>
                <br>
                Kindly note that the duration of the tour (3 hours) is from the time of pickup to the time of dropoff.
            </p>

        </div>
        <section class="page-inner-section">
            <h2>Itinerary</h2>
            <p>
                1. Pickup from agreed meeting point<br>
                <br>
                2. Drive to Chinatown, colonial district, Muslim quarter and Little India. At each stop you will have some time to take photo or to buy something quickly.<br>
                <br>
                As this is a private tour, I can customize it according to your needs. The above is only the proposed itinerary, which you can change to suit your needs.<br>
                <br>
                3. Drop off at agreed dropoff point
            </p>
        </section>

        <h2 class="paddingTen">
            <a class="orangeDisc" href="/TBL/WebObjects/ToursByLocals.woa/1/wo/G1r7iwZlTbmaMqMcikTFrM/5.47.104.0">Book this tour</a>

        </h2>
        <div class="tour-currency-price">
            <b>Tour Price</b>

            <p>240&nbsp;<small>USD</small><span><a class="toolTipster cursorPointer tooltipstered" href="javascript: void(0)">(for&nbsp;up&nbsp;to&nbsp;4&nbsp;people)</a>&nbsp;(duration: 3 hours)&nbsp;<a target="instructionsviewer" onclick="var w=window.open('https://www.toursbylocals.com/DepositPolicy','instructionsviewer','toolbar=no,location=no,status=no,menubar=no,resizable=yes,scrollbars=yes,width=700,height=600'); w.focus(); return false" href="https://www.toursbylocals.com/DepositPolicy">deposit ?</a></span></p>



        </div>
        <asp:Button ID="BtnConfirm" runat="server" CssClass="btn btn-default" Style="float: right" Text="Confirm Booking" OnClick="BtnConfirm_Click" />
    </form>

</asp:Content>
