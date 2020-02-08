<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PrintPlanner.aspx.cs" Inherits="TouristHelp.PrintPlanner" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-6">
                <div class="map"></div>
            </div>
            <div class="col-6">
                <div class="instructions"></div>
            </div>
        </div>
    </div>
    <form runat="server">
        <asp:HiddenField ID="URLHidden" runat="server" Value="" />
        <asp:HiddenField ID="MarkersHidden" runat="server" Value="" />
    </form>
    <script>
        mapboxgl.accessToken = 'pk.eyJ1IjoiMTg0NDUxai1ueXAiLCJhIjoiY2szbmJobTJuMWI1MTNnbWlta3QwZ3BqZSJ9.PbaZ3Kq-_qUDjV9qMUdIWQ';
        var map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/mapbox/streets-v11?optimize=true',
            center: [103.8198, 1.3521]
        });

        map.setMaxBounds([[103.560239, 1.182667], [104.093586, 1.511393]]);

        map.addControl(new mapboxgl.NavigationControl());
        map.setRenderWorldCopies(false);

        map.on('load', function () {
            var url = $("#<%= URLHidden.ClientID %>").val;
            var req = new XMLHttpRequest();
            req.open('GET', url, true);
            req.onload = function () {
                var json = JSON.parse(req.response);
                var data = json.routes[0];
                var route = data.geometry.coordinates;
                var geojson = {
                    type: 'Feature',
                    properties: {},
                    geometry: {
                        type: 'LineString',
                        coordinates: route
                    }
                };
                // if the route already exists on the map, reset it using setData
                if (map.getSource('route')) {
                    map.getSource('route').setData(geojson);
                } else { // otherwise, make a new request
                    map.addLayer({
                        id: 'route',
                        type: 'line',
                        source: {
                            type: 'geojson',
                            data: {
                                type: 'Feature',
                                properties: {},
                                geometry: {
                                    type: 'LineString',
                                    coordinates: geojson
                                }
                            }
                        },
                        layout: {
                            'line-join': 'round',
                            'line-cap': 'round'
                        },
                        paint: {
                            'line-color': '#e60000',
                            'line-width': 5,
                            'line-opacity': 0.75
                        }
                    });
                }
                var instructions = document.getElementById('instructions');
                instructions.style.visibility = "visible";
                var steps = data.legs[0].steps;

                var tripInstructions = [];
                for (var i = 0; i < steps.length; i++) {
                    tripInstructions.push('<br><li>' + steps[i].maneuver.instruction) + '</li>';
                    instructions.innerHTML = '<br><h3 class="duration">Trip duration: ' + Math.floor(data.duration / 60) + ' min </h3>' + tripInstructions;
                }
            }
            req.send();

            JSON.parse($("#<%= MarkersHidden.ClientID %>").val).forEach(function (marker) {
                // create a HTML element for each feature
                var el = document.createElement('div');
                el.className = 'marker';

                // make a marker for each feature and add to the map
                new mapboxgl.Marker(el)
                    .setLngLat(marker.geometry.coordinates)
                    .addTo(map);
            });
        });


    </script>
</asp:Content>
