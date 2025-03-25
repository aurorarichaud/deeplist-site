using Microsoft.AspNetCore.Mvc;
using DeepList.Api.Data;
using DeepList.Api.Models;
using System.Linq;

namespace DeepList.Api.Controllers {
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase {
        private readonly AppDbContext _context;
        public UsuarioController(AppDbContext context) {
            _context = context;
        }
        
        [HttpPost("registrar")]
        public IActionResult Registrar(Usuario usuario) {
            if (_context.Usuarios.Any(u => u.Nome == usuario.Nome))
                return BadRequest("Nome de usuário já existente.");
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpPost("login")]
        public IActionResult Login(Usuario usuario) {
            var user = _context.Usuarios.FirstOrDefault(u => u.Nome == usuario.Nome &&u.Senha == usuario.Senha);
            if (user == null) return Unauthorized();
            return Ok(user);
        }
        

        [HttpGet]
        public IActionResult ListarUsuarios() {
            var usuarios = _context.Usuarios.Select(u => new {
                u.Id,
                u.Nome
            }).ToList();
            if (usuarios.Count == 0) {
                return NotFound("Nenhum usuário encontrado.");
            }
            return Ok(usuarios);
        }
    }
}