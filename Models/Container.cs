using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlContainerSystem.Models;

public class Container
{
    [Key]
    public int ID { get; set; }

    [Required]
    public string Numero { get; set; } = null!;

    [Required]
    public TipoContainer Tipo { get; set; }

    [Required]
    public TamanhoContainer Tamanho { get; set; }

    [Required]
    public int BL_ID { get; set; }

    [ForeignKey("BL_ID")]
    public virtual BL? BL { get; set; }
}