using System;
using System.Collections.Generic;

namespace MangXaHoi.Models.DbContext;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? ProductId { get; set; }

    public int? UserId { get; set; }

    public string? CommentText { get; set; }

    public DateTime? PostedDate { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
