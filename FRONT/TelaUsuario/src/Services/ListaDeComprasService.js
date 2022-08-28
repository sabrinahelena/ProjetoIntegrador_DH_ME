export default function ResidenciaService(){
    
    this.GetById = async function(IdResidencia){
        const reponse = await fetch(`https://localhost:7163/api/ListaDeCompras/RequererListaDeComprasPorIdResidência?IdResidencia=${IdResidencia}`);
        const lista = await reponse.json();
        console.log(lista);
        return lista;
    }


    
    this.PatchLista = async function(Quantidade,IdProduto, IdResidencia){
        const configPatch={
            method: 'PATCH',
            body:JSON.stringify(),
            headers:{
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
            },
        }
        const reponse = await fetch(`https://localhost:7163/api/ListaDeCompras/AtualizarQuantidadeProdutoNaListaDeCompras?IdResidencia=${IdResidencia}&IdProduto=${IdProduto}&Quantidade=${Quantidade}`,configPatch)
        const Alteracao = response.json();
    }



    this.PostLista = async function(IdResidencia,IdProduto){
        const configPost = {
            method: 'POST',
            body: JSON.stringify(),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://localhost:7163/api/ListaDeCompras/AdicionarListaDeCompras?IdResidencia=${IdResidencia}&IdProduto=${IdProduto}`,configPost);
    }

    this.DeleteLista = async function(IdResidencia,IdProduto){
        const configDeleteLista={
            method:'DELETE',
            body: JSON.stringify(),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const response = await fetch(`https://localhost:7163/api/ListaDeCompras/DeletarProdutoDaListaPorId?IdProduto=${IdProduto}&IdResidencia=${IdResidencia}`,configDeleteLista);
    }
}