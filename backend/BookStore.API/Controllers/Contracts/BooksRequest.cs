namespace BookStore.API.Controllers.Contracts
{
    public record BooksRequest(
        string Title,
        string Description,
        decimal Price);

}
