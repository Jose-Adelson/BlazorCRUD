using System.ComponentModel.DataAnnotations;

namespace BlazorApp_ProjetoCSI.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUser { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
    }
}
