using ExemploFundamentos.Common.Models;


int[] arrayInteiros = new int[3]; // Declaração de um array de inteiros com 3 posições
arrayInteiros[0] = 72; // Atribuindo valor à primeira posição do array
arrayInteiros[1] = 64; // Atribuindo valor à segunda posição do array
arrayInteiros[2] = 50; // Atribuindo valor à terceira posição do array 
//arrayInteiros[3] = 1; // Isso causará um erro de índice fora do intervalo, pois o array só tem 3 posições (0, 1, 2) 

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}







// Pessoa pessoa1 = new() // Instanciando um objeto da classe Pessoa
// {
//     Nome = "Jeferson",
//     Idade = 38
// };
// pessoa1.Apresentar();

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string opcao;

//         while (true)
//         {
//             Console.WriteLine("Digite uma opção:");
//             Console.WriteLine("1 - Cadastrar cliente");
//             Console.WriteLine("2 - Buscar cliente");
//             Console.WriteLine("3 - Apagar cliente");
//             Console.WriteLine("4 - Encerrar");

//             opcao = Console.ReadLine() ?? string.Empty;

//             switch (opcao)
//             {
//                 case "1":
//                     Console.WriteLine("Cadastro de Cliente");
//                     break;

//                 case "2":
//                     Console.WriteLine("Busca de Cliente");
//                     break;

//                 case "3":
//                     Console.WriteLine("Apagar Cliente");
//                     break;

//                 case "4":
//                     Console.WriteLine("Encerrar");
//                     Environment.Exit(0); // Encerra o programa
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida");
//                     break;
//             }
//         }
//     }
// }


//----Sintaxe do While------------------------------------------

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número:");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");


//-------Tabuada------------------------------------------------
// int numero = 2;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break; // Interrompe o loop quando contador for igual a 6
//     }
// }

//----------------------------------------------------
//int numero = 2; //TABUADA
//tabuada
//for (int contador = 0; contador <= 10; contador++)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}

//---------------------------------------------
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine("Decremento 0 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

//---------------------------------------------------------------------
//Calculadora calc = new Calculadora();

/*calc.Add(10, 30);
calc.Subtract(10, 30);
calc.Multiply(10, 2);
calc.divide(20 , 2);
calc.Potencia(3, 3);*/

/*calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);*/
//calc.RaizQuadrada(9);

//-----------------------------------------------------------------------
/*bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar.");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia!");
}*/

/*bool possuiPresencaMinima = true;
double media = 8.5;

if (possuiPresencaMinima && media >= 7) //operador "e"
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}*/

//------------------------------------------------------------------------
/*bool maiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = true;

if (maiorDeIdade || possuiAutorizacaoDoResponsavel) //operador OR
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada");
}*/

//-----------------------------------------------------------------------
/*Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}*/

//---------------------------------------------------------------------------------------
// if, else, else if
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra <= 0)
// {
//     Console.WriteLine("Venda não realizada!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada.");
// }

//-------------------------------------------------------------------------
// string a = "15";

// int b = Convert.ToInt32(a);

// Console.WriteLine(b);

//-----------------------------------------------------------------------

// double a = 4 / (2 + 2);

// Console.WriteLine(a);

//-----------------------------------------------------------------------

// int inteiro = 5;
// string a = inteiro.ToString();// casting - int para string

// Console.WriteLine(a);

//----------------------------------------------------------------------

// int a = Convert.ToInt32("5"); //Transforma uma string em inteiro

// Console.WriteLine(a);

//----------------------------------------------------------------------

// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5; // equivale c = c + 5;
// c -= 10;

// Console.WriteLine(c);

//---------------------------------------------------------------------

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm"));

//-------------------------------------------------------------------------
// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00")); //ToString adiciona dois dígitos após a vírgula.
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);
// -------------------------------------------------------------------------------------------------------------------------------
/*Pessoa pessoa1 = new()
{
    Nome = "Jeferson",
    Idade = 38
};
pessoa1.Apresentar();*/