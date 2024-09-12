using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Seller
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int ShopId { get; set; }

    public virtual Shop Shop { get; set; } = null!;
}
