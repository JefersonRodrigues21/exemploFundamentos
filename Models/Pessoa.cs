using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; } //required foi inserido por causa do nome com erro
        public int Idade { get; set; } //get(pega valor), set(atribui valor)

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");//console(classe), writeline(método)
        }
    }
}