namespace DesafioPOO.Models
{

    //Desafio Concluído
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Nokia instalando {nomeApp}...");
        }
    }
}