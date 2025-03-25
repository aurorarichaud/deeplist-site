using System;

namespace DeepList.Api.Models {
    public class Tarefa {
        public int Id { get; set;}
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataEntrega { get; set; }
        // Foreign Key para o usuario
        public int UsuarioId { get; set; }
        public Usuario? Responsavel { get; set; }
        //                         //
        public required string Dificultade { get; set; }
        public bool Concluida { get; set; } = false;
    }
}