namespace BookStore.API.Controllers.Contracts
{
    public record BooksResponse(
        Guid Id,
        string Title,
        string Description,
        decimal Price);

}
