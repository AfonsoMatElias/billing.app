var patterns = {
    id: function (str) {
        patterns.id.msg = tag('Valor inválido, verifique a sequência. Ex.: 012345678LA909');
        return /^\d{9}[A-Z]{2}[\d]{3}$/.test(str);
    },
    email: function (str) {
        patterns.email.msg = tag('Valor inválido. Ex: afonso@matumona.com');
        return /^([\w\.-]+)@([\w\.-]+)\.([a-z]{1,8})(\.[a-z]{1,8})?$/i.test(str);
    },
    phone: function (str) {
        patterns.email.msg = tag('Valor inválido. Ex.: (+244|00244)915997790 . Identificador é opcional');
        return /^(\+[\d]{3}|[\d]{5})?[\d]{9}$/.test(str);
    },
    password: function (str) {
        patterns.password.msg = tag('Valor inválido. Composição: 8-20 Caracteres com digitos incluindo @ . ! - _ Ou um BI. Ex.: Abc.1234');
        return /^[A-Z][a-zA-Z\d@_\.!]{8,20}/.test(str) || /^\d{9}[A-Z]{2}[\d]{3}$/.test(str);
    },
    select: function (el) {
        patterns.select.msg = tag('Valor inválido, seleccione uma opcção excepto o \'None\'');
        return !(el.selectedIndex === -1 || el.selectedIndex == 0)
    },
    text: function (str) {
        patterns.text.msg = tag('Valor inválido, o texto só pode conter caracteres, números, e - _ . ');
        return /^[\w \.-]+$/ig.test(str)
    },
    date: function (el) {
        return !( el.value === '' );
    },
    age: function (el) {
        patterns.age.msg = tag('Valor inválido, valores aceite 01/01/1910 - 31/12/[Ano Actual - 4]. ');
        var limitMin = new Date(Date.parse('01/01/1910'));
        var limitMax = new Date(new Date().toLocaleDateString().split('/').map(function(v, i){ 
            return i === 2 ?  ((v * 1) - 4) + '' : v;
        }).join('/'));
        
        var current = new Date(el.value);
        return limitMin <= current && current <= limitMax;
    },
    'confirm-pass': function (el) {
        var pass = el.aboveMe('.input-field').previousElementSibling.node('input');
        patterns['confirm-pass'].msg = tag('As senhas não conciedem');
        return (Pass.value === el.value );
    },
    checkboxes: function (el) {
        patterns.checkboxes.msg = tag('Pelo menos uma caixa deve ser selecionada');
        var hasOne = false;

        for (var c of el.children) {
            if ( c.node('input').checked ) {
                hasOne = true;
                break;
            }
        }

        return hasOne;
    }
}

patterns['confirm-pass'].forceElement = true;
// Adding especial treatment
for (var key of ['date', 'select', 'age', 'checkboxes']) {
    patterns[key].isSpecial = true;
}

var validation = {
    listen: function (root, success, fail, addEvent) {
        if ( addEvent === null || addEvent === undefined ) addEvent = true;
        // Getting all the fields that need to be validated
        var inputs = (root || document).nodes('[validate]'),
            invalidClass = 'invalid',
            validClass = 'valid'
        // Looping them
        for (var el of inputs) {
            // Getting the pattern in the patterns
            var $pattern = patterns[el.attributes.validate.value]
            // Checking if the pattern was found
            if (!$pattern) {
                console.warn('Pattern not created yet.', el.attributes.validate.value, el);
                continue;
            }

            if (addEvent) {
                var evt = $pattern.isSpecial ? 'change' : 'keyup';
                var event = easy.lazy(function (e) {    
                    main(e.target);
                }, 800);
                el.addEventListener(evt, event, false);
            } else {
                main(el);
            }

            function main(el) {
                // Getting the actually
                var label, $elem = el;
                if ( el.hasAttribute('validate'))
                    label = $elem.previousElementSibling;
                else {
                    $elem = el.aboveMe('[validate]');
                    label = $elem.previousElementSibling;
                }

                var rule = $elem.attributes.validate.value;
                var pattern = patterns[rule];
                // Getting the value to be evaluated
                var val = $elem.value;
                // Checking if an special one
                if (pattern.isSpecial || pattern.forceElement)
                    // Changing the evaluation value
                    val = $elem;
                
                var result = pattern(val);
                var ctn = label.children[0];
                // Checking the pattern
                if (result === false) {
                    // Showing the message
                    if (!ctn && !$elem.hasAttribute('validate-unset')) label.innerHTML += pattern.msg; 
                    // Marking the border
                    $elem.classList.add(invalidClass);
                    // Fail
                    if (fail) fail($elem);
                } else {
                    // unmarking the border
                    $elem.classList.remove(invalidClass);
                    // Hiding the message
                    if (ctn && !$elem.hasAttribute('validate-unset')) label.removeChild(ctn);
                    // Show that the validation passed
                    $elem.classList.add(validClass);
                    var tId = setTimeout(function () {
                        $elem.classList.remove(validClass);
                        clearTimeout(tId);
                    }, 2000);
                    // Success
                    if (success) success($elem);
                }
            }
        }
        return inputs.length;
    },
    run: function ($form) {
        var validCounter = 0, fails = [];
        // Getting the validation data
        var total = validation.listen($form, function () {
            validCounter++;
        }, function (el) {
            fails.push(el);
        }, false);

        return {
            ok: total == validCounter,
            fails: fails
        };
    }
}

function tag(msg) {
    var structure = `<span class="error-container">
        |<span class="error-info">
            ${escape(msg)}
        <\/span>
    <\/span>`;
    return unescape(structure);
}