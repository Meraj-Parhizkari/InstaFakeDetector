﻿using InstaFakeDetector.Entities.AuditableEntity;

namespace InstaFakeDetector.Entities;

public class Category : IAuditableEntity
{
    public int Id { get; set; }

    public Category()
    {
        Products = new HashSet<Product>();
    }

    public string Name { get; set; }

    public string Title { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}