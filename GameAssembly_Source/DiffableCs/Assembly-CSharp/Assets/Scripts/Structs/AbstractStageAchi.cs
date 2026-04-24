namespace Assets.Scripts.Structs;

internal abstract class AbstractStageAchi
{
	[JsonProperty]
	protected int value; //Field offset: 0x10
	[JsonProperty]
	protected int count; //Field offset: 0x14
	[JsonProperty]
	protected byte subValue; //Field offset: 0x18

	protected AbstractStageAchi() { }

	public abstract bool Do(ref AchievementArgs args, ref AchiInfo achiInfo) { }

}

