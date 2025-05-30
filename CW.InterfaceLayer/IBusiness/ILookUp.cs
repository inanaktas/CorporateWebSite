using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
	public interface ILookUp
	{
		List<SkillDataModel> GetSkills();
		List<ExperienceDataModel> GetExperiences();
	}
}
