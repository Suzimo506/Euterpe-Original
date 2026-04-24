using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200056E")]
internal struct CheckRoleItemParams
{
	[Token(Token = "0x4001FFC")]
	[FieldOffset(Offset = "0x0")]
	public string packageUid;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001FFD")]
	public int roleIndex;

	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4001FFE")]
	public int elfinIndex;

	[Token(Token = "0x4001FFF")]
	[FieldOffset(Offset = "0x10")]
	public int[] loadingIndex;

	[Token(Token = "0x4002000")]
	[FieldOffset(Offset = "0x18")]
	public int welcomeIndex;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4002001")]
	public int feverIndex;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002002")]
	public int backgroundId;

	[Token(Token = "0x1700051C")]
	public int jsonIndex
	{
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x654870", Offset = "0x653070", Length = "0x84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600383E")]
	[Address(RVA = "0x654810", Offset = "0x653010", Length = "0x5C")]
	public CheckRoleItemParams(string packUid, int roleIdx = -1, int elfinIdx = -1, int[] loadingIdx = null, int welcomeIdx = -1, int feverIdx = -1, int backgroundId = -1)
	{
	}
}
