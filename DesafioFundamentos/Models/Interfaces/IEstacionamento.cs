using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models.Interfaces
{
    public interface IEstacionamento
    {
        public void AdicionarVeiculo();
        public void ListarVeiculos();
        public void RemoverVeiculo();
    }
}