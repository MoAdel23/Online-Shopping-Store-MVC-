// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//function showImage() {
//    window.document.getElementById("profilePicture").src = window.URL.createObjectURL(this.files[0])
//    document.getElementvById("profilePicture").src = window.URL.careteObjectURL(this.files[0]);
//}

function ShowImage(e, imgsrc) {
    var image = window.document.getElementById('profilePicture');

    if (e.value == '') {
        image.src = imgsrc;
        toastr["error"]("No Image file  uploaded ", "Profile Picture");
    } else {
        imgsrc = window.URL.createObjectURL(e.files[0]);
        image.src = imgsrc;
        toastr["success"]("Image file has been uploaded successfuly", "Profile Picture");
    }
}