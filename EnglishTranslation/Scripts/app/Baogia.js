$(document).ready(function () {
  $(".removeActive").removeClass("active");
  $("#gotoCommtor").addClass("active");
  $("#Name2").hide();
  $("#Name3").hide();
});

function SendRequest() {
  var name=$("#Name").val();
  if (name !== "") {
    $("#NameBaoGia").removeClass("has-error");
    $("#NameBaoGia").addClass("has-success");
    $("#Name1").hide();
    $("#Name2").show();
    $("#Name3").hide();
  } else {
    $("#NameBaoGia").addClass("has-error");
    $("#NameBaoGia").removeClass("has-success");
    $("#Name1").hide();
    $("#Name2").hide();
    $("#Name3").show();
  }
}
