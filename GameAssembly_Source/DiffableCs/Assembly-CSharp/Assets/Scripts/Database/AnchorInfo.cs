namespace Assets.Scripts.Database;

internal class AnchorInfo
{
	public List<AnchorMusicInfo> album_list; //Field offset: 0x10
	public List<AnchorElfinList> elfin_list; //Field offset: 0x18
	public List<AnchorBanBgmInfo> ban_bgm_list; //Field offset: 0x20

	public AnchorInfo() { }

}

