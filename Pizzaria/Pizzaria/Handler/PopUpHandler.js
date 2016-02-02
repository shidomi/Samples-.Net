
setInterval(function () { WindowHandler() }, 2000);
function WindowHandler() {
    var lbl = $("#lbl").text();

    if (lbl != "") {

        var res = lbl.split(" ", 2);

        if (res[0] == "new") {
            var w = 530;
            var h = 580;
            var left = Number((screen.width / 2) - (w / 2));
            var tops = Number((screen.height / 2) - (h / 2));
            window.open("NewCustomer.aspx?nmbr=" + res[1], '', 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=no, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=' + tops + ', left=' + left);
        }
        else{
            var w = 500;
            var h = 450;
            var left = Number((screen.width / 2) - (w / 2));
            var tops = Number((screen.height / 2) - (h / 2));
            window.open("FoundCustomer.aspx?" + lbl, '', 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=no, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=' + tops + ', left=' + left);
        }
    }
}
