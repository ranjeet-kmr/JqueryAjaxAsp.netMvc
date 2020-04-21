function ShowImagePreview(imageUploader, previewImage) {
    if (imageUploader.files && imageUploader.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImage).attr('src', e.target.result);
        }
        reader.readAsDataURL(imageUploader.files[0]);
    }
}

function jQueryAjaxPost(form) {
    $.validator.onobtrusive.parse(form);
    if ($(form).valid()) {
        var ajaxconfig = {
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (response) {
                $("#firsttab").html(response)
            }
        }
        if ($(form).attr('enctype') == "multipart/form-data") {

        }
        $.ajax();

    }
    return false;
}