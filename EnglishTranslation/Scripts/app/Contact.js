//hunghv2 -- abc

$(document).ready(function () {
  $(".redColor").hide();
  $(".removeActive").removeClass("active");
  $("#gotoContact").addClass("active");
});
function SaveContact() {
  var model = {}
  model.Name = $("#UserName").val();
  model.Email = $("#UserEmail").val();
  model.Phone = $("#UserPhone").val();
  model.Subject = $("#UserMsg").val();
  model.IsSendMail = true;
  var flag = false;
  if (model.Name !== "") {
    $("#EnterName").hide();
  } else {
    $("#EnterName").show();
    flag = true;
  }
  if (model.Email !== "") {
    $("#EnterEmail").hide();
    if (validateEmail(model.Email)) {
      $("#EmailCorrect").hide();
    } else {
      $("#EmailCorrect").show();
    }
  } else {
    $("#EnterEmail").show();
    flag = true;
  }
  if (model.Phone !== "") {
    $("#EnterPhone").hide();
    if (validatePhone(model.Phone)) {
      $("#PhoneCorrect").hide();
    } else {
      $("#PhoneCorrect").show();
      flag = true;
    }
  } else {
    $("#EnterPhone").show();
    flag = true;
  }
 

  if (!flag) {
    $.ajax({
      url: Etran.SaveContact,
      type: "POST",
      data: model,
      success: function (response) {
      },
      error: function (response) {
      }
    });
  }
}

function validateEmail(sEmail) {
  var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
  if (filter.test(sEmail)) {
    return true;
  }
  return false;
}

function validatePhone(phone) {
  var intRegex = /[0-9 -()+]+$/;
  if (!intRegex.test(phone)|| (phone.length < 9)||(phone.length > 11)) 
  {
    return false;
  }
  else 
  {
    return true;
  }
}