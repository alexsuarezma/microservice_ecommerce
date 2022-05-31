using System.ComponentModel.DataAnnotations;

namespace Identity.Service.EventHandler.Commands
{
    public class UserUpdateCommand : UserCreateCommand
    {
        [Required]
        public string Id { get; set; }
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public string Password { get; set; }
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
    }
}
