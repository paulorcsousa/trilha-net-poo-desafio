namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;            
        }
          public Smartphone(string numero)
        {
            Numero = numero;           
        }
        

       public string GetModelo()
    {
        return Modelo;
    }
    public void SetModelo(string modelo)
    {
        Modelo = modelo;
    }

    public string GetIMEI()
    {
        return IMEI;
    }

    public void SetIMEI(string imei)
    {
        IMEI = imei;
    }

    public int GetMemoria()
    {
        return Memoria;
    }

    public void SetMemoria(int memoria)
    {
        Memoria = memoria;
    }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}