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
        
        getLocation(addMarker);
        markers.forEach(mark => addMarker(mark))
    };
    
    
    document.head.appendChild(script);
    return true;
}

// Adds a marker to the map.
function addMarker({lat, lng, title}, iconLink = "https://developers.google.com/maps/documentation/javascript/examples/full/images/parking_lot_maps.png") {
   
    new google.maps.Marker({
        title: title,
        position: new google.maps.LatLng(lat, lng),
        icon: iconLink,
        map: map,
    });
}

/* 
*   @desc takes a callback funciton, uses the navigator api to get geo location. Adds them as a marker.
*   @param callback funciton
*   @return void 
* */
function getLocation(callback) {
    let coordinates = {
        'lat': '',
        'lng': '',
        'title': 'Your position',
    }
    if (navigator.geolocation) {

        const svgMarker = {
            path: "M10.453 14.016l6.563-6.609-1.406-1.406-5.156 5.203-2.063-2.109-1.406 1.406zM12 2.016q2.906 0 4.945 2.039t2.039 4.945q0 1.453-0.727 3.328t-1.758 3.516-2.039 3.070-1.711 2.273l-0.75 0.797q-0.281-0.328-0.75-0.867t-1.688-2.156-2.133-3.141-1.664-3.445-0.75-3.375q0-2.906 2.039-4.945t4.945-2.039z",
            fillColor: "blue",
            fillOpacity: 0.6,
            strokeWeight: 0,
            rotation: 0,
            scale: 2,
            anchor: new google.maps.Point(15, 30),
        };
        
        navigator.geolocation.getCurrentPosition(position => {
            coordinates.lat = position.coords.latitude;
            coordinates.lng = position.coords.longitude;
         
            callback(coordinates, svgMarker);
        });
    }
}

