// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function get_names(){
    $('#teamnames').attr('hidden','hidden');
    $('#teamnames2').removeAttr('hidden', 'hidden');
    $('#button1').attr('hidden','hidden');
    $('#button2').removeAttr('hidden', 'hidden');

}
function reloaddiv(){
    $("#teamnames2").load(" #teamnames2 > *");
}