$('.checkbox').click(function () {
    $(this).toggleClass('checkbox fa fa-square-o');
    $(this).toggleClass('checkbox fa fa-check-square');
    $('.todo-item').toggleClass('todo-item done');
    $('.todo-item done').toggleClass('todo-item');
});