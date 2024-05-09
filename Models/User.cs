using System;
using System.Collections.Generic;

namespace Recipe__MVCProject.Models;

public partial class User
{
    public decimal Userid { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public decimal? Roleid { get; set; }

    public string? Profileimage { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<Recipesale> Recipesales { get; set; } = new List<Recipesale>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
}
