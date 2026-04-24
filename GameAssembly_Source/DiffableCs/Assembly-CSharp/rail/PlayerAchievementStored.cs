namespace rail;

public class PlayerAchievementStored : EventBase
{
	public bool group_achievement; //Field offset: 0x30
	public string achievement_name; //Field offset: 0x38
	public uint current_progress; //Field offset: 0x40
	public uint max_progress; //Field offset: 0x44

	public PlayerAchievementStored() { }

}

