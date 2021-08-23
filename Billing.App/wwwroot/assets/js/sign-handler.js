function signHandler() {
    var easy = this;
    // A  shortcut for document
    var doc = document;
    var eventPrevented = function (selector, event, callback) {
        var el = doc.node(selector);
        if (el) el.listen(event, function (evt) {
            evt.preventDefault();
            if (callback) callback.call(null, evt);
        });
    }

    // validation.listen( doc.node('#signin-form') || 
    // doc.node('#signup-form') || 
    // doc.node('#signup-form'), null, null, true );

    // Basic form handling
    // Actions for buttons pressed in stepable container
    var stepActions = {
        baseURL: '',
        // SignIp form action
        SignIn: function (event) {
            var form, btn;

            if (event.base.nodeName === 'FORM') {
                form = event.base;
                btn = form.node('button');
            } else {
                btn = event.base;
                form = btn.aboveMe('form');
            }
            
            if (hasSpinner(btn)) return;
            addOrRemSpinner(btn);

            var formObj = easy.toJsObj(form);

            easy.create('sign/in', {
                User: formObj.User,
                Password: formObj.Password
            })
                .then(function (data) {
                    sessionStorage.token = data.result.type + ' ' + data.result.token;
                    window.location.href = '/';
                })
                .catch(function (error) {
                    notify({
                        type: 'error',
                        message: error.message
                    });
                })
                .finally(function () {
                    addOrRemSpinner(btn, true);
                });
            return false;
        },
        // SignUp form action
        SignUp: function (event) {
            var form, btn;

            if (event.base.nodeName === 'FORM') {
                form = event.base;
                btn = form.node('.send-data');
            } else {
                btn = event.base;
                form = btn.aboveMe('form');
            }

            if (hasSpinner(btn)) return;
            addOrRemSpinner(btn);

            // Executes the main action
            setTimeout(function () {
                addOrRemSpinner(btn, true);
            }, 2000);

            return false;
        },
        // Email validation for reset password form 
        EmailValidation: function (event) {
            console.log('Validating the email');
            return true;
        },
        // Code validation for reset password form 
        CodeValidation: function (event) {
            console.log('Validating the code');
            return true;
        },
        // Code validation for reset password form 
        ResetPassword: function (event) {
            var form, btn;

            if (event.base.nodeName === 'FORM') {
                form = event.base;
                btn = form.node('.send-data');
            } else {
                btn = event.base;
                form = btn.aboveMe('form');
            }

            if (hasSpinner(btn)) return;
            addOrRemSpinner(btn);

            // Executes the main action
            setTimeout(function () {
                addOrRemSpinner(btn, true);
            }, 2000);
            return false;
        }
    };

    // The Main step action
    var stepControl = function (event, dir) {
        event.preventDefault();

        // Getting the action
        var action = stepActions[event.base.valueIn('action')];
        if (action) {
            var keepOn = action(event);
            if (!keepOn) return;
        }

        event.base.valueIn('action');

        // Getting the section
        var current = event.base.aboveMe('.stepable');

        // Defining some className
        var hide = 'hide-it';

        // Checking if the current is valid
        if (current) {
            // Aux var to store the next or prev child 
            var other = null;

            // Switching between the direction
            switch (dir) {
                case 'next':
                    other = current.nextElementSibling;
                    break;
                case 'prev':
                    other = current.previousElementSibling;
                    break;
            }

            // Checking if the other was found
            if (!other) return;

            // Setting up the animations
            switch (dir) {
                case 'next':
                    other.niceIn('left', current, function (o, c) {
                        o.classList.remove(hide);
                        c.classList.add(hide);
                    });
                    break;

                case 'prev':
                    other.niceIn('right', current, function (o, c) {
                        o.classList.remove(hide);
                        c.classList.add(hide);
                    });
                    break;
            }
        }
    }

    // Form step handler
    var next = doc.nodes('.next-form');
    var prev = doc.nodes('.prev-form');

    // Adding the stepAction event
    next.listen('click', function (e) {
        e.preventDefault();
        // Next form
        stepControl(e, 'next');
    });
    prev.listen('click', function (e) {
        e.preventDefault();
        // Previous form
        stepControl(e, 'prev');
    });

    // Form Submit handler
    // Preventing the default signin action
    eventPrevented('#signin-form', 'submit', function (e) {
        stepActions.SignIn(e);
    });

    // Preventing the default signup action
    eventPrevented('#signup-form', 'submit');

    // Preventing the default signup action
    eventPrevented('.sign-recover', 'submit');
    // End Form Submit handler
}