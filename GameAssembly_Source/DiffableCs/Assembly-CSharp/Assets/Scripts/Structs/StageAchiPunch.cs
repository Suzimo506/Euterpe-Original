namespace Assets.Scripts.Structs;

internal class StageAchiPunch : AbstractStageAchi
{
	[JsonProperty]
	protected BmsNodeUid[] valueArray; //Field offset: 0x20

	public StageAchiPunch() { }

	public virtual bool Do(ref AchievementArgs args, ref AchiInfo achiInfo) { }

}

