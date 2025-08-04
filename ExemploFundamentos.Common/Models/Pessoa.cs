using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa Física.
    /// </summary>
    public class Pessoa
    {
        public required string Nome { get; set; } //required foi inserido por causa do nome com erro
        public int Idade { get; set; } //get(pega valor), set(atribui valor)
        public string NomeRepresentanteLegalDaPessoaFisisca { get; set; } = "Jeferson"; //Propriedade com valor padrão  

        /// <summary>
        /// Faz a apresentação da pessoa com nome e idade.
        /// </summary>

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");//console(classe), writeline(método)
        }
    }
}