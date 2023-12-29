namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            if(memoria >= 0)
            {
                Memoria = memoria;
            }
            else
            {
                Memoria = 0;
            }
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Meu celular é um Nokia de modelo {Modelo} e vamos instalar o app: {nomeApp}");
        }
    }
}