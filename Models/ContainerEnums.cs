namespace BlContainerSystem.Models;
using System.ComponentModel.DataAnnotations;

public enum TipoContainer
{
    Dry,
    Reefer
}

public enum TamanhoContainer
{
    [Display(Name = "20")]
    Tamanho20 = 20,
    
    [Display(Name = "40")]
    Tamanho40 = 40
}