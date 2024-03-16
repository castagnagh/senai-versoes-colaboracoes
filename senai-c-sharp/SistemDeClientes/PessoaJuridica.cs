using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemDeClientes
{
    internal class PessoaJuridica : Clientes
    {
        public string Cnpj {  get; set; }
        public string Ie {  get; set; }

        public override void PagarImposto(double valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
