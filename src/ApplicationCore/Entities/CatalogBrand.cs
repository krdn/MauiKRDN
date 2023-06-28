using Krdn.Maui.ApplicationCore.Interfaces;

namespace Krdn.Maui.ApplicationCore.Entities;
public class CatalogBrand : BaseEntity, IAggregateRoot
{
    public string Brand { get; private set; }
    public CatalogBrand(string brand)
    {
        Brand = brand;
    }
}
