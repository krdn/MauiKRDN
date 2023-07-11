using System;
using System.Collections.Generic;

namespace Krdn.Maui.ApplicationCore.Entities.NorthwindAggregate;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
