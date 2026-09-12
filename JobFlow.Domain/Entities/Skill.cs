namespace JobFlow.Domain.Entities;

public class Skill
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public Skill()
    {
        Id = Guid.NewGuid();
    }
}