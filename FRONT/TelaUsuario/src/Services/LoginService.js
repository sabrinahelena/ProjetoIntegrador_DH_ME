export default function LoginService(){
    this.PostLogin = async function(bodyLogin){
        const configPost = {
            method: 'POST',
            body: JSON.stringify(bodyLogin),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
                
                'Accept': 'application/json, application/xml, text/plain, text/html, *.*',
              },
        }
        const reponse = await fetch(`https://localhost:7163/api/Acesso/Autenticar`,configPost);
        const Login = await reponse.json();
        return Login;
    }
}