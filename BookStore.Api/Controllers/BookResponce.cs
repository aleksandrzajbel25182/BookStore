namespace BookStore.Api.Controllers
{
    public record BookResponce(
        Guid id,
        string Title,
        string Description,
        decimal Price);
}
