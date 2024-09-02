using System.ComponentModel.DataAnnotations;

namespace BlazorApp_ProjetoCSI.Models
{

    public class Tarefas
    {
        public int ID { get; set; }
        public string? Descricao { get; set; }
        public string? Prioridade { get; set; }
        public string? Responsavel { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Prazo { get; set; }
    }
}
