export default function ResidenciaService(){
    
    this.GetAll = async function(){
        const reponse = await fetch('https://localhost:7163/api/GerenciarUsuario/ListarTodasResidencias');
        const residencias = await reponse.json();
        console.log(residencias);
        return residencias;
    }

    this.Post = async function(bodyResidencia,IdUsuario){
        const configPost = {
            method: 'POST',
            body: JSON.stringify(bodyResidencia),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://localhost:7163/api/GerenciarUsuario/AdicionarResidencia?id=${IdUsuario}`,configPost);
        const newResidencia = await reponse.json();
        console.log(newResidencia);
    }
}