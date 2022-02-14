using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Plataformas
{
    interface IPlataforma
    {
        void ConfiguracaoRMTP();
        void AuthToken();
    }
}
