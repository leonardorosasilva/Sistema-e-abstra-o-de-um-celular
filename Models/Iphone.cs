namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMei, int memoria) : base(numero, modelo, iMei, memoria)
        {
            Console.WriteLine($"Numero: {numero}\nModelo: {modelo} \nIMEI: {iMei} \nMemoria: {memoria}" );
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iOS...");
        }
    }
}