import { Component, dynamic } from "bouerjs";
// import { Chart } from "@canvasjs";
const { Chart } = require("@canvasjs/charts");

import html from './Dashboard.html';

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
		const data = this.bouer!.data;
		data.currentPage = 'Dashboard';

		// Chart Loading
		const totalSales = new Chart("total-sales", {
			title: { text: '' },
			animationEnabled: true,
			theme: (false ? 'dark1' : 'light2'),
			axisX: {
				labelFontColor: '#878787',
			},
			axisY: {
				gridColor: "#f2f2f2",
				labelFontColor: '#878787',
			},
			data: [{
				type: "splineArea",
				lineDashType: 'solid',
				// line: true,
				// lineColor: 'rgba(81, 160, 213)',
				color: 'rgba(81, 160, 213, 0.6)',
				markerColor: 'rgba(81, 160, 213)',
				dataPoints: this.months.map((item, index) => {
					var _index = index + 1;
					return {
						label: item.substring(0, 3),
						y: (_index * 10000000) + Math.floor(Math.random() * 50500009)
					};
				})
			}]
		});
		const sellingLevels = new Chart("selling-levels", {
			title: { text: '' },
			animationEnabled: true,
			data: [{
				type: "doughnut",
				startAngle: 60,
				innerRadius: 86,
				indexLabel: "{label} - #percent%",
				toolTipContent: "<b>{label}:</b> {y} Itens (#percent%)",
				dataPoints: [{
					y: 57,
					label: "Afonso Matumona"
				}, {
					y: 13,
					label: "Isabel Formosa Matumona"
				}, {
					y: 10,
					label: "Maria Matumona"
				}, {
					y: 24,
					label: "Sebastião Matumona"
				}, {
					y: 6,
					label: "Pereira Matumona"
				}]
			}]
		});

		// Adding all charts in the list
		const charts = [totalSales, sellingLevels];

		// Rendering all the charts
		charts.forEach(chart => chart.render());
	}
}