using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCRUD.Models;
using DotnetCRUD.Data;

namespace DotnetCRUD.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app){
            var route = app.MapGroup("/person");
            
            route.MapPost("/", async (PersonRequest req, PersonContext context) => {
                var person = new PersonModel(req.name);

                // Adiciona a pessoa ao contexto do banco de dados
                await context.AddAsync(person);
                
                // Salva as alterações no banco de dados
                await context.SaveChangesAsync();
            });
        }
    }
} 