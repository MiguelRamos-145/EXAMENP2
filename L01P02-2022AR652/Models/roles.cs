using System.ComponentModel.DataAnnotations;

namespace L01P02_2022AR652.Models
{
    public class roles
    {

        [Key]
        public int rolId { get; set; }
        public string? rolNombre { get; set; }
    }
}
