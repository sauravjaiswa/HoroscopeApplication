jQuery.validator.addMethod("dob",
    function (value, element, param) {

        var dateGiven = new Date(value);
        var dateNow = new Date();
        console.log(dateGiven);
        console.log(dateNow);
        if (dateGiven <= dateNow) {
            return true;
        }
        else {
            return false;
        }
    });

jQuery.validator.unobtrusive.adapters.addBool("dob");