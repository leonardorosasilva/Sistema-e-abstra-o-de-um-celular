namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string _numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo { get; set; }
        private string _IMEI { get; set; }
        private int _memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMei, int memoria)
        {
            _numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _IMEI = iMei;
            _memoria = memoria;
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