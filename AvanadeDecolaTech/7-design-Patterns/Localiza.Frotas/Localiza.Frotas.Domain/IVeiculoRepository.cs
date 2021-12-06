using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Frotas.Domain
{
    public interface IVeiculoRepository
    {
        public Veiculo GetById(Guid id);
        IEnumerable<Veiculo> GetAll(); // todos os veiculos
        public void Add(Veiculo veiculo); // add veiculo
        public void Delete(Veiculo veiculo); // deleta o veiculo
        public void Update(Veiculo veiculo);
    }
}
