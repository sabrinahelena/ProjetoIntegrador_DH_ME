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



    // this.Post = async function(IdResidencia,IdProduto){
    //     const configPost = {
    //         method: 'POST',
    //         body: JSON.stringify(),
    //         headers: {
    //             'Content-Type': 'application/json; charset=UTF-8',
                
    //             'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
    //           },
    //     }
    //     const reponse = await fetch(`https://localhost:7163/api/ListaDeCompras/AdicionarListaDeCompras?IdResidencia=${IdResidencia}&IdProduto=${IdProduto}`,configPost);
    //     const newLista = await reponse.json();
    //     console.log(newLista);
    // }
}