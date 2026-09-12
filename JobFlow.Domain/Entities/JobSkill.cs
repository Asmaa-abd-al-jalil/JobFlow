namespace JobFlow.Domain.Entities;

public class JobSkill
{
    public Guid JobId { get; private set; }

    public Guid SkillId { get; private set; }

    public bool IsRequired { get; private set; }

    public JobSkill()
    {
    }
}