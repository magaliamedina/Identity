using Microsoft.AspNetCore.Identity;

namespace IdentityUsuario.Models
{
    public class AppUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
