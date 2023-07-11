using System;
using System.Collections.Generic;

namespace Krdn.Maui.ApplicationCore.Entities.NorthwindAggregate;

public partial class Shipper
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
