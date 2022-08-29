export default function ProdutoService(){
    
    this.GetAll = async function(){
        const reponse = await fetch(`https://listmeapi20220829125529.azurewebsites.net/api/Produtos/ListarTodosProdutos`);
        const produto = await reponse.json();
        console.log(produto);
        return produto;
    }

    this.Post = async function(IdResidencia,IdProduto){
        const configPost = {
            method: 'POST',
            body: JSON.stringify(),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://listmeapi20220829125529.azurewebsites.net/api/Estoque/AdicionarEstoquePorIdResidencia${IdResidencia}?IdProduto=${IdProduto}`,configPost);
        const newEstoque = await reponse.json();
        console.log(newEstoque);
    }
}