export default function ResidenciaService(){
    
    this.GetByIdEstoque = async function(IdResidencia){
        const reponse = await fetch(`https://listmeapi20220829125529.azurewebsites.net/api/Estoque/RequererEstoquePorIdResidencia${IdResidencia}`);
        const estoque = await reponse.json();
        console.log(estoque);
        return estoque;
    }

    this.PostEstoque = async function(IdResidencia,IdProduto){
        const configPost = {
            method: 'POST',
            body: JSON.stringify(),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://listmeapi20220829125529.azurewebsites.net/api/Estoque/AdicionarEstoquePorIdResidencia${IdResidencia}?IdProduto=${IdProduto}`,configPost);
        
    }

    this.PatchEstoque = async function(bodyAlteracao,IdProduto, IdResidencia){
        const configPatch={
            method: 'PATCH',
            body:JSON.stringify(bodyAlteracao),
            headers:{
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
            },
        }
        const reponse = await fetch(`https://listmeapi20220829125529.azurewebsites.net/api/Estoque/AtualizarEstoque${IdProduto}/${IdResidencia}`,configPatch)
        const Alteracao = response.json();
    }

    this.DeleteEstoque = async function(IdEstoque){
        const configPatch={
            method: 'DELETE',
            body:JSON.stringify(),
            headers:{
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
            },
        }
        const reponse = await fetch(`https://listmeapi20220829125529.azurewebsites.net/api/Estoque/DeletarEstoquePorId${IdEstoque}`,configPatch)
    }
}