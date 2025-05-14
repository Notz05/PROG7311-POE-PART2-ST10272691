using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Category { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Production Date")]
    public DateTime ProductionDate { get; set; }

    // Foreign key to Farmer
    [Display(Name = "Farmer")]
    public int FarmerId { get; set; }

    [ForeignKey("FarmerId")]
    public virtual Farmer Farmer { get; set; }
}
