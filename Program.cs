using exemploFundamentos.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 11;

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada.");
}

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