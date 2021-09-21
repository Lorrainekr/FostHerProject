$("#project").click(function () {
    $("#partial_project").show();
    $("#partial_objectif").hide();
    $("#partial_comment").hide();
    $("#partial_contributor").hide();
});

$("#objectif").click(function () {
    $("#partial_project").hide();
    $("#partial_objectif").show();
    $("#partial_comment").hide();
    $("#partial_contributor").hide();
});

$("#comment").click(function () {
    $("#partial_project").hide();
    $("#partial_objectif").hide();
    $("#partial_comment").show();
    $("#partial_contributor").hide();
});

$("#contributions").click(function () {
    $("#partial_project").hide();
    $("#partial_objectif").hide();
    $("#partial_comment").hide();
    $("#partial_contributor").show();
});

/* sticky menu scroll navbar crowdfunding*/
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

// sticky menu scroll contrepartie crowdfunding
window.onscroll = function () { myFunction() };

var staticcontrepartie = document.getElementById("staticcontrepartie");
var stickycontrepartie = staticcontrepartie.offsetTop;

function myFunction() {
    if (window.pageYOffset >= stickycontrepartie) {
        staticcontrepartie.classList.add("stickycontrepartie")
    } else {
        staticcontrepartie.classList.remove("stickycontrepartie");
    }
}
/* block deroulant*/
var coll = document.getElementsByClassName("collapsible");
var i;

for (i = 0; i < coll.length; i++) {
    coll[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.display === "block") {
            content.style.display = "none";
        } else {
            content.style.display = "block";
        }
    });
}
