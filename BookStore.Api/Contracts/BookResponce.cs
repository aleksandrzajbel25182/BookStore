namespace BookStore.Api.Contracts
{
    public record BookResponce(
        Guid id,
        string Title,
        string Description,
        decimal Price);
}
