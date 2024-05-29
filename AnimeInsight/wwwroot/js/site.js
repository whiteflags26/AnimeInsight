// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//textbox character count
function inputHandler(args) {
    let word, addresscountRem, addressCount;
    word = this.respectiveElement.value;
    addressCount = word.length;
    addresscountRem = document.getElementById('numbercount');
    addresscountRem.textContent = addressCount + "/2000";
}
