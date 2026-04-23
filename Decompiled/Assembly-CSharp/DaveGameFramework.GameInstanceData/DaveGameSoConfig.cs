using Cpp2ILInjected;
using UnityEngine;

namespace DaveGameFramework.GameInstanceData;

[Token(Token = "0x20004BF")]
[CreateAssetMenu]
public class DaveGameSoConfig : ScriptableObject
{
	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x18")]
	public float cutFishSuccessRate;

	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x1C")]
	public float dishSuccessRate;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019E2")]
	public string victoryShowAssetName;

	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x28")]
	public string failShowAssetName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019E4")]
	public int failBarrageId;

	[Address(RVA = "0x5C16E0", Offset = "0x5BFEE0", Length = "0x7")]
	[Token(Token = "0x6003572")]
	public DaveGameSoConfig()
	{
	}
}
