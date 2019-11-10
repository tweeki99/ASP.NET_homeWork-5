$("#button").on("click", function () {
    $.ajax({
        type: "Post",
        url: "Home/Publish",
        data: { name: $("#name").val(), text: $("#text").val()},
        success: function (response) {
            $("#tableBody").append("<tr><td>" + response.Name + "</td><td>" + response.Text + "</td></tr>");
        }
    });
});