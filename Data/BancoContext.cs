using Microsoft.EntityFrameworkCore;
using Prefeituras.Models;
using System.Data.Common;

namespace Prefeituras.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        public DbSet<PrefeituraModel> Prefeitura { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
