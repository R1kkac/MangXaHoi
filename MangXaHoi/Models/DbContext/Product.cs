using System;
using System.Collections.Generic;

namespace MangXaHoi.Models.DbContext;

public partial class Product
{
    public int ProductId { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? PostedDate { get; set; }

    public string? Status { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual User? User { get; set; }
}
