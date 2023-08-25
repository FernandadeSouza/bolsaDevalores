using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Cadastro
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string nome { get; set; }

        [Column("datanascimento")]
        public DateTime nascimento { get; set; }

        [Column("cpf")]
        public string cpf { get; set; }

        [Column("cnpj")]
        public string cnpj { get; set; }

        [Column("telefone")]
        public string telefone { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("senha")]
        public string senha { get; set; }
    }
}
