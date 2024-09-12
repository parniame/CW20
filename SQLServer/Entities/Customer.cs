using System;
using System.Collections.Generic;

namespace DataAccess.SQLServer.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public  List<Order> Orders { get; set; } = new List<Order>();
}
