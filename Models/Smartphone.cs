namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string _Modelo;
        private string _IMEI;
        private int _Memoria;

        public string Modelo
        {
            get => _Modelo;

            set{
                _Modelo = value;
            }
        }

        public string IMEI{
            get => _IMEI;

            set{
                _IMEI = value;
            }
        }

        public int Memoria{
            get => _Memoria;

            set{
                _Memoria = value;
            }
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