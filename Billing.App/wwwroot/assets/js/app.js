var app = new Bouer("body", {
    data: {
        baseUrl: "http://localhost:5000/api/",

        // Variables
        currentPage: "None",
        pageLoading: false,
        showNotification: false,
        showConversation: false,
        showProfile: false,

        products: [{
                id: 1,
                code: "prod1",
                name: "Água",
                nameSecondary: "Água Pura",
                price: 150,
                stock: 1000,
                subCategory: "Comida",
                estado: "Activo",
            },
            {
                id: 2,
                code: "prod2",
                name: "Arroz",
                nameSecondary: "Arroz Branco",
                price: 250,
                stock: 100,
                subCategory: "Comida",
                estado: "Activo",
            },
            {
                id: 3,
                code: "prod3",
                name: "Massa",
                nameSecondary: "Massa Amarela",
                price: 200,
                stock: 120,
                subCategory: "Comida",
                estado: "Activo",
            },
            {
                id: 4,
                code: "prod4",
                name: "Feijão",
                nameSecondary: "Feijão Preto",
                price: 500,
                stock: 10,
                subCategory: "Comida",
                estado: "Activo",
            },
        ],
        conversations: [{
                id: 1,
                user: "António Ferraz Lopes",
                message: "Rato, viste como?",
                seen: false,
                date: "2020-09-05T18:30:50.102",
            },
            {
                id: 2,
                user: "Salomão Satuta",
                message: "Fruta, viste como?",
                seen: false,
                date: "2020-09-09T20:30:50.10Z",
            },
        ],
        notifications: [{
                id: 1,
                message: "Stock de `Água` está em 5 itens!",
                date: "2020-09-09T18:41:50.102",
            },
            {
                id: 2,
                type: "fa-warning",
                message: "Stock de `Rede` está em 0 itens!",
                date: "2020-09-09T18:26:50.102",
            },
            {
                id: 3,
                message: "Stock de `Rede` está em 5 itens!",
                date: "2020-09-09T18:20:50.102",
            },
        ],

        // preferences
        preferences: {
            messagePopup: true,
            notificationPopup: true,
            cashBoxOpenCloseConfirmation: false,
            darkMode: false,
        },

        application: {
            token: '',
            role: 'Perfil',
            user: {
                id: '',
                nome: '',
                userName: '',
                user: {}
            }
        },

        // Methods
        SignOut: function () {
            this.data.application.token = '';
            window.location.href = '/index.html';
        },
        openable: function (evt) {
            // Toggleable class
            var cls = 'sub-menu-opened';
            // The old submenu
            var old = this.data.openedMenu;
            // Getting the sub menu from clicked menu
            var current = evt.currentTarget.nextElementSibling;
            // Closing the old if needed
            if (old) old.classList.remove(cls);
            // Return if the current is equal to the old and clear storage
            if (current === old) return this.data.openedMenu = null;
            // Opening the current
            if (current) current.classList.add(cls);
            // Storing the current opened
            this.data.openedMenu = current;

            [].slice.call(current.querySelectorAll('a')).filter(function (item) {
                item.onclick = function () {
                    current.classList.remove(cls);
                }
            });
        }
    },

    globalData: {
        notify: notify,
        toDate: toDate,
        signOut: signOut,
        hasSpinner: hasSpinner,
        getAchronym: getAchronym,
        getPartialData: getPartialData,
        selectOneImage: selectOneImage,
        toHumanBirthday: toHumanBirthday,
        addOrRemSpinner: addOrRemSpinner,
        calculateNotificationPeriod: calculateNotificationPeriod,
        aboveMe: aboveMe,
        toCode: toCode
    },

    config: {
        usehash: false,
        prefetch: true,
    },

    beforeLoad: function () {
        var bouer = this;

        var noTokenRequiredPages = [
            "/sign.in.html",
            "/sign.up.html",
            "/sign.recover.html",
        ];

        var isInNoTokenRequiredPages =
            noTokenRequiredPages.find(function (item) {
                return window.location.href.includes(item);
            }) != null;

        if (isInNoTokenRequiredPages && sessionStorage.token)
            return (window.location.href = "/");
        else if (!isInNoTokenRequiredPages && !sessionStorage.token)
            return (window.location.href = "/sign.in.html");

        // Is loading something
        var pagesLoading = 0;

        function decreasePageLoaded() {
            pagesLoading--;
            if (bouer.data.pageLoading == true && pagesLoading === 0)
                bouer.data.pageLoading = false;
        }
        this.on("component:requested", function () {
            pagesLoading++;
            if (this.data.pageLoading === false) this.data.pageLoading = true;
        });

        // Everything loaded
        this.on("component:loaded", function () {
            decreasePageLoaded();
        });

        // If some page is blocked, then load the main page
        this.on("component:blocked", function () {
            decreasePageLoaded();
        });

        this.on("component:fail", function () {
            decreasePageLoaded();

            notify({
                message: "Página ou ficheiro não encontrado!",
                type: "error",
            });
        });

        this.watch(
            "darkMode",
            function (v) {
                var dark = "dark-mode",
                    light = "light-mode";
                if (v) document.documentElement.classList.replace(light, dark);
                else document.documentElement.classList.replace(dark, light);
            },
            this.data.preferences
        );

        if (isInNoTokenRequiredPages) return;

        this.deps['web']('sign/account')
            .then(function (response) {
                bouer.set(response.data, bouer.data.application.user);
            })
            .catch(function (error) {
                if (error.message === 'Unauthorized')
                    return;

                notify({
                    type: 'error',
                    message: error.message || error
                });
            });

        var jwtObj = JSON.parse(atob(sessionStorage.token.split(' ')[1].split('.')[1]))

        this.data.application.role = Array.isArray(jwtObj.role) ? jwtObj.role[0] : jwtObj.role;
    },
    loaded: function () {
        if (typeof signHandler === 'function') signHandler.call(this);
    },
    components: AppComponents(),
    deps: {
        web: function (path, method, body, headers) {
            return fetch(this.data.baseUrl + path, {
                body: body,
                method: method || 'get',
                headers: headers || {
                    'Accept': "application/json",
                    'Content-Type': "application/json",
                    'Authorization': sessionStorage.token || undefined
                },
            }).then(function (response) {
                if (response.ok)
                    return response.json();
                throw new Error(response.statusText);
            }).then(serverResponse => {
                if (!serverResponse.success)
                    throw new Error(serverResponse.errors.join('\n'));
                
                return serverResponse;
            }).catch(error => {
                notify({
                    type: 'error',
                    message: error.message || error
                });
                throw error;
            });
        }
    },

    middleware: function (config, app) {
        var web = app.deps['web'];
        config('req', function (bind) {
            bind(function (context) {
                return web(context.detail.requestPath)
                    .then(function (response) {
                        return {
                            data: response.data,
                            pagination: response.pagination
                        }
                    });
            });
        });
    }
});

