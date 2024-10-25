using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;

public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; } = default!;

    [Required]
    [StringLength(100)]
    public string Nome { get;set; } = default!;

    [Required]
    [StringLength(100)]
    public string Marca { get;set; } = default!;

    [Required]
    [StringLength(50)]
    public int Ano { get; set; } = default!;

}