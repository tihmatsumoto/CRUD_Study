using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiemi.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public String Email { get; set; }
        public long Telefone { get; set; }

    }

    public static class Cadastros
    {
        public static List<Pessoa> Pessoas = new List<Pessoa>();

        public static void PreencherListaInicial()
        {
            Pessoa pessoa1 = new Pessoa()
            {
                Id = Guid.NewGuid(),
                Nome = "Teste de Validação",
                Idade = 27,
                Email = "teste@teste.com",
                Telefone = 965621859
            };

            Pessoa marcia = new Pessoa()
            {
                Id = Guid.NewGuid(),
                Nome = "Marcia Matsumoto",
                Idade = 28,
                Email = "mmatsumoto@primeit.pt",
                Telefone = 911845152
            };

            Cadastros.Pessoas.Add(pessoa1);
            Cadastros.Pessoas.Add(marcia);
        }
    }

}
