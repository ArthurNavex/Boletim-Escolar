using SistemaBoletimEscolar;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BoletimEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolhaMenu;
            List<CadastrarAlunos> alunos = new List<CadastrarAlunos>();
            

            while (true)
            {

                Console.WriteLine("========= Boletim Escolar =========");
                Console.WriteLine("");
                Console.WriteLine("[1] Cadastrar aluno");
                Console.WriteLine("[2] Lista de alunos");
                Console.WriteLine("[3] Sair do Sistema");
                Console.WriteLine("");
                Console.Write("Selecione a opção desejada: ");
                escolhaMenu = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (escolhaMenu == 1)
                {

                    CadastrarAlunos adicionar = new CadastrarAlunos();
                    Console.Write("Cadastrar aluno: ");
                    adicionar.Nomes = Console.ReadLine();
                    alunos.Add(adicionar);
                    Console.WriteLine("");

                }
                else if (escolhaMenu == 2)
                {

                    for (int i = 0; i < alunos.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {alunos[i].Nomes} - Media: {alunos[i].Media().ToString("F2", CultureInfo.InvariantCulture)}"); 
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Qual ação você deseja executar?:");
                    Console.WriteLine("");
                    Console.WriteLine("[1] Adicionar nota");
                    Console.WriteLine("[Qualquer numero] Voltar ao menu");
                    int escolhaMenuAlunos = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (escolhaMenuAlunos == 1)
                    {
                        Console.Write("Para qual alunos você quer adicionar uma nota? (escrva o nome):");
                        string nomeAluno = Console.ReadLine();
                        CadastrarAlunos pesquisarNome = alunos.Find(u => u.Nomes == nomeAluno);
                        Console.WriteLine(" ");
                        Console.WriteLine($"Você selecionou o aluno {nomeAluno}!");

                        while (true) {
                            {

                                if (pesquisarNome != null)
                                Console.WriteLine("A nota de qual trimestre você quer adicionar?");
                                Console.WriteLine("");
                                Console.WriteLine("[1] 1 trimestre");
                                Console.WriteLine("[2] 2 trimestre");
                                Console.WriteLine("[3] 3 trimestre");
                                Console.WriteLine("[4] Sair");
                                int escolhaTrimestre = int.Parse(Console.ReadLine());
                                Console.WriteLine(" ");

                                if (escolhaTrimestre == 1)
                                {
                                    Console.Write("Digite a nota do primeiro trimestre do aluno (de 0 a 100): ");

                                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    pesquisarNome.Notas.Add(nota);
                                    Console.WriteLine("");
                                }
                                else if (escolhaTrimestre == 2)
                                {
                                    Console.Write("Digite a nota do segundo trimestre do aluno (de 0 a 100): ");

                                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    pesquisarNome.Notas.Add(nota);
                                    Console.WriteLine("");
                                }
                                else if (escolhaTrimestre == 3) 
                                {
                                    Console.Write("Digite a nota do terceiro trimestre do aluno (de 0 a 100): ");

                                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    pesquisarNome.Notas.Add(nota);
                                    Console.WriteLine("");
                                }
                                else if (escolhaTrimestre == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Escolha uma da opções disponiveis!");
                                    Console.WriteLine("");
                                }

                                
                            }
                        }
                    }
                    

                }
                else if (escolhaMenu == 3) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha uma da opções disponiveis");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Você saiu do Sistema!");
        }
    }
}