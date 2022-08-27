namespace CaulculadoraIMCPFS
{
    public static class Calculadora
    {
        public static double QuadradoAltura(double altura)
        {
            return (Math.Round(altura * altura, 2));
        }

        public static string CalcularIMC(double altura, double peso)
        {
            if (altura == 0)
            {
                return "Altura inválida!";
            }

            if (altura < 0)
            {
                return "Opa! Ocorreu um erro!";
            }

            double alturaQuadrado = QuadradoAltura(altura);

            double resultado = (peso / alturaQuadrado);

            if (resultado <= 0)
            {
                return "Opa! Ocorreu um erro!";
            }

            else if (resultado < 18.5 && resultado > 0)
            {
                return ("IMC: " + resultado + ", Categoria: Abaixo do peso");
            }

            else if (resultado >= 18.5 && resultado < 25.0)
            {
                return ("IMC: " + resultado + ", Categoria: Peso normal");
            }

            else if (resultado >= 25.0 && resultado < 30.0)
            {
                return ("IMC: " + resultado + ", Categoria: Sobrepeso");
            }

            else if (resultado >= 30.0 && resultado < 35.0)
            {
                return ("IMC: " + resultado + ", Categoria: Obesidade Grau I");
            }

            else if (resultado >= 35.0 && resultado < 40.0)
            {
                return ("IMC: " + resultado + ", Categoria: Obesidade Grau II");
            }

            else
            {
                return ("IMC: " + resultado + ", Categoria: Obesidade Grau III");
            }

            
        }
    }
}