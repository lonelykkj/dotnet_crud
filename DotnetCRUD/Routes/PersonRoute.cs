using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCRUD.Models;

namespace DotnetCRUD.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app){
            app.MapGet("person", () => new PersonModel(name:"John Doe"));
        }
    }
} 