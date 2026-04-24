using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E4")]
public class ReportBackgroundInfo : BaseDataObject
{
	[Token(Token = "0x4002963")]
	[FieldOffset(Offset = "0x20")]
	public string image;

	[Token(Token = "0x4002964")]
	[FieldOffset(Offset = "0x28")]
	public ReportBackgroundGetChannel getChannel;

	[Token(Token = "0x1700071E")]
	public bool isUnlock
	{
		[Address(RVA = "0x4A4050", Offset = "0x4A2850", Length = "0x99")]
		[Token(Token = "0x600480F")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004810")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public ReportBackgroundInfo()
	{
	}
}
