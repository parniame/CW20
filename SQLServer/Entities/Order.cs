using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ShopId { get; set; }

    public  Customer Customer { get; set; } = null!;

    public  List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public  Shop Shop { get; set; } = null!;
}
