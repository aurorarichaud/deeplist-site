using System.Collections.Generic;

namespace DeepList.Api.Models {
    public class Usuario {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Senha { get; set; }

        public List<Tarefa> Tarefas {get; set; } = new();
    }
}