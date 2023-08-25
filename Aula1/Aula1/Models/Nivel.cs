using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Nivel
    {
        [Column ("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
    }
}
