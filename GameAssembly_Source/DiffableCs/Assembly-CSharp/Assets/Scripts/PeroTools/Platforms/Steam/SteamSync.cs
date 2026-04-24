namespace Assets.Scripts.PeroTools.Platforms.Steam;

public class SteamSync : ISync
{
	private string m_FolderPath; //Field offset: 0x10
	private string m_FileName; //Field offset: 0x18
	private string m_FilePath; //Field offset: 0x20

	public SteamSync() { }

	private void DeleteRegedit() { }

	public override void LoadLocal() { }

	private void RemoveFile() { }

	public override void SaveLocal() { }

}

