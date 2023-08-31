using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Aula1.Models
{
        public class Quiz
    {
        [Column ("id")]
        public int Id { get; set; }

        [Column("id_login")]
        public int id_login { get; set; }

        [Column("id_niveis")]
        public int Id_niveis { get; set; }

        [Column("questionario_1")]
        public string questionario_1 { get; set; }

        [Column("questionario_2")]
        public string questionario_2 { get; set; }

        [Column("questionario_3")]
        public string questionario_3 { get; set; }

        [Column("questionario_4")]
        public string questionario_4 { get; set; }

        [Column("questionario_5")]
        public string questionario_5 { get; set; }
    }
}
