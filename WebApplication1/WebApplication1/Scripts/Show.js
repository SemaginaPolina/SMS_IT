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