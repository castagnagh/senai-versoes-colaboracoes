using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemDeClientes
{
    internal class Clientes
    {
        public string Nome {  get; set; }
        public string Endereco {  get; set; }
        public double Valor { get; protected set; }
        public double ValorImposto { get; protected set; }
        public double Total { get; protected set; }

        public virtual void PagarImposto(double valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
