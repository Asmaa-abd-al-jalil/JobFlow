namespace JobFlow.Domain.Entities;

public class Job
{
    public Guid Id { get; private set; }

    public Guid CompanyId { get; private set; }

    public string Title { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public string Location { get; private set; } = string.Empty;

    public decimal? SalaryMin { get; private set; }

    public decimal? SalaryMax { get; private set; }

    public bool IsActive { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public Job()
    {
        Id = Guid.NewGuid();
        IsActive = true;
        CreatedAt = DateTime.UtcNow;
    }
}