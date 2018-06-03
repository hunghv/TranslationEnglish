$(document).ready(function () {
  setInterval("slideSwitch()", 5000);
});

function gotoHome() {

}
function gotoAbout() {

}
function gotoCommtor() {

}

function gotoContact() {

}

function gotoContact() {

}
function slideSwitch() {
  var $active = $('#slideshow IMG.active');
  var $next = $active.next();

  if ($next.length === 0) {
    $('#1').removeClass();
    $('#2').removeClass();
    $('#3').removeClass();
    $('#1').addClass('active');
  }

  $active.addClass('last-active');

  $next.css({ opacity: 0.0 })
    .addClass('active')
    .animate({ opacity: 1.0 }, 1000, function () {
      $active.removeClass('active last-active');
    });
}
