using System;
using pensionato.obj.Classes;

namespace pensionato
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de quartos que será alugado");
            int n = int.Parse(Console.ReadLine());

            Quarto[] vect = new Quarto[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do estudante");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o Email do estudante");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o Quarto escolhido pelo estudante");
                int quarto =int.Parse(Console.ReadLine());
                vect[quarto]= new Quarto(nome,email);
                 Console.WriteLine();
        }
         Console.WriteLine("Listagem dos Quartos Alugados:");
        for(int q = 0; q <10 ; q++){

            if (vect[q] != null ){

            Console.WriteLine( q +" :" +vect[q]);
            }
        }
    }

}
   
}
