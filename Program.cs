using ListaExercicios.cs;

namespace Resol_Exercicios
{
    public class Lista
    {
        static void Main(string[] args)
        {
            int cont= 0;
            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("(1) Soma dos valores                              |");
                Console.WriteLine("(2) Etado civil e tempo de casado (a)             |");
                Console.WriteLine("(3) Nuúmero impar ou par                          |");
                Console.WriteLine("(4) Números iguais ou diferetes                   |");
                Console.WriteLine("(5) O dobro ou o triplo de um número              |");
                Console.WriteLine("(6) Numero verdadeiro ou falso                    |");
                Console.WriteLine("(7) Se for impar soma: 8 se for par soma: 5       |");
                Console.WriteLine("(8) Números em ordem decrescente                  |");
                Console.WriteLine("(9) Peso Ideal                                    |");
                Console.WriteLine("(10) Descobrir o  IMC                             |");
                Console.WriteLine("(11) Opções de pagamento.                         |");
                Console.WriteLine("(12) Media de aproveitamento de um aluno          |");
                Console.WriteLine("==================================================");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção ou pressione (0) para encerrar: ");
                int opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        
                        Console.WriteLine();
                        Exercicios objopcao1 = new Exercicios();//Instanciando um objeto da Classe Exercisios

                        objopcao1.Exer1();//Chamando um método da classe Exercicios

                        break;
                    case 2:
                        
                        Console.WriteLine();
                        Exercicios objopcao2 = new Exercicios();//Da Clasee exerxicios eu crio (instancio) um novo objeto chamado opcao 2,
                        //esse objeto ira conter e utilizar os mesmos atributos e métodos da Classe mãe.

                        objopcao2.Exer2();//Aqui estamos chamando um método do nosso objeto método esse que foi herdado da |Classe mãe.
                        
                        break;
                    case 3:
                        
                        Console.WriteLine();

                        Exercicios objopcao3 = new Exercicios();
                        objopcao3.Exer3();
                            break;
                    case 4:
                        
                        Exercicios objopcao4 = new Exercicios();

                        objopcao4.Exer4();
                           break;
                    case 5:
                       
                        Console.WriteLine();
                        Exercicios objopcao5 = new Exercicios();

                        objopcao5.Exer5();
                        break;
                    case 6:

                        Exercicios objobjopcao6 = new Exercicios();
                        objobjopcao6.Exer6();
                        break;
                    case 7:
                        
                        Console.WriteLine();
                        Exercicios objopcao7 = new Exercicios();
                        objopcao7.Exer7();
                        break;
                    case 8:
                        
                        Exercicios objopcao8 = new Exercicios();
                        

                        objopcao8.Exer8();
                        break;
                    case 9:
                        
                        Console.WriteLine();
                        Exercicios objopcao9 = new Exercicios();
                        objopcao9.Exer9();
                        break;
                    case 10:
                       
                        Console.WriteLine();
                        Exercicios objpcao10 = new Exercicios();
                        objpcao10.Exer10();
                        break;
                    case 11:
                        
                        Console.WriteLine();
                        Exercicios objopcao11 = new Exercicios();
                        objopcao11.Exer11();
                        break;
                    case 12:

                        Console.WriteLine();
                        Exercicios objopcao12 = new Exercicios();
                        objopcao12.Exer12();


                        break;

                    default:
                        if(opcao <0 || opcao > 12)
                        {
                            Console.WriteLine("Opção invalida!");
                        }
                        else if(opcao == 0)
                        {
                            Console.WriteLine("Encerar o Programa.");
                            
                        }
                         break;
                }
                cont = opcao;

               

            } while (cont != 0);
        }
    }
    //Program by Amilton Lopes.
}