namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                if (nomeApp != null) { Console.WriteLine($"Baixando App {nomeApp} da Store"); }
            }
            catch
            {
                throw new ArgumentException("Falta nome do App");
            }
        }
    }
}