using System;
using System.Collections.Generic;

namespace Recipe__MVCProject.Models;

public partial class Category
{
    public decimal Categoryid { get; set; }

    public string? Categoryname { get; set; }

    public string? Categoryimage { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
