using AutoMapper;
using IdentityUsuario.DTO;
using IdentityUsuario.Models;

namespace IdentityUsuario.Configurations
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<AppUser, UserDTO>().ReverseMap();
        }
    }
}
