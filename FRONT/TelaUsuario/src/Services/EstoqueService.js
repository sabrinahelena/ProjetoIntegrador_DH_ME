export default function ResidenciaService(){
    
    this.GetById = async function(IdResidencia){
        const reponse = await fetch(`https://localhost:7163/api/Estoque/RequererEstoquePorIdResidencia${IdResidencia}`);
        const estoque = await reponse.json();
        console.log(estoque);
        return estoque;
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
        const reponse = await fetch(`https://localhost:7163/api/Estoque/AdicionarEstoquePorIdResidencia${IdResidencia}?IdProduto=${IdProduto}`,configPost);
        const newEstoque = await reponse.json();
        console.log(newEstoque);
    }
}