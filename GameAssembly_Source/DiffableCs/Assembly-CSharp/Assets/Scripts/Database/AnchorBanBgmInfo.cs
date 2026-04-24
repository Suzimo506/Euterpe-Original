namespace Assets.Scripts.Database;

internal struct AnchorBanBgmInfo
{
	public string object_id; //Field offset: 0x0
	public DateTime created_at; //Field offset: 0x8
	public DateTime updated_at; //Field offset: 0x10
	public string bgm_name; //Field offset: 0x18
	public string bgm_file_name; //Field offset: 0x20
	public string note; //Field offset: 0x28
	public string author; //Field offset: 0x30
	public bool is_anchor_user; //Field offset: 0x38
	public bool is_delete; //Field offset: 0x39

}

