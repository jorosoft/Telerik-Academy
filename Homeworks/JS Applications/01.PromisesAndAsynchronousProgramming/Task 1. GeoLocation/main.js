let map = document.getElementById("map");

let position = new Promise((resolve, reject) => {    
        navigator.geolocation.getCurrentPosition(
        (pos) => {
            resolve(pos);
        },
        (err) => {
            reject(err);
        });
});

function parsePosition(pos) {
    return {
        lat: pos.coords.latitude,
        long: pos.coords.longitude
    };
}

function showMap(posObj) {    
    let src = `http://maps.googleapis.com/maps/api/staticmap?center=${posObj.lat},${posObj.long}&zoom=15&size=800x500&sensor=false`;
    map.style.marginLeft = "26%";
    map.style.marginTop = "5%";
    map.setAttribute("src", src);    
}

position
    .then(parsePosition)
    .then(showMap);