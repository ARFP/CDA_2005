window.addEventListener('DOMContentLoaded', function() {
    
});

var menuToggle = document.getElementById("menuToggle");
var menu = document.getElementById('menu');
//console.log(menu);
/*
function menu_Click() {
   menu.classList.toggle('active');
}

menuToggle.addEventListener('click', menu_Click);


menuToggle.addEventListener('click', function() {
    menu.classList.toggle('active');
});
*/
menuToggle.addEventListener('click', () => menu.classList.toggle('active'));

