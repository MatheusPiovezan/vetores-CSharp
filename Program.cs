using Vetores;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Quartos[] vetor = new Quartos[10];

            Console.Write("Quantos quartos vão ser alugados ? ");
            int nQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < nQuartos; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Quartos { Nome = nome, Email = email, Quarto = quarto };
                Console.WriteLine();
            }

            Console.WriteLine("----Quartos----");

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{vetor[i].Quarto}: Nome: {vetor[i].Nome}, Email: {vetor[i].Email}");
                }
            }
        }
    }
}