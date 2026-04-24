namespace Assets.Scripts.Database;

internal class SteamAchievementInfo : BaseDataObject
{
	public int id; //Field offset: 0x20
	public string apiName; //Field offset: 0x28
	public string stateName; //Field offset: 0x30
	public SteamAchievementExInfo steamAchievementExInfo; //Field offset: 0x38

	public SteamAchievementInfo() { }

}

