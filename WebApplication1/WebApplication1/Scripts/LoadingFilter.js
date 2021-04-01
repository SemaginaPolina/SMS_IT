function loadProduct() {
    event.preventDefault();
    var xhttp = new XMLHttpRequest();

    var category = document.getElementById("category").value;
    var color = document.getElementById("color").value;

    var body = "cat=" + category + "&color=" + color;


    xhttp.onreadystatechange = function () {


        if (this.readyState == 4 && this.status == 200) {

            var tempTr = document.getElementById("product");
            tempTr.innerHTML = xhttp.responseText;
        }
    };
    xhttp.open("POST", "/Catalog/AjaxProducs", true);
    xhttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    xhttp.send(body);
}