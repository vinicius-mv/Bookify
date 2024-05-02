namespace Bookify.Application.Apartments.SearchApartments;

public sealed class ApartmentResponse
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public string Description { get; init; }

    public decimal Price { get; private set; }

    public string Currency { get; private set; }

    public AddressResponse Address { get; set; }
}
