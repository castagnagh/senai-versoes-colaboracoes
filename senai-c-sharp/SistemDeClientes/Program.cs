namespace SistemDeClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("Informe o seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o seu Endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica(j) ?");
            string tipo = Console.ReadLine();
            if(tipo == "f")
            {
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = nome;
                pf.Endereco = endereco;
                Console.WriteLine("Informe o seu CPF: ");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Informe seu RG: ");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Informar o Valor de Compra: ");
                valor = double.Parse(Console.ReadLine());
                pf.PagarImposto(valor);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome...........: " + pf.Nome);
                Console.WriteLine("Endereço.......: " + pf.Endereco);
                Console.WriteLine("CPF............: " + pf.Cpf);
                Console.WriteLine("RG.............: " + pf.Rg);
                Console.WriteLine("Valor de Compra: " + pf.Valor.ToString("C"));
                Console.WriteLine("Imposto........: " + pf.ValorImposto);
                Console.WriteLine("Total a Pagar..: " + pf.Total);
            }
        }
    }
}