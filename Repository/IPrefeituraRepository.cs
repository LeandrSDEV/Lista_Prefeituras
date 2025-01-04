using Prefeituras.Models;

namespace Prefeituras.Repository
{
    public interface IPrefeituraRepository
    {
        List<PrefeituraModel> BuscarTodos();
        PrefeituraModel BuscarPorId(int id);
        PrefeituraModel Cadastrar(PrefeituraModel prefeitura);
        PrefeituraModel Editar(PrefeituraModel prefeitura);
        bool Apagar(int id);
    }
}
