namespace Assets.Scripts.GameCore;

public class StageInfo : SerializedScriptableObject
{
	public List<MusicData> musicDatas; //Field offset: 0x58
	public decimal delay; //Field offset: 0x60
	public string mapName; //Field offset: 0x70
	public string music; //Field offset: 0x78
	public string scene; //Field offset: 0x80
	public int difficulty; //Field offset: 0x88
	public string md5; //Field offset: 0x90
	public float bpm; //Field offset: 0x98
	public List<SceneEvent> sceneEvents; //Field offset: 0xA0
	public Dictionary<String, List`1<GameDialogArgs>> dialogEvents; //Field offset: 0xA8

	public StageInfo() { }

}

