using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fala_Cidadao.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a idade.")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar o perfil.")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Usuário,
        Autoridade
    }
}
