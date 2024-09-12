using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ShopId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual Shop Shop { get; set; } = null!;
}
