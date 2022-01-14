function AppComponents() {
	return [
		{
			name: "app-table",
			path: "/components/elements/table.html"
		},
		{
			name: "app-popup",
			path: "/components/elements/popup.html"
		},
		{
			name: "app-address",
			path: "/components/shared/address.html"
		},
		{
			name: "app-contact",
			path: "/components/shared/contact.html"
		},
		{
			name: "create-person",
			path: "/components/shared/create-person.html"
		},

		// Wrappers
		{
			name: "settings-wrapper",
			path: "/components/views/settings/settings.html"
		},

		// # Profile Partials
		{
			name: "setting-profile-name",
			path: "/components/views/settings/profile/sections/setting-name.html"
		},
		{
			name: "setting-profile-birth",
			path: "/components/views/settings/profile/sections/setting-birth.html"
		},
		{
			name: "setting-profile-photo",
			path: "/components/views/settings/profile/sections/setting-photo.html"
		},
		{
			name: "setting-profile-password",
			path: "/components/views/settings/profile/sections/setting-password.html"
		},
		{
			name: "setting-profile-gender",
			path: "/components/views/settings/profile/sections/setting-gender.html"
		},

		// # Establishment Partials
		{
			name: "setting-establishment-name",
			path: "/components/views/settings/establishment/sections/setting-name.html"
		},
		{
			name: "setting-establishment-address",
			path: "/components/views/settings/establishment/sections/setting-address.html"
		},
		{
			name: "setting-establishment-manager",
			path: "/components/views/settings/establishment/sections/setting-manager.html"
		},
		{
			name: "setting-establishment-regime",
			path: "/components/views/settings/establishment/sections/setting-regime.html"
		},


		// # Views
		{
			route: "/dashboard",
			path: "/components/views/dashboards/dashboard.html",
			title: "Dashboard",
			isDefault: true,
			children: [{
				route: "/stock",
				path: "/components/views/dashboards/stock.html",
				title: "Dashboard • Stock de Produtos",
				//keepAlive: true
			}]
		},

		// Customer
		{
			route: "/customers/create/{typeEntity}",
			path: "/components/views/customer/create.html",
			title: "Cliente • Cadastrar",
		},
		{
			route: "/customers/tec",
			path: "/components/views/customer/list.html",
			title: "Cliente • Listagem",
		},
		{
			route: "/customers/view/{id}",
			path: "/components/views/customer/view.html",
			title: "Cliente • Visualizar",
		},

		// Provider
		{
			route: "/providers/create/{typeEntity}",
			path: "/components/views/provider/create.html",
			title: "Cliente • Cadastrar",
		},
		{
			route: "/providers/tef",
			path: "/components/views/provider/list.html",
			title: "Fornecedor • Listagem",
		},
		{
			route: "/providers/view/{id}",
			path: "/components/views/provider/view.html",
			title: "Fornecedor • Visualizar",
		},

		// Product
		{
			route: "/products",
			path: "/components/views/product/list.html",
			title: "Produto • Listagem",
			children: [{
					route: "/create",
					path: "/components/views/product/create.html",
					title: "Produto • Cadastrar",
					// keepAlive: true,
				},
				{
					route: "/view/{id}",
					path: "/components/views/product/view.html",
					title: "Produto • Visualizar",
				}
			]
		},

		// Sell
		{
			route: "/sell",
			path: "/components/views/sell.html",
			title: "Venda",
			// keepAlive: true,
		},

		// Buy
		{
			route: "/buy",
			path: "/components/views/buy.html",
			title: "Compra",
			// keepAlive: true,
		},

		// Chat
		{
			route: "/chat",
			path: "/components/views/chat.html",
			title: "Chat",
		},

		// Report
		{
			route: "/reports",
			path: "/components/views/reports.html",
			title: "Relatórios",
		},

		// Settings
		{
			route: "/settings",
			path: "/components/views/settings/profile/profile.html",
			title: "Config • Perfil",
			children: [{
					title: "Config • Funcionários",
					route: "/employees",
					path: "/components/views/settings/employees/employees.html",
					children: [{
						title: "Config • Criar Funcionário",
						route: "/create",
						path: "/components/views/settings/employees/create.html",
					}]
				},
				{
					title: "Config • Aplicações",
					route: "/apps",
					path: "/components/views/settings/apps/apps.html",
				},
				{
					title: "Config • Preferências",
					route: "/preferences",
					path: "/components/views/settings/preferences/preferences.html",
				},
				{
					title: "Config • Estabelecimento",
					route: "/establishment",
					path: "/components/views/settings/establishment/establishment.html",
					children: [{
						title: "Config • Criar Estabelecimento",
						route: "/create",
						path: "/components/views/settings/establishment/create.html",
					}]
				},
				{
					title: "Config • Licença",
					route: "/license",
					path: "/components/views/settings/license/license.html",
				},
				{
					title: "Config • Sobre",
					route: "/about",
					path: "/components/views/settings/about.html",
				},
				{
					name: 'settings-management-wrapper',
					title: "Config • Dados de Referência",
					route: "/management",
					path: "/components/views/settings/management/management-wrapper.html",
					children: [{
							title: "Config • Lista de Armazens",
							route: "/armazem",
							path: "/components/views/settings/management/sections/armazem/list.html",
							children: [{
								title: "Config • Criar Armazem",
								route: "/create",
								path: "/components/views/settings/management/sections/armazem/create.html",
							}]
						},
						{
							title: "Config • Lista de Secções",
							route: "/seccao",
							path: "/components/views/settings/management/sections/seccao/list.html",
							children: [{
								title: "Config • Criar Secção",
								route: "/create",
								path: "/components/views/settings/management/sections/seccao/create.html",
							}]
						},
						{
							title: "Config • Lista de Categorias",
							route: "/categoria",
							path: "/components/views/settings/management/sections/categoria/list.html",
							children: [{
								title: "Config • Criar Categoria",
								route: "/create",
								path: "/components/views/settings/management/sections/categoria/create.html",
							}]
						},
						{
							title: "Config • Lista de Formas de Pagamento",
							route: "/formaPagamento",
							path: "/components/views/settings/management/sections/formaPagamento/list.html",
							children: [{
								title: "Config • Criar Forma de Pagamento",
								route: "/create",
								path: "/components/views/settings/management/sections/formaPagamento/create.html",
							}]
						},
						{
							title: "Config • Lista de Paises",
							route: "/pais",
							path: "/components/views/settings/management/sections/pais/list.html",
							children: [{
								title: "Config • Criar Pais",
								route: "/create",
								path: "/components/views/settings/management/sections/pais/create.html",
							}]
						},
						{
							title: "Config • Lista de SubCategorias",
							route: "/subcategoria",
							path: "/components/views/settings/management/sections/subcategoria/list.html",
							children: [{
								title: "Config • Criar Subcategoria",
								route: "/create",
								path: "/components/views/settings/management/sections/subcategoria/create.html",
							}]
						},
						{
							title: "Config • Lista de Tipo de Venda",
							route: "/tipovenda",
							path: "/components/views/settings/management/sections/tipovenda/list.html",
							children: [{
								title: "Config • Criar Tipo de Venda",
								route: "/create",
								path: "/components/views/settings/management/sections/tipovenda/create.html",
							}]
						},
						{
							title: "Config • Lista de Tipo de Factura",
							route: "/tipofactura",
							path: "/components/views/settings/management/sections/tipofactura/list.html",
							children: [{
								title: "Config • Criar Tipo de Factura",
								route: "/create",
								path: "/components/views/settings/management/sections/tipofactura/create.html",
							}]
						},
						{
							title: "Config • Lista de Tipo de Contacto",
							route: "/tipocontacto",
							path: "/components/views/settings/management/sections/tipocontacto/list.html",
							children: [{
								title: "Config • Criar Tipo de Contacto",
								route: "/create",
								path: "/components/views/settings/management/sections/tipocontacto/create.html",
							}]
						},
						{
							title: "Config • Lista de Tipo de Entidade",
							route: "/tipoentidade",
							path: "/components/views/settings/management/sections/tipoentidade/list.html",
							children: [{
								title: "Config • Criar Tipo de Entidade",
								route: "/create",
								path: "/components/views/settings/management/sections/tipoentidade/create.html",
							}]
						},
					]
				},
			]
		},

		// Not found page
		{
			route: "/notfound",
			path: "/components/views/not-found.html",
			title: "404 Page Not Found",
			isNotFound: true,
		},

	]
}