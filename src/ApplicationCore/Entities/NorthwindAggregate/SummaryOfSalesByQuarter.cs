using System;
using System.Collections.Generic;

namespace Krdn.Maui.ApplicationCore.Entities.NorthwindAggregate;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
