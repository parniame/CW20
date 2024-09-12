using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Price
{
    public int Id { get; set; }

    public decimal Price1 { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
