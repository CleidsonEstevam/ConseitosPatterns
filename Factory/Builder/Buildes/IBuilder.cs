using Builder.Componentes;
using Builder.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Buildes
{
    interface IBuilder
    {
        void Reset();

        Veiculo GetVeiculo();

        void GetCambio(Cambio cambio);

        void Motor(Motor motor);

        void TipoDeVeiculo(TipoDeVeiculo tipoDeVeiculo);
    }
}
