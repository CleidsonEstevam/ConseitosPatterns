using Factory.Veiculos;


namespace Factory.Factores
{
    abstract class Frota
    {
        public void CriandoTransporte() 
        {
            IVeiculos veiculo = CriarVeiculo();
            veiculo.ComecarRota();
        
        }

        protected abstract IVeiculos CriarVeiculo();
    }
}
