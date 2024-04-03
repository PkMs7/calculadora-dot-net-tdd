namespace CalculadoraTDD
{
    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Dividir(int num1, int num2)
        {
            return 0;
        }

        public int Multiplicar(int num1, int num2)
        {
            return 0;
        }

        public List<string> GerarHistorico()
        {
            return new List<string>();
        }
    }
}