function entidadeValida() {


    var nome = document.getElementById("TextBoxNomeID").value;
    var morada = document.getElementById("TextBoxMoradaID").value;
    var codPostal = document.getElementById("TextBoxCodPostalID").value;
    var localidade = document.getElementById("TextBoxLocalidadeID").value;
    var email = document.getElementById("TextBoxEmailID").value;
    var telemovel = document.getElementById("TextBoxTelefoneID").value;
    var telefone = document.getElementById("TextBoxTelemovelID").value;
    var fax = document.getElementById("TextBoxFaxID").value;
    var cc = document.getElementById("TextBoxCcID").value;
    var iban = document.getElementById("TextBoxIbanID").value;
    var nif = document.getElementById("TextBoxNifID").value;
    var letrasEspacosExp = /^[ÂÊÎÔÛÁÉÍÓÚÃÕÑÇâêîôûñõãáéíóúça-zA-Z ]*$/
    var telefoneExp = /^[0-9]{9,14}$/
    var telemovelExp = /^[0-9]{9,14}$/
    var faxExp = /^[0-9]{9,14}$/
    var ccExp = /^[0-9]{7,8}$/
    var nifExp = /^[0-9]{9}$/
    var emailExp = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    var codPostalExp = /^\d+-\d+$/
    var ibanExp = /^(\w\w)([0-9]{23})/


    if (nome == '' ||
        morada == '' ||
        codPostal == '' ||
        localidade == '' ||
        email == '' ||
        telemovel == '' ||
        telefone == '' ||
        fax == '' ||
        cc == '' ||
        iban == '' ||
        nif == '')
    {
    alert("Todos os campos devem estar preenchidos");
    return false;
    }

    if ((!codPostal.lenght == 8) || (!codPostal.match(codPostalExp))) {
        alert("O código postal deve ter o formato 0000-000.");
        return false;

    }

    if (!localidade.match(letrasEspacosExp)) {
        alert("A localidade deve conter apenas letras e espaços.");
        return false;

    }


    if (!email.match(emailExp)) {
        alert("Formato de email inválido.");
        return false;

    }



    if (!telefone.match(telefoneExp)) {
        alert("O telefone deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;

    }

    if (!telefone.match(telefoneExp)) {
        alert("O telemóvel deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;

    }

    else if (!fax.match(faxExp)) {
        alert("O fax deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;

    }

    if (!cc.match(ccExp)) {
        alert("O número do Cartão de Cidadão deve ser composto por 7 ou 8 algarismos");
        return false;

    }


    if (!iban.match(ibanExp)) {
        alert("O IBAN é composto por 25 caracteres: 2 letras + 23 algarismos.");
        return false;

    }

    if (!nif.match(nifExp)) {
        alert("O NIF deve ser composto por 9 algarismos");
        return false;

    }

}

function entidadeValidaTribunal() {


    var nome = document.getElementById("TextBoxNomeID").value;
    var morada = document.getElementById("TextBoxMoradaID").value;
    var codPostal = document.getElementById("TextBoxCodPostalID").value;
    var localidade = document.getElementById("TextBoxLocalidadeID").value;
    var email = document.getElementById("TextBoxEmailID").value;
    var telemovel = document.getElementById("TextBoxTelefoneID").value;
    var telefone = document.getElementById("TextBoxTelemovelID").value;
    var fax = document.getElementById("TextBoxFaxID").value;
    var iban = document.getElementById("TextBoxIbanID").value;
    var nif = document.getElementById("TextBoxNifID").value;
    var letrasEspacosExp = /^[ÂÊÎÔÛÁÉÍÓÚÃÕÑÇâêîôûñõãáéíóúça-zA-Z ]*$/
    var telefoneExp = /^[0-9]{9,14}$/
    var telemovelExp = /^[0-9]{9,14}$/
    var faxExp = /^[0-9]{9,14}$/
    var nifExp = /^[0-9]{9}$/
    var emailExp = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    var codPostalExp = /^\d+-\d+$/
    var ibanExp = /^(\w\w)([0-9]{23})/


    if (nome == '' ||
        morada == '' ||
        codPostal == '' ||
        localidade == '' ||
        email == '' ||
        telemovel == '' ||
        telefone == '' ||
        fax == '' ||
        iban == '' ||
        nif == '') {
        alert("Todos os campos devem estar preenchidos");
        return false;
    }

    if ((!codPostal.lenght == 8) || (!codPostal.match(codPostalExp))) {
        alert("O código postal deve ter o formato 0000-000.");
        return false;

    }

    if (!localidade.match(letrasEspacosExp)) {
        alert("A localidade deve conter apenas letras e espaços.");
        return false;

    }


    if (!email.match(emailExp)) {
        alert("Formato de email inválido.");
        return false;

    }



    if (!telefone.match(telefoneExp)) {
        alert("O telefone deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;

    }

    if (!telefone.match(telefoneExp)) {
        alert("O telemóvel deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;

    }

    else if (!fax.match(faxExp)) {
        alert("O fax deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;

    }

    if (!iban.match(ibanExp)) {
        alert("O IBAN é composto por 25 caracteres: 2 letras + 23 algarismos.");
        return false;

    }

    if (!nif.match(nifExp)) {
        alert("O NIF deve ser composto por 9 algarismos");
        return false;


    }

}