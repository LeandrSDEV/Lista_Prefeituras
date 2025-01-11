using Prefeituras.Data;
using Prefeituras.Models;

namespace Prefeituras.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BancoContext _bancoContext;

        public UsuarioRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel BuscarPorLogin(string login)
        {
            return _bancoContext.Usuario.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel BuscarPorId(int id)
        {
            return _bancoContext.Usuario.FirstOrDefault(x => x.Id == id);           
        }

        public List<UsuarioModel> BuscarTodos()
        {
            var list = _bancoContext.Usuario.ToList();
            _bancoContext.SaveChanges();

            return list;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            _bancoContext.Usuario.Add(usuario);
            _bancoContext.SaveChanges();

            return usuario;
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            var bancoDB = BuscarPorId(usuario.Id);

            if (bancoDB == null) throw new Exception("Houve um erro na atualização.");

            bancoDB.Nome = usuario.Nome;
            bancoDB.Email = usuario.Email;
            bancoDB.Login = usuario.Login;
            usuario.Perfil = usuario.Perfil;
            bancoDB.DataAtualizacao = DateTime.Now;

            _bancoContext.SaveChanges();
            return bancoDB;           
        }

        public bool Apagar(int id)
        {
            var bancoDB = BuscarPorId(id);

            if (bancoDB == null) throw new Exception("Houve um erro na deleção");

            _bancoContext.Usuario.Remove(bancoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        
    }
}
