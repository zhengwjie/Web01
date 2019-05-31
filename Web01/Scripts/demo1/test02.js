
function post01() {

    var author01 = $('#Author').val();
    var text01 = $('#Comment').val();
    alert(author01);
    $.ajax(
        {
            type: "post",
            url: "GetComments01",
            dada: { author: author01, text: text01 }
        })
    //Response.redirect('/Comments/GetComments');
}