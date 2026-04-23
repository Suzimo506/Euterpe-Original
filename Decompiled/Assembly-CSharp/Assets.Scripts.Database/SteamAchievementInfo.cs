using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F2")]
internal class SteamAchievementInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400298B")]
	public int id;

	[Token(Token = "0x400298C")]
	[FieldOffset(Offset = "0x28")]
	public string apiName;

	[Token(Token = "0x400298D")]
	[FieldOffset(Offset = "0x30")]
	public string stateName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400298E")]
	public SteamAchievementExInfo steamAchievementExInfo;

	[Token(Token = "0x6004851")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public SteamAchievementInfo()
	{
	}
}
