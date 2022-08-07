using ListMEAPI.DependencyInjections;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace ListMEAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Sprint 3 -  Briefing",
                    Description = "-----add----",
                    TermsOfService = new Uri("https://www.exemplo.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Site oficial",
                        Url = new Uri("https://www.exemplo.com")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Licença",
                        Url = new Uri("https://example.com/license")
                    }
                });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                config.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

            });




            var Chave = Encoding.ASCII.GetBytes(Ambiente.Chave);

            // Adiciono os serviços de Autenticação e Autorização utilizando Jwt Bearer
            // e configurando Autenticação por padrão como Jwt B e os parametros de validação
            // do Token.
            builder.Services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Chave),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            builder.Services.AddDbContext<ListMEContext>();
            builder.Services.ResolveApiDependencies();

            //Ignorando possíveis ciclos do get one de usuário SE HOUVER USUARIO EM RESIDENCIA
            //builder.Services.AddControllers().AddJsonOptions(x =>
            //    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}