﻿using ListMEAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ListMEAPI.Services
  
{
    public class TokenService
    {
        public static string GerarChaveToken(UsuarioModel usuario)
        {
            var jwt = new JwtSecurityTokenHandler();

            // 1. Implementar o Corpo/Payload do Token
            var payload = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Role, usuario.tipousuario)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                // 1.1. Implementar a Assinatura.
                SigningCredentials = new SigningCredentials(
                    // 1.1.1. Chave secreta que será utilizada para Criptografia. 
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Ambiente.Chave)),
                    // 1.1.2. Algorítimo de Criptografia.
                    SecurityAlgorithms.HmacSha256)
            };

            // 2. Crio a Chave Token
            var chaveToken = jwt.CreateToken(payload);

            // 3. Retorno a Chave Token
            return jwt.WriteToken(chaveToken);
        }
    }
}
