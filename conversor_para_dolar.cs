namespace cotacao{

    class Conversor{

        public double dolar = 4.99;

        public double imposto = 0.06;

        public double RealParaDolar(double valor_comprado){
            return valor_comprado * dolar;
        }

        public double ValorPago(double valor_comprado){
            return valor_comprado + (valor_comprado * imposto);
        }
    }
}