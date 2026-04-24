namespace Assets.Scripts.Structs;

public struct NsGameStatisticsData
{
	public uint music_index; //Field offset: 0x0
	public int music_difficulty; //Field offset: 0x4
	public string character_uid; //Field offset: 0x8
	public string elfin_uid; //Field offset: 0x10
	public int hp; //Field offset: 0x18
	public int score; //Field offset: 0x1C
	public float acc; //Field offset: 0x20
	public int combo; //Field offset: 0x24
	public string evaluate; //Field offset: 0x28
	public int miss; //Field offset: 0x30

	public NsGameStatisticsData(uint nsMusicUid, int musicDifficulty, string roleUid, string elfinUid, int hp, int score, float accuracy, int combo, string evaluate, int miss) { }

}

