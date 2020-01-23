<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planner.aspx.cs" Inherits="TouristHelp.Planner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src='https://api.mapbox.com/mapbox-gl-js/v1.4.1/mapbox-gl.js'></script>
    <link href='https://api.mapbox.com/mapbox-gl-js/v1.4.1/mapbox-gl.css' rel='stylesheet' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-2">
        <div class="col-5">
        </div>
        <div class="col-7">
            <div id='map' style='width: auto; height: 80vh;'></div>
        </div>
    </div>
    <script>
        mapboxgl.accessToken = 'pk.eyJ1IjoiMTg0NDUxai1ueXAiLCJhIjoiY2szbmJobTJuMWI1MTNnbWlta3QwZ3BqZSJ9.PbaZ3Kq-_qUDjV9qMUdIWQ';
        var map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/mapbox/streets-v11',
            center: [103.8198, 1.3521],
            zoom: 11
        });
    </script>
</asp:Content>