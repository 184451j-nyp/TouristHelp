<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planner.aspx.cs" Inherits="TouristHelp.Planner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src='https://api.mapbox.com/mapbox-gl-js/v1.7.0/mapbox-gl.js'></script>
    <link href='https://api.mapbox.com/mapbox-gl-js/v1.7.0/mapbox-gl.css' rel='stylesheet' />
    <style>
        .marker {
            background-image: url('Images/map-marker.png');
            background-size: cover;
            width: 30px;
            height: 30px;
            border-radius: 50%;
            cursor: pointer;
        }

        .mapboxgl-popup {
            max-width: 200px;
        }

        .mapboxgl-popup-content {
            text-align: center;
            font-family: 'Open Sans', sans-serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-2">
        <div class="col-6">
            <form id="FormView1" runat="server">
                <div class="row">
                    <div class="col">
                        <asp:Label ID="lblNoEntry" runat="server" Text="Add some places by visiting our list of Attractions! Meanwhile, enjoy this random selection!" ForeColor="Red" Visible="false"></asp:Label>
                        <asp:GridView ID="gvDirections" runat="server" AutoGenerateColumns="False" CssClass="table mw-100" OnSelectedIndexChanged="gvDirections_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False"/>
                                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" />
                                <asp:BoundField DataField="Price" HeaderText="Price" ReadOnly="True" />
                                <asp:BoundField DataField="Location" HeaderText="Location" ReadOnly="True" Visible="False"/>
                                <asp:BoundField DataField="Type" HeaderText="Type" ReadOnly="True" />
                                <asp:CommandField SelectText="Delete" ShowSelectButton="True">
                                    <ItemStyle CssClass="btn btn-danger" ForeColor="White" />
                                </asp:CommandField>
                            </Columns>
                            <HeaderStyle CssClass="thead-dark" />
                        </asp:GridView>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <p>Add attractions to your favorites! :</p>
                        <asp:DropDownList ID="DropDownListAttractions" runat="server"></asp:DropDownList>
                        <asp:Button ID="BtnAddAttraction" runat="server" Text="Add" OnClick="BtnAddAttraction_Click" />
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col">
                        <h3>Get Directions!</h3>
                        <br />
                        <p>Add locations in the order you want to visit them:</p>
                        <br />
                        <p>Saved locations:</p>
                        <asp:DropDownList ID="DropDownListSaved" runat="server"></asp:DropDownList>
                        <button class="btn btn-info" onclick="addToList(); return false;"></button>
                    </div>
                </div>

                <asp:HiddenField ID="geojsonHidden" runat="server" Value="" />
            </form>
        </div>
        <div class="col-6">
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

        map.setMaxBounds([[103.560239, 1.182667], [104.093586, 1.511393]]);

        map.addControl(new mapboxgl.NavigationControl());
        map.setRenderWorldCopies(false);

        var geojson = { 'type': 'FeatureCollection', 'features': JSON.parse(document.getElementById("<%= geojsonHidden.ClientID %>").value) }

        geojson.features.forEach(function (marker) {
            // create a HTML element for each feature
            var el = document.createElement('div');
            el.className = 'marker';

            // make a marker for each feature and add to the map
            new mapboxgl.Marker(el)
                .setLngLat(marker.geometry.coordinates).
                setPopup(new mapboxgl.Popup({ offset: 25 })
                    .setHTML("<h3>" + marker.properties.title + "</h3><p>" + marker.properties.description + "</p>"))
                .addTo(map);
        });

        function addToList() {
            alert("Button click!");
        }
    </script>
</asp:Content>