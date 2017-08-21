$( function() {
    $(".datepicker").datepicker({
        dateFormat: "dd/mm/yy"
    });

    $.validator.methods.date = function (value, element) {
        return true;
    }
} );
