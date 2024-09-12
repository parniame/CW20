using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Shop
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public int Code { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
}
