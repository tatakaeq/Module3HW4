namespace Module3HW4.Models;

public class User
{
    private static int _id = 0;
    public User()
    {
        _id++;
        Id = _id;
    }

    public int Id { get; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public int Age { get; init; }
    public string? PhoneNumber { get; init; }
}