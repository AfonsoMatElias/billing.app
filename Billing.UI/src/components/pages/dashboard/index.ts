import { Component, IoC } from "bouerjs";

import html from './dashboard.html';
import * as ApexCharts from "apexcharts";

export default class Dashboard extends Component {
	readonly isDefault = true;
	readonly title = 'Dashboard';
	readonly route = '/dashboard';

	readonly currentYear: number = Number(new Date().toLocaleDateString('pt').split('/').reverse()[0]);
	readonly currentMonth: number = Number(new Date().toLocaleDateString('pt').split('/')[1]);
	readonly months = [
		'Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho',
		'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'
	];

	readonly data = {
		items: [{
			name: 'Dell E7077',
			qty: 120,
			color: '#fcaec1',
			selling: 1000
		}, {
			name: 'Sony TV 4k UHD',
			qty: 189,
			color: '#cc6b00',
			selling: 235
		}, {
			name: 'iPhone XR',
			qty: 58,
			color: '#3caba1',
			selling: 292
		}, {
			name: 'Samsung Ultra 20',
			qty: 88,
			color: '#ca6aa1',
			selling: 14
		}],

		currentMonth: this.months[this.currentMonth - 1],
		currentYear: this.currentYear,
		selectedYear: this.currentYear,

		anualInterval: Array(3).fill(this.currentYear)
			.map(function (item, index) {
				return (item - index)
			}),

		acronym: function (name: string) {
			if (!name) return '#';
			const chunck = name.toUpperCase().split(' ');
			const first = chunck[0];
			const last = chunck[chunck.length - 1];

			if (first == last) return first[0] + first[1];
			else return first[0] + last[0];
		}
	};

	constructor() {
		super(html);
	}

	loaded(): void {
		const bouer = this.bouer!;
		const data = bouer.data;
		data.currentPage = 'Dashboard';

		const lineContainer = this.el!.querySelector("#total-sales") as HTMLCanvasElement;
		const dounutContainer = this.el!.querySelector("#selling-levels") as HTMLCanvasElement;

		const isDark = (v?: any) => v || bouer.globalData.preferences.darkMode.value ? 'dark' : 'light';

		const areaData = this.months.map((item, i) => {
			return {
				x: item.substring(0, 3),
				y: ((i + 1) * 10000000) + Math.floor(Math.random() * 5050009)
			};
		});
		
		const pieData = [
			{
				sales: 57,
				employee: "Afonso Matumona"
			}, {
				sales: 13,
				employee: "Isabel Formosa Matumona"
			}, {
				sales: 10,
				employee: "Maria Matumona"
			}, {
				sales: 24,
				employee: "Sebastião Matumona"
			}, {
				sales: 6,
				employee: "Pereira Matumona"
			}
		];

		const lineChart = new ApexCharts(lineContainer, {
			theme: {
				mode: isDark(),
			},
			chart: {
				toolbar: false,
				type: "area",
				stacked: true
			},
			dataLabels: {
				enabled: false
			},
			series: [
				{
					data: areaData
				}
			],
		});

		const pieChart = new ApexCharts(dounutContainer, {
			theme: {
				mode: isDark(),
			},
			chart: {
				type: "pie",
			},
			labels: pieData.map(x => x.employee),
			series: pieData.map(x => x.sales)
		});

		// Adding all charts in the list
		const charts = [lineChart, pieChart];

		// Rendering all the charts
		charts.forEach(chart => chart.render());

		bouer.on('onThemeChange', evt => {
			const value = evt.detail.isDark;
			charts.forEach(chart => chart.updateOptions({
				theme: {
					mode: isDark(value)
				}	
			}));
		});
	}
}