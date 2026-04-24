using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019D")]
public class UnlockStageAnimPlayBgm : MonoBehaviour
{
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x18")]
	public PnlUnlockStage pnlUnlockStage;

	[Address(RVA = "0x4E9860", Offset = "0x4E8060", Length = "0x1DB")]
	[Token(Token = "0x6000BC8")]
	public void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000BC9")]
	public UnlockStageAnimPlayBgm()
	{
	}
}
