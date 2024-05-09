using System;
using System.Collections.Generic;

namespace Recipe__MVCProject.Models;

public partial class Recipe
{
    public decimal Recipeid { get; set; }

    public decimal? Userid { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Ingredients { get; set; }

    public string? Instructions { get; set; }

    public decimal? Categoryid { get; set; }

    public DateTime? Addedtime { get; set; }

    public string? Mainimage { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Recipesale> Recipesales { get; set; } = new List<Recipesale>();

    public virtual ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();

    public virtual User? User { get; set; }
}
