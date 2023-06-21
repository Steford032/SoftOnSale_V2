var xhr;

window.onload = function () {
    xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4) {
            if (xhr.status == 200) {
                document.getElementById("output").innerHTML = xhr.responseText;
            }
        }
    }

    var button1 = document.getElementById("button1");
    button1.onclick = clickHandler;
}
function clickHandler() {
    xhr.open("GET", "Handler.cs");

    xhr.send(null);
}