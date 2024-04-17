using System.Globalization;

namespace cotacao {
    class CotacaoDolar {

        static void Main(string[] args){

            Conversor conversor = new Conversor();
            
            Console.WriteLine("Cotação atual: R$ " + conversor.dolar.ToString());

            Console.WriteLine("Digite o valor a ser comprado");
            double valor_comprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor_convertido = conversor.RealParaDolar(valor_comprado);

            double valor_pago = conversor.ValorPago(valor_convertido);

            Console.WriteLine($"Você quer comprar R$: {valor_comprado}");
            Console.WriteLine($"Valor a ser pago com impostos R$: {valor_pago}");
            Console.WriteLine($"Você pagará R$ {valor_pago - valor_convertido} de impostos");


        }
    }
}