using Prefeituras.Data;
using Prefeituras.Models;

namespace Prefeituras.Repository
{
    public class PrefeituraRepository : IPrefeituraRepository
    {
        private readonly BancoContext _bancoContext;

        public PrefeituraRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<PrefeituraModel> BuscarTodos()
        {
            var list = _bancoContext.Prefeitura.ToList();
            _bancoContext.SaveChanges();

            return list;
        }

        public PrefeituraModel Cadastrar(PrefeituraModel prefeitura)
        {
            _bancoContext.Prefeitura.Add(prefeitura);
            _bancoContext.SaveChanges();

            return prefeitura;
        }
    }
}
