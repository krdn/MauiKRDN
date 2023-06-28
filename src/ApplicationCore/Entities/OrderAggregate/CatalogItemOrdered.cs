using Ardalis.GuardClauses;

namespace Krdn.Maui.ApplicationCore.Entities.OrderAggregate;
public class CatalogItemOrdered // ValueObject
{
    public CatalogItemOrdered(int catalogItemId, string productName, string pictureUri)
    {
        Guard.Against.OutOfRange(catalogItemId, nameof(catalogItemId), 1, int.MaxValue);
        Guard.Against.NullOrEmpty(productName, nameof(productName));
        Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));

        CatalogItemId = catalogItemId;
        ProductName = productName;
        PictureUri = pictureUri;
    }

#pragma warning disable CS8618 // Required by Entity Framework
    private CatalogItemOrdered() { }

    public int CatalogItemId { get; private set; }
    public string ProductName { get; private set; }
    public string PictureUri { get; private set; }
}
