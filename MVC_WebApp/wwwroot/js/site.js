function validatefields(ctrls, datatype, e) {
    debugger;
    var returnflag = true;
    if (datatype == 'int') {
        var num = '1234567890\b';
        if (num.indexOf(e.key.toString()) == -1)
            returnflag = false;
    }
    else if (datatype == 'string') {
        var num = 'qwertyuioplkjhgfdsazxcvbnm .-\b';
        if (num.indexOf(e.key.toString().toLowerCase()) == -1)
            returnflag = false;

        if (ctrls.value.split(' ').length >= 3 && e.key == ' ')
            returnflag = false;
    }
    else if (datatype == 'double') {
        var num = '1234567890.\b';
        if (num.indexOf(e.key.toString()) == -1)
            returnflag = false;

        if (ctrls.value.indexOf('.') >= 0 && e.key == '.')
            returnflag = false;
    }
    return returnflag;
}
