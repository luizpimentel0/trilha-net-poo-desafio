namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public const string FABRICANTE = "Nokia";
        public Nokia(string numero, string modelo, string imei, int memoria ) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no {FABRICANTE}");
        }
    }
}
