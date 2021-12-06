using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Localiza.Frotas.Domain;

namespace Localiza.Frotas.Infra.Repository.EF
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options) : base(options)
        {

        }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
