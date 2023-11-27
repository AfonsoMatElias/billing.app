function signHandler() {
    var bouer = this;
    var web = bouer.deps['web'];

    // A  shortcut for document
    var doc = document;
    var eventPrevented = function (selector, event, callback) {
        var el = doc.querySelector(selector);
        if (el) el.addEventListener(event, function (evt) {
            evt.preventDefault();
            if (callback) callback.call(null, evt);
        });
    }

    // validation.addEventListener( doc.querySelector('#signin-form') || 
    // doc.querySelector('#signup-form') || 
    // doc.querySelector('#signup-form'), null, null, true );

    // Basic form handling
    // Actions for buttons pressed in stepable container
    var stepActions = {
        baseURL: '',
        // SignIp form action
        SignIn: function (event) {
            var form, btn;

            if (event.currentTarget.nodeName === 'FORM') {
                form = event.currentTarget;
                btn = form.querySelector('button');
            } else {
                btn = event.currentTarget;
                form = aboveMe(btn, 'form');
            }

            if (hasSpinner(btn)) return;
            addOrRemSpinner(btn);

            var formObj = bouer.toJsObj(form);

            web('sign/in', 'post', JSON.stringify({
                    User: formObj.User,
                    Password: formObj.Password
                }))
                .then(function (response) {
                    sessionStorage.token = response.data.type + ' ' + response.data.token;
                    window.location.href = '/';
                })
                .finally(function () {
                    addOrRemSpinner(btn, true);
                });
            return false;
        },
        // SignUp form action
        SignUp: function (event) {
            var form, btn;

            if (event.currentTarget.nodeName === 'FORM') {
                form = event.currentTarget;
                btn = form.querySelector('.send-data');
            } else {
                btn = event.currentTarget;
                form = aboveMe(btn, 'form');
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

            if (event.currentTarget.nodeName === 'FORM') {
                form = event.currentTarget;
                btn = form.querySelector('.send-data');
            } else {
                btn = event.currentTarget;
                form = aboveMe(btn, 'form');
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
        var action = stepActions[event.currentTarget.getAttribute('action')];
        if (action) {
            var keepOn = action(event);
            if (!keepOn) return;
        }

        // Getting the section
        var current = aboveMe(event.currentTarget, '.stepable');

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
    var next = doc.querySelector('.next-form');
    var prev = doc.querySelector('.prev-form');

    // Adding the stepAction event
    if (next) next.addEventListener('click', function (e) {
        e.preventDefault();
        // Next form
        stepControl(e, 'next');
    });
    if (prev) prev.addEventListener('click', function (e) {
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