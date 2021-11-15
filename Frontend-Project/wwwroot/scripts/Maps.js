let map;

function createMap(API_KEY, markers) {
    const script = document.createElement('script');
    script.src = `https://maps.googleapis.com/maps/api/js?key=${API_KEY}&callback=initMap`;
    script.async = true;
    
    window.initMap = function (listener) {
        // JS API is loaded and available

        console.log("listener: " + listener)
        map = new google.maps.Map(document.getElementById("map"), {
            center: {lat: 55.31982, lng: 15.18783},
            zoom: 16,
        });

        const styledMapType = new google.maps.StyledMapType([{
                featureType: 'poi',
                elementType: 'labels',
                stylers: [
                    { visibility: 'off' }
                ]
            }])

        map.mapTypes.set("styled_map", styledMapType);
        map.setMapTypeId("styled_map");

           
        const pos = new google.maps.LatLng(55.31982, 15.18783)
        /* var marker = new google.maps.Marker({
            position: pos,
            icon: "https://developers.google.com/maps/documentation/javascript/examples/full/images/parking_lot_maps.png",
            map: map,
            title: "Hallo Marker!"
        }); */
        
        markers.forEach(mark => addMarker(mark))
    };
    
    
    document.head.appendChild(script);
    return true;
}

// Adds a marker to the map.
function addMarker({lat, lng, title}) {
   
    new google.maps.Marker({
        title: title,
        position: new google.maps.LatLng(lat, lng),
        icon: "https://developers.google.com/maps/documentation/javascript/examples/full/images/parking_lot_maps.png",
        map: map,
    });
}


