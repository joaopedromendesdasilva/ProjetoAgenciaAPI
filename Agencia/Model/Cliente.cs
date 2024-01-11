using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Model
{

[Table("Clientes")]
public class Cliente
{
    [Key]
    [Column("id")]
    public int ClienteId { get; set; }

    [Required]
    [StringLength(100)]
    [Column("nome")]
    public string Nome { get; set; }

    [Required]
    [StringLength(100)]
    [Column("email")]
    public string Email { get; set; }

    [Required]
    [StringLength(100)]
    [Column("Cliente_URL")]
    public string ClienteURL { get; set; }


    [StringLength(20)]
    [Column("telefone")]
    public string Telefone { get; set; }

    [Column("data_nascimento")]
    public DateTime DataNascimento { get; set; }

    
 
}






}