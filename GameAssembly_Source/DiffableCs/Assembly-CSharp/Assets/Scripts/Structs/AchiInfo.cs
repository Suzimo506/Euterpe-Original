namespace Assets.Scripts.Structs;

public struct AchiInfo
{
	public string uid; //Field offset: 0x0
	public string saveUid; //Field offset: 0x8
	public int packageIndex; //Field offset: 0x10
	public int musicIndex; //Field offset: 0x14
	public int achiDiffIndex; //Field offset: 0x18
	public int achiIndex; //Field offset: 0x1C

	private static string ToStageAchiUid(ref AchievementArgs args, ref AchiInfo achiInfo) { }

	public static bool TryParse(string parseUid, ref AchievementArgs args, out AchiInfo result) { }

	public static bool TryParse(string parseUid, out AchiInfo result) { }

}

