namespace rail;

public class RailDlcInstallProgress
{
	public uint progress; //Field offset: 0x10
	public ulong finished_bytes; //Field offset: 0x18
	public ulong total_bytes; //Field offset: 0x20
	public uint speed; //Field offset: 0x28

	public RailDlcInstallProgress() { }

}

