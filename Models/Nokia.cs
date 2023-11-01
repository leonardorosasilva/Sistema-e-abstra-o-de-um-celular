namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string iMei, int memoria) : base(numero, modelo, iMei, memoria)
        {
            Console.WriteLine($"Numero: {numero}\nModelo: {modelo} \nIMEI: {iMei} \nMemoria: {memoria}" );
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Android... ");
        }
    }
}