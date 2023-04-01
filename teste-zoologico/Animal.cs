using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_zoologico
{
    public class Animal
    {
        private string espécie;
        public string Espécie
        {
            get { return espécie; }
            set
            {
                if (value == "Cachorro" || value == "Gato" || value == "Vaca")
                {
                    espécie = value;
                }
                else
                {
                    espécie = "Raça não disponível para cadastro.";
                }
            }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private bool somEmitido;

        public bool SomEmitido
        {
            get { return somEmitido; }
            set { somEmitido = value; }
        }

        private bool estaDoente;

        public bool EstaDoente
        {
            get { return estaDoente; }
            set { estaDoente = value; }
        }

        private bool temManchas;

        public bool TemManchas
        {
            get { return temManchas; }
            set { temManchas = value;}
        }


        public void ExibirDads()
        {
            Console.WriteLine("Nome:" + this.Nome);
            Console.WriteLine("Idade:" + this.Idade);
            Console.WriteLine("Cor:" + this.Cor);
            Console.WriteLine("Esse animal emite algum som: " + this.SomEmitido);
            Console.WriteLine("Esee animal está doente: " + this.EstaDoente);
            Console.WriteLine("Esse animal possui manchas:" + this.TemManchas);

        }
    }
}