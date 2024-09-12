using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Product
{
    public int Id { get; set; }
    public string Description { get; set; }

    public string Name { get; set; } = null!;
    public decimal Weight { get; set; }
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
}
