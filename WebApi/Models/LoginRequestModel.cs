using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class LoginRequestModel
    {
        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo 'Email' deve ser um endereço de email válido.")]
        public string Email { get; set; }
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }    
    }
}
