using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disciplina
{
    public class Calculadora
    {
        private Calculo calculo = new Calculo();

        public static void LerValores(Calculo calc)
        {
            Console.WriteLine("Digite Valor A: ");
            calc.pegarValA(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite Valor B: ");
            calc.pegarValB(double.Parse(Console.ReadLine()));
        }
        public void ExecutarCalculadora()
            {
                int opcao = 0;

                do
                {
                    Console.WriteLine("Escolha uma opção:");
                    Console.WriteLine("1 - Calcular soma ");
                    Console.WriteLine("2 - Calcular subtração");
                    Console.WriteLine("3 - Calcular Multiplicação");
                    Console.WriteLine("4 - Retornar maior valor");
                    Console.WriteLine("5 - Somar geral");
                    Console.WriteLine("6 - Sair");
                    
                    Console.WriteLine("A Opção escolhida é: ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            LerValores(calculo);
                            calculo.CalcularSoma();
                            calculo.ImprimirResultado(1);
                            break;

                        case 2:
                            Console.Clear();
                            LerValores(calculo);
                            calculo.CalcularSubtracao();
                            calculo.ImprimirResultado(2);
                            break;

                        case 3:
                            Console.Clear();
                            LerValores(calculo);
                            calculo.CalcularMultiplicacao();
                            calculo.ImprimirResultado(3);
                            break;

                        case 4:
                            Console.Clear();
                            LerValores(calculo);
                            double maior = calculo.RetornarMaior();
                            Console.WriteLine($"O maior valor é: {maior}");
                            break;

                        case 5:
                            Console.Clear();
                            LerValores(calculo);
                            Console.Write("Digite valor C: ");
                            double valorC = double.Parse(Console.ReadLine());

                            calculo.SomarGeral(valorC);                             
                            Console.WriteLine($"A soma geral é: {calculo.Resultado}");
                            break;

                        case 6:
                            Console.WriteLine("Saindo...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                    Console.WriteLine();
                    if(opcao != 6)
                        Console.ReadLine();
                } while (opcao != 6);
            }
        }

    }
