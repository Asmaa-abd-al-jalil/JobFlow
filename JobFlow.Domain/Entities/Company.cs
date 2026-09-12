namespace JobFlow.Domain.Entities;

public class Company
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public DateTime CreatedAt { get; private set; }

    public Company()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }
}