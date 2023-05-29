using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {
            
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
