using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using teste_zoologico;
using static System.Net.Mime.MediaTypeNames;

namespace Zoológico
{
    class program
    {
        public static Animal espécie;
        public static Animal nome;
        public static Animal idade;
        public static Animal cor;
        public static Animal manchas;
        public static Animal doente;
        public static Animal somEmitido;
        static void Main(string[] args)
        {
            string cadastro = "S";

            Console.WriteLine("Cadastro de animais!");
            Console.WriteLine("Digite S para começar");
            cadastro = Console.ReadLine();

            while (cadastro == "S")
            {
                Animal Cachorro = new Animal();
                Animal Gato = new Animal();
                Animal Vaca = new Animal();

                Console.WriteLine("Qual espécie você deseja cadastrar? ");
                Cachorro.Espécie = Console.ReadLine();
                Console.WriteLine("Qual o nome do animal? ");
                Cachorro.Nome = Console.ReadLine();
                Console.WriteLine("Qual a idade do animal: ");
                Cachorro.Idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a cor do animal? ");
                Cachorro.Cor = Console.ReadLine();
                Console.WriteLine("Esse animal emite som? (Digite TRUE para sim ou FALSE para não)");
                Cachorro.SomEmitido = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Esse animal possui manchas? (Digite TRUE para sim ou FALSE para não)");
                Cachorro.TemManchas = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Esse animal está doente? (Digite TRUE para sim ou FALSE para não)");
                Cachorro.EstaDoente= Convert.ToBoolean(Console.ReadLine());

                Cachorro.ExibirDads();

                Console.WriteLine("Deseja continuar cadastrando? Digite S para SIM e N para NÃO.");
                cadastro = Console.ReadLine();

                if (cadastro == "S")
                {
                    Console.WriteLine("S");
                }
                else
                {
                    Cachorro.ExibirDads();
                
                }

            }
        }
    }
}