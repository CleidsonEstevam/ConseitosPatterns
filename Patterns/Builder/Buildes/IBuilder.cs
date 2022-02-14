using Builder.Componentes;
using Builder.Produtos;


namespace Builder.Buildes
{
    interface IBuilder
    {
        void Reset();

        Veiculo GetVeiculo();

        void Cambio(Cambio cambio);

        void Motor(Motor motor);

        void TipoDeVeiculo(TipoDeVeiculo tipoDeVeiculo);
    }
}
