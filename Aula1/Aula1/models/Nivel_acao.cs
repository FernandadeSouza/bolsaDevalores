using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.models
{
    public class Nivel_acao
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nivel_id")]
        public int nivel_id { get; set; }

        [Column("acao_id")]
        public int acao_id { get; set; }

    }
}
