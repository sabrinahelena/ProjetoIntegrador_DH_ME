export default function UsuarioService(){
    
    this.GetById = async function(IdUsuario){
        const reponse = await fetch(`https://localhost:7163/api/CadastroUsuario/RequererUsuárioPorId${IdUsuario}`);
        const usuario = await reponse.json();
        console.log(usuario);
        console.log("alo");
        return usuario;
    }

    this.Put = async function(bodyRecipe,IdUsuario){
        const configPost = {
            method: 'POST',
            body: JSON.stringify(bodyRecipe),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://localhost:7163/api/CadastroUsuario/AlterarUsuarioPorId${IdUsuario}`,configPost);
        const newUsuario = await reponse.json();
        console.log(newUsuario);
    }
}