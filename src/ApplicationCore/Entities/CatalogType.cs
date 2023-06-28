using Krdn.Maui.ApplicationCore.Interfaces;

namespace Krdn.Maui.ApplicationCore.Entities;
public class CatalogType : BaseEntity, IAggregateRoot
{
    public string Type { get; private set; }
    public CatalogType(string type)
    {
        Type = type;
    }
}