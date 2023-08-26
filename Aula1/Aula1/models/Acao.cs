using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula1.Models
{
    public class Acao
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_niveis")]
        public int Id_Niveis { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("variacao")]
        public string Variacao { get; set; }
    }


}