function notify(obj) {
    if (!obj || !obj.message) return;

    var container = document.querySelector(".popup-container");
    if (!container) return;
    var component = document.createElement("app-popup");

    if (!obj.type) obj.type = "info";

    var messageData = obj.message;

    if (messageData instanceof Object) {
        messageData = "Ocorreu um erro não identificado."
        console.error('[Unknown Error]:', obj.message);
    }

    obj.message = escape(messageData);
    if (obj.url) obj.url = escape(obj.url);
    else obj.url = null;

    component.setAttribute('data', JSON.stringify(obj));

    // Inserting the node
    container.insertBefore(component, container.children[0]);

    app.compile({
        el: component,
        context: app
    });

    if (typeof obj.run === 'function') {
        setTimeout(function () {
            obj.run();
        }, 2500);
    }
}

function calculateNotificationPeriod(input) {
    var d = Math.abs(new Date(input) - new Date()) / 1000;
    var r = {};
    var s = {
        $1ano: 31536000,
        $2mes: 2592000,
        $3semana: 604800,
        $4dia: 86400,
        $5hora: 3600,
        $6minuto: 60,
        $7segundo: 1,
    };

    Object.keys(s).forEach(function (key) {
        r[key] = Math.floor(d / s[key]);
        d -= r[key] * s[key];
    });

    function buildMessage(_int, label) {
        return "há " + _int + " " + label + (_int == 1 ? "" : "s");
    }

    var message = "";
    var keys = Object.keys(r);
    for (var key of keys) {
        var value = r[key];
        if (value > 0 && message == "") {
            var _key = key.substring(2);
            message = buildMessage(
                value,
                _key == "mes" ? (value == 1 ? "mês" : "meses") : _key
            );
        }
    }

    return message || "agora mesmo";
}

