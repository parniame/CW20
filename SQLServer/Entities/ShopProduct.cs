using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class ShopProduct
{
    public int ShopId { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Shop Shop { get; set; } = null!;
}
