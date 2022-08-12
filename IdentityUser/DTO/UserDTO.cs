using System.ComponentModel.DataAnnotations;

namespace IdentityUsuario.DTO
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
    }

    public class UserDTO : LoginUserDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        public string Roles { get; set; }
    }
}
