using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ProductFilterViewModel
{
    public List<Product>? Products { get; set; }

    [Display(Name = "Category")]
    public string? SelectedCategory { get; set; }

    [Display(Name = "From Date")]
    [DataType(DataType.Date)]
    public DateTime? FromDate { get; set; }

    [Display(Name = "To Date")]
    [DataType(DataType.Date)]
    public DateTime? ToDate { get; set; }

    // All available categories for dropdown filters
    public List<string>? Categories { get; set; }

    // Optional: for filtering by Farmer
    [Display(Name = "Farmer")]
    public int? SelectedFarmerId { get; set; }
    public List<Farmer>? Farmers { get; set; }
}
