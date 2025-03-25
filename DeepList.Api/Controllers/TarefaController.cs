using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeepList.Api.Data;
using DeepList.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeepList.Api.Controllers {
    [ApiController]
    [Route("api/tarefas")]
    public class TarefaController : ControllerBase {
        private readonly AppDbContext _context;

        public TarefaController(AppDbContext context) {
            _context = context;
        }

        // GET: api/tarefas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarefa>>> GetTarefas() {
            var tarefas = await _context.Tarefas
                .Include(t => t.Responsavel) // inclui dados do usuário relacionado
                .ToListAsync();
            return Ok(tarefas);
        }

        // GET: api/tarefas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefa>> GetTarefa(int id) {
            var tarefa = await _context.Tarefas
                .Include(t => t.Responsavel)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (tarefa == null) return NotFound();
            return Ok(tarefa);
        }

        // POST: api/tarefas
        [HttpPost]
        public async Task<ActionResult<Tarefa>> CriarTarefa(Tarefa tarefa) {
            // Verifica se o usuário existe
            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTarefa), new { id = tarefa.Id }, tarefa);
        }

        // PUT: api/tarefas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditarTarefa(int id, Tarefa tarefaAtualizada) {
            if (id != tarefaAtualizada.Id) return BadRequest("ID da tarefa não corresponde.");

            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa == null) return NotFound();

            // Verifica se o novo usuário existe
            var usuario = await _context.Usuarios.FindAsync(tarefaAtualizada.UsuarioId);
            if (usuario == null) return BadRequest("Usuário não encontrado.");

            tarefa.Titulo = tarefaAtualizada.Titulo;
            tarefa.Descricao = tarefaAtualizada.Descricao;
            tarefa.DataEntrega = tarefaAtualizada.DataEntrega;
            tarefa.Dificultade = tarefaAtualizada.Dificultade;
            tarefa.Concluida = tarefaAtualizada.Concluida;
            tarefa.UsuarioId = tarefaAtualizada.UsuarioId;
            tarefa.Responsavel = usuario;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/tarefas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarTarefa(int id) {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa == null) return NotFound();

            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
