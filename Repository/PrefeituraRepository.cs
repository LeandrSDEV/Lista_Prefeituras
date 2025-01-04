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

        public PrefeituraModel BuscarPorId(int id)
        {
            var unico = _bancoContext.Prefeitura.FirstOrDefault(x => x.Id == id);
            _bancoContext.SaveChanges();

            return unico;
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

        public PrefeituraModel Editar(PrefeituraModel prefeitura)
        {
            var bancoDB = _bancoContext.Prefeitura.Find(prefeitura.Id);

            if (bancoDB == null) throw new Exception("Houve um erro na atualização.");

            bancoDB.Municipio = prefeitura.Municipio;
            bancoDB.NomeRH = prefeitura.NomeRH;
            bancoDB.EmailRH = prefeitura.EmailRH;
            bancoDB.TelefoneRH = prefeitura.TelefoneRH;

            _bancoContext.SaveChanges();
            return bancoDB;
            
        }
    }
}
