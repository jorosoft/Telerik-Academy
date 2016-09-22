let popup = document.getElementById("popup");

popup.style.width = "800px";
popup.style.height = "40px";
popup.style.backgroundColor = "lightblue";
popup.style.border = "1px solid black";
popup.style.borderRadius = "10px";
popup.style.marginTop = "5%";
popup.style.marginLeft = "20%";
popup.style.fontFamily = "Arial";
popup.style.fontSize = "22px";
popup.style.paddingTop = "20px";
popup.style.paddingLeft = "30px";
popup.innerHTML = "This Website is removed to other location! You will be redirected in 2 seconds...";


let redirect = new Promise((resolve, reject) => {
    setTimeout(function () {
        resolve("https://www.google.com");
    }, 2000);
});

function changeUrl(url) {
    window.location = url;
}

redirect
    .then(changeUrl);