$(document).ready(function () {
    $("#btnajax").click(function () {

      
        $.ajax({
            data: JSON.stringify({
                'id': $(this).val()

            }),
            url: "/Cd/ExcluirAjax",
            method: "POST",
            contentType: "application/json",
            success: function (msg) {
                alert(msg); //recebe retorno do controller
                location.reload();
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                console.log("erro na requisição - getMenorNumero");
                alert('erro >>>' + errorThrown + '>> ' + XMLHttpRequest.responseText);
            },
            cache: false,
            async: false
        });

    });
    })