namespace Metodos {
    class Program{
        static void Main(string[] args)
        {
            MeuMetodo();
            string nome = ReturnName("Joshua", "Pedroso", 23);
            Console.WriteLine(nome);
        }
        static void MeuMetodo()
        {
            Console.WriteLine("Refazendo novamente fundamentos do C#");
        }
        static string ReturnName(
            string nome, 
            string sobrenome,
            int idade)
        {
            return nome + " " + sobrenome + " Tem " + idade.ToString();
        }
    }
}

