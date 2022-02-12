using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Componentes
{
    class Motor
    {
        private int ligar;
        public int Ligar { get; set; }
        public Motor(int ligar)
        {
            this.Ligar = ligar;
        }
    }
   
   
}
