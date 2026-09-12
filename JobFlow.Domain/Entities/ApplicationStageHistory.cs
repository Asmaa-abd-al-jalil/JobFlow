using JobFlow.Domain.Enums;

namespace JobFlow.Domain.Entities;

public class ApplicationStageHistory
{
    public Guid Id { get; private set; }

    public Guid ApplicationId { get; private set; }

    public ApplicationStage FromStage { get; private set; }

    public ApplicationStage ToStage { get; private set; }

    public DateTime ChangedAt { get; private set; }

    public string? Note { get; private set; }

    public ApplicationStageHistory()
    {
        Id = Guid.NewGuid();
        ChangedAt = DateTime.UtcNow;
    }
}