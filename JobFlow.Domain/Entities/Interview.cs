using JobFlow.Domain.Enums;

namespace JobFlow.Domain.Entities;

public class Interview
{
    public Guid Id { get; private set; }

    public Guid ApplicationId { get; private set; }

    public DateTime ScheduledAt { get; private set; }

    public int DurationInMinutes { get; private set; }

    public InterviewType Type { get; private set; }

    public string? MeetingLink { get; private set; }

    public string? Notes { get; private set; }

    public Interview()
    {
        Id = Guid.NewGuid();
    }
}