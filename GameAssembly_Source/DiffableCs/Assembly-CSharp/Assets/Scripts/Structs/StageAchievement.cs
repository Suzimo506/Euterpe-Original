namespace Assets.Scripts.Structs;

public class StageAchievement
{
	[JsonProperty]
	private string uid; //Field offset: 0x10
	[JsonProperty]
	private StageAchiConditionType conditionType; //Field offset: 0x18
	[JsonProperty]
	private StageAchiPunch punch; //Field offset: 0x20
	[JsonProperty]
	private StageAchiScore score; //Field offset: 0x28
	[JsonProperty]
	private StageAchiFever fever; //Field offset: 0x30
	[JsonProperty]
	private StageAchiJudge judge; //Field offset: 0x38
	[JsonProperty]
	private StageAchiEvaluate evaluate; //Field offset: 0x40
	[JsonProperty]
	private StageAchiHurt hurt; //Field offset: 0x48
	[JsonProperty]
	private StageAchiCombo combo; //Field offset: 0x50

	public StageAchievement() { }

	public bool Do(ref AchievementArgs args, out AchiInfo achiInfo) { }

	private bool Private_Do(StageAchiConditionType condition, ref AchievementArgs args, ref AchiInfo achiInfo) { }

}

