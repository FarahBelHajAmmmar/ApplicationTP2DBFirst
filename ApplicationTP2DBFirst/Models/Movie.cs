using System;
using System.Collections.Generic;

namespace ApplicationTP2DBFirst.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? GenreId { get; set; }

    public virtual Genre? Genre { get; set; }
}
