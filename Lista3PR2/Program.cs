using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int exercicio;

            //Console.WriteLine("Qual o exercicio: ");
            //exercicio = int.Parse(Console.ReadLine());

            //switch (exercicio)
            //{

            //    case 1:
            //        int dia;

            //        Console.WriteLine("Exercicio 1");
            //        Console.WriteLine("Qual o dia da semana ? : ");
            //        dia = int.Parse(Console.ReadLine());

            //        switch (dia)
            //        {
            //            case 1:
            //                Console.WriteLine("Esse dia é o Domingo");
            //                break;

            //            case 2:
            //                Console.WriteLine("Esse dia é a Segunda-Feira");
            //                break;

            //            case 3:
            //                Console.WriteLine("Esse dia é a Terça-Feira");
            //                break;

            //            case 4:
            //                Console.WriteLine("Esse dia é a Quarta-Feira");
            //                break;

            //            case 5:
            //                Console.WriteLine("Esse dia é a Quinta-Feira");
            //                break;

            //            case 6:
            //                Console.WriteLine("Esse dia é a Sexta-Feira");
            //                break;

            //            case 7:
            //                Console.WriteLine("Esse dia é o Sabado");
            //                break;

            //            default:
            //                Console.WriteLine("Não existe esse dia ");
            //                break;

            //        }
            //        break;

            //    case 2:

            //        double compra, paga, tot;

            //        Console.WriteLine("Exercicio 2");
            //        Console.WriteLine("Qual o valor em que ficou sua compra?");
            //        compra = double.Parse(Console.ReadLine());

            //        Console.WriteLine("Qual o método de pagamento?");
            //        Console.WriteLine("1 - Dinheiro ? "); 
            //        Console.WriteLine("2 - Pix ? ");
            //        Console.WriteLine("3 - Cartão de débito ? ");
            //        Console.WriteLine("4 - Cartão de Crédito ?");

            //        paga = double.Parse(Console.ReadLine());

            //        switch (paga)
            //        {
            //            case 1:
            //                tot = compra * 0.85;
            //           Console.WriteLine("O valor da sua compra é de: " + tot);
            //                break;

            //            case 2:
            //                tot = compra * 0.90;
            //           Console.WriteLine("O valor da sua compra é de: " +tot);
            //                break;

            //            case 3:
            //               tot = compra * 1.05;
            //            Console.WriteLine("O valor da sua compra é de: " + tot);
            //                break;

            //            case 4:
            //                tot = compra * 1.10;
            //            Console.WriteLine("O valor da sua compra é de: " + tot);
            //                break;

            //            default:
            //           Console.WriteLine("Não aceitamos esse tipo de pagamento !");
            //                break;
            //        }
            //        break;

            //    case 3:
            //        int mes;
            //        string anobi;

            //        Console.WriteLine("O seu ano é bissexto? ");
            //        anobi = Console.ReadLine();

            //        //Se for bissesto
            //        if (anobi == "sim")
            //        {
            //            Console.WriteLine("Escreva o numero correspondente do mês: ");
            //            mes= int.Parse(Console.ReadLine());

            //            switch (mes)
            //            {
            //                case 1:

            //                    Console.WriteLine("O mês é janeiro e ele tem 31 dias");
            //                    break;
            //                case 2:

            //                    Console.WriteLine("O mês é fevereiro e ele tem 29 dias");
            //                    break;
            //                case 3:

            //                    Console.WriteLine("O mês é março e ele tem 31 dias");
            //                    break;
            //                case 4:

            //                    Console.WriteLine("O mês é abril e ele tem 30 dias");
            //                    break;
            //                case 5:

            //                    Console.WriteLine("O mês é maio e ele tem 31 dias");
            //                    break;
            //                case 6:

            //                    Console.WriteLine("O mês é junho e ele tem 30 dias");
            //                    break;
            //                case 7:

            //                    Console.WriteLine("O mês é julho e ele tem 31 dias");
            //                    break;
            //                case 8:

            //                    Console.WriteLine("O mês é agosto e ele tem 31 dias");
            //                    break;
            //                case 9:

            //                    Console.WriteLine("O mês é setembro e ele tem 30 dias");
            //                    break;
            //                case 10:

            //                    Console.WriteLine("O mês é outubro e ele tem 31 dias");
            //                    break;
            //                case 11:

            //                    Console.WriteLine("O mês é novembro e ele tem 30 dias");
            //                    break;
            //                case 12:

            //                    Console.WriteLine("O mês é dezembro e ele tem 31 dias");
            //                    break;

            //                default:
            //                    Console.WriteLine("Mes nao existente");
            //                    break;

            //            }
            //        }

            //        else
            //        {
            //            //Se nao for bissesto 
            //            Console.WriteLine("Escreva o numero do mês: ");
            //            mes = int.Parse(Console.ReadLine());

            //            switch (mes)
            //            {
            //                case 1:

            //                    Console.WriteLine("O mês é janeiro e ele tem 31 dias");
            //                    break;
            //                case 2:

            //                    Console.WriteLine("O mês é fevereiro e ele tem 28 dias");
            //                    break;
            //                case 3:

            //                    Console.WriteLine("O mês é março e ele tem 31 dias");
            //                    break;
            //                case 4:

            //                    Console.WriteLine("O mês é abril e ele tem 30 dias");
            //                    break;
            //                case 5:

            //                    Console.WriteLine("O mês é maio e ele tem 31 dias");
            //                    break;
            //                case 6:

            //                    Console.WriteLine("O mês é junho e ele tem 30 dias");
            //                    break;
            //                case 7:

            //                    Console.WriteLine("O mês é julho e ele tem 31 dias");
            //                    break;
            //                case 8:

            //                    Console.WriteLine("O mês é agosto e ele tem 31 dias");
            //                    break;
            //                case 9:

            //                    Console.WriteLine("O mês é setembro e ele tem 30 dias");
            //                    break;
            //                case 10:

            //                    Console.WriteLine("O mês é outubro e ele tem 31 dias");
            //                    break;
            //                case 11:

            //                    Console.WriteLine("O mês é novembro e ele tem 30 dias");
            //                    break;
            //                case 12:

            //                    Console.WriteLine("O mês é dezembro e ele tem 31 dias");
            //                    break;
            //                default:
            //                    Console.WriteLine("Mes nao existente");
            //                    break;

            //            }
            //        }
            //        break;

            //    case 4:


            //        char cara;
            //        int num1, num2;


            //        Console.WriteLine("Escreva um valor para o primeiro numero: ");
            //        num1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Escreva um valor para o segundo numero: ");
            //        num2 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Qual a operaçao desejada ?: ");
            //        cara = char.Parse(Console.ReadLine());
            //        switch (cara)
            //        {
            //            case '+':
            //                Console.WriteLine(num1 + num2);
            //                break;

            //            case '-':
            //                Console.WriteLine(num1 - num2);
            //                break;

            //            case '*':
            //                Console.WriteLine(num1 * num2);
            //                break;

            //            case '/':
            //                Console.WriteLine(num1 / num2);
            //                break;

            //            default:
            //                Console.WriteLine("Operaçao nao existente!");
            //                break;
            //        }

            //        break;

            //    case 5:

            //        double cod, sala, novo, dif;

            //        Console.WriteLine("Qual o codigo do seu cargo ? ");
            //        cod = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Qual o seu salario atual ? ");
            //        sala = double.Parse(Console.ReadLine());

            //        switch (cod)
            //        {
            //            //Os casos estao nomeados de acordo com o codigo
            //            case 101:

            //                novo = sala * 1.075;
            //                dif = novo % sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            case 102:

            //                novo = sala * 1.097;
            //                dif = sala - novo;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            case 103:

            //                novo = sala * 1.117;
            //                dif = novo - sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            case 204:

            //                novo = sala * 1.089;
            //                dif = novo - sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            case 206:

            //                novo = sala * 1.1324;
            //                dif = novo - sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            case 301:

            //                novo = sala * 1.104;
            //                dif = novo - sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            case 302:

            //                novo = sala * 1.146;
            //                dif = novo - sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;

            //            default:
            //                novo = sala * 1.435;
            //                dif = novo - sala;
            //                Console.WriteLine("O seu salário antigo era de: R$" + sala + ", o seu novo salario é de: R$" + novo + " e a diferença é de: R$" + dif);
            //                break;
            //        }
            //        break;

            //    case 6:
            //        double sal, salli, impos;

            //        Console.WriteLine("Qual o seu salario atual ?");
            //        sal = double.Parse(Console.ReadLine());

            //        if (sal < 1903.98)
            //        {
            //            Console.WriteLine("Com o seu salario voce nao paga imposto de renda");
            //        }
            //        else if (sal >= 1903.99 && sal <= 2826.65)
            //        {
            //            salli = sal - sal * 0.075;
            //            impos = sal % salli;
            //            Console.WriteLine("O seu salario liquido é de: R$" + salli + " , e o imposto foi de: R$" + impos);
            //        }
            //        else if (sal >= 2826.66 && sal <= 3751.05)
            //        {
            //            salli = sal - sal * 0.15;
            //            impos = sal % salli;
            //            Console.WriteLine("O seu salario liquido é de: R$" + salli + " , e o imposto foi de: R$" + impos);
            //        }
            //        else if (sal >= 3751.06 && sal <= 4664.68)
            //        {
            //            salli = sal - sal * 0.225;
            //            impos = sal % salli;
            //            Console.WriteLine("O seu salario liquido é de: R$" + salli + " , e o imposto foi de: R$" + impos);
            //        }
            //        else
            //        {
            //            salli = sal - sal * 0.275;
            //            impos = sal % salli;
            //            Console.WriteLine("O seu salario liquido é de: R$" + salli + " , e o imposto foi de: R$" + impos);
            //        }
            //        break;


            //    default:
            //        Console.WriteLine("opção invalida!");
            //        break;


        }
    }
}
