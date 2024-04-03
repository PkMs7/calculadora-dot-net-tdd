namespace CalculadoraTDD
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            historico.Insert(0, $"Resultado de {num1} + {num2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            historico.Insert(0, $"Resultado de {num1} - {num2} = {resultado}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            historico.Insert(0, $"Resultado de {num1} / {num2} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            historico.Insert(0, $"Resultado de {num1} * {num2} = {resultado}");
            return resultado;
        }

        public List<string> GerarHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}