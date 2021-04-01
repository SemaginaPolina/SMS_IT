function cleanMove() {
    var elem = document.getElementById("myBar_2");
    var width = 10;
    elem.style.width = width + '%';
    elem.innerHTML = width + '%';
}

function move() {
    var elem = document.getElementById("myBar_2");
    var width = 10;
    var id = setInterval(frame, 10);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
        } else {
            width++;
            elem.style.width = width + '%';
            elem.innerHTML = width * 1 + '%';
        }
    }
}