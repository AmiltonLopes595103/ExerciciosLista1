using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.cs
{
    public class Exercicios
    {
        public void Exer1()
        {
            int soma = 0;
            Console.WriteLine("Escolha um número inteiro como valor de A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha um número inteiro como valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha um número inteiro como valor de C: ");
            int c = int.Parse(Console.ReadLine());


            soma = a + b;

            if(soma > c)
            {
                Console.WriteLine();
                Console.WriteLine("A soma do valor A mais o valor B é maior que o valoe C");
                Console.WriteLine("pois  A = " + a +",  B = "+ b +" e C = "+c);
                Console.WriteLine("Somando: A = "+a+ " +  B = "+b+" o resltado é: "+ soma+ " que é maior que C = "+c);
                Console.WriteLine();
            }
            else if (soma < c)
            {
                Console.WriteLine();
                Console.WriteLine("A soma do valor A mais o valor B é menor que o valor C");
                Console.WriteLine("Pois A = "+a+ ", B = "+b+" e C = "+c);
                Console.WriteLine("Somando: A = "+a+" + B = "+b+" o resultado é: "+soma+" que é menor que C = "+c);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("A soma do valor A mais o valor B é igual  ao valor de C");
                Console.WriteLine("Pois A = " + a + ", B = " + b + " e C = " + c);
                Console.WriteLine("Somando: A = " + a + " + B = " + b + " o resultado é: " + soma + " que é igual a C = " + c);
                Console.WriteLine();
            }
        }

        public void Exer2()
        
        {
            Console.WriteLine("Olá, qual é o seu nome: ");
            String nome = Console.ReadLine().ToUpper();//.ToUpper converte um texto de minusculo para Maiusculo.
            Console.WriteLine("Qual o seu sexo F ou M: ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());//.ToUpper converte o texto recebido para um texto em maiusculo
            Console.WriteLine("Qual é o seu estado civil: ");
            string estCivil = Console.ReadLine().ToUpper();

            if(sexo == 'F' && estCivil == "CASADA")
            {
                Console.WriteLine();
                Console.WriteLine("Ola " + nome + " você tem quantos anos de casada: ");
                    int anos = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Sexo: " + sexo);
                Console.WriteLine("Estado Civil: " + estCivil);
                Console.WriteLine("Tempo de casada: "+ anos + " anos");
                Console.WriteLine();
            }
            else
            {
                //Abaixo todos os dados serão exibidos escritos em Maiousculo
                //pois já foram convertidos previamente para Maiusculo no momento do preencimento.
                Console.WriteLine();
                Console.WriteLine("Nome: "+nome);
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Estado Civil: "+estCivil);
                Console.WriteLine();
            }


        }

        public void Exer3()
        {
            Console.WriteLine("Digite um numero: ");
            float numero = float.Parse(Console.ReadLine());
            float div = numero % 2;//Nesta linha obteremos o resto da divisão de um numero por dois para saber se o resto é 0 ou 1.
            //utilizando o operador mod  representado pelo simbolode de porcentagem (%).
            float result = div;
            
            if(result == 0)
            {
                Console.WriteLine();
                Console.WriteLine("O numero escolhido é par: " + numero);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("O numero escolhido é impar: " + numero);
                Console.WriteLine();
            }

        }

        public void Exer4()
        {
            Console.WriteLine("Insira um número inteiro que será o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um número inteiro que será o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            int soma = 0;

            if (a == b)
            {
                c = a + b;
                Console.WriteLine();
                Console.WriteLine("A é igual a B");
                Console.WriteLine("A vale: " + a + " e B  vale: " + b);
                Console.WriteLine("Somando os dois valores o resultado é: "+c);
                Console.WriteLine();
            }
            else
            {
                c = a * b;
                Console.WriteLine();
                Console.WriteLine("A é diferente de B: ");
                Console.WriteLine("O valor de A é: "+a+" e o valor de B é: "+b);
                Console.WriteLine("Multiplicado os dois valores o resultado é: "+c);
                Console.WriteLine();
            }
        }

        public void Exer5()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            

            if (numero >= 0)
            {
               int d =numero * 2;
                Console.WriteLine();
                Console.WriteLine("O dobro de: "+numero+" é:"+d);
                Console.WriteLine();
            }
            else
            {
                int t = numero * 3;
                Console.WriteLine();
                Console.WriteLine("O triplo de: "+numero+" é: "+t);
                Console.WriteLine();
            }



        }
        public void Exer6()
        {
           bool valor1, valor2;
            
            
            Console.WriteLine("Escolha True ou False para o valor 1: ");
            valor1 = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("Esc olha True ou False para o valor 2: ");
            valor2= bool.Parse(Console.ReadLine().ToLower());

            if(valor1 == valor2 )
            {
                Console.WriteLine();
                Console.WriteLine("True");

            }
            else {
                Console.WriteLine();
                Console.WriteLine("False");
            }


        }
        public void Exer7()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int resultado = 0;
            int soma = 0;
            resultado = numero % 2;
            if (resultado== 1)
            {
                
                soma = numero + 8;
                Console.WriteLine();
                Console.WriteLine("O numero: "+numero+" é impar");
                Console.WriteLine("Somando: " + numero + " + 8 o resultado é:" + soma);
                Console.WriteLine();
            }
            else
            {
                
                
                soma = numero + 5;
                Console.WriteLine();
                Console.WriteLine("O número:"+numero+" é par");
                Console.WriteLine("Somando: " + numero + " + 5 o resultado é:" + soma);
                Console.WriteLine();
            }

        }
       

        public void Ordenar(int[] numero)
        {
            int i;
            int[] lista = new int[3];//Declarando o array.
            for (i =0; i <3; i++)
            {
                lista[i] = numero[i];
            }

            Trocar(lista);
            


        }
        public void Trocar(int[]lista)
        {
            int aux;
            int i;
            int j;
            for(i=0; i<3; i++)
            {
                for(j=i+1; j<3; j++)
                {
                    if (lista[j] > lista[i])
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                        


                    }

                }
                

            }
            Console.WriteLine();
            Console.WriteLine("Mostrando os números em ordem decrescente:");
            for (i = 0; i < 3; i++)
            {
                
                Console.WriteLine(lista[i]);

            }

        }

        public void Exer8()
        {
            Console.WriteLine("Esolha três números inteiros diferentes:");
            Console.WriteLine();
            Console.WriteLine("Informe o 1° número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2° número: ");
            int num2 = int.Parse(Console.ReadLine());
            //Tratando os número para que não sejam inseridos números repetidos.
            if (num2 == num1)//se o numero 2 for igual ao numero 1 então peça para trocar o numero e verifique se a troca foi efetuada.
            {
                do
                {
                    Console.WriteLine("Esse número já foi escolhido");
                    Console.WriteLine("Por favor escolha um número diferente: ");
                    num2 = int.Parse(Console.ReadLine());

                } while(num2 == num1);//enquanto o numero digitado for igual ao numero um peca pra trocar o numero ate que a troca
                //seja efetuada e verifique.
                
            }
            Console.WriteLine("Informe o 3° número: ");
            int num3 = int.Parse(Console.ReadLine());
            if(num3 == num1)//se o numero 3 for igual ao numero 1 pessa pra trocar o numero e verifique se a troca foi efetuada.
            {
                do
                {
                    Console.WriteLine("Esse número já foi escolhido");
                    Console.WriteLine("Por favor escolha um número diferente:");
                    num3 = int.Parse(Console.ReadLine());

                } while (num3 == num1);
                
            }
            else if(num3 == num2)// se o numero 3 for igual ao numero 2 peça para trocar e verifique se a troca foi efetuada.
            {
                do
                {
                    Console.WriteLine("Esse número já foi escolhido:");
                    Console.WriteLine("Por favor escolha um número diferente:");
                    num3 = int.Parse(Console.ReadLine());

                } while (num3 == num2);
               

            }

           
            int[]numero = new int[3];
           
            
                numero[0] = num1;
                numero[1] = num2;
                numero[2] = num3;
        
               
           
            Ordenar(numero);


            
            


        }
        public void Exer9()
        {
            Console.WriteLine("Informe o seu sexo M ou F: ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Inform sua altura: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double pesoIdeal;


            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * h) - 58;

                Console.WriteLine();
                Console.WriteLine("Seu peso ideal é: " + pesoIdeal.ToString("F2"));
                Console.WriteLine();



            }
            else if (sexo == 'F')
            {

                pesoIdeal = (62.1 * h) - 44.7;
                Console.WriteLine();
                Console.WriteLine("Seu peso oideal é: " + pesoIdeal.ToString("F2"));
                Console.WriteLine();


            }

        }
        public void Exer10()
        {
            Console.WriteLine("Qual a sua Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            double IMC;
            IMC = peso/Math.Pow(altura, 2);

            if (IMC < 18.5)
            {
                Console.WriteLine();
                Console.WriteLine("Voce esta abaixo do peso ideal");
                Console.WriteLine();
                Console.WriteLine("O seu IMC é: "+IMC.ToString("F2"));
                Console.WriteLine();

            }
            else if(IMC>=18.5 && IMC <= 25)
            {
                Console.WriteLine();
                Console.WriteLine("Seu Peso está normal");
                Console.WriteLine();
                Console.WriteLine("O seu IMC é : "+IMC.ToString("F2"));
                Console.WriteLine();

            }
            else if(IMC>=25 && IMC  <=30)
            {
                Console.WriteLine();
                Console.WriteLine("Voce está acima do peso");
                Console.WriteLine();
                Console.WriteLine("O seu IMC é : "+IMC.ToString("F2"));
                Console.WriteLine();

            }
            else if (IMC > 30)
            {
                Console.WriteLine();
                Console.WriteLine("Você está obeso.");
                Console.WriteLine();
                Console.WriteLine("o seu IMC é: "+IMC.ToString("F2"));
                Console.WriteLine();

            }




        }

        public void Exer11()
        {
            double preco = 0;
            double total = 0;
            double porcent = 0;
            int opcao = 0;
            Console.WriteLine("Informe o preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("====================================================================");
            Console.WriteLine("Opções de pagamento disponiveis:                                    |");
            Console.WriteLine("Opção (1) À vista em dinheiro ou cheque com 10% de desconto.        |");
            Console.WriteLine("Opção (2) À vista no cartão de crédito, recebe 15% de desconto.     |");
            Console.WriteLine("Opção (3) Em duas vezes, preço normal da estiqueta sem juros.       |");
            Console.WriteLine("Opção (4) Em duas vezes, preço normal da estiqueta mais juros de 10%|");
            Console.WriteLine("Escolha uma opção digitando o numero correspondente:                |");
            Console.WriteLine("====================================================================");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();
       

            switch (opcao)
            {
                case 1:
                     porcent =preco * 0.1;
                    total = preco - porcent;
                    Console.WriteLine();
                    Console.WriteLine("Valor total do produto: R$ "+ preco.ToString("F2"));
                    Console.WriteLine("Valor do desconto: R$ "+ porcent.ToString("F2"));
                    Console.WriteLine("Valor total a pagar com desconto: R$ " + total.ToString("F2"));
                    Console.WriteLine();
                    break;

                case 2:
                    porcent = preco * 0.15;
                    total = preco - porcent;
                    Console.WriteLine();
                    Console.WriteLine("Valor total do produto: R$ " + preco.ToString("F2"));
                    Console.WriteLine("Valor do desconto: R$ " + porcent.ToString("F2"));
                    Console.WriteLine("Valor total a pagar com desconto: R$ " + total.ToString("F2"));
                    Console.WriteLine();
                    break;
                case 3:
                    total = preco / 2;
                    Console.WriteLine();
                    Console.WriteLine("Valor total do produto: R$ "+preco.ToString("F2"));
                    Console.WriteLine("Quantidade de parcelas: 2 parcelas");
                    Console.WriteLine("Valor da parcela: R$ "+total.ToString("F2"));
                    Console.WriteLine("Total a pagar: R$ " + total.ToString("F2"));
                    Console.WriteLine();


                    break;
                case 4:
                    porcent = preco * 0.1;
                    double calc = preco / 2;
                    total = calc + porcent;
                    Console.WriteLine();
                    Console.WriteLine("Valor total do produto: R$ " + preco.ToString("F2"));
                    Console.WriteLine("Quantidade de parcelas: 2 parcelas");
                    Console.WriteLine("Valor das parcela: R$ " +calc.ToString("F2") + " + 10% de juros" );
                    Console.WriteLine("Valor total a apagar: R$ " +total.ToString("F2"));
                    Console.WriteLine();
                    break;


            }
        }
        public void Exer12()
        {
            decimal id, va1, va2, va3, oat, mediaN, mediaA, soma;

            Console.WriteLine("Informe o id do aluno: ");
            id = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da VA1 do aluno "+ id+" : ");
            va1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da VA2 do aluno "+id+" :");
            va2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da VA3 do alono "+id+" :");
            va3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informa a nota da OAT do aluno "+id+" :");
            oat = decimal.Parse(Console.ReadLine());

            soma = va1 + va2 + va3 + oat;
            mediaN = soma / 4;

            

            mediaA = (va1 + va2* 2 + va3 * 3 + mediaN) / 3;



            if (mediaA >= 90)
            {
                Console.WriteLine();
                Console.WriteLine("ID do aluno: "+id);
                Console.WriteLine("Notas do aluno:  VA1"+ va1 + ", VA2: "+va2 +", VA3: "+va3+", OAT: "+oat);
                Console.WriteLine("Média das avaliaçoes: " + mediaN+" Média de aproveitamento: "+mediaA.ToString("F2"));
                Console.WriteLine("Conceito de Aprovação: (A) aluno aprovado." );
                Console.WriteLine();
            }
            else if ((mediaA >=75) && (mediaA < 90))
            {
                Console.WriteLine();
                Console.WriteLine("ID do aluno"+id);
                Console.WriteLine("Notas do aluno:  VA1 " + va1 + ", VA2 " + va2 +  ", VA3 " + va3 + ", OAT " + oat);
                Console.WriteLine("Média das avaliaçoes: " + mediaN + "  Média de aproveitamento: " + mediaA.ToString("F2"));
                Console.WriteLine("Conceito de Aprovação: (B) aluno aprovado.");
                Console.WriteLine();


            }
            else if ((mediaA>=60) && (mediaA<75))
            {
                Console.WriteLine();
                Console.WriteLine("ID do aluno: "+id);
                Console.WriteLine("Notas do aluno:  VA1 " + va1 + ", VA2  " + va2 + ", VA3 " + va3 + ", OAT " + oat);
                Console.WriteLine("Média das avaliaçoes: " + mediaN + " Média de aproveitamento: " + mediaA.ToString("F2"));
                Console.WriteLine("Conceito de Aprovação: (C) aluno aprovado.");
                Console.WriteLine();

            }
            else if((mediaA>=40) && (mediaA<60))
            {
                Console.WriteLine();
                Console.WriteLine("ID do Aluno: "+id);
                Console.WriteLine("Notas do aluno:  VA1 " + va1 + ", VA2 " + va2 + ", VA3 " + va3 + ", OAT " + oat);
                Console.WriteLine("Média das avaliaçoes: " + mediaN + " Média de aproveitamento: " + mediaA.ToString("F2"));
                Console.WriteLine("Conceito de Aprovação: (D) aluno reprovado.");
                Console.WriteLine();
            }
            else if (mediaA < 40)
            {
                Console.WriteLine();
                Console.WriteLine("ID do aluno: "+id);
                Console.WriteLine("Notas do aluno:  VA1 " + va1 + " ,VA2 " + va2 + " ,VA3 " + va3 + "  ,OAT " + oat);
                Console.WriteLine("Média das avaliaçoes: " + mediaN + " Média de aproveitamento: " + mediaA.ToString("F2"));
                Console.WriteLine("Conceito de Aprovação: (E) aluno reprovado.");
                Console.WriteLine();
            }










        }
        
    }
}
