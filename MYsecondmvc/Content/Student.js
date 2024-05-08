$(document).ready(function () {
    GetMYsecondmvcList();
});



var Savereg = function () {
    var name = $("#txtName").val();
    var email_id = $("#txtEmail").val();
    var dob = $("#txtdate").val();
    var contact_no = $("#txtnumber").val();
    var address = $("#txtAdd").val();
    var model = { Name: name, Email_ID: email_id, DOB: dob, Contact_No: contact_no, Address: address };
    $.ajax({
        url: "/Student/Savereg",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/Json;charset=utf-8",
        dataType: "Json",
        success: function (response) {
            alert("Successfull");
        }
    })
}
var GetMYsecondmvcList = function () {
    debugger;
    $.ajax({
        url: "/Student/GetMYsecondmvcList",
        method: "post",
        contentType: "application/Json;charset=utf-8",
        dataType: "Json",
        async: false,
        success: function (response) {
            var html = "save";
            $("#tblStudents tbody").empty();

            $.each(response.model, function (index, elementValue) {

                html += "<tr><td>" + elementValue.Srno +
                    "</td><td>" + elementValue.Id +
                    "</td><td>" + elementValue.Name +
                    "</td><td>" + elementValue.Email_id +
                    "</td><td>" + elementValue. DOB +
                    "</td><td>" + elementValue.Contact_No +
                    "</td><td>" + elementValue.Address + "</td></tr>";

            });
            $("#tblStudents tbody").append(html);
        }

    });
}