function toHumanBirthday(data) {
    if (!data) return 'N/A';

    var date = data.split('T')[0].split('-');
    var monthMap = [
        'Janeiro',
        'Fevereiro',
        'Março',
        'Abril',
        'Maio',
        'Junho',
        'Julho',
        'Agosto',
        'Setembro',
        'Outubro',
        'Novembro',
        'Dezembro'
    ];

    var day = date[2];
    var month = monthMap[(date[1] * 1 - 1)];
    var year = date[0];

    return day + ' de ' + month + ' de ' + year;
}

function toDate(jsonDate) {
    return new Date(Date.parse(jsonDate))
        .toLocaleDateString('pt');
}

function addOrRemSpinner(btn, isRemove) {
    var classList = btn.classList;
    var loadingClass = 'is-loading';
    if (isRemove) {
        classList.remove(loadingClass);
        return;
    }

    classList.add(loadingClass);
}

function hasSpinner(btn) {
    return btn.classList.contains('is-loading');
}

function getAchronym(value) {
    if (!value) return '#';
    var _splitted = value.split(' ');

    return _splitted[0][0] + ((_splitted[1] || '')[0] || '');
}

function signOut() {
    sessionStorage.removeItem('token');
    window.location.href = '/sign.in.html';
}

function getPartialData(input = {
    url: '',
    search: '',
    controls: null,
    pagination: null,
    search: '',
    beforeRequest: function () {},
    onReponse: function () {},
    onCatch: function () {},
    onFinish: function () {}
}) {

    // `this` keyword is the bouer instance
    if (!input.controls)
        return console.log("controls and pagination need to be defined");

    (input.beforeRequest || function () {}).call(this);

    if (!input.url.includes("?"))
        input.url += '?';
    else
        input.url += '&';

    var web = this.deps['web'];
    web(input.url + 'page=' + input.controls.page + '&size=' + 
        input.controls.size + '&search=' + (input.search || ''))
        .then(function (response) {
            input.onReponse(response);
        })
        .catch(function (error) {
            (input.onCatch || function () {}).call(this);
            notify({
                type: 'error',
                message: error.message || error
            });
        })
        .finally(function () {
            (input.onFinish || function () {}).call(this);
        });
}

function selectOneImage(product) {
    if (product.produtoImagens.length == 0)
        return '/assets/images/box.svg';

    return product.produtoImagens[0].imageUrl;
}

function aboveMe(me, selector) {
    var doc = document;
    // Parent getter
    function parent(elem) {
        var $node = elem.parentNode;

        if (!(selector)) return $node;
        if ($node === doc || !($node)) return null;

        var tester = doc.createElement('body');
        tester.innerHTML = $node.outerHTML;

        if ($node.nodeName === tester.nodeName)
            tester.innerHTML = '';
        else
            tester.children[0].innerHTML = '';

        if (tester.querySelector(selector))
            return $node;
        else if ($node.nodeName === tester.nodeName)
            return null;
        else
            return parent($node);
    }
    // Getting the parent
    return parent(me);
}

function toCode(len) {
    if (len == null) len = 8;
    var alpha = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ_01234567890';
    var lower = false,
        result = '',
        i = 0;
    for (i; i < len; i++) {
        var pos = Math.floor(Math.random() * alpha.length);
        result += lower ? alpha[pos].toLowerCase() : alpha[pos];
        lower = !lower;
    }
    return result;
}