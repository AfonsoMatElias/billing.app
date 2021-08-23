new Easy("body", {
    data: {
        // Variables
        search: "",
        showSearchBar: true,
        currentPage: "None",
        pageLoading: false,
        showNotification: false,
        showConversation: false,
        showProfile: false,

        products: [
            {
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
        conversations: [
            {
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
        notifications: [
            {
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
            var current = evt.base.nextElementSibling;
            // Closing the old if needed
            if (old) old.classList.remove(cls);
            // Return if the current is equal to the old and clear storage
            if (current === old) return this.data.openedMenu = null;
            // Opening the current
            if (current) current.classList.add(cls);
            // Storing the current opened
            this.data.openedMenu = current;

            current.nodes('a').filter(function (item) {
                item.onclick = function () {
                    current.classList.remove(cls);
                }
            });
        }
    },
    mounted: function () {
        var $easy = this;
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
            if ($easy.data.pageLoading == true && pagesLoading === 0)
                $easy.data.pageLoading = false;
        }
        this.on("incRequested", function () {
            pagesLoading++;
            if (this.data.pageLoading === false) this.data.pageLoading = true;
        });

        // Everything loaded
        this.on("incLoaded", function () {
            decreasePageLoaded();
        });

        // If some page is blocked, then load the main page
        this.on("incBlocked", function () {
            decreasePageLoaded();
        });

        this.on("incFail", function () {
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

        $easy.get('sign/account')
            .then(function (data) {
                $easy.setData(data.result, $easy.data.application.user);
            })
            .catch(function (error) {
                if (error.message === 'Unauthorized')
                    return;

                notify({
                    type: 'error',
                    message: error.message || error
                });
            });

        var jwtObj =  JSON.parse(atob(sessionStorage.token.split(' ')[1].split('.')[1]))

        this.data.application.role = Array.isArray(jwtObj.role) ? jwtObj.role[0] : jwtObj.role;
    },
    loaded: function () {
        // Calling all the external functions
        this.call([
            window.signHandler
        ], true);
    },
    components: {
        config: {
            usehash: false,
            preload: true,
        },
        elements: {
            table: "/components/elements/table",
            popup: "/components/elements/popup",
            address: "/components/shared/address",
            contact: "/components/shared/contact",
            "create-person": "/components/shared/create-person",

            // # Views
            dashboard: {
                route: "/dashboard",
                url: "/components/views/dashboards/dashboard",
                title: "Dashboard",
                isDefault: true,
                children: {
                    "dash-stock": {
                        route: "/stock",
                        url: "/components/views/dashboards/stock",
                        title: "Dashboard • Stock de Produtos",
                        //keepAlive: true
                    },
                },
            },

            "choose-page": {
                route: "/choose/:type",
                url: "/components/shared/choose-page",
                title: "Escolha o Tipo",
            },

            // Customer
            "customer-create": {
                route: "/customers/create/:type/:typeEntity",
                url: "/components/views/customer/create",
                title: "Cliente • Cadastrar",
            },
            "customers-singular": {
                route: "/customers/tps",
                url: "/components/views/customer/list-singular",
                title: "Cliente • Listagem (Singulares)",
            },
            "customers-company": {
                route: "/customers/tpc",
                url: "/components/views/customer/list-company",
                title: "Cliente • Listagem (Colectivas)",
            },
            "customers-view": {
                route: "/customers/view/:type/:typeEntity/:id",
                url: "/components/views/customer/view",
                title: "Cliente • Visualizar",
            },

            // Provider
            "provider-create": {
                route: "/providers/create/:type/:typeEntity",
                url: "/components/views/provider/create",
                title: "Cliente • Cadastrar",
            },
            "providers-singular": {
                route: "/providers/tps",
                url: "/components/views/provider/list-singular",
                title: "Fornecedor • Listagem (Singulares)",
            },
            "providers-company": {
                route: "/providers/tpc",
                url: "/components/views/provider/list-company",
                title: "Fornecedor • Listagem (Colectivas)",
            },
            "providers-view": {
                route: "/providers/view/:type/:typeEntity/:id",
                url: "/components/views/provider/view",
                title: "Fornecedor • Visualizar",
            },

            // Product
            products: {
                route: "/products",
                url: "/components/views/product/list",
                title: "Produto • Listagem",
                children: {
                    "product-create": {
                        route: "/create",
                        url: "/components/views/product/create",
                        title: "Produto • Cadastrar",
                        keepAlive: true,
                    },
                    "product-view": {
                        route: "/view/:id",
                        url: "/components/views/product/view",
                        title: "Produto • Visualizar",
                    },
                },
            },

            // Sell
            sell: {
                route: "/sell",
                url: "/components/views/sell",
                title: "Venda",
                keepAlive: true,
            },

            // Buy
            buy: {
                route: "/buy",
                url: "/components/views/buy",
                title: "Compra",
                keepAlive: true,
            },

            // Chat
            chat: {
                route: "/chat",
                url: "/components/views/chat",
                title: "Chat",
            },

            // Report
            reports: {
                route: "/reports",
                url: "/components/views/reports",
                title: "Relatórios",
            },

            // Settings
            settings: {
                route: "/settings",
                url: "/components/views/settings/profile/profile",
                title: "Config • Perfil",
                children: {
                    "settings-employees": {
                        title: "Config • Funcionários",
                        route: "/employees",
                        url: "/components/views/settings/employees/employees",
                        children: {
                            "settings-employee-create": {
                                title: "Config • Criar Funcionário",
                                route: "/create",
                                url: "/components/views/settings/employees/create",
                            },
                        },
                    },
                    "settings-apps": {
                        title: "Config • Aplicações",
                        route: "/apps",
                        url: "/components/views/settings/apps/apps",
                    },
                    "settings-preferences": {
                        title: "Config • Preferências",
                        route: "/preferences",
                        url: "/components/views/settings/preferences/preferences",
                    },
                    "settings-establishment": {
                        title: "Config • Estabelecimento",
                        route: "/establishment",
                        url: "/components/views/settings/establishment/establishment",
                        children: {
                            "settings-establishment-create": {
                                title: "Config • Criar Estabelecimento",
                                route: "/create",
                                url: "/components/views/settings/establishment/create",
                            },
                        },
                    },
                    "settings-license": {
                        title: "Licença",
                        route: "/license",
                        url: "/components/views/settings/license/license",
                    },
                    "settings-about": {
                        title: "Sobre",
                        route: "/about",
                        url: "/components/views/settings/about",
                    },
                },
            },

            // Wrappers
            "settings-wrapper": "/components/views/settings/settings",

            // # Profile Partials
            "setting-profile-name":
                "/components/views/settings/profile/sections/setting-name",
            "setting-profile-birth":
                "/components/views/settings/profile/sections/setting-birth",
            "setting-profile-photo":
                "/components/views/settings/profile/sections/setting-photo",
            "setting-profile-password":
                "/components/views/settings/profile/sections/setting-password",
            "setting-profile-gender":
                "/components/views/settings/profile/sections/setting-gender",

            // # Establishment Partials
            "setting-establishment-name":
                "/components/views/settings/establishment/sections/setting-name",
            "setting-establishment-address":
                "/components/views/settings/establishment/sections/setting-address",
            "setting-establishment-manager":
                "/components/views/settings/establishment/sections/setting-manager",

            // Not found page
            notfound: {
                route: "/notfound",
                url: "/components/views/not-found",
                title: "404 Page Not Found",
                isNotFound: true,
            },
        },
    },
    dependencies: [
        new EasyConnector("http://localhost:5000/api/", {
            type: "json",
            headers: {
                'Accept': "application/json",
                'Content-Type': "application/json",
                'Authorization': sessionStorage.token || undefined
            },
        }),
    ],
});

function notify(obj) {
    if (!obj || !obj.message) return;

    var container = document.node(".popup-container");
    if (!container) return;
    var inc = document.createElement("inc");

    if (!obj.type) obj.type = "info";

    // Preparing the inc
    inc.valueIn("src", "popup");

    var messageData = obj.message;

    if (messageData instanceof Object) {
        messageData = "Ocorreu um erro não identificado."
        console.error('[Unknown Error]:', obj.message);
    }

    obj.message = escape(messageData);
    if (obj.url) obj.url = escape(obj.url);
    else obj.url = null;

    inc.valueIn("data", JSON.stringify(obj));

    // Inserting the node
    container.insertBefore(inc, container.children[0]);

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
    r.keys(function (key, value) {
        if (value > 0 && message == "") {
            var _key = key.substr(2);
            message = buildMessage(
                value,
                _key == "mes" ? (value == 1 ? "mês" : "mese") : _key
            );
        }
    });

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