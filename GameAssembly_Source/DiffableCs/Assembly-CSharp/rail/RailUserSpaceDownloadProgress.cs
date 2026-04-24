namespace rail;

public class RailUserSpaceDownloadProgress
{
	public uint progress; //Field offset: 0x10
	public ulong total; //Field offset: 0x18
	public uint speed; //Field offset: 0x20
	public SpaceWorkID id; //Field offset: 0x28
	public ulong finidshed; //Field offset: 0x30

	public RailUserSpaceDownloadProgress() { }

}

