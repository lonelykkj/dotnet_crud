using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCRUD.Models
{
    public class PersonModel
    {
        public PersonModel(string name)
        {
            Name = name;
            // Gera um novo ID único para cada instância de PersonModels
            // Isso garante que cada pessoa tenha um identificador exclusivo.
            Id = Guid.NewGuid();
        }

        // Init permite que a propriedade seja definida apenas no momento da criação do objeto
        // e não possa ser alterada posteriormente, garantindo que o ID seja imutável.
        public Guid Id { get; init; }
        public string Name { get; private set; }
    }
}