﻿
using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Category { get; set; }

    [Required]
    public decimal Price { get; set; }

    public int Stock { get; set; }
}