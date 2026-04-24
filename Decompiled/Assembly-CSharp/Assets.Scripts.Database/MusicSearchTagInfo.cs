using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E1")]
public class MusicSearchTagInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400295C")]
	[JsonProperty]
	private string uid;

	[Token(Token = "0x400295D")]
	[JsonProperty]
	[FieldOffset(Offset = "0x28")]
	private string[] tag;

	[Token(Token = "0x1700071B")]
	public string musicUid
	{
		[Token(Token = "0x6004806")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071C")]
	public bool isValid
	{
		[Token(Token = "0x6004808")]
		[Address(RVA = "0x4A1730", Offset = "0x49FF30", Length = "0x12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004807")]
	[Address(RVA = "0x4A1690", Offset = "0x49FE90", Length = "0x90")]
	public bool Contains(string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6004809")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public MusicSearchTagInfo()
	{
	}
}
