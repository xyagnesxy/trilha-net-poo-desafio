namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"instalando o aplicativo {aplicativo} no nokia");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}