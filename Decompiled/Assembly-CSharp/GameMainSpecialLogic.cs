using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.ReplaceTools;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B1")]
public class GameMainSpecialLogic : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x18")]
	public ReplaceTools[] badAppleReplaces;

	[Address(RVA = "0x5BE050", Offset = "0x5BC850", Length = "0xC")]
	[Token(Token = "0x6000543")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x5BDE80", Offset = "0x5BC680", Length = "0x1C7")]
	private void BadAppleLogic()
	{
	}

	[Address(RVA = "0x5BE060", Offset = "0x5BC860", Length = "0x50")]
	[Token(Token = "0x6000545")]
	public GameMainSpecialLogic()
	{
	}
}
