﻿using Localiza.Frotas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Frotas.Infra.Repository
{
    public class MemoryRepository : IVeiculoRepository
    {
        private readonly IList<Veiculo> entities = new List<Veiculo>();
        public void Add(Veiculo veiculo)
        {
            entities.Add(veiculo);
        }

        public void Delete(Veiculo veiculo)
        {
            entities.Remove(veiculo);
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return entities.ToList();
        }

        public Veiculo GetById(Guid id)
        {
            return entities.SingleOrDefault(element => element.Id == id);
        }

        public void Update(Veiculo veiculo)
        {
            entities.Remove(GetById(veiculo.Id));
            entities.Add(veiculo);
        }
    }
}
