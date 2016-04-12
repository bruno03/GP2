$(function () {

    var addFormWorkItem = function () {
        var $button = $(this);
        var $target = $button.attr("data-gp-target");
        var $formToInsert = $("#formWorkItem").html();

        $('#' + $target).append($formToInsert);
    };


    var deleteFormWorkItem = function () {
        var $button = $(this);
        var $formToDelete = $button.parent(); 

        console.log($button);
        console.log($formToDelete);
        alert("delete");

        //$formToDelete.remove(); 
        /*
        var $button = $(this);
        var $formToInsert = $("div[data-gp-formworkitem='true']").parent().html();

        console.log($button); 
        $('#' + $target).remove($formToInsert);
        */
    };


    var removeFormWorkItem = function () {

        var $checkbox = $(".myCheckBox");

        if(($checkbox).is(':checked'))
        {
            $formToDelete = $checkbox.parent().parent();

            $formToDelete.remove(); 

        }

        console.log($checkbox); 


        alert("REMOVE"); 
    }; 


    $("button[data-gp-addformworkitem='true']").click(addFormWorkItem);
    $("button[data-gp-deleteformworkitem='true']").click(deleteFormWorkItem);
    $("button[data-gp-removeformworkitem='true']").click(removeFormWorkItem);


    console.log("démarrage gp.js")
    

});