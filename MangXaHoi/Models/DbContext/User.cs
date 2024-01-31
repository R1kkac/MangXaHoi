using System;
using System.Collections.Generic;

namespace MangXaHoi.Models.DbContext;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual ICollection<Transaction> TransactionBuyers { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionSellers { get; set; } = new List<Transaction>();
}
