namespace BookStore.Api.Contracts
{
    public record BookRequest(
    Guid id,
    string Title,
    string Description,
    decimal Price);
}
