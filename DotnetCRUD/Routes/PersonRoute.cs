using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCRUD.Models;
using DotnetCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace DotnetCRUD.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app){
            var route = app.MapGroup("/person");
            
            route.MapPost("/", async (PersonRequest req, PersonContext context) => {
                var person = new PersonModel(req.name);

                await context.AddAsync(person); // Adiciona a pessoa ao contexto do banco de dados
                
                await context.SaveChangesAsync(); // Salva as alterações no banco de dados
            });

            route.MapGet("/", async (PersonContext context) => {
                var people = await context.People.ToListAsync(); // Recupera todas as pessoas do banco de dados e retorna como uma lista

                if(people.Count == 0){
                    return Results.NotFound("Nenhuma pessoa encontrada.");
                }
                
                return Results.Ok(people); 
            });

            route.MapPut("/{id:guid}", async(Guid id, PersonRequest req, PersonContext context) => {

                var person = await context.People.FindAsync(id) ; // Busca a pessoa pelo ID

                if (person ==null)
                    return Results.NotFound("Pessoa não encontrada."); 

                person.ChangeName(req.name); 
                await context.SaveChangesAsync(); 

                return Results.Ok(person);
            });

            route.MapDelete("/{id:guid}", async(Guid id, PersonContext context) => {
                var person = await context.People.FindAsync(id); 

                if (person == null)
                    return Results.NotFound("Pessoa não encontrada."); 


                // context.People.Remove(person);
                person.SetInactive();
                await context.SaveChangesAsync(); 

                return Results.Ok("Pessoa removida com sucesso."); 
            });
        }
    }
} 