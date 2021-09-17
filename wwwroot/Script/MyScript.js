$("#project").click(function () {
    $("#partial_project").show();
    $("#partial_objectif").hide();
    $("#partial_contributor").hide();
});

$("#objectif").click(function () {
    $("#partial_project").hide();
    $("#partial_objectif").show();
    $("#partial_contributor").hide();
});

$("#contributions").click(function () {
    $("#partial_project").hide();
    $("#partial_objectif").hide();
    $("#partial_contributor").show();
});

window.onscroll = function () { myFunction() };

var subnav = document.getElementById("subnav");
var sticky = subnav.offsetTop;

function myFunction() {
    if (window.pageYOffset >= sticky) {
        subnav.classList.add("sticky")
    } else {
        subnav.classList.remove("sticky");
    }
}
