using Prefeituras.Models;

namespace Prefeituras.Repository
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Cadastrar(UsuarioModel usuario);
        UsuarioModel Editar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
