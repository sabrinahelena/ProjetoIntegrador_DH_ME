export default function ResidenciaService(){
    
    this.GetById = async function(IdResidencia){
        const reponse = await fetch(`https://localhost:7163/api/ListaDeCompras/RequererListaDeComprasPorIdResidência?IdResidencia=1${IdResidencia}`);
        const lista = await reponse.json();
        console.log(lista);
        return lista;
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
        const reponse = await fetch(`https://localhost:7163/api/ListaDeCompras/AdicionarListaDeCompras?IdResidencia=${IdResidencia}&IdProduto=${IdProduto}`,configPost);
        const newLista = await reponse.json();
        console.log(newLista);
    }
}