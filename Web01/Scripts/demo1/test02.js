
function post01() {

    var comment1 = new Comment(){ ID = 0, Author = $('#Author').val(), Text = $('#Comment').val() };
    $.ajax(
        {
            type: "post",
            url: "Comments/GetComments",
            dada: { comment: comment1 }
        })
    Response.redirect('/Comments/GetComments');
}