using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemDeClientes
{
    internal class PessoaFisica : Clientes
    {
        public string Cpf { get; set; }
        public string Rg {  get; set; }
    }
}
