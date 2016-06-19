function entidadeValida() {

    var nome, morada, codPostal, localidade, email, telemovel, telefone, fax, cc, iban, nif, lastChangeBy;
    var emailRegex;

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
    // var letrasEspacosExp = /^[a-zA-Z ]*$/
    var letrasEspacosExp = /^[ÂÊÎÔÛÁÉÍÓÚÃÕÑÇâêîôûñõãáéíóúça-zA-Z ]*$/
    var emailExp = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    var codPostalExp =/^\d+-\d+$/


    if (nome == '' && morada =='' && codPostal == '' && localidade == '' && email == '' && telemovel =='' && telefone =='' && fax== '' && cc =='' && iban =='' && nif == '' && lastChangeBy)
    {
        alert( "Todos os campos devem estar preenchidos");
        return false;     
    }

    if (!nome.match(letrasEspacosExp))
    {
        alert("O nome deve conter apenas letras e espaços.");
        return false;
        nome.focus();
    }

    if (!localidade.match(letrasEspacosExp))
    {
        alert("A localdiade deve conter apenas letras e espaços.");
        return false;
        localidade.focus();
    }


    if (!email.match(emailExp))
    {
        alert("Formato de email inválido.");
        return false;
        email.focus();
    }

    if (isNaN(telemovel.value)) {
        alert("O telemovel deve ser composto apenas por algarismos");
        return false;
        telemovel.focus();
    }

    if (isNaN(telefone.value)) {
        alert("O telefone deve ser composto apenas por algarismos");
        return false;
        telefone.focus();
    }

    if (cc.value.length !== 8 && isNaN(cc.value)) {
        alert("O número do Cartão de Cidadão deve ser composto por 8 algarismos");
        return false;
        cc.focus();
    }

    if (nif.value.length !== 9 && isNaN(nif.value)) {
        alert("O NIF deve ser composto por 9 algarismos");
        return false;
        nif.focus();
    }

    if (nif.value.length !== 9 && isNaN(nif.value)) {
        alert("O NIF deve ser composto por 9 algarismos");
        return false;
        nif.focus();
    }

    if((codPostal.value.lenght !== 8) && (!codPostal.match(codPostalExp)))
    {
        alert("O código postal deve ter o formato 0000-000.");
        return false;
        codPostal.focus();
    
    }




}