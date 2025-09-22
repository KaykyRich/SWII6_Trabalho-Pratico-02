using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlContainerSystem.Models;

public class BL
{
    [Key]
    public int ID { get; set; }

    [Required]
    public string Numero { get; set; } = null!;

    [Required]
    public string Consignee { get; set; } = null!;

    [Required]
    public string Navio { get; set; } = null!;

    public virtual ICollection<Container> Containers { get; set; } = new List<Container>();
}