using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000084")]
public class NexBinaryData
{
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x86B0A0", Offset = "0x8698A0", Length = "0x69F")]
	public static List<byte> GetBinaryData(string characterUid, string elfinUid, int hp, int combo, string evaluate, int miss)
	{
		return null;
	}

	[Address(RVA = "0x86B740", Offset = "0x869F40", Length = "0x1CB")]
	[Token(Token = "0x60003F5")]
	public static List<string> GetObject(List<byte> binaryData)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60003F6")]
	public NexBinaryData()
	{
	}
}
