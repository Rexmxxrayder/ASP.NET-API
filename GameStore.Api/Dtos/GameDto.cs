namespace GameStore.Api.Dtos;

public record class GameDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Genre { get; init; }
    public decimal Price { get; init; }
    public DateOnly ReleaseDate { get; init; }

    public GameDto(int id, string name, string genre, decimal price, DateOnly releaseDate)
    {
        Id = id;
        Name = name;
        Genre = genre;
        Price = price;
        ReleaseDate = releaseDate;
    }

    public GameDto(int id, CreateGameDto createGameDto)
    {
        Id = id;
        Name = createGameDto.Name;
        Genre = createGameDto.Genre;
        Price = createGameDto.Price;
        ReleaseDate = createGameDto.ReleaseDate;
    }
};

