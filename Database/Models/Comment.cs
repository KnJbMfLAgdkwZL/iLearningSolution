﻿using Database.Interfaces;

namespace Database.Models;

public partial class Comment : IEntity
{
    public int Id { get; set; }
    public int ReviewId { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; } = null!;

    public virtual Review Review { get; set; } = null!;
    public virtual User User { get; set; } = null!;
}