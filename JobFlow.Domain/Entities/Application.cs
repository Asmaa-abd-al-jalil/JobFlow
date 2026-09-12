using JobFlow.Domain.Enums;

namespace JobFlow.Domain.Entities;

public class Application
{
    public Guid Id { get; private set; }

    public Guid JobId { get; private set; }

    public Guid CandidateId { get; private set; }

    public ApplicationStage Stage { get; private set; }

    public DateTime AppliedAt { get; private set; }

    public Application()
    {
        Id = Guid.NewGuid();
        Stage = ApplicationStage.Applied;
        AppliedAt = DateTime.UtcNow;
    }
}