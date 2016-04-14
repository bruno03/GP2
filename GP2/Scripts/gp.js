$(function () {

    //Méthode pour ajouter une ligne (Form) 
    var addFormWorkItem = function () {
        var $button = $(this);
        var $target = $button.attr("data-gp-target");
        var $formToInsert = $("#formWorkItem").html();

        $('#' + $target).append($formToInsert);
    };

    //Méthode pour supprimer les lignes si elles sont cochées
    var removeFormWorkItem = function () {
        var $checkbox = $("input:checked");

        $checkbox.each(function () {
            $formToDelete = $(this).parent();
            $formToDelete.remove(); 
        });       
        
    };

    var submitFormWorkOrder = function () {

        $formMain = $("form:first");

        

        $formMain.submit();
    }; 

    //Listener sur les boutons 
    $("button[data-gp-addformworkitem='true']").click(addFormWorkItem);
    $("button[data-gp-removeformworkitem='true']").click(removeFormWorkItem);
    $("button[data-gp-createworkorder='true']").click(submitFormWorkOrder);


    

});