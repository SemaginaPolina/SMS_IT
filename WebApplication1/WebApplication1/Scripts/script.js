function validateEmail(email) {
    const re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}

function Info(messages) {
    alert(messages);
}

function Clear(value) {
    value = "";
    return value;
}

function colorLable() {
    x = document.getElementById('sizeLabel');
    x.style.color = 'white';

    x = document.getElementById('costLabel');
    x.style.color = 'white';

    x = document.getElementById('choiseLabel');
    x.style.color = 'white';

    x = document.getElementById('experienceLabel');
    x.style.color = 'white';

    x = document.getElementById('emailLabel');
    x.style.color = 'white';
}

function clearValue() {
    document.getElementById('size') = "";

    document.getElementById('cost') = "";

    document.getElementById('choise') = "";

    document.getElementById('experience') = "";

    document.getElementById('email') = "";
}

document.getElementById("test").addEventListener('submit', function (e) {
    e.preventDefault();

    colorLable();
    cleanMove();
    let isGoog = true;
    let size = document.getElementById("size").value;
    let cost = document.getElementById("cost").value;
    let choise = document.getElementById("choise").value;
    let experience = document.getElementById("experience").value;
    let email = document.getElementById("email").value;
    let comment = document.getElementById("comment").value;
    let messages = "";

    if (!/^[0-9]+$/.test(size) || size < 1) {
        isGoog = false;
        messages = "Ошибка в поле размер!";
        x = document.getElementById('sizeLabel');
        x.style.color = 'red';

        Info(messages);
    }
    if (!size.length == 0) {
        if (!/^[0-9]+$/.test(cost) || cost < 1) {
            isGoog = false;
            messages = "Ошибка в поле цена!";
            x = document.getElementById('costLabel');
            x.style.color = 'red';
            Info(messages);
        }
    }
    if (!/^[а-яА-Я]+$/.test(choise) || choise.length == 0 || choise.length > 15) {
        isGoog = false;
        messages = "Ошибка в поле предпочитаемый товар!";
        x = document.getElementById('choiseLabel');
        x.style.color = 'red';
        Info(messages);
    }

    if (!validateEmail(email)) {
        isGoog = false;
        messages = "Ошибка в поле почта!";
        x = document.getElementById('emailLabel');
        x.style.color = 'red';
        Info(messages);
    }

    if (isGoog) {
        move();
    }
})


function initForEffect() {
    i_main = 0;
    txt_main = 'Магазин спортивного снаряжения Gliding';
    speed = 50;
}

function startKeyboardEffect() {
    if (i_main < txt_main.length) {
        document.getElementById("main").innerHTML += txt_main.charAt(i_main);
        i_main++;
        setTimeout(startKeyboardEffect, speed);
    }
}
function initScrol() {
    window.onscroll = function () { myFunction() };
}

function myFunction() {
    var winScroll = document.body.scrollTop || document.documentElement.scrollTop;
    var height = document.documentElement.scrollHeight - document.documentElement.clientHeight;
    var scrolled = (winScroll / height) * 100;
    document.getElementById("myBar").style.width = scrolled + "%";
}

