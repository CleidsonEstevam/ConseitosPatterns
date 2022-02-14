using Builder.Buildes;
using Builder.Diretores;
using Builder.Produtos;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder = new VeiculoBuilder();
            Diretor diretor = new Diretor(builder);

            diretor.ConstruirCarroSedan();

            Veiculo sedan = builder.GetVeiculo();

            Console.WriteLine(sedan);

            Console.Read();
        }
    }
}
