internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Tamanho da arvore: ");
        int tamanhoArvore = Convert.ToInt32(Console.ReadLine());
        TrianguloRetangulo(tamanhoArvore);

        Console.Write("Numero escolhido (De 1 a 26): ");
        int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
        AlfabetoSorteado(numeroEscolhido);
    }

    static void TrianguloRetangulo(int tamanhoDaArvore) 
    {
        int estrala = 1;

        for (int i = 1; i <= tamanhoDaArvore; i++) 
        {
            int espacoQTD = tamanhoDaArvore - i;
            int estrelaQTD = 2 * i - 1;

            string espaco = new string(' ', espacoQTD);
            string estrela = new string('*', estrelaQTD);

            Console.WriteLine($"{espaco}{estrela}");
        }

        //   * 1
        //  *** 3
        // ***** 5 
        //******* 7
    }

    static void AlfabetoSorteado(int numeroEscolhido) 
    {
        string[] strings =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z"
        };

        for (int i = 1; i < strings.Length; i++) 
        {
            int index = numeroEscolhido - 1;
            if (numeroEscolhido == i)
            {
                Console.WriteLine($"A letra equivalente a esse número no alfabeto é: {strings[index]}");
            }
        }
    }
}


