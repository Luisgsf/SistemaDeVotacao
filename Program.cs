using System;
using System.Collections.Generic;

namespace Sistema_de_votação_de_lideres_da_sala
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[] candidatoNome = new string[5];
            int[,] candidatoCodigo = new int[5,2];
            List<CodigoEleitor> eleitores = new List<CodigoEleitor>();
            string op;
            bool sair = false;
            int contador=0;
            int comando;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Escreva o nome do {0}° candidato :", i+1);
                candidatoNome[i] = Console.ReadLine();
                Console.Write("Escreva o numero do candidato {0} :", candidatoNome[i]);
                candidatoCodigo[i,0] = int.Parse(Console.ReadLine());
                candidatoCodigo[i, 1] = 0;
                
            }
            Console.Clear();
            Console.WriteLine("RELATORIO DE CANDIDATOS");
            Console.WriteLine("============================================");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} _ {1}", candidatoNome[i], candidatoCodigo[i,0]);
            }
            Console.WriteLine("============================================");
            do
            {
                CodigoEleitor eleitor = new CodigoEleitor();
                Console.Write("Qual o codigo do eleitor: ");
                comando = int.Parse(Console.ReadLine());
                eleitor.codigo = comando;
                Console.Clear();
                Console.WriteLine("Escolha um dos candidatos abaixo escrevendo o numero do mesmo.");
                Console.WriteLine("LISTA DE CANDIDATOS");
                Console.WriteLine("============================================");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0} _ {1}", candidatoNome[i], candidatoCodigo[i, 0]);
                }
                Console.WriteLine("============================================");
                Console.Write("Digite o numero do candidato: ");
                comando = int.Parse(Console.ReadLine());
                for(int i = 0; i < 5; i++)
                {
                    if(comando == candidatoCodigo[i,0])
                    {
                        candidatoCodigo[i, 1]++;
                    }
                }

                eleitor.voto = comando;
                contador++;
                Console.Clear();
                Console.WriteLine("REGISTRADO!");
                Console.WriteLine("============================================");
                Console.Write("Deseja liberar novo eleitor para a votação? (Sim ou Não): ");
                op = Console.ReadLine();
                if(op == "Sim" | op == "sim")
                {
                    sair = false;
                }else
                {
                    sair = true;
                }
                Console.Clear();

            } while (!sair);
            Console.Clear();
            Console.WriteLine("============================================");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Candidato de nome {0} e o numero do candidato é {1} obteve {2} votos", candidatoNome[i], candidatoCodigo[i, 0], candidatoCodigo[i,1]);
            }
            Console.WriteLine("============================================");
        }
    }
}