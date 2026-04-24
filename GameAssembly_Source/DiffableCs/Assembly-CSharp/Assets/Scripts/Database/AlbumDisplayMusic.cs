namespace Assets.Scripts.Database;

public class AlbumDisplayMusic
{
	public string displayTitle; //Field offset: 0x10
	public AlbumsInfo albumInfo; //Field offset: 0x18
	private readonly List<String> musicUids; //Field offset: 0x20

	public int count
	{
		 get { } //Length: 59
	}

	public AlbumDisplayMusic(string title) { }

	public AlbumDisplayMusic(AlbumsInfo album) { }

	public void AddMusicUid(string uid) { }

	public void AddRangeMusicUid(List<String> uids) { }

	public void Clear() { }

	protected virtual void Finalize() { }

	public int get_count() { }

	public void GetMusicUids(List<String> buffer, bool clear = false) { }

}

