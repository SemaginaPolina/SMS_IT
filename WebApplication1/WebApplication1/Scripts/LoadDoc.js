function loadDoc() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            if (xhttp.responseXML) {
                var allSubs = xhttp.responseXML.getElementsByTagName("child");
                for (var i = 0; i < allSubs.length; i++) {
                    var size = allSubs[i].getElementsByTagName("size")[0].firstChild.nodeValue;
                    var footLength = allSubs[i].getElementsByTagName("footLength")[0].firstChild.nodeValue;

                    var tempTr = document.createElement("tr");
                    tempTr.innerHTML = "<td>" + size + "</td>" + "<td>" + footLength + "</td>";
                    document.getElementById("childTable").appendChild(tempTr);

                }
            }
        }
    };
    xhttp.open("GET", "../Content/children.xml", true);
    xhttp.send();
}