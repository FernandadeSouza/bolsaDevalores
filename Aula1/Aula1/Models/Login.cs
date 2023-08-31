using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula1.Models
{
     public class Login
    {
        [Column("id")]
        public int Id { get; set; }

        [Column ("id_cadastro")]
        public int Id_cadastro { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }
    }
}
