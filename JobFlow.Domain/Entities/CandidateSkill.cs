namespace JobFlow.Domain.Entities;

public class CandidateSkill
{
    public Guid CandidateId { get; private set; }

    public Guid SkillId { get; private set; }

    public int YearsOfExperience { get; private set; }

    public CandidateSkill()
    {
    }
}