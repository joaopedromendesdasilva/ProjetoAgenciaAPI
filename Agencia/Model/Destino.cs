using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Model 
{


[Table("Destinos")]
public class Destino
{
    [Key]
    [Column("id")]
    public int DestinoId { get; set; }

    [Required]
    [StringLength(100)]
    [Column("nome")]
    public string Nome { get; set; }

    [MaxLength]
    [Column("descricao")]
    public string Descricao { get; set; }

    [Required]
    [StringLength(100)]
    [Column("DestinoURL")]
    public string DestinoURL { get; set; }

    [Required]
    [Column("preco")]
    public decimal Preco { get; set; }

}






}