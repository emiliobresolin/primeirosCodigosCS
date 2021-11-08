using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace estudos_solucoes
{
    public enum Conceito
    {
        A,
        B,
        C,
        D,
        E
    }
    public struct Aluno
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpacaoUsuario(); //usei a opcao rapida do proprio VS NewMethod e ele mandou as opcoes para o final do codigo fora da main.

            while (opcaoUsuario.ToUpper() != "X") //   TO UPPER SERVE PARA SE O USUARIO DIGITAR O X MINISCULO
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("\nInforme o Nome do Aluno: \n");  //add aluno
                        Aluno aluno = new Aluno();                         //declaramos um novo aluno
                        aluno.Nome = Console.ReadLine();                   //nome do aluno jogado para aluno.Nome

                        Console.WriteLine("\nInforme a Nota do Aluno: \n");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))//conversao de string para decimal com TRYPARSE com IF ELSE
                        {
                            aluno.Nota = nota;                             //poderia ser aluno.Nota=decimal.Parse(Console.ReadLine()) e com isso conseguimos apagar a linha 31
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("\nValor da Nota deve ser Decimal\n");
                        }
                        alunos[indiceAluno] = aluno;                       //posicao do array que entra o nome
                        indiceAluno++;                                     //incremento para proxima posicao do array
                        break;
                    case "2":
                        foreach(var a in alunos)                           // var 'a' pq var alunos ja existe //FOREACH = PARA CADA A VOCE IMPRIME ALUNO E NOTA
                        {
                            if (!string.IsNullOrEmpty(a.Nome))             //SERVE PARA NAO MOSTRAR OS VALORES DO ARRAY Q NAO FORAM INSERIDOS
                            {
                                Console.WriteLine($"\nALUNO: {a.Nome} - NOTA: {a.Nota}\n"); //USAR O $ PARA ENDERECAR OS {}
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                                                                        //COMO ULTILIZAR ENUMS
                        Conceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        if (mediaGeral <= 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        if (mediaGeral <= 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        if (mediaGeral <= 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"\nMedia Geral da Turma: {mediaGeral} - Conceito da Turma: {conceitoGeral}\n");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("\nOpcao Invalida!\n");
                }
                //FOI APAGADO O MENU Q VINHA DEPOIS DA OPCAO DO USUARIO E MODICICAMOS opcaoUsuario=conseole... para ObeerOpcaoUsuario
                opcaoUsuario = ObterOpacaoUsuario();
            }

            Console.ReadLine();

        }

        private static string ObterOpacaoUsuario()
        {
            Console.WriteLine("Informe a opcao desejada");
            Console.WriteLine("1 - Inserir Novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Media Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}

//PRIMEIRA LINHA DE CODIGO -.-
/*Console.WriteLine("Hello World");*/

//LOOP SIMPLES COM FOR
/*int numeroDeVezes = 5;
for(int i=0; i< numeroDeVezes; i++)
{
    Console.WriteLine("Bem vindo ao curso de dotnet\n" + i);               
}*/

//COMO DECLARAR VARIAVEIS
/*int a;
int b = 2, c = 3;
const int d = 4;
a = 1;
Console.WriteLine(a + b + c + d);*/

//EXEMPLOS DE IF         -----> $ puxa o {}
/*if (args.Length == 0)
{
    Console.WriteLine("nenhum argumento");
}
else if (args.Length == 1)
{
    Console.WriteLine("um argumento");
}
else
{
    Console.WriteLine ($"{args.Length} argumetos"); 
}*/

//EXEMPLOS SWITCH CASE EM C#
/*int numeroDeArgumentos = args.Length;
numeroDeArgumentos = 2;
switch (numeroDeArgumentos)
{
    case 0:
        Console.WriteLine("nenhum argumento");
        break;
    case 1:
        Console.WriteLine("um argumento");
        break;
    default:
        Console.WriteLine("dois argumento");
        break;
}*/

//EXEMPLOS WHILE
/*int i = 0;
while (i < args.Length)
{
    Console.WriteLine(args[i]);
    i++;
}*/

//EXEMPLOS DE DO WHILE    --> ! eh a negativa da string
/*string texto;
do
{
    texto = Console.ReadLine();
    Console.WriteLine(texto);
} while (!string.IsNullOrEmpty(texto));*/


// INTERFACE EXPLICACAO ?????????
/*    
interface IDataBound
{
    void Binder(Binder b);
}
public class EditBox: ICombobox, IDataBound
{
    public void Paint() { }
    public void SetText(string text) { }
    public void Bind(Binder b) { }
}*/

//ARREDONDAMENTO
/*string[] line = Console.ReadLine().Split(" ");
float a = Int32.Parse(line[0]);
float b = Int32.Parse(line[1]);
float total = (a / b);
if (a % b != 0)
{
    Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
}
else
{
    Console.WriteLine(total.ToString("0.00"));
}*/