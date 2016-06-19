function utilizadorValido() {

    var username = document.getElementById("TextBoxUsernameID").value;
    var password = document.getElementById("TextBoxPasswordID").value;
    var confirmarPassword = document.getElementById("TextBoxConfirmarPasswordID").value;
    var email = document.getElementById("TextBoxEmailID").value;
    var telefone = document.getElementById("TextBoxTelefoneID").value;

    var usernameExp = /^\w+$/
    var emailExp = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    var telefoneExp = /^[0-9]{9,14}$/
    var passwordExp = /^[0-9a-zA-Z]{8,}$/



    if (username.length == 0 || password.length == 0 || confirmarPassword.length == 0 || email.length == 0 || telefone.length == 0)
    {
        //alert("Todos os campos devem estar preenchidos");

        alert("Todos os campos devem ser preenchidos.");
        return false;
    }

    if(!username.match(usernameExp))
    {
        alert("O username deve conter apenas números e letras, sem acentos ou cedilhas");
        return false;
    }

    if (!password.match(passwordExp)) {
        alert("A password deve conter pelo menos 8 caracteres, apenas números e letras, sem acentos ou cedilhas");
        return false;
    }


    if (confirmarPassword !== password)
    {
        alert("Passwords não combinam. Certifique-se de que as password são iguais.");
        return false;
    }


    if (!email.match(emailExp)) 
    {
        alert("Formato de email inválido.");
        return false;
    }


    if (!telefone.match(telefoneExp)) 
    {
        alert("O telefone deve ser composto apenas por algarismos, um total de 9 a 14.");
        return false;
    }

}

function utilizadorValidoEditar() {

    var username = document.getElementById("TextBoxUsernameID").value;
    var email = document.getElementById("TextBoxEmailID").value;
    var telefone = document.getElementById("TextBoxTelefoneID").value;

    var usernameExp = /^\w+$/
    var emailExp = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    var telefoneExp = /^[0-9]{9,14}$/


    if (username.length == 0 || email.length == 0 || telefone.length == 0) {
        //alert("Todos os campos devem estar preenchidos");

        alert("Todos os campos devem ser preenchidos.");
        return false;
    }

    if (!username.match(usernameExp)) {
        alert("O username deve conter apenas números e letras, sem acentos ou cedilhas");
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

}
