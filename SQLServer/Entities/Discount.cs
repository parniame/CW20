using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Discount
{
    public int Id { get; set; }
    public DiscountType Type { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public decimal? Percent { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
public enum DiscountType
{
    Golden,
    Silver,
    Economy

}
