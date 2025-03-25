namespace DeepList.Client.Services {
    public class UsuarioService {
        public Usuario? UsuarioAtual { get; private set; }

        public bool EstaLogado => UsuarioAtual is not null;

        public void Login(Usuario usuario) {
            UsuarioAtual = usuario;
        }

        public void Logout() {
            UsuarioAtual = null;
        }

        public class Usuario {
            public int Id { get; set; }
            public string Nome { get; set; } = "";
        }
    }
}
