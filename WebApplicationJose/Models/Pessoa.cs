using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationJose.Models
{
    public class Pessoa
    {       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
        
    }

    public static class PessoasSingle
    {
        public static List<Pessoa> Pessoas = new List<Pessoa>();

        public static void PreencherSingleton()
        {
            Pessoa jose = new Pessoa()
            {
                Id = new Guid("3007bd7e-1927-4b1f-b26b-9e57f61d104d"),
                Name = "Jose Ricardo",
                Endereco = "Rua xablau",
                Telefone = 4846548
            };

            Pessoa marcia = new Pessoa()
            {
                Id = new Guid("1b4726dd-0ec3-4805-bffc-ad5631806341"),
                Name = "Marcia",
                Endereco = "Rua xablau 2222222",
                Telefone = 5464816548
            };


            PessoasSingle.Pessoas.Add(jose);
            PessoasSingle.Pessoas.Add(marcia);
        }

    }
}
