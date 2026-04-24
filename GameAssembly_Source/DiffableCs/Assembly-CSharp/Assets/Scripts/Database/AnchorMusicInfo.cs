namespace Assets.Scripts.Database;

internal struct AnchorMusicInfo
{
	public string object_id; //Field offset: 0x0
	public DateTime created_at; //Field offset: 0x8
	public DateTime updated_at; //Field offset: 0x10
	public string uid; //Field offset: 0x18
	public string name; //Field offset: 0x20
	public string author; //Field offset: 0x28
	public string bpm; //Field offset: 0x30
	public string music; //Field offset: 0x38
	public string demo; //Field offset: 0x40
	public string cover; //Field offset: 0x48
	public string noteJson; //Field offset: 0x50
	public string scene; //Field offset: 0x58
	public string levelDesigner; //Field offset: 0x60
	public string difficulty1; //Field offset: 0x68
	public string difficulty2; //Field offset: 0x70
	public string difficulty3; //Field offset: 0x78
	public string difficulty4; //Field offset: 0x80
	public int unlockLevel; //Field offset: 0x88
	public bool is_anchor_user; //Field offset: 0x8C
	public bool is_delete; //Field offset: 0x8D

}

