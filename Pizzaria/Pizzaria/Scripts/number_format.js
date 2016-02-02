function isNum(caractere) {

    var strValidos = "0123456789-,."

    if (strValidos.indexOf(caractere) == -1)

        return false;

    return true;

}

function validaTecla(campo, event) {

    var BACKSPACE = 8;

    var key;

    var tecla;

    CheckTAB = true;

    if (navigator.appName.indexOf("Netscape") != -1)

        tecla = event.which;

    else

        tecla = event.keyCode;

    key = String.fromCharCode(tecla);

    //alert( 'key: ' + tecla + ' -> campo: ' + campo.value);

    if (tecla == 13)

        return false;

    if (tecla == BACKSPACE)

        return true;

    return (isNum(key));

}