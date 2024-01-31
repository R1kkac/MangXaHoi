using System;
using System.Collections.Generic;

namespace MangXaHoi.Models.DbContext;

public partial class ProductImage
{
    public int ImageId { get; set; }

    public int? ProductId { get; set; }

    public string? ImagePath { get; set; }

    public string? Description { get; set; }

    public virtual Product? Product { get; set; }
}
