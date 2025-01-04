using Prefeituras.Models;

namespace Prefeituras.Repository
{
    public interface IPrefeituraRepository
    {
        List<PrefeituraModel> BuscarTodos();
        PrefeituraModel Cadastrar(PrefeituraModel prefeitura);
    }
}
