var Etran={}
$(document).ready(function () {
  setInterval("slideSwitch()", 5000);
});
function gotoHome() {
  window.location.href = Etran.HomeUrl;
}
function gotoAbout() {
  window.location.href = Etran.AboutUrl;
}
function gotoCommtor() {
  window.location.href = Etran.Commtor;
}

function gotoContact() {
  window.location.href = Etran.ContactUrl;
}

function gotoService() {
  window.location.href = Etran.ServicesUrl;
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
