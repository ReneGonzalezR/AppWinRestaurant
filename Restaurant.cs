
namespace AppWinRestaurant
{
    class Restaurant : IRestaurant
    {
        public Restaurant(double valor,int valor2)
        {
            Total = valor;
            Contador = valor2;
        }
        public double Total{ get; set; }
        public int Contador { get; set; }

        public void Agregar (int opcion, double extra)
        {
            switch (opcion)
            {
                case 1:
                    Contador = Contador + 3;
                    Total = Total + 80;
                    break;
                case 2:
                    Contador = Contador + 3;
                    Total = Total + 60;
                    break;
                case 3:
                    Contador++;
                    Total = Total + extra;
                    break;
            }
        }
        public void Quitar(int valor, double extra)
        {
            Contador = Contador - valor;
            Total = Total - extra;
        }
    }
}
