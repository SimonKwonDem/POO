internal class Program
{
    private static void Main(string[] args)
    {
        CajeroAutomatico cajero1 = new CajeroAutomatico("SANTANDER", 23321);
        cajero1.ConsultarSaldo();
        cajero1.DepositarDinero(20000);
        cajero1.RetirarDinero(20000);


    }

    class CajeroAutomatico
    {
        private string ubicacion;
        private int numSerie;
        private float saldoDisponible = 0;

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }
        public float SaldoDisponible
        {
            get { return saldoDisponible; }
            set { saldoDisponible = value; }
        } 

        public CajeroAutomatico(string ubicacion, int numSerie)
        {
            this.ubicacion = ubicacion;
            this.numSerie = numSerie;
        }

        public void DepositarDinero(float monto)
        {
            if (monto > 0)
            {
                saldoDisponible += monto; 
                Console.WriteLine($"Su monto de {monto} se ha acreditado");
            }
            else
               Console.WriteLine("No se ha podido ingresar el dinero");
            ConsultarSaldo();
        }
        public void RetirarDinero(float monto)
        {
            if(monto <= saldoDisponible)
            {
                saldoDisponible -= monto;
                Console.WriteLine("Su retiro fue exitoso");
                ConsultarSaldo();
            }
            else
                Console.WriteLine("No es posible realizar la operación");
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo disponible: {saldoDisponible}");
        }
    }
}