export default interface ProdutoModel {
	id: Number
	createdAt: Date
	updatedAt: Date
	visibility: boolean
	uid: string;
	nome: string; 
	nomeSecundario: string; 
	codigo: string;
	descricao: string; 
	precoUnitario: Number 
	iVA: Number
	subCategoriaId: Number 
	isPerecivel: boolean 
	isStock: boolean
}