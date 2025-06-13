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
            Id = Guid.NewGuid(); // Gera um novo ID único para cada instância de PersonModels. Isso garante que cada pessoa tenha um identificador exclusivo.
        }

        public Guid Id { get; init; } // Init permite que a propriedade seja definida apenas no momento da criação do objeto e não possa ser alterada posteriormente, garantindo que o ID seja imutável.
        public string Name { get; private set; }

        public void ChangeName(string name){
            Name = name; // Método para alterar o nome da pessoa. Isso permite que o nome seja modificado após a criação do objeto, mas mantém o ID imutável.
        }

        public void SetInactive(){
            Name = "Desativado"; // Método para desativar a pessoa, alterando o nome para "Desativado". Isso pode ser útil para marcar pessoas como inativas sem removê-las do banco de dados.
        }
    }
}