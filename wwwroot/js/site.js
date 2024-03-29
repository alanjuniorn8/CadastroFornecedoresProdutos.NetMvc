﻿function ajaxModal() {

    $(document).ready(function () {

        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click", function (e) {
                $('#myModalContent').load(this.href, function () {
                    $('#myModal').modal({
                        keyboard: true
                    }, 'show');
                    bindForm(this);
                });
                return false;
            });
        });

        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url);
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }

    });
}

function buscaCep() {

    $(document).ready(function () {
    

        function limpaFormularioCep() {
            $("#Endereco_Logradouro").val("");
            $("#Endereco_Bairro").val("");
            $("#Endereco_Cidade").val("");
            $("#Endereco_Estado").val("");
        }

        $("#Endereco_Cep").blur(function () {

            var cep = $(this).val().replace(/\D/g, '');

            if (cep != "") {

                var validCep = /^[0-9]{8}$/;


                if (validCep.test(cep)) {

                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");

                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados){

                        if (!("erro" in dados)) {
                            $("#Endereco_Logradouro").val(dados.logradouro);
                            $("#Endereco_Bairro").val(dados.bairro);
                            $("#Endereco_Cidade").val(dados.localidade);
                            $("#Endereco_Estado").val(dados.uf);
                        } else {
                            limpaFormularioCep();
                            alert("CEP não encontrado.");
                        }

                    });

                } else {
                    limpaFormularioCep();
                    alert("Formado de CEP inválido.");
                }

            } else {
                limpaFormularioCep();
            }

        });

    });

}

$(document).ready(
    setTimeout(function () {
        $("#msg_box").fadeOut(3000);
    }, 3000)
)