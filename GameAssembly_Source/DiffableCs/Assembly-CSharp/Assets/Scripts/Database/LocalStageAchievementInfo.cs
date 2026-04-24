namespace Assets.Scripts.Database;

public class LocalStageAchievementInfo : BaseDataObject
{
	public String[] easy; //Field offset: 0x20
	public String[] normal; //Field offset: 0x28
	public String[] hard; //Field offset: 0x30

	public LocalStageAchievementInfo() { }

	public void GetDiffByIndex(int index, List<String> buffer, bool clear = false) { }

	public String[] GetDiffByName(string name) { }

}

