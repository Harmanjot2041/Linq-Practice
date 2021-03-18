function handleClick() {
    
    if (ValidationForm()) {
        $("#SubmitForm").submit();
    }

}
function ValidationForm() {
    var isValid = true;
   
    $("#Error").text("");
    if ($("#StudentID").val().trim() != "" && $("#StudentName").val().trim() != "" && $("#Age").val().trim() != "") {
        $("#Error").text("Please Enter Atleast One Field");
        isValid = false;
    }
    
    return isValid;

}