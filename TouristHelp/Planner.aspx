<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planner.aspx.cs" Inherits="TouristHelp.Planner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src='https://api.mapbox.com/mapbox-gl-js/v1.4.1/mapbox-gl.js'></script>
    <link href='https://api.mapbox.com/mapbox-gl-js/v1.4.1/mapbox-gl.css' rel='stylesheet' />
    <script src="https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-directions/v4.0.2/mapbox-gl-directions.js"></script>
    <link
        rel="stylesheet"
        href="https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-directions/v4.0.2/mapbox-gl-directions.css"
        type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-2">
        <div class="col-5">
            <form ID="FormView1" runat="server">
                <asp:GridView ID="gvDirections" runat="server" AutoGenerateColumns="False" CssClass="table">
                    <columns>
                    <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="name" HeaderText="Name" ReadOnly="True" />
                    <asp:BoundField DataField="latitude" HeaderText="Latitude" ReadOnly="True" />
                    <asp:BoundField DataField="longitude" HeaderText="Longitude" ReadOnly="True" />
                    <asp:BoundField DataField="type" HeaderText="Type" ReadOnly="True" />
                    <asp:ButtonField Text="Insert" />
                </columns>
                </asp:GridView>
            </form>
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
        map.addControl(new mapboxgl.NavigationControl());
        map.setRenderWorldCopies(false);
        /*map.addControl(
            new MapboxDirections({
                accessToken: mapboxgl.accessToken
            }),
            'top-left'
        );*/
    </script>
</asp:Content>