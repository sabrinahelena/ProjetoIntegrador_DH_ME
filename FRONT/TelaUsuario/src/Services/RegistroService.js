export default function RegistroService(){
    this.PostRegistro = async function(bodyRegistro){
        const configPostRegistro = {
            method: 'POST',
            body: JSON.stringify(bodyRegistro),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://localhost:7163/api/CadastroUsuario/AdicionarUsuario`,configPostRegistro);
        
    }
}