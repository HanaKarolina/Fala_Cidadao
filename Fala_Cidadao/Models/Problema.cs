using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fala_Cidadao.Models
{
    [Table("Problemas")]
    public class Problema
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o assunto.")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a categoria.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o local.")]
        public string Local { get; set; }

        public string Status { get; set; }
    }
}
